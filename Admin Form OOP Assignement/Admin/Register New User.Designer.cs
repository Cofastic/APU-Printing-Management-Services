namespace Admin_Form_OOP_Assignement
{
    partial class Register_New_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register_New_User));
            this.labelRegister = new System.Windows.Forms.Label();
            this.labelProfile = new System.Windows.Forms.Label();
            this.labelPN = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.txtboxProfile = new System.Windows.Forms.TextBox();
            this.txtboxUser = new System.Windows.Forms.TextBox();
            this.txtboxPass = new System.Windows.Forms.TextBox();
            this.txtboxPN = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelIDdesc = new System.Windows.Forms.Label();
            this.cboxShowpass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.BackColor = System.Drawing.Color.Transparent;
            this.labelRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.labelRegister.ForeColor = System.Drawing.Color.White;
            this.labelRegister.Location = new System.Drawing.Point(266, 9);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(212, 26);
            this.labelRegister.TabIndex = 8;
            this.labelRegister.Text = "Register New User";
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.BackColor = System.Drawing.Color.Transparent;
            this.labelProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfile.ForeColor = System.Drawing.Color.Transparent;
            this.labelProfile.Location = new System.Drawing.Point(212, 90);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(79, 13);
            this.labelProfile.TabIndex = 10;
            this.labelProfile.Text = "Profile Name";
            // 
            // labelPN
            // 
            this.labelPN.AutoSize = true;
            this.labelPN.BackColor = System.Drawing.Color.Transparent;
            this.labelPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPN.ForeColor = System.Drawing.Color.Transparent;
            this.labelPN.Location = new System.Drawing.Point(212, 193);
            this.labelPN.Name = "labelPN";
            this.labelPN.Size = new System.Drawing.Size(90, 13);
            this.labelPN.TabIndex = 11;
            this.labelPN.Text = "Phone Number";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.Transparent;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.Transparent;
            this.labelUser.Location = new System.Drawing.Point(212, 125);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(63, 13);
            this.labelUser.TabIndex = 11;
            this.labelUser.Text = "Username";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.BackColor = System.Drawing.Color.Transparent;
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.ForeColor = System.Drawing.Color.Transparent;
            this.labelPass.Location = new System.Drawing.Point(212, 159);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(61, 13);
            this.labelPass.TabIndex = 12;
            this.labelPass.Text = "Password";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(308, 262);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "Customer",
            "Worker",
            "Manager"});
            this.cmbRole.Location = new System.Drawing.Point(308, 222);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(156, 21);
            this.cmbRole.TabIndex = 15;
            this.cmbRole.SelectedIndexChanged += new System.EventHandler(this.cmbJob_SelectedIndexChanged);
            // 
            // txtboxProfile
            // 
            this.txtboxProfile.Location = new System.Drawing.Point(308, 87);
            this.txtboxProfile.Name = "txtboxProfile";
            this.txtboxProfile.Size = new System.Drawing.Size(156, 20);
            this.txtboxProfile.TabIndex = 16;
            // 
            // txtboxUser
            // 
            this.txtboxUser.Location = new System.Drawing.Point(308, 122);
            this.txtboxUser.Name = "txtboxUser";
            this.txtboxUser.Size = new System.Drawing.Size(156, 20);
            this.txtboxUser.TabIndex = 17;
            // 
            // txtboxPass
            // 
            this.txtboxPass.Location = new System.Drawing.Point(308, 156);
            this.txtboxPass.Name = "txtboxPass";
            this.txtboxPass.Size = new System.Drawing.Size(156, 20);
            this.txtboxPass.TabIndex = 18;
            // 
            // txtboxPN
            // 
            this.txtboxPN.Location = new System.Drawing.Point(308, 190);
            this.txtboxPN.Name = "txtboxPN";
            this.txtboxPN.Size = new System.Drawing.Size(156, 20);
            this.txtboxPN.TabIndex = 19;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(389, 262);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.BackColor = System.Drawing.Color.Transparent;
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.ForeColor = System.Drawing.Color.Transparent;
            this.labelRole.Location = new System.Drawing.Point(212, 227);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(33, 13);
            this.labelRole.TabIndex = 21;
            this.labelRole.Text = "Role";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.Transparent;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.Transparent;
            this.labelID.Location = new System.Drawing.Point(212, 61);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(50, 13);
            this.labelID.TabIndex = 22;
            this.labelID.Text = "User ID";
            // 
            // labelIDdesc
            // 
            this.labelIDdesc.AutoSize = true;
            this.labelIDdesc.BackColor = System.Drawing.Color.Black;
            this.labelIDdesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelIDdesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDdesc.ForeColor = System.Drawing.Color.Transparent;
            this.labelIDdesc.Location = new System.Drawing.Point(308, 59);
            this.labelIDdesc.Name = "labelIDdesc";
            this.labelIDdesc.Size = new System.Drawing.Size(52, 15);
            this.labelIDdesc.TabIndex = 23;
            this.labelIDdesc.Text = "User ID";
            this.labelIDdesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelIDdesc.Click += new System.EventHandler(this.labelIDdesc_Click);
            // 
            // cboxShowpass
            // 
            this.cboxShowpass.AutoSize = true;
            this.cboxShowpass.BackColor = System.Drawing.Color.Transparent;
            this.cboxShowpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxShowpass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cboxShowpass.Location = new System.Drawing.Point(469, 158);
            this.cboxShowpass.Margin = new System.Windows.Forms.Padding(2);
            this.cboxShowpass.Name = "cboxShowpass";
            this.cboxShowpass.Size = new System.Drawing.Size(115, 17);
            this.cboxShowpass.TabIndex = 60;
            this.cboxShowpass.Text = "Show Password";
            this.cboxShowpass.UseVisualStyleBackColor = false;
            this.cboxShowpass.CheckedChanged += new System.EventHandler(this.cboxShowpass_CheckedChanged);
            // 
            // Register_New_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(701, 358);
            this.Controls.Add(this.cboxShowpass);
            this.Controls.Add(this.labelIDdesc);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtboxPN);
            this.Controls.Add(this.txtboxPass);
            this.Controls.Add(this.txtboxUser);
            this.Controls.Add(this.txtboxProfile);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelPN);
            this.Controls.Add(this.labelProfile);
            this.Controls.Add(this.labelRegister);
            this.Name = "Register_New_User";
            this.Text = "Register New User Page";
            this.Load += new System.EventHandler(this.Register_New_User_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.Label labelProfile;
        private System.Windows.Forms.Label labelPN;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.TextBox txtboxProfile;
        private System.Windows.Forms.TextBox txtboxUser;
        private System.Windows.Forms.TextBox txtboxPass;
        private System.Windows.Forms.TextBox txtboxPN;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelIDdesc;
        private System.Windows.Forms.CheckBox cboxShowpass;
    }
}