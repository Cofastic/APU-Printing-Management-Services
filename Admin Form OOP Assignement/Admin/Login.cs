using System; 
using System.Collections.Generic; 
using System.ComponentModel; 
using System.Data; 
using System.Drawing; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
using System.Windows.Forms;
using System.Data.SqlClient; 
using Admin_Form_OOP_Assignment; 
using Admin_Form_OOP_Assingment; 

namespace Admin_Form_OOP_Assignement 
{
    public partial class Login : Form 
    {
        public Login() // Constructor method for the Login class
        {
            InitializeComponent(); // Initializing the components of the form
            txtboxPass.UseSystemPasswordChar = true; // Setting the password textbox to use system password characters
        }

        public static Login Instance; // Declaration of a static instance of the Login class
        SqlConnection connection1 = new SqlConnection("Data Source=DESKTOP-4J2129A;Initial Catalog=Users;Integrated Security=True;TrustServerCertificate=True"); // Creating a SQL connection object
        SqlCommand command1; // Declaration of a SQL command object
        SqlCommand command2; // Declaration of another SQL command object

        private void btnLogin_Click(object sender, EventArgs e) // Event handler for the login button click
        {
            try // Start of a try block
            {
                if ((txtboxUser.Text != null) && (txtboxPass.Text != null)) // Checking if the username and password textboxes are not null
                {
                    string Username = txtboxUser.Text; // Retrieving the entered username
                    string Password = txtboxPass.Text; // Retrieving the entered password
                    { // Start of a code block
                        connection1.Open(); // Opening the SQL connection
                        command1 = new SqlCommand("SELECT * FROM Credential WHERE Username=@Username AND Password=@Password", connection1); // Creating a SQL command to select user data
                        command1.Parameters.AddWithValue("@Username", Username); // Adding parameter for the username
                        command1.Parameters.AddWithValue("@Password", Password); // Adding parameter for the password
                        SqlDataAdapter SDA = new SqlDataAdapter(command1); // Creating a SQL data adapter
                        DataTable table = new DataTable(); // Creating a data table
                        SDA.Fill(table); // Filling the data table with data from the SQL command
                        if (table.Rows.Count > 0) // Checking if any rows are returned
                        {
                            string ID = table.Rows[0][0].ToString(); // Retrieving the user ID
                            LoginDetails userprofile = new LoginDetails(table.Rows[0][1].ToString(), table.Rows[0][5].ToString(), table.Rows[0][4].ToString(), table.Rows[0][0].ToString()); // Creating a login details object with user data
                            if (userprofile.Role != null) // Checking if the user has a role
                            {
                                txtboxUser.Text = string.Empty; // Clearing the username textbox
                                txtboxPass.Text = string.Empty; // Clearing the password textbox
                                if (userprofile.Role == "Admin") // Checking if the user is an admin
                                {
                                    Admin AdminForm = new Admin(); // Creating an instance of the admin form
                                    AdminForm.Logindetail(userprofile); // Passing login details to the admin form
                                    AdminForm.Show(); // Showing the admin form
                                    this.Hide(); // Hiding the current login form
                                }
                                else if (userprofile.Role == "Worker") // Checking if the user is a worker
                                {
                                    WorkerMenu WorkerForm = new WorkerMenu(); // Creating an instance of the worker menu form
                                    WorkerForm.LoginDetail(userprofile); // Passing login details to the worker menu form
                                    WorkerForm.Show(); // Showing the worker menu form
                                    this.Hide(); // Hiding the current login form
                                }
                                else if (userprofile.Role == "Customer") // Checking if the user is a customer
                                {
                                    CustomerForm customerForm = new CustomerForm(ID); // Creating an instance of the customer form
                                    customerForm.LoginDetail(userprofile); // Passing login details to the customer form
                                    customerForm.Show(); // Showing the customer form
                                    this.Hide(); // Hiding the current login form
                                }
                                else // If the user has an unrecognized role
                                {
                                    Form1 ManagerForm = new Form1(); // Creating an instance of the default form
                                    ManagerForm.LoginDetail(userprofile); // Passing login details to the default form
                                    ManagerForm.Show(); // Showing the default form
                                    this.Hide(); // Hiding the current login form
                                }
                            }
                        }
                        else // If no matching user data is found
                        {
                            MessageBox.Show("Invalid Login", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); // Showing an error message
                            connection1.Close(); // Closing the SQL connection
                            txtboxUser.Text = string.Empty; // Clearing the username textbox
                            txtboxPass.Text = string.Empty; // Clearing the password textbox
                        }
                    }
                }
            }
            catch (Exception ex) // Catching any exceptions that occur
            {
                MessageBox.Show(ex.Message); // Displaying the exception message in a message box
            }
        }

        private void Login_Load(object sender, EventArgs e) // Event handler for the login form load
        {

        }

        private void btnExit_Click(object sender, EventArgs e) // Event handler for the exit button click
        {
            DialogResult result; // Declaration of a dialog result variable
            result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // Displaying a confirmation message
            if (result == DialogResult.Yes) // Checking if the user clicked 'Yes'
            {
                Application.Exit(); // Exiting the application
            }
            else // If the user clicked 'No'
            {
                this.Show(); // Showing the current form
            }
        }

        private void cboxShowpass_CheckedChanged(object sender, EventArgs e) // Event handler for the show password checkbox change
        {
            if (cboxShowpass.Checked) // Checking if the checkbox is checked
            {
                txtboxPass.UseSystemPasswordChar = false; // Showing the password characters
            }
            else // If the checkbox is not checked
            {
                txtboxPass.UseSystemPasswordChar = true; // Hiding the password characters
            }
        }
    }
}
