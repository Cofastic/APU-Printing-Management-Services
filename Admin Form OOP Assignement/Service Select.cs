using Admin_Form_OOP_Assignement;
using Admin_Form_OOP_Assignment;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Admin_Form_OOP_Assingment
{
    public partial class ServiceSelectForm : Form
    {
        private string Profilename;
        private string Role;
        private string phonenumber;
        private string ID; 

        public List<Request> RequestLists = new List<Request>();

        string CustomerID;
        public double TotalPrice = 0;
        double price;
        double discount;
        public string TotalConfirm;
        string SelectedService;

        public double rates;
        public string rates_text = "<Prices>";
        public string discount_text = "<Discount>";

        public ServiceSelectForm(string _customerID)
        {
            InitializeComponent();
            CustomerID = _customerID;
        }

        public void LoginDetail(LoginDetails userprofile)
        {
            Profilename = userprofile.Profilename;
            Role = userprofile.Role;
            phonenumber = userprofile.Phonenumber;
            ID = userprofile.ID;
        }
        private void listBoxServicesSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            // clears and focuses on qty box after sservice selection changes
            SelectedService = listBoxServicesSelection.Text;
            textBoxQty.Clear();
            textBoxQty.Focus();

            // prices for services
            if (listBoxServicesSelection.SelectedIndex == 0)
            {
                rates_text = "RM 0.8/ page";
                rates = 0.8;
            }
            else if (listBoxServicesSelection.SelectedIndex == 1)
            {
                rates_text = "RM 2.5/ page";
                rates = 2.5;
            }
            else if (listBoxServicesSelection.SelectedIndex == 2)
            {
                rates_text = "RM 5.5/ book";
                rates = 5.5;
            }
            else if (listBoxServicesSelection.SelectedIndex == 3)
            {
                rates_text = "RM 9.3/ book";
                rates = 9.3;
            }
            else if (listBoxServicesSelection.SelectedIndex == 4)
            {
                rates_text = "RM 6.0/ page";
                rates = 6.0;
            }
            else if (listBoxServicesSelection.SelectedIndex == 5)
            {
                rates_text = "RM 3.0/ page";
                rates = 3.0;
            }

            labelPrice.Text = rates_text;
            labelDiscount.Text = discount_text;
        }

        // method to change price label after entering quantity
        private void textBoxQty_TextChanged(object sender, EventArgs e)
        {
            // catch if there is error with parsing and if number is positive
            if (int.TryParse(textBoxQty.Text, out int quantity) && quantity > 0)
            {
                // calculate price for service based on qty
                price = rates * int.Parse(textBoxQty.Text);

                // set price display
                labelPrice.Text = (price).ToString();

                // calculate discount and uptdate total price if selection is 1,2,5, or 6
                int discountIndex = listBoxServicesSelection.SelectedIndex;
                if (discountIndex == 0 || discountIndex == 1 || discountIndex == 4 || discountIndex == 5)
                {
                    if (int.Parse(textBoxQty.Text) > 100)
                    {
                        price *= 0.9;
                        discount = price / 9;
                        labelPrice.Text = (price).ToString();
                        labelDiscount.Text = (discount).ToString();
                    }
                    else
                    {
                        labelDiscount.Text = "No Discount";
                    }
                }
                else
                {
                    labelDiscount.Text = "No Discount";
                }
            }
        }


        // provides info about which service is being selected on ServiceList
        // changes price to rates of services
        // adds selected service into listbox
        public int count = 0;
        private void buttonAddService_Click(object sender, EventArgs e)
        {


            // checks if there is a selected index in listbox
            if (listBoxServicesSelection.SelectedIndex == -1)
            {
                MessageBox.Show("please select service");
                labelPrice.Text = rates_text;
                labelDiscount.Text = discount_text;
                textBoxQty.Text = "";
                textBoxQty.Focus();
            }
            else 
            {
                // catches exceptions with textbox values
                // checks if quantity entered is valid
                if (int.TryParse(textBoxQty.Text, out int Qtyyy) && Qtyyy > 0)
                {
                    // create new instance of request 
                    Request request1 = new Request();

                    // adds request into listss
                    RequestLists.Add(request1);

                    // adds the service and quantity into the listbox 
                    listBoxServices.Items.Add($"{textBoxQty.Text}\t{SelectedService}");

                    // assign requests attributes
                    request1.type = SelectedService;
                    request1.quantity = int.Parse(textBoxQty.Text);
                    request1.price = price;
                    request1.discount = discount;                    

                    // updates total costs
                    TotalPrice = 0;
                    for (int i = 0; i < RequestLists.Count; i++)
                    {
                        TotalPrice += RequestLists[i].price;
                    }

                    // checks urgency
                    if (checkBoxUrgent.Checked)
                    {
                        TotalPrice *= 1.3;
                    }

                    labelTotalPrice.Text = "RM " + TotalPrice.ToString();

                }
                else
                {
                    textBoxQty.Focus();
                    MessageBox.Show("please enter a positive integer");

                }
            }
        }

        // remove a selected index of the listbox
        private void buttonRemoveService_Click(object sender, EventArgs e)
        {
            // when no index selected show error
            if (listBoxServices.SelectedIndex > -1)
            {
                // remove from requestslists the selected index
                RequestLists.RemoveAt(listBoxServices.SelectedIndex);

                listBoxServices.Items.RemoveAt(listBoxServices.SelectedIndex);

                // tries to focus on the first index of listbox after deletion
                try
                {
                    listBoxServices.SelectedIndex = 0;
                }
                catch (Exception) {  }
            }
            else 
            {
                // tries to focus on the first index of listbox if no index selected
                MessageBox.Show("please select index to delete");
                try
                {
                    listBoxServices.SelectedIndex = 0;
                }
                catch (Exception) {  }
            }

            // every time this is clicked, updates total price based on existing request
            TotalPrice = 0;
            for (int i = 0; i < RequestLists.Count; i++)
            {
                TotalPrice += RequestLists[i].price;
            }

            // checks urgency
            if (checkBoxUrgent.Checked)
            {
                TotalPrice *= 1.3;
            }
            labelTotalPrice.Text = "RM " + TotalPrice.ToString();
        }

        // call the confirmation form when pressing this button
        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            if (TotalPrice != 0)
            {
                FormConfirmation df = new FormConfirmation(RequestLists, TotalPrice, checkBoxUrgent.Checked, this, CustomerID);
                df.ShowDialog();
            }
            else
            {
                MessageBox.Show("please add services");
            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginDetails userprofile = new LoginDetails(Profilename, ID,Role, phonenumber);
            CustomerForm CustomerMenu = new CustomerForm(CustomerID);
            CustomerMenu.LoginDetail(userprofile);
            CustomerMenu.Show();
        }

        private void checkBoxUrgent_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUrgent.Checked)
            {
                TotalPrice = 0;
                for (int i = 0; i < RequestLists.Count; i++)
                {
                    TotalPrice += RequestLists[i].price;
                }
                TotalPrice *= 1.3;
                labelTotalPrice.Text = "RM " + TotalPrice.ToString();
            }

            if (!checkBoxUrgent.Checked)
            {
                TotalPrice = 0;
                for (int i = 0; i < RequestLists.Count; i++)
                {
                    TotalPrice += RequestLists[i].price;
                }
                labelTotalPrice.Text = "RM " + TotalPrice.ToString();

            }
        }

        private void ServiceSelectForm_Load(object sender, EventArgs e)
        {

        }
    }
}
