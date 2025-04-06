namespace Admin_Form_OOP_Assignement
{
    partial class Admin_Update_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Update_User));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelNewPass = new System.Windows.Forms.Label();
            this.labelPN = new System.Windows.Forms.Label();
            this.labelUsers = new System.Windows.Forms.Label();
            this.txtboxProfile = new System.Windows.Forms.TextBox();
            this.txtboxNewPass = new System.Windows.Forms.TextBox();
            this.txtboxPN = new System.Windows.Forms.TextBox();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.labelProfilename = new System.Windows.Forms.Label();
            this.cboxShowpass = new System.Windows.Forms.CheckBox();
            this.labelIDdesc = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelRoledesc = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelUserdesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(392, 14);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(314, 37);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "Update User Profile";
            // 
            // labelNewPass
            // 
            this.labelNewPass.AutoSize = true;
            this.labelNewPass.BackColor = System.Drawing.Color.Transparent;
            this.labelNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPass.ForeColor = System.Drawing.Color.Transparent;
            this.labelNewPass.Location = new System.Drawing.Point(340, 231);
            this.labelNewPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewPass.Name = "labelNewPass";
            this.labelNewPass.Size = new System.Drawing.Size(133, 20);
            this.labelNewPass.TabIndex = 14;
            this.labelNewPass.Text = "New Password";
            // 
            // labelPN
            // 
            this.labelPN.AutoSize = true;
            this.labelPN.BackColor = System.Drawing.Color.Transparent;
            this.labelPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPN.ForeColor = System.Drawing.Color.Transparent;
            this.labelPN.Location = new System.Drawing.Point(340, 280);
            this.labelPN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPN.Name = "labelPN";
            this.labelPN.Size = new System.Drawing.Size(132, 20);
            this.labelPN.TabIndex = 15;
            this.labelPN.Text = "Phone Number";
            // 
            // labelUsers
            // 
            this.labelUsers.AutoSize = true;
            this.labelUsers.BackColor = System.Drawing.Color.Transparent;
            this.labelUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsers.ForeColor = System.Drawing.Color.Transparent;
            this.labelUsers.Location = new System.Drawing.Point(340, 325);
            this.labelUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(65, 20);
            this.labelUsers.TabIndex = 16;
            this.labelUsers.Text = "Users:";
            // 
            // txtboxProfile
            // 
            this.txtboxProfile.Location = new System.Drawing.Point(489, 177);
            this.txtboxProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxProfile.Name = "txtboxProfile";
            this.txtboxProfile.Size = new System.Drawing.Size(250, 26);
            this.txtboxProfile.TabIndex = 17;
            this.txtboxProfile.TextChanged += new System.EventHandler(this.txtboxProfile_TextChanged);
            // 
            // txtboxNewPass
            // 
            this.txtboxNewPass.Location = new System.Drawing.Point(489, 228);
            this.txtboxNewPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxNewPass.Name = "txtboxNewPass";
            this.txtboxNewPass.Size = new System.Drawing.Size(250, 26);
            this.txtboxNewPass.TabIndex = 20;
            // 
            // txtboxPN
            // 
            this.txtboxPN.Location = new System.Drawing.Point(490, 275);
            this.txtboxPN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxPN.Name = "txtboxPN";
            this.txtboxPN.Size = new System.Drawing.Size(248, 26);
            this.txtboxPN.TabIndex = 21;
            // 
            // cmbUsers
            // 
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(490, 325);
            this.cmbUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(248, 28);
            this.cmbUsers.TabIndex = 22;
            this.cmbUsers.SelectedIndexChanged += new System.EventHandler(this.cmbUsers_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(488, 382);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 42);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(620, 382);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 42);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // labelProfilename
            // 
            this.labelProfilename.AutoSize = true;
            this.labelProfilename.BackColor = System.Drawing.Color.Transparent;
            this.labelProfilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfilename.ForeColor = System.Drawing.Color.Transparent;
            this.labelProfilename.Location = new System.Drawing.Point(340, 177);
            this.labelProfilename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProfilename.Name = "labelProfilename";
            this.labelProfilename.Size = new System.Drawing.Size(118, 20);
            this.labelProfilename.TabIndex = 18;
            this.labelProfilename.Text = "Profile Name";
            // 
            // cboxShowpass
            // 
            this.cboxShowpass.AutoSize = true;
            this.cboxShowpass.BackColor = System.Drawing.Color.Transparent;
            this.cboxShowpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxShowpass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cboxShowpass.Location = new System.Drawing.Point(746, 229);
            this.cboxShowpass.Name = "cboxShowpass";
            this.cboxShowpass.Size = new System.Drawing.Size(161, 24);
            this.cboxShowpass.TabIndex = 27;
            this.cboxShowpass.Text = "Show Password";
            this.cboxShowpass.UseVisualStyleBackColor = false;
            this.cboxShowpass.CheckedChanged += new System.EventHandler(this.cboxShowpass_CheckedChanged);
            // 
            // labelIDdesc
            // 
            this.labelIDdesc.AutoSize = true;
            this.labelIDdesc.BackColor = System.Drawing.Color.Black;
            this.labelIDdesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelIDdesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDdesc.ForeColor = System.Drawing.Color.Transparent;
            this.labelIDdesc.Location = new System.Drawing.Point(652, 137);
            this.labelIDdesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIDdesc.Name = "labelIDdesc";
            this.labelIDdesc.Size = new System.Drawing.Size(76, 22);
            this.labelIDdesc.TabIndex = 28;
            this.labelIDdesc.Text = "User ID";
            this.labelIDdesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelIDdesc.Click += new System.EventHandler(this.labelIDdesc_Click);
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.BackColor = System.Drawing.Color.Transparent;
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.ForeColor = System.Drawing.Color.Transparent;
            this.labelRole.Location = new System.Drawing.Point(340, 137);
            this.labelRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(47, 20);
            this.labelRole.TabIndex = 29;
            this.labelRole.Text = "Role";
            // 
            // labelRoledesc
            // 
            this.labelRoledesc.AutoSize = true;
            this.labelRoledesc.BackColor = System.Drawing.Color.Transparent;
            this.labelRoledesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoledesc.ForeColor = System.Drawing.Color.Transparent;
            this.labelRoledesc.Location = new System.Drawing.Point(486, 137);
            this.labelRoledesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRoledesc.Name = "labelRoledesc";
            this.labelRoledesc.Size = new System.Drawing.Size(127, 20);
            this.labelRoledesc.TabIndex = 30;
            this.labelRoledesc.Text = "labelRoledesc";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.Transparent;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.Transparent;
            this.labelUser.Location = new System.Drawing.Point(340, 98);
            this.labelUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(94, 20);
            this.labelUser.TabIndex = 10;
            this.labelUser.Text = "Username";
            // 
            // labelUserdesc
            // 
            this.labelUserdesc.AutoSize = true;
            this.labelUserdesc.BackColor = System.Drawing.Color.Transparent;
            this.labelUserdesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserdesc.ForeColor = System.Drawing.Color.Transparent;
            this.labelUserdesc.Location = new System.Drawing.Point(484, 98);
            this.labelUserdesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserdesc.Name = "labelUserdesc";
            this.labelUserdesc.Size = new System.Drawing.Size(129, 20);
            this.labelUserdesc.TabIndex = 11;
            this.labelUserdesc.Text = "labelUserdesc";
            // 
            // Admin_Update_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1005, 591);
            this.Controls.Add(this.labelRoledesc);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelIDdesc);
            this.Controls.Add(this.cboxShowpass);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbUsers);
            this.Controls.Add(this.txtboxPN);
            this.Controls.Add(this.txtboxNewPass);
            this.Controls.Add(this.labelProfilename);
            this.Controls.Add(this.txtboxProfile);
            this.Controls.Add(this.labelUsers);
            this.Controls.Add(this.labelPN);
            this.Controls.Add(this.labelNewPass);
            this.Controls.Add(this.labelUserdesc);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Admin_Update_User";
            this.Text = "Update User - Admin Page";
            this.Load += new System.EventHandler(this.Admin_Update_User_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelNewPass;
        private System.Windows.Forms.Label labelPN;
        private System.Windows.Forms.Label labelUsers;
        private System.Windows.Forms.TextBox txtboxProfile;
        private System.Windows.Forms.TextBox txtboxNewPass;
        private System.Windows.Forms.TextBox txtboxPN;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labelProfilename;
        private System.Windows.Forms.CheckBox cboxShowpass;
        private System.Windows.Forms.Label labelIDdesc;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelRoledesc;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelUserdesc;
    }
}