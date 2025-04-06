using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Form_OOP_Assignment
{
    public partial class UpdateCustomer : Form
    {
        string CustomerID;
        string name;
        string phone;
        string pass;  
        CustomerForm CustomerForm;

        public UpdateCustomer(string _CustomerID, CustomerForm _CustomerForm)
        {
            InitializeComponent();
            CustomerID = _CustomerID;
            CustomerForm = _CustomerForm;

            SqlConnection conn = new SqlConnection("Data Source=V-LAPTOP\\MSSQLSERVERAZURE;Initial Catalog=OOP;" +
                                                    "Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from [OOP].[dbo].[User] where ID = @ID", conn);

            cmd.Parameters.AddWithValue("@ID", CustomerID);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable("ThisCustomer");
            sda.Fill(dt);

            name = dt.Rows[0].Field<string>("Username");
            pass = dt.Rows[0].Field<string>("Password");
            phone = dt.Rows[0].Field<string>("Phone_Number");
  
            
            // Get data from database
            tbNewName.Text = name;
            tbNewPass.Text = pass;
            tbNewPhone.Text = phone;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            name = tbNewName.Text;
            pass = tbNewPass.Text;
            phone = tbNewPhone.Text;

            SqlConnection conn = new SqlConnection("Data Source=V-LAPTOP\\MSSQLSERVERAZURE;Initial Catalog=OOP;" +
                                                    "Integrated Security=True");

            // update to database
            SqlCommand cmd = new SqlCommand("update [OOP].[dbo].[User]" +
                "set Phone_Number = @Phone, Username = @Name, Password = @Pass " +
                "where ID = @ID", conn);

            cmd.Parameters.AddWithValue("@Phone", phone);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Pass", pass);
            cmd.Parameters.AddWithValue("@ID", CustomerID);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            CustomerForm.labelCustomerName.Text = name;
            CustomerForm.labelCustomerPhone.Text = phone;

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm form = new CustomerForm(CustomerID);
            form.Show();
        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
