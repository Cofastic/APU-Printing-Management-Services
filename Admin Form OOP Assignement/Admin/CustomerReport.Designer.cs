namespace Admin_Form_OOP_Assignement
{
    partial class CustomerReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerReport));
            this.labelTitle = new System.Windows.Forms.Label();
            this.dataGridViewGenedReport = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenedReport)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(331, 20);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(542, 37);
            this.labelTitle.TabIndex = 19;
            this.labelTitle.Text = "Generated Service Request Report";
            // 
            // dataGridViewGenedReport
            // 
            this.dataGridViewGenedReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGenedReport.Location = new System.Drawing.Point(214, 70);
            this.dataGridViewGenedReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewGenedReport.Name = "dataGridViewGenedReport";
            this.dataGridViewGenedReport.RowHeadersWidth = 62;
            this.dataGridViewGenedReport.Size = new System.Drawing.Size(834, 533);
            this.dataGridViewGenedReport.TabIndex = 18;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(22, 203);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(172, 75);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CustomerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1052, 623);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.dataGridViewGenedReport);
            this.Controls.Add(this.btnBack);
            this.Name = "CustomerReport";
            this.Text = "CustomerReport";
            this.Load += new System.EventHandler(this.CustomerReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenedReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridViewGenedReport;
        private System.Windows.Forms.Button btnBack;
    }
}