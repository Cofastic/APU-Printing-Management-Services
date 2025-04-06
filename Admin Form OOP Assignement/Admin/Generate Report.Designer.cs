namespace Admin_Form_OOP_Assignement
{
    partial class Generate_Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generate_Report));
            this.labelReport = new System.Windows.Forms.Label();
            this.acceptRequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSet1 = new Admin_Form_OOP_Assignement.UsersDataSet1();
            this.cmbFilters = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.labelFromDT = new System.Windows.Forms.Label();
            this.labelToDT = new System.Windows.Forms.Label();
            this.labelFilters = new System.Windows.Forms.Label();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.labelServiceRQ = new System.Windows.Forms.Label();
            this.cmbServices = new System.Windows.Forms.ComboBox();
            this.acceptRequestTableAdapter = new Admin_Form_OOP_Assignement.UsersDataSet1TableAdapters.AcceptRequestTableAdapter();
            this.usersDataSet2 = new Admin_Form_OOP_Assignement.UsersDataSet2();
            this.acceptRequestBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.acceptRequestTableAdapter1 = new Admin_Form_OOP_Assignement.UsersDataSet2TableAdapters.AcceptRequestTableAdapter();
            this.usersDataSet3 = new Admin_Form_OOP_Assignement.UsersDataSet3();
            this.acceptRequestBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.acceptRequestTableAdapter2 = new Admin_Form_OOP_Assignement.UsersDataSet3TableAdapters.AcceptRequestTableAdapter();
            this.dataGridViewGenReport = new System.Windows.Forms.DataGridView();
            this.acceptRequestBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSet4 = new Admin_Form_OOP_Assignement.UsersDataSet4();
            this.acceptRequestTableAdapter3 = new Admin_Form_OOP_Assignement.UsersDataSet4TableAdapters.AcceptRequestTableAdapter();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.usersDataSet12 = new Admin_Form_OOP_Assignement.UsersDataSet12();
            this.requestIDsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestIDsTableAdapter = new Admin_Form_OOP_Assignement.UsersDataSet12TableAdapters.RequestIDsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.acceptRequestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptRequestBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptRequestBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptRequestBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestIDsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelReport
            // 
            this.labelReport.AutoSize = true;
            this.labelReport.BackColor = System.Drawing.Color.Transparent;
            this.labelReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.labelReport.ForeColor = System.Drawing.Color.White;
            this.labelReport.Location = new System.Drawing.Point(469, 6);
            this.labelReport.Name = "labelReport";
            this.labelReport.Size = new System.Drawing.Size(188, 26);
            this.labelReport.TabIndex = 8;
            this.labelReport.Text = "Generate Report";
            // 
            // acceptRequestBindingSource
            // 
            this.acceptRequestBindingSource.DataMember = "AcceptRequest";
            this.acceptRequestBindingSource.DataSource = this.usersDataSet1;
            // 
            // usersDataSet1
            // 
            this.usersDataSet1.DataSetName = "UsersDataSet1";
            this.usersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbFilters
            // 
            this.cmbFilters.FormattingEnabled = true;
            this.cmbFilters.Items.AddRange(new object[] {
            "Yearly Report",
            "Service Request Report",
            "Customer Report"});
            this.cmbFilters.Location = new System.Drawing.Point(24, 90);
            this.cmbFilters.Name = "cmbFilters";
            this.cmbFilters.Size = new System.Drawing.Size(135, 21);
            this.cmbFilters.TabIndex = 10;
            this.cmbFilters.SelectedIndexChanged += new System.EventHandler(this.cmbFilters_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(24, 348);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 28);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(22, 213);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(135, 21);
            this.cmbCustomer.TabIndex = 12;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(24, 315);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(133, 27);
            this.btnGenerate.TabIndex = 14;
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // labelFromDT
            // 
            this.labelFromDT.AutoSize = true;
            this.labelFromDT.BackColor = System.Drawing.Color.Transparent;
            this.labelFromDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFromDT.ForeColor = System.Drawing.Color.Transparent;
            this.labelFromDT.Location = new System.Drawing.Point(70, 117);
            this.labelFromDT.Name = "labelFromDT";
            this.labelFromDT.Size = new System.Drawing.Size(33, 13);
            this.labelFromDT.TabIndex = 17;
            this.labelFromDT.Text = "Year";
            // 
            // labelToDT
            // 
            this.labelToDT.AutoSize = true;
            this.labelToDT.BackColor = System.Drawing.Color.Transparent;
            this.labelToDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToDT.ForeColor = System.Drawing.Color.Transparent;
            this.labelToDT.Location = new System.Drawing.Point(67, 157);
            this.labelToDT.Name = "labelToDT";
            this.labelToDT.Size = new System.Drawing.Size(42, 13);
            this.labelToDT.TabIndex = 18;
            this.labelToDT.Text = "Month";
            // 
            // labelFilters
            // 
            this.labelFilters.AutoSize = true;
            this.labelFilters.BackColor = System.Drawing.Color.Transparent;
            this.labelFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilters.ForeColor = System.Drawing.Color.Transparent;
            this.labelFilters.Location = new System.Drawing.Point(67, 74);
            this.labelFilters.Name = "labelFilters";
            this.labelFilters.Size = new System.Drawing.Size(45, 13);
            this.labelFilters.TabIndex = 19;
            this.labelFilters.Text = "Filters:";
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.BackColor = System.Drawing.Color.Transparent;
            this.labelCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomer.ForeColor = System.Drawing.Color.Transparent;
            this.labelCustomer.Location = new System.Drawing.Point(58, 197);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(69, 13);
            this.labelCustomer.TabIndex = 20;
            this.labelCustomer.Text = "Customers:";
            // 
            // labelServiceRQ
            // 
            this.labelServiceRQ.AutoSize = true;
            this.labelServiceRQ.BackColor = System.Drawing.Color.Transparent;
            this.labelServiceRQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServiceRQ.ForeColor = System.Drawing.Color.Transparent;
            this.labelServiceRQ.Location = new System.Drawing.Point(67, 237);
            this.labelServiceRQ.Name = "labelServiceRQ";
            this.labelServiceRQ.Size = new System.Drawing.Size(54, 13);
            this.labelServiceRQ.TabIndex = 21;
            this.labelServiceRQ.Text = "Service:";
            // 
            // cmbServices
            // 
            this.cmbServices.FormattingEnabled = true;
            this.cmbServices.Items.AddRange(new object[] {
            "All",
            "Printing A4 - Black and White",
            "Printing A4 - Color",
            "Binding - Comb Binding",
            "Binding - Thick Cover",
            "Printing - Poster A0/A1",
            "Printing - Poster A2/A3"});
            this.cmbServices.Location = new System.Drawing.Point(22, 253);
            this.cmbServices.Name = "cmbServices";
            this.cmbServices.Size = new System.Drawing.Size(135, 21);
            this.cmbServices.TabIndex = 22;
            this.cmbServices.SelectedIndexChanged += new System.EventHandler(this.cmbServices_SelectedIndexChanged);
            // 
            // acceptRequestTableAdapter
            // 
            this.acceptRequestTableAdapter.ClearBeforeFill = true;
            // 
            // usersDataSet2
            // 
            this.usersDataSet2.DataSetName = "UsersDataSet2";
            this.usersDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // acceptRequestBindingSource1
            // 
            this.acceptRequestBindingSource1.DataMember = "AcceptRequest";
            this.acceptRequestBindingSource1.DataSource = this.usersDataSet2;
            // 
            // acceptRequestTableAdapter1
            // 
            this.acceptRequestTableAdapter1.ClearBeforeFill = true;
            // 
            // usersDataSet3
            // 
            this.usersDataSet3.DataSetName = "UsersDataSet3";
            this.usersDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // acceptRequestBindingSource2
            // 
            this.acceptRequestBindingSource2.DataMember = "AcceptRequest";
            this.acceptRequestBindingSource2.DataSource = this.usersDataSet3;
            // 
            // acceptRequestTableAdapter2
            // 
            this.acceptRequestTableAdapter2.ClearBeforeFill = true;
            // 
            // dataGridViewGenReport
            // 
            this.dataGridViewGenReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGenReport.Location = new System.Drawing.Point(167, 52);
            this.dataGridViewGenReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewGenReport.Name = "dataGridViewGenReport";
            this.dataGridViewGenReport.RowHeadersWidth = 62;
            this.dataGridViewGenReport.RowTemplate.Height = 28;
            this.dataGridViewGenReport.Size = new System.Drawing.Size(743, 324);
            this.dataGridViewGenReport.TabIndex = 25;
            this.dataGridViewGenReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGenReport_CellContentClick);
            // 
            // acceptRequestBindingSource3
            // 
            this.acceptRequestBindingSource3.DataMember = "AcceptRequest";
            this.acceptRequestBindingSource3.DataSource = this.usersDataSet4;
            // 
            // usersDataSet4
            // 
            this.usersDataSet4.DataSetName = "UsersDataSet4";
            this.usersDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // acceptRequestTableAdapter3
            // 
            this.acceptRequestTableAdapter3.ClearBeforeFill = true;
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(22, 133);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(135, 21);
            this.cmbYear.TabIndex = 26;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(22, 173);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(135, 21);
            this.cmbMonth.TabIndex = 27;
            // 
            // usersDataSet12
            // 
            this.usersDataSet12.DataSetName = "UsersDataSet12";
            this.usersDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // requestIDsBindingSource
            // 
            this.requestIDsBindingSource.DataMember = "RequestIDs";
            this.requestIDsBindingSource.DataSource = this.usersDataSet12;
            // 
            // requestIDsTableAdapter
            // 
            this.requestIDsTableAdapter.ClearBeforeFill = true;
            // 
            // Generate_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(917, 424);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.dataGridViewGenReport);
            this.Controls.Add(this.cmbServices);
            this.Controls.Add(this.labelServiceRQ);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.labelFilters);
            this.Controls.Add(this.labelToDT);
            this.Controls.Add(this.labelFromDT);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cmbFilters);
            this.Controls.Add(this.labelReport);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Generate_Report";
            this.Text = "Generate Report Page";
            this.Load += new System.EventHandler(this.Generate_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.acceptRequestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptRequestBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptRequestBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptRequestBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestIDsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReport;
        private System.Windows.Forms.ComboBox cmbFilters;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label labelFromDT;
        private System.Windows.Forms.Label labelToDT;
        private System.Windows.Forms.Label labelFilters;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.Label labelServiceRQ;
        private System.Windows.Forms.ComboBox cmbServices;
        private UsersDataSet1 usersDataSet1;
        private System.Windows.Forms.BindingSource acceptRequestBindingSource;
        private UsersDataSet1TableAdapters.AcceptRequestTableAdapter acceptRequestTableAdapter;
        private UsersDataSet2 usersDataSet2;
        private System.Windows.Forms.BindingSource acceptRequestBindingSource1;
        private UsersDataSet2TableAdapters.AcceptRequestTableAdapter acceptRequestTableAdapter1;
        private UsersDataSet3 usersDataSet3;
        private System.Windows.Forms.BindingSource acceptRequestBindingSource2;
        private UsersDataSet3TableAdapters.AcceptRequestTableAdapter acceptRequestTableAdapter2;
        private System.Windows.Forms.DataGridView dataGridViewGenReport;
        private UsersDataSet4 usersDataSet4;
        private System.Windows.Forms.BindingSource acceptRequestBindingSource3;
        private UsersDataSet4TableAdapters.AcceptRequestTableAdapter acceptRequestTableAdapter3;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private UsersDataSet12 usersDataSet12;
        private System.Windows.Forms.BindingSource requestIDsBindingSource;
        private UsersDataSet12TableAdapters.RequestIDsTableAdapter requestIDsTableAdapter;
    }
}