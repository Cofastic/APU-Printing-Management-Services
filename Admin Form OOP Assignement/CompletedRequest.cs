using Admin_Form_OOP_Assignement;
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
    public partial class CompletedRequest : Form
    {
        string Profilename;
        string Role;
        string phonenumber;
        string workerID;

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4J2129A;Initial Catalog=Users;Integrated Security=True;TrustServerCertificate=True;");
        public CompletedRequest()
        {
            InitializeComponent();
        }

        private void CompletedRequest_Load(object sender, EventArgs e)
        {

        }
        public void LoginDetail(LoginDetails userprofile)
        {
            Profilename = userprofile.Profilename; // Set the profile name
            Role = userprofile.Role; // Set the role
            phonenumber = userprofile.Phonenumber; // Set the phone number
            workerID = userprofile.ID;
            labelWorkerID.Text = workerID;

            LoadData();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginDetails userprofile = new LoginDetails(Profilename, Role, phonenumber, workerID);
            WorkerMenu WorkerForm = new WorkerMenu();
            WorkerForm.LoginDetail(userprofile);
            WorkerForm.Show();
        }
        private void LoadData()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM RequestIDs WHERE RequestStatus = 'Completed' AND AssignedWorker = @WorkerID", conn);
                cmd.Parameters.AddWithValue("@WorkerID", workerID); // Add the WorkerID parameter
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                dt.Clear();
                sda.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void labelWorkerID_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
