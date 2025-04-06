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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Diagnostics.Eventing.Reader;

namespace Admin_Form_OOP_Assignement
{
    public partial class Register_New_User : Form
    {
        private string Profilename; // Store the profile name of the user
        private string Role; // Store the role of the user
        private string phonenumber; // Store the phone number of the user   
        private string ID; // Store the ID of the user


        // Define a SqlConnection object to establish connection with the database
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4J2129A;Initial Catalog=Users;Integrated Security=True;TrustServerCertificate=True");

        // Constructor of the form
        public Register_New_User()
        {
            InitializeComponent();
            txtboxPass.UseSystemPasswordChar = true; // Setting the password character to be displayed as system 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList; // Set the combo box to DropDownList style to prevent user editing
        }

        public void LoginDetail(LoginDetails userprofile)
        {
            Profilename = userprofile.Profilename; // Set the profile name
            Role = userprofile.Role; // Set the role
            phonenumber = userprofile.Phonenumber; // Set the phone number
            ID = userprofile.ID; // Set the ID
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginDetails userprofile = new LoginDetails(Profilename, Role, phonenumber, ID);
            Admin AdminForm = new Admin();
            // Pass the login details to the Admin form
            AdminForm.Logindetail(userprofile);
            AdminForm.Show();
        }

        private void cmbJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRole.SelectedItem != null)
            {
                string selectedRole = cmbRole.SelectedItem.ToString();
                AutoIDNumber(selectedRole); // Generate the current ID based on the selected role
            }
        }

        // Method to generate an auto-incremented ID based on the selected role
        private void AutoIDNumber(string role)
        {
            // Define the prefix based on the selected role
            string prefix;
            switch (role)
            {
                case "Admin":
                    prefix = "A";
                    break;
                case "Customer":
                    prefix = "C";
                    break;
                case "Worker":
                    prefix = "W";
                    break;
                case "Manager":
                    prefix = "M";
                    break;
                default:
                    // Throw an ArgumentException if the role is invalid
                    // An argument exception occurs when a method receives an invalid argument.
                    // so if none of the roles which are mentioned above are selected, it will throw an exception
                    throw new ArgumentException("Invalid role", nameof(role));
            }
            // Initialize the counter for the new ID
            int IDNumber = 0;
            try
            {
                // Open the database connection
                conn.Open();
                // Query to count the existing IDs for the given role
                SqlCommand command = new SqlCommand($"SELECT COUNT(ID) FROM Credential WHERE ID LIKE '{prefix}%'", conn);
                int count = Convert.ToInt32(command.ExecuteScalar());

                // Increment the count to generate the new ID
                IDNumber = count + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            // Generate the new ID based on the role and the incremented counter
            string newID = $"{prefix}{IDNumber:D2}";

            // Update the label with the new ID
            labelIDdesc.Text = newID;
        }

        private void Register_New_User_Load(object sender, EventArgs e)
        {
            // Set the default text for the ComboBox as a prompt for role selection
            cmbRole.Text = "Please Select Role For User";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Check if the role is not selected
            if (cmbRole.Text == "Please Select Role For User")
            {
                // Show an error message if the role is not selected
                MessageBox.Show("Error, Please Choose A Role For The User", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if any mandatory fields are empty
            if (string.IsNullOrWhiteSpace(txtboxUser.Text) || string.IsNullOrWhiteSpace(txtboxPass.Text) || string.IsNullOrWhiteSpace(txtboxProfile.Text))
            {
                // Show an error message if any mandatory fields are empty
                MessageBox.Show("Error, Profile Name, Username and Password are not specified", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if any mandatory fields are empty
            }

            // Check if the username field is empty
            if (string.IsNullOrWhiteSpace(txtboxUser.Text))
            {
                // Show an error message if the username field is empty
                MessageBox.Show("Error, Username is not specified", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if the username field is empty
            }

            // Check if the password field is empty
            if (string.IsNullOrWhiteSpace(txtboxPass.Text))
            {
                // Show an error message if the password field is empty
                MessageBox.Show("Error, Password is not specified", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if the password field is empty
            }

            // Check if password is at least 6 characters long
            if (txtboxPass.Text.Length < 6)
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

            // Check if the profile name field is empty
            if (string.IsNullOrWhiteSpace(txtboxProfile.Text))
            {
                // Show an error message if the profile name field is empty
                MessageBox.Show("Error, Profile Name is not specified", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if the profile name field is empty
            }

            // Try block to attempt database operations
            try
            {
                // Check if username already exists
                conn.Open();
                SqlCommand checkDuplicate = new SqlCommand("SELECT COUNT(*) FROM Credential WHERE Username = @Username", conn);
                checkDuplicate.Parameters.AddWithValue("@Username", txtboxUser.Text);
                int userCount = (int)checkDuplicate.ExecuteScalar();
                conn.Close();

                if (userCount > 0)
                {
                    MessageBox.Show("Username already exists. Please choose a different username.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Generate the new ID before opening the connection to insert the new user
                AutoIDNumber(cmbRole.Text);

                // Create a new UserData object with user details
                UserData RegisternNewUser = new UserData(
                    labelIDdesc.Text, // ID
                    txtboxUser.Text,  // Username
                    txtboxPass.Text,  // Password
                    txtboxProfile.Text,// Profile Name
                    cmbRole.Text,      // Role
                    txtboxPN.Text);    // Phone Number

                conn.Open();
                // Define SQL command to insert user details into the database
                SqlCommand command1 = new SqlCommand("INSERT INTO Credential (ID, Profile_Name, Username, Password, Phone_Number, Role) VALUES (@ID, @Profile_Name, @Username, @Password, @Phone_Number, @Role)", conn);

                // Use parameters to prevent SQL injection
                command1.Parameters.AddWithValue("@ID", RegisternNewUser.ID);
                command1.Parameters.AddWithValue("@Profile_Name", RegisternNewUser.Profile_name);
                command1.Parameters.AddWithValue("@Username", RegisternNewUser.Username);
                command1.Parameters.AddWithValue("@Password", RegisternNewUser.Password);
                command1.Parameters.AddWithValue("@Phone_Number", RegisternNewUser.Phonenumber);
                command1.Parameters.AddWithValue("@Role", RegisternNewUser.Role);

                // Execute SQL command to insert user details into the database
                command1.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("User Registered Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear all input fields after successful registration
                txtboxUser.Text = string.Empty;
                txtboxPass.Text = string.Empty;
                txtboxProfile.Text = string.Empty;
                txtboxPN.Text = string.Empty;
                cmbRole.Text = "Please Select Role For User";
                labelIDdesc.Text = "";
            }
            // Exception Handling
            catch (Exception ex)
            {
                // Show error message if any exception occurs during database operation
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void labelIDdesc_Click(object sender, EventArgs e)
        {

        }

        private void cboxShowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxShowpass.Checked)
            {
                txtboxPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtboxPass.UseSystemPasswordChar = true;
            }
        }
    }

}

