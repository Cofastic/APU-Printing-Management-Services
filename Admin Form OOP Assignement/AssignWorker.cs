using Admin_Form_OOP_Assignement;
using Admin_Form_OOP_Assingment;
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

    public partial class AssignWorker : Form
    {
        private string Profilename; // Store the profile name of the user
        private string Role; // Store the role of the user
        private string phonenumber; // Store the phone number of the user   
        private string ID; // Store the ID of the user

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4J2129A;Initial Catalog=Users;Integrated Security=True;TrustServerCertificate=True");

        public AssignWorker()
        {
            InitializeComponent();
            conn.Open();
            string ReqStatus = "SELECT * FROM RequestIDs WHERE RequestStatus = 'New'";
            SqlCommand DisplayStatus = new SqlCommand(ReqStatus, conn);

            SqlDataAdapter da = new SqlDataAdapter(DisplayStatus);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();
            CMBReqValues();
            CMBWorkerValues();

        }

        public void LoginDetail(LoginDetails userprofile)
        {
            Profilename = userprofile.Profilename; // Set the profile name
            Role = userprofile.Role; // Set the role
            phonenumber = userprofile.Phonenumber; // Set the phone number
            ID = userprofile.ID; // Set the ID
        }
        private void LoadRequests()
        {
            conn.Open();
            string query = "SELECT * FROM RequestIDs WHERE RequestStatus = 'New'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();


            comboBoxRequestID.DisplayMember = "RequestID";
            comboBoxRequestID.ValueMember = "RequestID";
            comboBoxRequestID.DataSource = dt;
        }

        
        private void AssignWorker_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oOPDataSet10.WorkerMenu' table. You can move, or remove it, as needed.
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4J2129A;Initial Catalog=Users;Integrated Security=True;TrustServerCertificate=True");
        }
        private void CMBReqValues()
        {
            try
            {
                conn.Open();
                SqlCommand command1 = new SqlCommand("SELECT RequestID FROM RequestIDs WHERE RequestStatus = 'NEW'", conn);
                SqlDataReader reader = command1.ExecuteReader();

                comboBoxRequestID.Items.Clear(); 

                while (reader.Read())
                {
                    string ReqID = reader.GetString(0);
                    comboBoxRequestID.Items.Add(ReqID);
                }

                if (comboBoxRequestID.Items.Count > 0)
                {
                    comboBoxRequestID.SelectedIndex = 0; 
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
        private void CMBWorkerValues()
        {
            try
            {
                conn.Open();
                SqlCommand command1 = new SqlCommand("SELECT ID FROM Credential WHERE ID LIKE 'W%'", conn);
                SqlDataReader reader = command1.ExecuteReader();

                comboBoxWorkerID.Items.Clear();

                while (reader.Read())
                {
                    string WorkerID = reader.GetString(0);
                    comboBoxWorkerID.Items.Add(WorkerID);
                }

                if (comboBoxWorkerID.Items.Count > 0)
                {
                    comboBoxWorkerID.SelectedIndex = 0;
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnAssignWorker_Click(object sender, EventArgs e)
        {
            // Check if any combo box value is null
            if (comboBoxRequestID.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid Request ID.");
                return;
            }

            if (comboBoxWorkerID.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid Worker ID.");
                return;
            }
            string requestId = comboBoxRequestID.SelectedItem.ToString();
            string workerId = comboBoxWorkerID.SelectedItem.ToString();

            try
            {
                // Updating RequestIDs table
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4J2129A;Initial Catalog=Users;Integrated Security=True;TrustServerCertificate=True"))
                {
                    string updateRequestQuery = "UPDATE RequestIDs SET RequestStatus = 'Assigned', AssignedWorker = @WorkerID WHERE RequestID = @RequestID";
                    using (SqlCommand cmd = new SqlCommand(updateRequestQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@RequestID", requestId);
                        cmd.Parameters.AddWithValue("@WorkerID", workerId);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    MessageBox.Show("Worker assigned successfully!");
                    LoadRequests();
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginDetails userprofile = new LoginDetails(Profilename, Role, ID, phonenumber);
            Form1 ManagerForm = new Form1();
            ManagerForm.LoginDetail(userprofile);
            ManagerForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
 


   
