namespace Admin_Form_OOP_Assignment
{
    partial class FormConfirmation
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
            this.labelServices = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelUrgency = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelServices
            // 
            this.labelServices.AutoSize = true;
            this.labelServices.BackColor = System.Drawing.Color.Transparent;
            this.labelServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServices.ForeColor = System.Drawing.Color.White;
            this.labelServices.Location = new System.Drawing.Point(14, 194);
            this.labelServices.Name = "labelServices";
            this.labelServices.Size = new System.Drawing.Size(190, 29);
            this.labelServices.TabIndex = 0;
            this.labelServices.Text = "Your Services: ";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(678, 494);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(164, 92);
            this.buttonConfirm.TabIndex = 13;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.ForeColor = System.Drawing.Color.White;
            this.labelTotalPrice.Location = new System.Drawing.Point(546, 194);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(238, 29);
            this.labelTotalPrice.TabIndex = 14;
            this.labelTotalPrice.Text = "Amount to be paid :";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(867, 494);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(164, 92);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelUrgency
            // 
            this.labelUrgency.AutoSize = true;
            this.labelUrgency.BackColor = System.Drawing.Color.Transparent;
            this.labelUrgency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUrgency.ForeColor = System.Drawing.Color.White;
            this.labelUrgency.Location = new System.Drawing.Point(546, 311);
            this.labelUrgency.Name = "labelUrgency";
            this.labelUrgency.Size = new System.Drawing.Size(135, 29);
            this.labelUrgency.TabIndex = 16;
            this.labelUrgency.Text = "<urgency>";
            // 
            // FormConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Admin_Form_OOP_Assignement.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 601);
            this.Controls.Add(this.labelUrgency);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.labelServices);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormConfirmation";
            this.Text = "FormConfirmation";
            this.Load += new System.EventHandler(this.FormConfirmation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelServices;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelUrgency;
    }
}