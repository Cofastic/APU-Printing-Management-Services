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
    public partial class FormConfirmation : Form
    {
        public List<Request> RequestList;
        public string LabelText = "Requested Services: ";
        public bool IsUrgent;
        public double TotalPrice;
        ServiceSelectForm ServiceSelectForm1;
        public string CustomerID;

        // initialize form while changing value of label to become selected services
        public FormConfirmation(List<Request> _RequestList , double _TotalPrice, bool _Urgent, ServiceSelectForm _ServiceSelectForm, string _CustomerID)
        {
            RequestList = _RequestList;
            IsUrgent = _Urgent;
            TotalPrice = _TotalPrice;
            ServiceSelectForm1 = _ServiceSelectForm;
            CustomerID = _CustomerID;


            InitializeComponent();



            double UrgencyFee = TotalPrice / 1.3 * 0.3;
            labelUrgency.Text = $"Urgent Request \n( additional 30% surcharge) " +
                                $"\nRM {UrgencyFee/0.3*1} + additional RM {UrgencyFee}";


            // using string lists for assigning values
            for (int i = 0; i < RequestList.Count; i++)
            {
                // adds all selected services and quantity to services label
                LabelText += $"\n{RequestList[i].quantity}pc of {RequestList[i].type}";
            }
            labelServices.Text = LabelText;


            // adds total price to total price label
            labelTotalPrice.Text += $"\nRM {TotalPrice}";

            if (IsUrgent) { labelUrgency.Visible = true; }
            else { labelUrgency.Visible = false; }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            // populate RequestIDs table 
            Random random = new Random();
            string randomNumber = random.Next(0, 99999).ToString().PadLeft(5, '0');
            string NewRequestId = $"R{randomNumber}";

            DateTime now = DateTime.Now;
            string formattedDate = now.ToString("yyyy-MM-dd HH:mm:ss");

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4J2129A;Initial Catalog=Users;Integrated Security=True;TrustServerCertificate=True");

            SqlCommand cmd = new SqlCommand("insert into [Users].[dbo].[RequestIDs] values " +
                                            "( @RequestID, 'new', @CustomerID, @TotalPrice, @Date, @Urgency, 'None')", conn);

            cmd.Parameters.AddWithValue("@RequestID"    , NewRequestId);
            cmd.Parameters.AddWithValue("@CustomerID"   , CustomerID);            
            cmd.Parameters.AddWithValue("@TotalPrice"   , TotalPrice);
            cmd.Parameters.AddWithValue("@Date"         , formattedDate);
            cmd.Parameters.AddWithValue("@Urgency"      , IsUrgent);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();


            // populate RequestList table
            foreach (Request item in RequestList)
            {
                SqlCommand cmd2 = new SqlCommand("insert into [Users].[dbo].[RequestList] values " +
                                                 "( @RequestID2, @ServiceName, @Quantity, @Price)", conn);

                cmd2.Parameters.AddWithValue("@RequestID2"   , NewRequestId);
                cmd2.Parameters.AddWithValue("@ServiceName"  , item.type);
                cmd2.Parameters.AddWithValue("@Quantity"     , item.quantity);
                cmd2.Parameters.AddWithValue("@Price"        , item.price);

                conn.Open();
                cmd2.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("successfully created request");
            ServiceSelectForm1.Close();
            CustomerForm CF = new CustomerForm(CustomerID);
            CF.Show();
            this.Close();
        }

        private void FormConfirmation_Load(object sender, EventArgs e)
        {

        }
    }
}
