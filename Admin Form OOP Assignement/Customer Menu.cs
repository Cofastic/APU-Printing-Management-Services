using Admin_Form_OOP_Assignement;
using Admin_Form_OOP_Assingment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Form_OOP_Assignment
{
    public partial class CustomerForm : Form
    {
        public string CustomerID;
        public CustomerForm(string _CustomerID)
        {
            InitializeComponent();

            CustomerID = _CustomerID;

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4J2129A;Initial Catalog=Users;Integrated Security=True;TrustServerCertificate=True");
            conn.Open();    

            SqlCommand cmd = new SqlCommand("SELECT *   FROM [Users].[dbo].[Credential] where ID = @ID", conn);
            cmd.Parameters.AddWithValue("@ID", CustomerID);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable("Customer");
            sda.Fill(dt);


            string CustomerName = dt.Rows[0].Field<string>("Username");
            string CustomerPhone = dt.Rows[0].Field<string>("Phone_Number");
            string CustomerRole = dt.Rows[0].Field<string>("Role");

            labelCustomerName.Text = CustomerName;
            labelCustomerPhone.Text = CustomerPhone;
            labelCustomerRole.Text = CustomerRole;
            labelIDdesc.Text = CustomerID;

        }
        public void LoginDetail(LoginDetails userprofile)
        {
            labelCustomerName.Text = userprofile.Profilename;
            labelCustomerPhone.Text = userprofile.Phonenumber;
            labelIDdesc.Text = userprofile.ID;
            labelCustomerRole.Text = userprofile.Role;
        }


        private void RequestButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Pass the correct parameters to the LoginDetails constructor
            LoginDetails userprofile = new LoginDetails(labelCustomerName.Text, labelCustomerPhone.Text, labelIDdesc.Text, labelCustomerRole.Text);
            ServiceSelectForm serviceselect = new ServiceSelectForm(CustomerID);
            serviceselect.LoginDetail(userprofile);
            serviceselect.Show();
        }

        private void CheckRequestButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Pass the correct parameters to the LoginDetails constructor
            LoginDetails userprofile = new LoginDetails(labelCustomerName.Text, labelCustomerPhone.Text, labelIDdesc.Text, labelCustomerRole.Text);
            RequestViewing reqview = new RequestViewing(CustomerID);
            reqview.LoginDetail(userprofile);
            reqview.Show();
        }


        private void UpdateProfileButton_Click(object sender, EventArgs e)
        {
            // Pass the correct parameters to the LoginDetails constructor
            LoginDetails userprofile = new LoginDetails(labelCustomerName.Text, labelCustomerRole.Text, labelCustomerPhone.Text, labelIDdesc.Text);
            Update_Personal_Profile updateprofile = new Update_Personal_Profile();
            updateprofile.LoginDetail(userprofile);
            updateprofile.Show();
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
