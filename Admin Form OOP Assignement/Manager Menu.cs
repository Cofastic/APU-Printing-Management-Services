using Admin_Form_OOP_Assignement;
using Admin_Form_OOP_Assignment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Admin_Form_OOP_Assingment
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4J2129A;Initial Catalog=Users;Integrated Security=True;TrustServerCertificate=True");
        public Form1()
        {
            InitializeComponent();
            conn.Open();
            string ReqStatus = "SELECT * FROM RequestIDs";
            SqlCommand DisplayStatus = new SqlCommand(ReqStatus, conn);
            comboBox1.SelectedIndex = 0;
            LoadData("New");

            SqlDataAdapter da = new SqlDataAdapter(DisplayStatus);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        public void LoginDetail(LoginDetails userprofile)
        {
            labelManagerName.Text = userprofile.Profilename;
            labelManagerID.Text = userprofile.ID;
            labelManagerPhone.Text = userprofile.Phonenumber;
            labelManagerRole.Text = userprofile.Role;
        }


        private void Form1_Load(object sender, EventArgs e)
        {


        }
        private void LoadData(string status)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4J2129A;Initial Catalog=Users;Integrated Security=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    string ReqStatus;
                    if (status == "All")
                    {
                        ReqStatus = "SELECT * FROM RequestIDs";
                    }
                    else
                    {
                        ReqStatus = "SELECT * FROM RequestIDs WHERE RequestStatus = @RequestStatus";
                    }
                    SqlCommand DisplayStatus = new SqlCommand(ReqStatus, conn);
                    DisplayStatus.Parameters.AddWithValue("@RequestStatus", status);

                    SqlDataAdapter da = new SqlDataAdapter(DisplayStatus);
                    DataTable dt = new DataTable();
                    dt.Clear();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = comboBox1.SelectedItem.ToString();
            LoadData(selectedStatus);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string selectedStatus = comboBox1.SelectedItem.ToString();
            LoadData(selectedStatus);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

        }

        private void btnAssignWorker_Click(object sender, EventArgs e)
        {
            // Pass the correct parameters to the LoginDetails constructor
            LoginDetails userprofile = new LoginDetails(labelManagerName.Text , labelManagerID.Text,labelManagerRole.Text,labelManagerPhone.Text);
            AssignWorker assign = new AssignWorker();
            assign.LoginDetail(userprofile);
            assign.Show();
        }

        private void UpdateProfileButton_Click(object sender, EventArgs e)
        {
            // Pass the correct parameters to the LoginDetails constructor
            LoginDetails userprofile = new LoginDetails(labelManagerName.Text, labelManagerRole.Text, labelManagerPhone.Text, labelManagerID.Text);
            Update_Personal_Profile updateprofile = new Update_Personal_Profile();
            updateprofile.LoginDetail(userprofile);
            updateprofile.Show();
            this.Close();
        }
    }
    }
