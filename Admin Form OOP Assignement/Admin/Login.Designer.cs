namespace Admin_Form_OOP_Assignement
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtboxPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.labelPass = new System.Windows.Forms.Label();
            this.txtboxUser = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.cboxShowpass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtboxPass
            // 
            this.txtboxPass.Location = new System.Drawing.Point(453, 248);
            this.txtboxPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxPass.Name = "txtboxPass";
            this.txtboxPass.Size = new System.Drawing.Size(229, 26);
            this.txtboxPass.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(453, 352);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(231, 63);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.BackColor = System.Drawing.Color.Transparent;
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.ForeColor = System.Drawing.Color.White;
            this.labelPass.Location = new System.Drawing.Point(352, 252);
            this.labelPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(91, 20);
            this.labelPass.TabIndex = 3;
            this.labelPass.Text = "Password";
            // 
            // txtboxUser
            // 
            this.txtboxUser.Location = new System.Drawing.Point(453, 160);
            this.txtboxUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxUser.Name = "txtboxUser";
            this.txtboxUser.Size = new System.Drawing.Size(229, 26);
            this.txtboxUser.TabIndex = 4;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.Transparent;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(350, 165);
            this.labelUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(94, 20);
            this.labelUser.TabIndex = 5;
            this.labelUser.Text = "Username";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(218, 14);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(671, 37);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "APU Printing Service Management System ";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(33, 483);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(177, 60);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cboxShowpass
            // 
            this.cboxShowpass.AutoSize = true;
            this.cboxShowpass.BackColor = System.Drawing.Color.Transparent;
            this.cboxShowpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxShowpass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cboxShowpass.Location = new System.Drawing.Point(453, 293);
            this.cboxShowpass.Name = "cboxShowpass";
            this.cboxShowpass.Size = new System.Drawing.Size(161, 24);
            this.cboxShowpass.TabIndex = 28;
            this.cboxShowpass.Text = "Show Password";
            this.cboxShowpass.UseVisualStyleBackColor = false;
            this.cboxShowpass.CheckedChanged += new System.EventHandler(this.cboxShowpass_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1038, 562);
            this.Controls.Add(this.cboxShowpass);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.txtboxUser);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtboxPass);
            this.Name = "Login";
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtboxPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox txtboxUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox cboxShowpass;
    }
}

