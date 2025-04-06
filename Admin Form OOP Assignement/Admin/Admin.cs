// Including necessary namespaces
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Defining the namespace for the Admin form
namespace Admin_Form_OOP_Assignement
{
    // Partial class definition for the Admin form
    public partial class Admin : Form
    {
        // Constructor for the Admin form
        public Admin()
        {
            // Method to initialize form components
            InitializeComponent();
        }

        // Method to set the login details on the form
        public void Logindetail(LoginDetails userprofile)
        {
            // Setting the label text to the user's profile name
            labelNamedesc.Text = userprofile.Profilename;
            // Setting the label text to the user's role
            labelJobdesc.Text = userprofile.Role;
            // Setting the label text to the user's phone number
            labelPNdesc.Text = userprofile.Phonenumber;
            // Setting the label text to the user's ID
            labelIDdesc.Text = userprofile.ID;
        }

        // Event handler for form load event (currently empty)
        private void Admin_Load(object sender, EventArgs e)
        {

        }

        // Event handler for the logout button click event
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Creating a new instance of the Login form
            Login login = new Login();
            // Showing the Login form
            login.Show();
            // Hiding the current Admin form
            this.Hide();
        }

        // Event handler for the report button click event
        private void btnReport_Click(object sender, EventArgs e)
        {
            // Creating a new instance of LoginDetails with current user details
            LoginDetails userprofile = new LoginDetails(labelNamedesc.Text, labelJobdesc.Text, labelPNdesc.Text, labelIDdesc.Text);
            // Creating a new instance of Generate_Report form
            Generate_Report genreport = new Generate_Report();
            // Passing user details to the Generate_Report form
            genreport.LoginDetail(userprofile);
            // Showing the Generate_Report form
            genreport.Show();
            // Hiding the current Admin form
            this.Hide();
        }

        // Event handler for the update button click event
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Creating a new instance of LoginDetails with current user details
            LoginDetails userprofile = new LoginDetails(labelNamedesc.Text, labelJobdesc.Text, labelPNdesc.Text, labelIDdesc.Text);
            // Creating a new instance of Exising_Users form
            Exising_Users existingusers = new Exising_Users();
            // Passing user details to the Exising_Users form
            existingusers.LoginDetail(userprofile);
            // Showing the Exising_Users form
            existingusers.Show();
            // Hiding the current Admin form
            this.Hide();
        }

        // Event handler for the user button click event
        private void btnUser_Click(object sender, EventArgs e)
        {
            // Creating a new instance of LoginDetails with current user details
            LoginDetails userprofile = new LoginDetails(labelNamedesc.Text, labelJobdesc.Text, labelPNdesc.Text, labelIDdesc.Text);
            // Creating a new instance of Register_New_User form
            Register_New_User registeruser = new Register_New_User();
            // Passing user details to the Register_New_User form
            registeruser.LoginDetail(userprofile);
            // Showing the Register_New_User form
            registeruser.Show();
            // Hiding the current Admin form
            this.Hide();
        }

        // Event handler for labelNamedesc click event (currently empty)
        public void labelNamedesc_Click(object sender, EventArgs e)
        {

        }

        // Event handler for labelPNdesc click event (currently empty)
        private void labelPNdesc_Click(object sender, EventArgs e)
        {

        }

        // Event handler for labelID click event (currently empty)
        private void labelID_Click(object sender, EventArgs e)
        {

        }
    }
}
