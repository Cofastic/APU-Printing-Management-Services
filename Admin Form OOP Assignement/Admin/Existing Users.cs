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

namespace Admin_Form_OOP_Assignement 
{
    public partial class Exising_Users : Form
    {
        // Declare a SqlConnection object to establish connection with the database
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4J2129A;Initial Catalog=Users;Integrated Security=True;TrustServerCertificate=True");
        // Declare private fields to store user details
        private string Profilename;
        private string Role;
        private string phonenumber;
        private string ID;

        // Constructor for the Existing_Users form
        public Exising_Users()
        {
            InitializeComponent(); // Initialize form components
            LoadTable(); // Call the LoadTable method to load data into the DataGridView
        }

        // Method to set login details passed from another form
        public void LoginDetail(LoginDetails userprofile)
        {
            // Set profile name, role, phone number, and ID fields
            Profilename = userprofile.Profilename;
            Role = userprofile.Role;
            phonenumber = userprofile.Phonenumber;
            ID = userprofile.ID;
        }

        // Method to load data into the DataGridView
        private void LoadTable()
        {
            {
                DataTable dt = new DataTable(); // Create a new DataTable to store data
                string query = "SELECT * FROM Credential"; // Define the SQL query to retrieve data

                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn)) // Create a new SqlCommand object with the query and connection
                    {
                        conn.Open(); // Open the database connection
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd)) // Create a new SqlDataAdapter with the SqlCommand
                        {
                            adapter.Fill(dt); // Fill the DataTable with data from the SqlDataAdapter
                        }
                        // Assign the DataTable to the DataSource property of the DataGridView
                        DataGridViewUsers.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions by displaying an error message
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Close the connection after using it, whether an exception occurred or not
                    conn.Close();
                }
            }
        }

        // Event handler for the back button click
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Hide the current form and show the Admin form with login details
            this.Hide();
            LoginDetails userprofile = new LoginDetails(Profilename, Role, phonenumber, ID);
            Admin AdminForm = new Admin();
            AdminForm.Logindetail(userprofile);
            AdminForm.Show();
        }

        // Event handler for the update button click
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Hide the current form and show the Admin_Update_User form with login details
            this.Hide();
            LoginDetails userprofile = new LoginDetails(Profilename, Role, phonenumber, ID);
            Admin_Update_User AdminUpdateUser = new Admin_Update_User();
            AdminUpdateUser.LoginDetail(userprofile);
            AdminUpdateUser.Show();
        }

        // Event handler for the form load event
        private void Exising_Users_Load(object sender, EventArgs e)
        {
            // Load data into the DataGridView from the 'usersDataSet.Credential' table
            this.credentialTableAdapter.Fill(this.usersDataSet.Credential);
        }
    }
}
