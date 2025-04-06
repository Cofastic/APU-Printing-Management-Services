using Admin_Form_OOP_Assignement;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Admin_Form_OOP_Assignement
{
    public partial class Generate_Report : Form
    {
        private string Profilename;
        private string Role;
        private string phonenumber;
        private string ID;

        // Constructor for the Generate_Report form
        public Generate_Report()
        {
            InitializeComponent(); // Initialize form components
            CMBValuesCustomer(); // Load customer values into the cmbCustomer combobox
            CMBValuesYear(); // Load year values into the cmbYear combobox
            CMBValuesMonth(); // Load month values into the cmbMonth combobox
            LoadReportData(); // Load report data into the DataGridView
            labelCustomer.Hide(); // Hide the label for customer selection
            cmbCustomer.Hide(); // Hide the combobox for customer selection
            labelServiceRQ.Hide(); // Hide the label for service request selection
            cmbServices.Hide(); // Hide the combobox for service request selection
            labelFromDT.Hide(); // Hide the label for "from" date selection
            labelToDT.Hide(); // Hide the label for "to" date selection
            cmbYear.Hide(); // Hide the combobox for year selection
            cmbMonth.Hide(); // Hide the combobox for month selection
        }

        // Method to load report data into the DataGridView
        private void LoadReportData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4J2129A;Initial Catalog=Users;Integrated Security=True;TrustServerCertificate=True"))
                {
                    string query = @"
                        SELECT 
                            RID.AssignedWorker, 
                            RID.CustomerID, 
                            RID.RequestID, 
                            RL.ServiceName, 
                            RL.ServiceQuantity, 
                            RL.ServicePrice, 
                            RID.RequestDate, 
                            RID.Urgent, 
                            RID.RequestStatus
                        FROM 
                            RequestIDs RID
                        JOIN 
                            RequestList RL 
                        ON 
                            RID.RequestID = RL.RequestID;"; // SQL query to select report data from the database

                    SqlDataAdapter sda = new SqlDataAdapter(query, conn); // Create a new SqlDataAdapter with the query and connection
                    DataTable dt = new DataTable(); // Create a new DataTable
                    sda.Fill(dt); // Fill the DataTable with data from the SqlDataAdapter

                    dataGridViewGenReport.DataSource = dt; // Set the DataSource property of the DataGridView to the DataTable
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show an error message if an exception occurs
            }
        }

        // Method to load customer values into the cmbCustomer combobox
        private void CMBValuesCustomer()
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4J2129A;Initial Catalog=Users;Integrated Security=True;TrustServerCertificate=True");
                SqlCommand command1 = new SqlCommand("SELECT ID FROM [Credential] WHERE ID LIKE 'C%'", conn); // SQL query to select customer IDs
                SqlDataReader reader;
                conn.Open(); // Open the database connection
                reader = command1.ExecuteReader(); // Execute the SQL query

                while (reader.Read())
                {
                    string Customers = reader.GetString(0); // Get customer ID from the SqlDataReader
                    cmbCustomer.Items.Add(Customers); // Add customer ID to the cmbCustomer combobox
                }
                conn.Close(); // Close the database connection
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Show an error message if an exception occurs
            }
        }

        // Method to load year values into the cmbYear combobox
        private void CMBValuesYear()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4J2129A;Initial Catalog=Users;Integrated Security=True;TrustServerCertificate=True");
            SqlCommand command1 = new SqlCommand(@"SELECT DISTINCT YEAR(RequestDate) AS Year FROM RequestIDs ORDER BY Year;", conn); // SQL query to select distinct years
            conn.Open(); // Open the database connection
            using (SqlDataReader reader = command1.ExecuteReader())
            {
                while (reader.Read())
                {
                    cmbYear.Items.Add(reader["Year"].ToString()); // Add year to the cmbYear combobox
                }
            }
            conn.Close(); // Close the database connection
        }

        // Method to load month values into the cmbMonth combobox
        private void CMBValuesMonth()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4J2129A;Initial Catalog=Users;Integrated Security=True;TrustServerCertificate=True");
            SqlCommand command1 = new SqlCommand(@"SELECT DISTINCT DATENAME(month, RequestDate) AS MonthName, MONTH(RequestDate) AS MonthNumber FROM RequestIDs ORDER BY MonthNumber;", conn); // SQL query to select distinct months
            conn.Open(); // Open the database connection
            using (SqlDataReader reader = command1.ExecuteReader())
            {
                while (reader.Read())
                {
                    cmbMonth.Items.Add(reader["MonthName"].ToString()); // Add month to the cmbMonth combobox
                }
            }
            conn.Close(); // Close the database connection
        }

        // Method to set login details
        public void LoginDetail(LoginDetails userprofile)
        {
            Profilename = userprofile.Profilename;
            Role = userprofile.Role;
            phonenumber = userprofile.Phonenumber;
            ID = userprofile.ID;
        }

        // Event handler for the back button click
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            LoginDetails userprofile = new LoginDetails(Profilename, Role, phonenumber, ID); // Create a new LoginDetails object with user profile information
            Admin AdminForm = new Admin(); // Create a new instance of the Admin form
            AdminForm.Logindetail(userprofile); // Pass the user profile information to the Admin form
            AdminForm.Show(); // Show the Admin form
        }

        // Event handler for the generate button click
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbFilters.Text == "Yearly Report" && cmbYear.SelectedItem != null) // Check if the selected report type is yearly and year is selected
                {
                    int selectedYear;
                    if (int.TryParse(cmbYear.SelectedItem.ToString(), out selectedYear)) // Try to parse the selected year
                    {
                        // Generate the yearly report
                        DataTable reportData = GenerateYearlyReport(selectedYear);

                        // Pass the data to the Generated_Report form
                        Generated_Report report = new Generated_Report(reportData);
                        report.LoginDetail(new LoginDetails(Profilename, Role, phonenumber, ID));
                        report.Show();
                        this.Close(); // Close the current form
                    }
                }
                else if (cmbFilters.Text == "Customer Report" && cmbCustomer.SelectedItem != null && cmbMonth.SelectedItem != null) // Check if the selected report type is customer and both customer and month are selected
                {
                    string customerID = cmbCustomer.SelectedItem.ToString(); // Get the selected customer ID
                    string month = cmbMonth.SelectedItem.ToString(); // Get the selected month

                    // Debug output
                    Console.WriteLine($"Debug: Generating customer report for customerID: {customerID}, month: {month}");

                    DataTable reportData = GenerateCustomerReport(customerID, month); // Generate customer report data

                    if (reportData.Rows.Count > 0) // Check if data is found
                    {
                        CustomerReport report = new CustomerReport(reportData); // Create a new instance of CustomerReport form
                        report.LoginDetail(new LoginDetails(Profilename, Role, phonenumber, ID)); // Pass user profile information to the CustomerReport form
                        report.Show(); // Show the CustomerReport form
                        this.Close(); // Close the current form
                    }
                    else
                    {
                        MessageBox.Show("No data found for the selected customer and month.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information); // Show message if no data is found
                    }
                }
                else if (cmbFilters.Text == "Service Request Report" && cmbYear.SelectedItem != null && cmbMonth.SelectedItem != null && cmbServices.SelectedItem != null) // Check if the selected report type is service request and all necessary fields are selected
                {
                    int selectedYear;
                    string selectedMonth = cmbMonth.SelectedItem.ToString(); // Get the selected month
                    string selectedService = cmbServices.SelectedItem.ToString(); // Get the selected service

                    if (int.TryParse(cmbYear.SelectedItem.ToString(), out selectedYear)) // Try to parse the selected year
                    {
                        // Generate the service request report
                        DataTable reportData = GenerateServiceRequestReport(selectedYear, selectedMonth, selectedService);

                        // Pass the data to the ServiceRequestReport form
                        GenerateServiceRequestReport report = new GenerateServiceRequestReport(reportData);
                        report.LoginDetail(new LoginDetails(Profilename, Role, phonenumber, ID));
                        report.Show();
                        this.Close(); // Close the current form
                    }
                }
                else
                {
                    MessageBox.Show("Please select all necessary fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Show message if necessary fields are not selected
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show message if an error occurs
            }
        }

        // Method to generate yearly report
        public DataTable GenerateYearlyReport(int year)
        {
            DataTable dt = new DataTable(); // Create a new DataTable
            string connectionString = "Data Source=DESKTOP-4J2129A;Initial Catalog=Users;Integrated Security=True;TrustServerCertificate=True"; // Connection string
            string query = @"
      SELECT 
          DATENAME(month, RequestDate) AS MonthName, 
          SUM(TotalPrice) AS TotalPrice 
      FROM RequestIDs 
      WHERE YEAR(RequestDate) = @Year 
      GROUP BY DATENAME(month, RequestDate), MONTH(RequestDate) 
      ORDER BY MONTH(RequestDate)"; // SQL query to generate yearly report

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Year", year); // Add year as parameter
                conn.Open(); // Open the database connection

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt); // Fill the DataTable with data from the SqlDataAdapter
                }
            }

            return dt; // Return the generated DataTable
        }

        // Method to generate customer report
        private DataTable GenerateCustomerReport(string customerID, string month)
        {
            DataTable dt = new DataTable(); // Create a new DataTable
            string connectionString = "Data Source=DESKTOP-4J2129A;Initial Catalog=Users;Integrated Security=True;TrustServerCertificate=True"; // Connection string
            string query = @"
              SELECT 
                  RID.CustomerID, 
                  RL.ServiceName, 
                  YEAR(RID.RequestDate) AS Year, 
                  DATENAME(month, RID.RequestDate) AS MonthName, 
                  SUM(RL.ServicePrice) AS TotalPrice 
              FROM RequestIDs RID
              JOIN RequestList RL ON RL.RequestID = RID.RequestID
              WHERE (@customerID = 'All Customers' OR RID.CustomerID = @customerID) 
              AND DATENAME(month, RID.RequestDate) = @month 
              GROUP BY RID.CustomerID, RL.ServiceName, YEAR(RID.RequestDate), DATENAME(month, RID.RequestDate), MONTH(RID.RequestDate) 
              ORDER BY RID.CustomerID, MONTH(RID.RequestDate)"; // SQL query to generate customer report

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@customerID", customerID); // Add customer ID as parameter
                cmd.Parameters.AddWithValue("@month", month); // Add month as parameter
                conn.Open(); // Open the database connection
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt); // Fill the DataTable with data from the SqlDataAdapter
                }
            }

            return dt; // Return the generated DataTable
        }

        // Method to generate service request report
        private DataTable GenerateServiceRequestReport(int year, string month, string serviceName)
        {
            DataTable dt = new DataTable(); // Create a new DataTable
            string connectionString = "Data Source=DESKTOP-4J2129A;Initial Catalog=Users;Integrated Security=True;TrustServerCertificate=True"; // Connection string

            using (SqlConnection conn = new SqlConnection(connectionString)) // Create a new SqlConnection
            {
                SqlCommand cmd; // Declare a SqlCommand

                if (serviceName == "All") // Check if service name is "All"
                {
                    cmd = new SqlCommand(@"
               SELECT 
                   RL.ServiceName, 
                   YEAR(RID.RequestDate) AS Year, 
                   DATENAME(month, RID.RequestDate) AS MonthName, 
                   SUM(RL.ServicePrice) AS TotalPrice 
               FROM RequestIDs RID
               JOIN RequestList RL ON RL.RequestID = RID.RequestID
               WHERE YEAR(RID.RequestDate) = @Year 
                   AND DATENAME(month, RID.RequestDate) = @Month
               GROUP BY RL.ServiceName, YEAR(RID.RequestDate), DATENAME(month, RID.RequestDate), MONTH(RID.RequestDate) 
               ORDER BY RL.ServiceName, MONTH(RID.RequestDate)", conn); // SQL query for service request report if service name is "All"
                }
                else
                {
                    cmd = new SqlCommand(@"
               SELECT 
                   RL.ServiceName, 
                   YEAR(RID.RequestDate) AS Year, 
                   DATENAME(month, RID.RequestDate) AS MonthName, 
                   SUM(RL.ServicePrice) AS TotalPrice 
               FROM RequestIDs RID
               JOIN RequestList RL ON RL.RequestID = RID.RequestID
               WHERE YEAR(RID.RequestDate) = @Year 
                   AND DATENAME(month, RID.RequestDate) = @Month
                   AND RL.ServiceName = @ServiceName
               GROUP BY RL.ServiceName, YEAR(RID.RequestDate), DATENAME(month, RID.RequestDate), MONTH(RID.RequestDate) 
               ORDER BY RL.ServiceName, MONTH(RID.RequestDate)", conn); // SQL query for service request report if specific service name is selected
                    cmd.Parameters.AddWithValue("@ServiceName", serviceName); // Add service name as parameter
                }

                cmd.Parameters.AddWithValue("@Year", year); // Add year as parameter
                cmd.Parameters.AddWithValue("@Month", month); // Add month as parameter

                conn.Open(); // Open the database connection

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd)) // Create a new SqlDataAdapter
                {
                    adapter.Fill(dt); // Fill the DataTable with data from the SqlDataAdapter
                }
            }

            // If the data table is empty, throw a custom exception
            if (dt.Rows.Count == 0)
            {
                throw new Exception("No services found for the selected month and year."); // Throw exception if no services are found
            }

            return dt; // Return the generated DataTable
        }

        // Event handler for the form load event
        private void Generate_Report_Load(object sender, EventArgs e)
        {
            // Load data into the RequestIDs table
            this.requestIDsTableAdapter.Fill(this.usersDataSet12.RequestIDs);
            // Load data into the AcceptRequest table
            this.acceptRequestTableAdapter3.Fill(this.usersDataSet4.AcceptRequest);
            // Load data into the AcceptRequest table
            this.acceptRequestTableAdapter2.Fill(this.usersDataSet3.AcceptRequest);
            // Load data into the AcceptRequest table
            this.acceptRequestTableAdapter1.Fill(this.usersDataSet2.AcceptRequest);
            // Load data into the AcceptRequest table
            this.acceptRequestTableAdapter.Fill(this.usersDataSet1.AcceptRequest);
        }

        // Event handler for the selection change in the combo box for filters
        private void cmbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilters.Text == "Yearly Report")
            {
                labelFromDT.Show(); // Show the "From" label
                cmbYear.Show(); // Show the year combo box
                cmbMonth.Hide(); // Hide the month combo box
                labelToDT.Hide(); // Hide the "To" label
            }
            else
            {
                labelCustomer.Hide(); // Hide the customer label
                cmbCustomer.Hide(); // Hide the customer combo box
                labelServiceRQ.Hide(); // Hide the service request label
                cmbServices.Hide(); // Hide the service request combo box
                cmbMonth.SelectedIndex = -1; // Deselect the month combo box
                cmbCustomer.SelectedIndex = -1; // Deselect the customer combo box
                cmbServices.SelectedIndex = -1; // Deselect the service request combo box
            }

            if (cmbFilters.Text == "Customer Report")
            {
                labelToDT.Show(); // Show the "To" label
                cmbMonth.Show(); // Show the month combo box
                labelCustomer.Show(); // Show the customer label
                cmbCustomer.Show(); // Show the customer combo box
                labelFromDT.Show(); // Show the "From" label
                cmbYear.Show(); // Show the year combo box
                cmbServices.SelectedIndex = -1; // Deselect the service request combo box
                cmbCustomer.SelectedIndex = -1; // Deselect the customer combo box
                cmbMonth.SelectedIndex = -1; // Deselect the month combo box
                cmbYear.SelectedIndex = -1; // Deselect the year combo box
                cmbYear.SelectedIndex = -1; // Deselect the year combo box
            }
            else
            {
                labelCustomer.Hide(); // Hide the customer label
                cmbCustomer.Hide(); // Hide the customer combo box
            }
            if (cmbFilters.Text == "Service Request Report")
            {
                labelFromDT.Show(); // Show the "From" label
                cmbYear.Show(); // Show the year combo box
                labelToDT.Show(); // Show the "To" label
                cmbMonth.Show(); // Show the month combo box
                labelServiceRQ.Show(); // Show the service request label
                cmbServices.Show(); // Show the service request combo box
                cmbCustomer.SelectedIndex = -1; // Deselect the customer combo box
                cmbServices.SelectedIndex = -1; // Deselect the service request combo box
                cmbMonth.SelectedIndex = -1; // Deselect the month combo box
                cmbYear.SelectedIndex = -1; // Deselect the year combo box
            }
            else
            {
                labelServiceRQ.Hide(); // Hide the service request label
                cmbServices.Hide(); // Hide the service request combo box
            }
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbServices_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbSizes_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridViewGenReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
