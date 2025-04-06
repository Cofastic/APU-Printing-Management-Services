using Admin_Form_OOP_Assignement;
using System.Windows.Forms;
using System;

namespace Admin_Form_OOP_Assignment
{
    public partial class WorkerMenu : Form
    {
        public WorkerMenu()
        {
            InitializeComponent();
        }

        public void LoginDetail(LoginDetails userprofile)
        {
            labelWorkerName.Text = userprofile.Profilename;
            labelWorkerRole.Text = userprofile.Role;
            labelPN.Text = userprofile.Phonenumber;
            labelWorkerIDdesc.Text = userprofile.ID;
        }

        private void btnAccReq_Click(object sender, EventArgs e)
        {
            // Pass the correct parameters to the LoginDetails constructor
            LoginDetails userprofile = new LoginDetails(labelWorkerName.Text, labelWorkerRole.Text, labelPN.Text, labelWorkerIDdesc.Text);
            AcceptRequest acceptreq = new AcceptRequest();
            acceptreq.LoginDetail(userprofile);
            acceptreq.Show();
            this.Hide();
        }

        private void btnCompReq_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Pass the correct parameters to the LoginDetails constructor
            LoginDetails userprofile = new LoginDetails(labelWorkerName.Text, labelWorkerRole.Text, labelPN.Text, labelWorkerIDdesc.Text);
            CompleteRequest compreq = new CompleteRequest();
            compreq.LoginDetail(userprofile);
            compreq.Show();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Pass the correct parameters to the LoginDetails constructor
            LoginDetails userprofile = new LoginDetails(labelWorkerName.Text, labelWorkerRole.Text, labelPN.Text, labelWorkerIDdesc.Text);
            CompletedRequest compdreq = new CompletedRequest();
            compdreq.LoginDetail(userprofile);
            compdreq.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void WorkerMenu_Load(object sender, EventArgs e)
        {

        }

        private void UpdateProfileButton_Click(object sender, EventArgs e)
        {
            // Pass the correct parameters to the LoginDetails constructor
            LoginDetails userprofile = new LoginDetails(labelWorkerName.Text, labelWorkerRole.Text, labelPN.Text, labelWorkerIDdesc.Text);
            Update_Personal_Profile updateprofile = new Update_Personal_Profile();
            updateprofile.LoginDetail(userprofile);
            updateprofile.Show();
            this.Close();
        }
    }
}
