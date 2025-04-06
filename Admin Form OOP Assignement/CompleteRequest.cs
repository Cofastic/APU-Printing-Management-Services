using Admin_Form_OOP_Assignement;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Admin_Form_OOP_Assignment
{
    public partial class CompleteRequest : Form
    {
        private string Profilename;
        private string Role;
        private string phonenumber;
        private string workerID;

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4J2129A;Initial Catalog=Users;Integrated Security=True;TrustServerCertificate=True");

        public CompleteRequest()
        {
            InitializeComponent();
        }

        // Set the user profile details and initialize ComboBox and DataGridView
        public void LoginDetail(LoginDetails userprofile)
        {
            Profilename = userprofile.Profilename;
            Role = userprofile.Role;
            phonenumber = userprofile.Phonenumber;
            workerID = userprofile.ID; // Store the worker ID
            labelWorkerID.Text = workerID;

            // Ensure workerID is set before calling these methods
            CMBValues();
            LoadData();
        }

        private void CMBValues()
        {
            try
            {
                conn.Open();
                SqlCommand command1 = new SqlCommand("SELECT RequestID FROM RequestIDs WHERE RequestStatus = 'Work In Progress' AND AssignedWorker = @WorkerID", conn);
                command1.Parameters.AddWithValue("@WorkerID", workerID); // Add the WorkerID parameter
                SqlDataReader reader = command1.ExecuteReader();

                cmbReqID.Items.Clear();

                while (reader.Read())
                {
                    string ReqID = reader.GetString(0);
                    cmbReqID.Items.Add(ReqID);
                }

                if (cmbReqID.Items.Count > 0)
                {
                    cmbReqID.SelectedIndex = 0;
                }

                reader.Close();
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

        private void LoadData()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM RequestIDs WHERE RequestStatus = 'Work In Progress' AND AssignedWorker = @WorkerID", conn);
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

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (cmbReqID.SelectedItem != null)
            {
                try
                {
                    string selectedReqID = cmbReqID.SelectedItem.ToString();

                    SqlCommand cmd = new SqlCommand("UPDATE RequestIDs SET RequestStatus = @Status WHERE RequestID = @ReqID", conn);
                    cmd.Parameters.AddWithValue("@Status", "Completed");
                    cmd.Parameters.AddWithValue("@ReqID", selectedReqID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    LoadData();

                    cmbReqID.Items.Clear();
                    CMBValues();

                    cmbReqID.SelectedIndex = -1;

                    MessageBox.Show("Request status updated to 'Completed'.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a request ID.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginDetails userprofile = new LoginDetails(Profilename, Role, phonenumber, workerID);
            WorkerMenu WorkerForm = new WorkerMenu();
            WorkerForm.LoginDetail(userprofile);
            WorkerForm.Show();
        }

        private void CompleteRequest_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void cmbReqID_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
