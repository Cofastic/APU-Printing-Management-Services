using Admin_Form_OOP_Assignment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Form_OOP_Assignement
{
    public partial class RequestViewing : Form
    {
        private string Profilename;
        private string Role;
        private string phonenumber;
        private string ID;

        public string CustomerID;
        public RequestViewing(string _CustomerID)
        {
            CustomerID = _CustomerID;
            InitializeComponent();

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4J2129A;Initial Catalog=Users;Integrated Security=True;TrustServerCertificate=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("select RID.RequestID, RID.TotalPrice, RID.RequestStatus, RID.RequestDate, " +
                " RID.CustomerID, U.Username, RID.Urgent, RL.ServiceName, RL.ServiceQuantity, RL.ServicePrice as [Base Price], RID.AssignedWorker" +
                " from RequestIDs RID " +
                " join [Credential] U on U.ID = RID.CustomerID " +
                " join RequestList RL on RL.RequestID = RID.RequestID " +
                " where U.ID = @CustomerID " +
                " order by RID.Urgent desc, RID.RequestDate ", conn);
            cmd.Parameters.AddWithValue("@CustomerID", CustomerID);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable("FullData");
            dt.Clear();
            sda.Fill(dt);
            DGVRequests.DataSource = dt;
            conn.Close();

        }
        public void LoginDetail(LoginDetails userprofile)
        {
            Profilename = userprofile.Profilename;
            Role = userprofile.Role;
            phonenumber = userprofile.Phonenumber;
            ID = userprofile.ID;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginDetails userprofile = new LoginDetails(Profilename, ID, Role, phonenumber);
            CustomerForm CustomerMenu = new CustomerForm(CustomerID);
            CustomerMenu.LoginDetail(userprofile);
            CustomerMenu.Show();
        }

        private void RequestViewing_Load(object sender, EventArgs e)
        {

        }

        private void DGVRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
