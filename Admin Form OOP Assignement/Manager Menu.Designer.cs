namespace Admin_Form_OOP_Assingment
{
    partial class Form1
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.labelManagerPage = new System.Windows.Forms.Label();
            this.oOPDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oOPDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLogout = new System.Windows.Forms.Button();
            this.oOPDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.oOPDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.requestIDsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAssignWorker = new System.Windows.Forms.Button();
            this.labelManagerName = new System.Windows.Forms.Label();
            this.labelManagerID = new System.Windows.Forms.Label();
            this.labelManagerPhone = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelManagerRole = new System.Windows.Forms.Label();
            this.UpdateProfileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.oOPDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oOPDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oOPDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oOPDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestIDsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(24, 175);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(130, 53);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // labelManagerPage
            // 
            this.labelManagerPage.AutoSize = true;
            this.labelManagerPage.BackColor = System.Drawing.Color.Transparent;
            this.labelManagerPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.labelManagerPage.ForeColor = System.Drawing.Color.White;
            this.labelManagerPage.Location = new System.Drawing.Point(353, 18);
            this.labelManagerPage.Name = "labelManagerPage";
            this.labelManagerPage.Size = new System.Drawing.Size(240, 39);
            this.labelManagerPage.TabIndex = 6;
            this.labelManagerPage.Text = "Manager Page";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(24, 356);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(130, 70);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(167, 207);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(625, 232);
            this.dataGridView1.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "New",
            "Assigned",
            "Work In Progress",
            "Completed",
            "           "});
            this.comboBox1.Location = new System.Drawing.Point(12, 143);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnAssignWorker
            // 
            this.btnAssignWorker.Location = new System.Drawing.Point(24, 235);
            this.btnAssignWorker.Name = "btnAssignWorker";
            this.btnAssignWorker.Size = new System.Drawing.Size(130, 55);
            this.btnAssignWorker.TabIndex = 11;
            this.btnAssignWorker.Text = "AssignWorker";
            this.btnAssignWorker.UseVisualStyleBackColor = true;
            this.btnAssignWorker.Click += new System.EventHandler(this.btnAssignWorker_Click);
            // 
            // labelManagerName
            // 
            this.labelManagerName.AutoSize = true;
            this.labelManagerName.BackColor = System.Drawing.Color.Transparent;
            this.labelManagerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManagerName.ForeColor = System.Drawing.Color.White;
            this.labelManagerName.Location = new System.Drawing.Point(541, 75);
            this.labelManagerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelManagerName.Name = "labelManagerName";
            this.labelManagerName.Size = new System.Drawing.Size(148, 20);
            this.labelManagerName.TabIndex = 12;
            this.labelManagerName.Text = "<manager name>";
            // 
            // labelManagerID
            // 
            this.labelManagerID.AutoSize = true;
            this.labelManagerID.BackColor = System.Drawing.Color.Transparent;
            this.labelManagerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManagerID.ForeColor = System.Drawing.Color.White;
            this.labelManagerID.Location = new System.Drawing.Point(541, 105);
            this.labelManagerID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelManagerID.Name = "labelManagerID";
            this.labelManagerID.Size = new System.Drawing.Size(118, 20);
            this.labelManagerID.TabIndex = 13;
            this.labelManagerID.Text = "<manager id>";
            // 
            // labelManagerPhone
            // 
            this.labelManagerPhone.AutoSize = true;
            this.labelManagerPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelManagerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManagerPhone.ForeColor = System.Drawing.Color.White;
            this.labelManagerPhone.Location = new System.Drawing.Point(541, 171);
            this.labelManagerPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelManagerPhone.Name = "labelManagerPhone";
            this.labelManagerPhone.Size = new System.Drawing.Size(219, 20);
            this.labelManagerPhone.TabIndex = 14;
            this.labelManagerPhone.Text = "<manager phone number>";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(356, 75);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(60, 20);
            this.labelName.TabIndex = 15;
            this.labelName.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(356, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(356, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Phone Number:";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.BackColor = System.Drawing.Color.Transparent;
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.ForeColor = System.Drawing.Color.White;
            this.labelRole.Location = new System.Drawing.Point(356, 141);
            this.labelRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(51, 20);
            this.labelRole.TabIndex = 18;
            this.labelRole.Text = "Role:";
            // 
            // labelManagerRole
            // 
            this.labelManagerRole.AutoSize = true;
            this.labelManagerRole.BackColor = System.Drawing.Color.Transparent;
            this.labelManagerRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManagerRole.ForeColor = System.Drawing.Color.White;
            this.labelManagerRole.Location = new System.Drawing.Point(541, 141);
            this.labelManagerRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelManagerRole.Name = "labelManagerRole";
            this.labelManagerRole.Size = new System.Drawing.Size(134, 20);
            this.labelManagerRole.TabIndex = 19;
            this.labelManagerRole.Text = "<manager role>";
            // 
            // UpdateProfileButton
            // 
            this.UpdateProfileButton.Location = new System.Drawing.Point(24, 296);
            this.UpdateProfileButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.UpdateProfileButton.Name = "UpdateProfileButton";
            this.UpdateProfileButton.Size = new System.Drawing.Size(130, 49);
            this.UpdateProfileButton.TabIndex = 20;
            this.UpdateProfileButton.Text = "Update Profile";
            this.UpdateProfileButton.UseVisualStyleBackColor = true;
            this.UpdateProfileButton.Click += new System.EventHandler(this.UpdateProfileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Admin_Form_OOP_Assignement.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateProfileButton);
            this.Controls.Add(this.labelManagerRole);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelManagerPhone);
            this.Controls.Add(this.labelManagerID);
            this.Controls.Add(this.labelManagerName);
            this.Controls.Add(this.btnAssignWorker);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.labelManagerPage);
            this.Controls.Add(this.btnRefresh);
            this.Name = "Form1";
            this.Text = "Manager Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oOPDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oOPDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oOPDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oOPDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestIDsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label labelManagerPage;
        private System.Windows.Forms.BindingSource oOPDataSetBindingSource;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.BindingSource oOPDataSet1BindingSource;
        private System.Windows.Forms.BindingSource oOPDataSetBindingSource1;
        private System.Windows.Forms.BindingSource oOPDataSet2BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource requestIDsBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAssignWorker;
        public System.Windows.Forms.Label labelManagerName;
        public System.Windows.Forms.Label labelManagerID;
        public System.Windows.Forms.Label labelManagerPhone;
        public System.Windows.Forms.Label labelName;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label labelRole;
        public System.Windows.Forms.Label labelManagerRole;
        private System.Windows.Forms.Button UpdateProfileButton;
    }
}

