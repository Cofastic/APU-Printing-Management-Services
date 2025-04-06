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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Admin_Form_OOP_Assignement // Namespace declaration
{
    public partial class Admin_Update_User : Form // Class declaration
    {
        private string Profilename; // Declaring a private variable for profile name
        private string Role; // Declaring a private variable for role
        private string phonenumber; // Declaring a private variable for phone number
        private string ID; // Declaring a private variable for ID

        public Admin_Update_User() // Constructor
        {
            InitializeComponent(); // Initializing components
            CMBValues(); // Calling the CMBValues method
            txtboxNewPass.UseSystemPasswordChar = true; // Setting the password character to be displayed as system 
            cmbUsers.DropDownStyle = ComboBoxStyle.DropDownList; // Set the combo box to DropDownList style to prevent user editing
        }

        private void CMBValues() // Method to populate combo box values
        {
            try // Start of try block
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4J2129A;Initial Catalog=Users;Integrated Security=True;TrustServerCertificate=True"); // Creating a new SqlConnection
                SqlCommand command1 = new SqlCommand("SELECT * FROM Credential", conn); // Creating a new SqlCommand
                SqlDataReader reader; // Declaring a SqlDataReader
                conn.Open(); // Opening the database connection
                reader = command1.ExecuteReader(); // Executing the SQL query

                while (reader.Read()) // Loop through the reader
                {
                    string username = reader.GetString(1); // Get the username from the reader
                    string userid = reader.GetString(0); // Get the user ID from the reader
                    cmbUsers.Items.Add(userid + " " + username); // Adding user ID and username to the combo box
                }
            }
            catch (Exception ex) // Catching exceptions
            {
                MessageBox.Show(ex.Message); // Displaying error message
            }
        }

        public void LoginDetail(LoginDetails userprofile) // Method to set login details
        {
            Profilename = userprofile.Profilename; // Setting the profile name
            Role = userprofile.Role; // Setting the role
            phonenumber = userprofile.Phonenumber; // Setting the phone number
            ID = userprofile.ID; // Setting the ID
        }

        private void btnBack_Click(object sender, EventArgs e) // Event handler for the back button click
        {
            this.Hide(); // Hide the current form
            LoginDetails userprofile = new LoginDetails(Profilename, Role, phonenumber, ID); // Creating a new login details object
            Admin AdminForm = new Admin(); // Creating a new admin form
            AdminForm.Logindetail(userprofile); // Setting login details for the admin form
            AdminForm.Show(); // Showing the admin form
        }

        private void Admin_Update_User_Load(object sender, EventArgs e) // Event handler for the form load event
        {
            cmbUsers.Text = "Please Select Role For User"; // Setting default text for combo box
        }

        private void btnUpdate_Click(object sender, EventArgs e) // Event handler for the update button click
        {
            if (string.IsNullOrWhiteSpace(txtboxNewPass.Text)) // Check if the password field is empty
            {
                MessageBox.Show("Error, Password Can't Be Blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show an error message if the password field is empty
                return; // Exit the method
            }

            // Check if password is at least 6 characters long
            if (txtboxNewPass.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if phone number contains only digits
            if (!string.IsNullOrWhiteSpace(txtboxPN.Text) && !txtboxPN.Text.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must contain only digits", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try // Start of try block
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4J2129A;Initial Catalog=Users;Integrated Security=True;TrustServerCertificate=True"); // Creating a new SqlConnection

                string selectedUser = cmbUsers.SelectedItem.ToString().Split(' ')[0]; // Get the selected user ID
                string profilename = txtboxProfile.Text; // Get the profile name
                string password = txtboxNewPass.Text; // Get the new password
                string phoneNumber = txtboxPN.Text; // Get the phone number

                conn.Open(); // Open the database connection
                SqlCommand command1 = new SqlCommand("UPDATE Credential SET Profile_Name = @Profile_Name, Password = @Password, Phone_Number = @Phone_Number WHERE ID = @ID", conn); // Create a new SqlCommand

                command1.Parameters.AddWithValue("@Profile_Name", profilename); // Add profile name as parameter
                command1.Parameters.AddWithValue("@Password", password); // Add password as parameter
                command1.Parameters.AddWithValue("@Phone_Number", phoneNumber); // Add phone number as parameter
                command1.Parameters.AddWithValue("@ID", selectedUser); // Add selected user ID as parameter

                command1.ExecuteNonQuery(); // Execute the SQL query

                string ID = selectedUser; // Set ID to selected user ID
                labelIDdesc.Text = ID; // Set the ID label text

                MessageBox.Show("User Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); // Show success message
                conn.Close(); // Close the database connection

                this.Hide(); // Hide the current form
                Login loginForm = new Login(); // Create a new login form
                loginForm.Show(); // Show the login form
            }
            catch (Exception ex) // Catching exceptions
            {
                MessageBox.Show(ex.Message); // Displaying error message
            }
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e) // Event handler for the combo box selection change
        {
            if (cmbUsers.SelectedItem != null) // Check if an item is selected
            {
                string selectedUserId = cmbUsers.SelectedItem.ToString().Split(' ')[0]; // Get the selected user ID
                SqlConnection connection1 = new SqlConnection("Data Source=DESKTOP-4J2129A;Initial Catalog=Users;Integrated Security=True;TrustServerCertificate=True"); // Creating a new SqlConnection
                SqlCommand command1 = new SqlCommand("SELECT * FROM Credential WHERE ID = @ID", connection1); // Creating a new SqlCommand
                command1.Parameters.AddWithValue("@ID", selectedUserId); // Add selected user ID as parameter

                connection1.Open(); // Open the database connection
                SqlDataReader reader = command1.ExecuteReader(); // Execute the SQL query

                if (reader.Read()) // Check if data is retrieved
                {
                    string ID = reader.GetString(0); // Get the ID from the reader
                    string profilename = reader.GetString(1); // Get the profile name from the reader
                    string Username = reader.GetString(2); // Get the username from the reader
                    string Password = reader.GetString(3); // Get the password from the reader
                    string PhoneNumber = reader.GetString(4); // Get the phone number from the reader
                    string Role = reader.GetString(5); // Get the role from the reader

                    // Update the UI with retrieved data
                    txtboxProfile.Text = profilename; // Set the profile name textbox
                    labelUserdesc.Text = Username; // Set the username label
                    txtboxPN.Text = PhoneNumber; // Set the phone number textbox
                    txtboxNewPass.Text = Password; // Set the password textbox
                    labelRoledesc.Text = Role; // Set the role label
                    labelIDdesc.Text = ID; // Set the ID label
                }
                else // If no data is retrieved
                {
                    txtboxProfile.Text = string.Empty; // Clear the profile name textbox
                    labelUserdesc.Text = string.Empty; // Clear the username label
                }
            }
        }

        private void txtboxProfile_TextChanged(object sender, EventArgs e) // Event handler for profile name textbox text change
        {

        }

        private void cboxShowpass_CheckedChanged(object sender, EventArgs e) // Event handler for show password checkbox change
        {
            if (cboxShowpass.Checked) // If show password checkbox is checked
            {
                txtboxNewPass.UseSystemPasswordChar = false; // Show the password in plain text
            }
            else // If show password checkbox is not checked
            {
                txtboxNewPass.UseSystemPasswordChar = true; // Hide the password
            }
        }

        private void labelIDdesc_Click(object sender, EventArgs e) // Event handler for ID label click
        {

        }
    }
}

