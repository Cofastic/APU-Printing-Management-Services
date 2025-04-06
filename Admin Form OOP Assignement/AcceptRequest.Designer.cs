namespace Admin_Form_OOP_Assignment

{
    partial class AcceptRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcceptRequest));
            this.labelWorkerID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.acceptRequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnDecline = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbReqID = new System.Windows.Forms.ComboBox();
            this.usersDataSet11 = new Admin_Form_OOP_Assignement.UsersDataSet11();
            this.acceptRequestBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.acceptRequestTableAdapter = new Admin_Form_OOP_Assignement.UsersDataSet11TableAdapters.AcceptRequestTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptRequestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptRequestBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWorkerID
            // 
            this.labelWorkerID.AutoSize = true;
            this.labelWorkerID.BackColor = System.Drawing.Color.Transparent;
            this.labelWorkerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWorkerID.ForeColor = System.Drawing.Color.White;
            this.labelWorkerID.Location = new System.Drawing.Point(228, 117);
            this.labelWorkerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWorkerID.Name = "labelWorkerID";
            this.labelWorkerID.Size = new System.Drawing.Size(200, 33);
            this.labelWorkerID.TabIndex = 1;
            this.labelWorkerID.Text = "labelWorkerID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(234, 198);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1074, 546);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(414, 789);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(246, 86);
            this.btnAccept.TabIndex = 3;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnDecline
            // 
            this.btnDecline.Location = new System.Drawing.Point(894, 789);
            this.btnDecline.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(246, 86);
            this.btnDecline.TabIndex = 4;
            this.btnDecline.Text = "Decline";
            this.btnDecline.UseVisualStyleBackColor = true;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1401, 846);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(160, 69);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbReqID
            // 
            this.cmbReqID.FormattingEnabled = true;
            this.cmbReqID.Location = new System.Drawing.Point(1380, 237);
            this.cmbReqID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbReqID.Name = "cmbReqID";
            this.cmbReqID.Size = new System.Drawing.Size(180, 28);
            this.cmbReqID.TabIndex = 6;
            // 
            // usersDataSet11
            // 
            this.usersDataSet11.DataSetName = "UsersDataSet11";
            this.usersDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // acceptRequestBindingSource1
            // 
            this.acceptRequestBindingSource1.DataMember = "AcceptRequest";
            this.acceptRequestBindingSource1.DataSource = this.usersDataSet11;
            // 
            // acceptRequestTableAdapter
            // 
            this.acceptRequestTableAdapter.ClearBeforeFill = true;
            // 
            // AcceptRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1618, 951);
            this.Controls.Add(this.cmbReqID);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelWorkerID);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AcceptRequest";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptRequestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptRequestBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelWorkerID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.BindingSource acceptRequestBindingSource;
        private System.Windows.Forms.ComboBox cmbReqID;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestStatusDataGridViewTextBoxColumn;
        private Admin_Form_OOP_Assignement.UsersDataSet11 usersDataSet11;
        private System.Windows.Forms.BindingSource acceptRequestBindingSource1;
        private Admin_Form_OOP_Assignement.UsersDataSet11TableAdapters.AcceptRequestTableAdapter acceptRequestTableAdapter;
    }
}

