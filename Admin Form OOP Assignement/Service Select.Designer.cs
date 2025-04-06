using Admin_Form_OOP_Assignement.Properties;
using System;

namespace Admin_Form_OOP_Assingment
{
    partial class ServiceSelectForm
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
            this.buttonAddService = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxServices = new System.Windows.Forms.ListBox();
            this.textBoxQty = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonRemoveService = new System.Windows.Forms.Button();
            this.buttonCheckout = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.listBoxServicesSelection = new System.Windows.Forms.ListBox();
            this.pictureBoxServices = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.checkBoxUrgent = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxServices)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddService
            // 
            this.buttonAddService.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddService.Location = new System.Drawing.Point(32, 788);
            this.buttonAddService.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonAddService.Name = "buttonAddService";
            this.buttonAddService.Size = new System.Drawing.Size(164, 75);
            this.buttonAddService.TabIndex = 0;
            this.buttonAddService.Text = "Add Service";
            this.buttonAddService.UseVisualStyleBackColor = false;
            this.buttonAddService.Click += new System.EventHandler(this.buttonAddService_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 665);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quantity: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Service: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 709);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Service Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Services : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(442, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Your Selected Services: ";
            // 
            // listBoxServices
            // 
            this.listBoxServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listBoxServices.FormattingEnabled = true;
            this.listBoxServices.ItemHeight = 25;
            this.listBoxServices.Location = new System.Drawing.Point(446, 425);
            this.listBoxServices.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.listBoxServices.Name = "listBoxServices";
            this.listBoxServices.Size = new System.Drawing.Size(384, 229);
            this.listBoxServices.TabIndex = 8;
            // 
            // textBoxQty
            // 
            this.textBoxQty.Location = new System.Drawing.Point(138, 665);
            this.textBoxQty.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxQty.Name = "textBoxQty";
            this.textBoxQty.Size = new System.Drawing.Size(112, 26);
            this.textBoxQty.TabIndex = 10;
            this.textBoxQty.TextChanged += new System.EventHandler(this.textBoxQty_TextChanged);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.White;
            this.labelPrice.Location = new System.Drawing.Point(154, 709);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(78, 20);
            this.labelPrice.TabIndex = 11;
            this.labelPrice.Text = "<Prices>";
            // 
            // buttonRemoveService
            // 
            this.buttonRemoveService.Location = new System.Drawing.Point(448, 788);
            this.buttonRemoveService.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonRemoveService.Name = "buttonRemoveService";
            this.buttonRemoveService.Size = new System.Drawing.Size(164, 75);
            this.buttonRemoveService.TabIndex = 12;
            this.buttonRemoveService.Text = "Remove Service";
            this.buttonRemoveService.UseVisualStyleBackColor = true;
            this.buttonRemoveService.Click += new System.EventHandler(this.buttonRemoveService_Click);
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.Location = new System.Drawing.Point(1312, 592);
            this.buttonCheckout.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(154, 92);
            this.buttonCheckout.TabIndex = 13;
            this.buttonCheckout.Text = "Checkout";
            this.buttonCheckout.UseVisualStyleBackColor = true;
            this.buttonCheckout.Click += new System.EventHandler(this.buttonCheckout_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(1312, 732);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(154, 92);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "Return to Menu";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // listBoxServicesSelection
            // 
            this.listBoxServicesSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBoxServicesSelection.FormattingEnabled = true;
            this.listBoxServicesSelection.ItemHeight = 29;
            this.listBoxServicesSelection.Items.AddRange(new object[] {
            "Printing A4 - Black and White",
            "Printing A4 - Color",
            "Binding - Comb Binding",
            "Binding - Thick Cover",
            "Printing - Poster A0/A1",
            "Printing - Poster A2/A3"});
            this.listBoxServicesSelection.Location = new System.Drawing.Point(16, 425);
            this.listBoxServicesSelection.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.listBoxServicesSelection.Name = "listBoxServicesSelection";
            this.listBoxServicesSelection.Size = new System.Drawing.Size(384, 178);
            this.listBoxServicesSelection.TabIndex = 15;
            this.listBoxServicesSelection.SelectedIndexChanged += new System.EventHandler(this.listBoxServicesSelection_SelectedIndexChanged);
            // 
            // pictureBoxServices
            // 
            this.pictureBoxServices.BackgroundImage = global::Admin_Form_OOP_Assignement.Properties.Resources.Prices;
            this.pictureBoxServices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxServices.Location = new System.Drawing.Point(16, 54);
            this.pictureBoxServices.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBoxServices.Name = "pictureBoxServices";
            this.pictureBoxServices.Size = new System.Drawing.Size(1030, 275);
            this.pictureBoxServices.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxServices.TabIndex = 5;
            this.pictureBoxServices.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(858, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 36);
            this.label6.TabIndex = 17;
            this.label6.Text = "Total Cost :";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.ForeColor = System.Drawing.Color.White;
            this.labelTotalPrice.Location = new System.Drawing.Point(858, 442);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(26, 36);
            this.labelTotalPrice.TabIndex = 18;
            this.labelTotalPrice.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(28, 748);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Discount :";
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.BackColor = System.Drawing.Color.Transparent;
            this.labelDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscount.ForeColor = System.Drawing.Color.White;
            this.labelDiscount.Location = new System.Drawing.Point(154, 748);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(100, 20);
            this.labelDiscount.TabIndex = 20;
            this.labelDiscount.Text = "<Discount>";
            // 
            // checkBoxUrgent
            // 
            this.checkBoxUrgent.AutoSize = true;
            this.checkBoxUrgent.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxUrgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.checkBoxUrgent.ForeColor = System.Drawing.Color.White;
            this.checkBoxUrgent.Location = new System.Drawing.Point(864, 508);
            this.checkBoxUrgent.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checkBoxUrgent.Name = "checkBoxUrgent";
            this.checkBoxUrgent.Size = new System.Drawing.Size(310, 24);
            this.checkBoxUrgent.TabIndex = 21;
            this.checkBoxUrgent.Text = "Urgent Request (+30% surcharge)";
            this.checkBoxUrgent.UseVisualStyleBackColor = false;
            this.checkBoxUrgent.CheckedChanged += new System.EventHandler(this.checkBoxUrgent_CheckedChanged);
            // 
            // ServiceSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Admin_Form_OOP_Assignement.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1556, 878);
            this.Controls.Add(this.checkBoxUrgent);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxServicesSelection);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCheckout);
            this.Controls.Add(this.buttonRemoveService);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxQty);
            this.Controls.Add(this.listBoxServices);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxServices);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAddService);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "ServiceSelectForm";
            this.Text = "Service Select Menu";
            this.Load += new System.EventHandler(this.ServiceSelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddService;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxServices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxServices;
        private System.Windows.Forms.TextBox textBoxQty;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonRemoveService;
        private System.Windows.Forms.Button buttonCheckout;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ListBox listBoxServicesSelection;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.CheckBox checkBoxUrgent;
    }
}

