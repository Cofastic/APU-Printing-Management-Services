namespace Admin_Form_OOP_Assignement
{
    partial class Generated_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generated_Report));
            this.labelGenerate = new System.Windows.Forms.Label();
            this.acceptRequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSet5 = new Admin_Form_OOP_Assignement.UsersDataSet5();
            this.btnBack = new System.Windows.Forms.Button();
            this.acceptRequestTableAdapter = new Admin_Form_OOP_Assignement.UsersDataSet5TableAdapters.AcceptRequestTableAdapter();
            this.usersDataSet7 = new Admin_Form_OOP_Assignement.UsersDataSet7();
            this.acceptRequestBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.acceptRequestTableAdapter1 = new Admin_Form_OOP_Assignement.UsersDataSet7TableAdapters.AcceptRequestTableAdapter();
            this.dataGridViewGenedReport = new System.Windows.Forms.DataGridView();
            this.monthNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acceptRequestBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSet8 = new Admin_Form_OOP_Assignement.UsersDataSet8();
            this.acceptRequestTableAdapter2 = new Admin_Form_OOP_Assignement.UsersDataSet8TableAdapters.AcceptRequestTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.acceptRequestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptRequestBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenedReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptRequestBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGenerate
            // 
            this.labelGenerate.AutoSize = true;
            this.labelGenerate.BackColor = System.Drawing.Color.Transparent;
            this.labelGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.labelGenerate.ForeColor = System.Drawing.Color.White;
            this.labelGenerate.Location = new System.Drawing.Point(400, 14);
            this.labelGenerate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGenerate.Name = "labelGenerate";
            this.labelGenerate.Size = new System.Drawing.Size(393, 37);
            this.labelGenerate.TabIndex = 8;
            this.labelGenerate.Text = "Generated Yearly Report";
            // 
            // acceptRequestBindingSource
            // 
            this.acceptRequestBindingSource.DataMember = "AcceptRequest";
            this.acceptRequestBindingSource.DataSource = this.usersDataSet5;
            // 
            // usersDataSet5
            // 
            this.usersDataSet5.DataSetName = "UsersDataSet5";
            this.usersDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(18, 254);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(172, 75);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // acceptRequestTableAdapter
            // 
            this.acceptRequestTableAdapter.ClearBeforeFill = true;
            // 
            // usersDataSet7
            // 
            this.usersDataSet7.DataSetName = "UsersDataSet7";
            this.usersDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // acceptRequestBindingSource1
            // 
            this.acceptRequestBindingSource1.DataMember = "AcceptRequest";
            this.acceptRequestBindingSource1.DataSource = this.usersDataSet7;
            // 
            // acceptRequestTableAdapter1
            // 
            this.acceptRequestTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewGenedReport
            // 
            this.dataGridViewGenedReport.AutoGenerateColumns = false;
            this.dataGridViewGenedReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGenedReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.monthNameDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.dataGridViewGenedReport.DataSource = this.acceptRequestBindingSource2;
            this.dataGridViewGenedReport.Location = new System.Drawing.Point(207, 71);
            this.dataGridViewGenedReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewGenedReport.Name = "dataGridViewGenedReport";
            this.dataGridViewGenedReport.RowHeadersWidth = 62;
            this.dataGridViewGenedReport.Size = new System.Drawing.Size(824, 500);
            this.dataGridViewGenedReport.TabIndex = 12;
            // 
            // monthNameDataGridViewTextBoxColumn
            // 
            this.monthNameDataGridViewTextBoxColumn.DataPropertyName = "MonthName";
            this.monthNameDataGridViewTextBoxColumn.HeaderText = "MonthName";
            this.monthNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.monthNameDataGridViewTextBoxColumn.Name = "monthNameDataGridViewTextBoxColumn";
            this.monthNameDataGridViewTextBoxColumn.Width = 260;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.Width = 250;
            // 
            // acceptRequestBindingSource2
            // 
            this.acceptRequestBindingSource2.DataMember = "AcceptRequest";
            this.acceptRequestBindingSource2.DataSource = this.usersDataSet8;
            // 
            // usersDataSet8
            // 
            this.usersDataSet8.DataSetName = "UsersDataSet8";
            this.usersDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // acceptRequestTableAdapter2
            // 
            this.acceptRequestTableAdapter2.ClearBeforeFill = true;
            // 
            // Generated_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1048, 589);
            this.Controls.Add(this.dataGridViewGenedReport);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.labelGenerate);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Generated_Report";
            this.Text = "Generrate Yearly Report";
            this.Load += new System.EventHandler(this.Generated_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.acceptRequestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptRequestBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenedReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptRequestBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGenerate;
        private System.Windows.Forms.DataGridView DataGridViewGenedReport;
        private System.Windows.Forms.Button btnBack;
        private UsersDataSet5 usersDataSet5;
        private System.Windows.Forms.BindingSource acceptRequestBindingSource;
        private UsersDataSet5TableAdapters.AcceptRequestTableAdapter acceptRequestTableAdapter;
        private UsersDataSet7 usersDataSet7;
        private System.Windows.Forms.BindingSource acceptRequestBindingSource1;
        private UsersDataSet7TableAdapters.AcceptRequestTableAdapter acceptRequestTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridViewGenedReport;
        private UsersDataSet8 usersDataSet8;
        private System.Windows.Forms.BindingSource acceptRequestBindingSource2;
        private UsersDataSet8TableAdapters.AcceptRequestTableAdapter acceptRequestTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
    }
}