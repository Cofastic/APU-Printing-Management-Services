using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Data;
using System.Windows.Forms;

namespace Admin_Form_OOP_Assignement
{
    public partial class CustomerReport : Form
    {
        private string Profilename;
        private string Role;
        private string phonenumber;
        private string ID;

        public CustomerReport(DataTable dt)
        {
            InitializeComponent();
            dataGridViewGenedReport.DataSource = dt;
        }

        public void LoginDetail(LoginDetails userprofile)
        {
            Profilename = userprofile.Profilename;
            Role = userprofile.Role;
            phonenumber = userprofile.Phonenumber;
            ID = userprofile.ID;
        }

        private void CustomerReport_Load(object sender, EventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginDetails userprofile = new LoginDetails(Profilename, Role, phonenumber, ID);
            Admin AdminForm = new Admin();
            AdminForm.Logindetail(userprofile);
            AdminForm.Show();
        }
    }
}
