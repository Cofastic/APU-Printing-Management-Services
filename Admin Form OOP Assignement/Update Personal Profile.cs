using System; 
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Admin_Form_OOP_Assignement 
{
    public partial class Update_Personal_Profile : Form 
    {
        private string Profilename; // Declaration of a private string variable for profile name
        private string Role; // Declaration of a private string variable for user role
        private string PhoneNumber; // Declaration of a private string variable for phone number
        private string ID; // Declaration of a private string variable for user ID

        public Update_Personal_Profile() // Constructor method for the Update_Personal_Profile class
        {
            InitializeComponent(); // Initializing the components of the form
            txtboxNewPass.UseSystemPasswordChar = true; // Setting the password textbox to use system password characters
        }

        public void LoginDetail(LoginDetails userprofile) // Method to set login details
        {
            Profilename = userprofile.Profilename; // Setting the profile name
            Role = userprofile.Role; // Setting the user role
            PhoneNumber = userprofile.Phonenumber; // Setting the phone number
            ID = userprofile.ID; // Setting the user ID

            // Update the text boxes with user information
            txtboxProfile.Text = Profilename; // Setting the profile name textbox text
            txtboxPN.Text = PhoneNumber; // Setting the phone number textbox text
            labelIDdesc.Text = ID; // Setting the label text for user ID
            labelRoledesc.Text = Role; // Setting the label text for user role
        }

        private void btnBack_Click(object sender, EventArgs e) // Event handler for the back button click
        {
            Login login = new Login(); // Creating an instance of the login form
            login.Show(); // Showing the login form
            this.Hide(); // Hiding the current form
        }

        private void btnUpdate_Click(object sender, EventArgs e) // Event handler for the update button click
        {
            if (string.IsNullOrWhiteSpace(txtboxNewPass.Text)) // Checking if the password field is empty or contains only white spaces
            {
                // Show an error message if the password field is empty
                MessageBox.Show("Error, Password Can't Be Blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if the password field is empty
            }

            try // Start of a try block to handle exceptions
            {
                // Update the user's profile
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4J2129A;Initial Catalog=Users;Integrated Security=True;TrustServerCertificate=True")) // Creating a SQL connection object
                {
                    conn.Open(); // Opening the SQL connection
                    SqlCommand command = new SqlCommand("UPDATE Credential SET Profile_Name = @Profile_Name, Password = @Password, Phone_Number = @Phone_Number WHERE ID = @ID", conn); // Creating a SQL command to update user profile
                    command.Parameters.AddWithValue("@Profile_Name", txtboxProfile.Text); // Adding parameter for profile name
                    command.Parameters.AddWithValue("@Password", txtboxNewPass.Text); // Adding parameter for password
                    command.Parameters.AddWithValue("@Phone_Number", txtboxPN.Text); // Adding parameter for phone number
                    command.Parameters.AddWithValue("@ID", ID); // Adding parameter for user ID

                    command.ExecuteNonQuery(); // Executing the SQL command
                }

                MessageBox.Show("User Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); // Showing a success message
            }
            catch (Exception ex) // Catching any exceptions that occur
            {
                MessageBox.Show(ex.Message); // Displaying the exception message in a message box
            }
        }

        private void Update_Personal_Profile_Load(object sender, EventArgs e) // Event handler for the form load event
        {

        }

        private void cboxShowpass_CheckedChanged(object sender, EventArgs e) // Event handler for the show password checkbox change
        {
            if (cboxShowpass.Checked) // Checking if the checkbox is checked
            {
                txtboxNewPass.UseSystemPasswordChar = false; // Showing the password characters
            }
            else // If the checkbox is not checked
            {
                txtboxNewPass.UseSystemPasswordChar = true; // Hiding the password characters
            }
        }
    }
}
