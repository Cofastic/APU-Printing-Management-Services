namespace Admin_Form_OOP_Assignment
{
    partial class CustomerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.labelCustomerPhone = new System.Windows.Forms.Label();
            this.RequestButton = new System.Windows.Forms.Button();
            this.CheckRequestButton = new System.Windows.Forms.Button();
            this.UpdateProfileButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelIDdesc = new System.Windows.Forms.Label();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.labelCustomerRole = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(181, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(181, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone :";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.labelCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerName.ForeColor = System.Drawing.Color.White;
            this.labelCustomerName.Location = new System.Drawing.Point(255, 103);
            this.labelCustomerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(73, 20);
            this.labelCustomerName.TabIndex = 2;
            this.labelCustomerName.Text = "<name>";
            // 
            // labelCustomerPhone
            // 
            this.labelCustomerPhone.AutoSize = true;
            this.labelCustomerPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerPhone.ForeColor = System.Drawing.Color.White;
            this.labelCustomerPhone.Location = new System.Drawing.Point(255, 213);
            this.labelCustomerPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCustomerPhone.Name = "labelCustomerPhone";
            this.labelCustomerPhone.Size = new System.Drawing.Size(158, 20);
            this.labelCustomerPhone.TabIndex = 3;
            this.labelCustomerPhone.Text = "<customer phone>";
            // 
            // RequestButton
            // 
            this.RequestButton.Location = new System.Drawing.Point(25, 127);
            this.RequestButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RequestButton.Name = "RequestButton";
            this.RequestButton.Size = new System.Drawing.Size(94, 32);
            this.RequestButton.TabIndex = 4;
            this.RequestButton.Text = "Make Request";
            this.RequestButton.UseVisualStyleBackColor = true;
            this.RequestButton.Click += new System.EventHandler(this.RequestButton_Click);
            // 
            // CheckRequestButton
            // 
            this.CheckRequestButton.Location = new System.Drawing.Point(25, 165);
            this.CheckRequestButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CheckRequestButton.Name = "CheckRequestButton";
            this.CheckRequestButton.Size = new System.Drawing.Size(94, 38);
            this.CheckRequestButton.TabIndex = 5;
            this.CheckRequestButton.Text = "Check Requests";
            this.CheckRequestButton.UseVisualStyleBackColor = true;
            this.CheckRequestButton.Click += new System.EventHandler(this.CheckRequestButton_Click);
            // 
            // UpdateProfileButton
            // 
            this.UpdateProfileButton.Location = new System.Drawing.Point(25, 208);
            this.UpdateProfileButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.UpdateProfileButton.Name = "UpdateProfileButton";
            this.UpdateProfileButton.Size = new System.Drawing.Size(94, 33);
            this.UpdateProfileButton.TabIndex = 6;
            this.UpdateProfileButton.Text = "Update Profile";
            this.UpdateProfileButton.UseVisualStyleBackColor = true;
            this.UpdateProfileButton.Click += new System.EventHandler(this.UpdateProfileButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(189, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Customer Menu";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(25, 246);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(94, 34);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Log Out";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(181, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID: ";
            // 
            // labelIDdesc
            // 
            this.labelIDdesc.AutoSize = true;
            this.labelIDdesc.BackColor = System.Drawing.Color.Transparent;
            this.labelIDdesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDdesc.ForeColor = System.Drawing.Color.White;
            this.labelIDdesc.Location = new System.Drawing.Point(255, 139);
            this.labelIDdesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIDdesc.Name = "labelIDdesc";
            this.labelIDdesc.Size = new System.Drawing.Size(122, 20);
            this.labelIDdesc.TabIndex = 10;
            this.labelIDdesc.Text = "<customer id>";
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.BackColor = System.Drawing.Color.Transparent;
            this.labelCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomer.ForeColor = System.Drawing.Color.White;
            this.labelCustomer.Location = new System.Drawing.Point(181, 173);
            this.labelCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(51, 20);
            this.labelCustomer.TabIndex = 11;
            this.labelCustomer.Text = "Role:";
            // 
            // labelCustomerRole
            // 
            this.labelCustomerRole.AutoSize = true;
            this.labelCustomerRole.BackColor = System.Drawing.Color.Transparent;
            this.labelCustomerRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerRole.ForeColor = System.Drawing.Color.White;
            this.labelCustomerRole.Location = new System.Drawing.Point(255, 173);
            this.labelCustomerRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCustomerRole.Name = "labelCustomerRole";
            this.labelCustomerRole.Size = new System.Drawing.Size(138, 20);
            this.labelCustomerRole.TabIndex = 12;
            this.labelCustomerRole.Text = "<customer role>";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = global::Admin_Form_OOP_Assignement.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 365);
            this.Controls.Add(this.labelCustomerRole);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.labelIDdesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.UpdateProfileButton);
            this.Controls.Add(this.CheckRequestButton);
            this.Controls.Add(this.RequestButton);
            this.Controls.Add(this.labelCustomerPhone);
            this.Controls.Add(this.labelCustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "CustomerForm";
            this.Text = "Customer Menu";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label labelCustomerName;
        public System.Windows.Forms.Label labelCustomerPhone;
        private System.Windows.Forms.Button RequestButton;
        private System.Windows.Forms.Button CheckRequestButton;
        private System.Windows.Forms.Button UpdateProfileButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label labelIDdesc;
        private System.Windows.Forms.Label labelCustomer;
        public System.Windows.Forms.Label labelCustomerRole;
    }
}