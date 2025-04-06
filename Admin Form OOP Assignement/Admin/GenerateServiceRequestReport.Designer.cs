namespace Admin_Form_OOP_Assignement
{
    partial class GenerateServiceRequestReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateServiceRequestReport));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewGenedReport = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenedReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(349, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Generated Service Request Report";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewGenedReport
            // 
            this.dataGridViewGenedReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGenedReport.Location = new System.Drawing.Point(203, 86);
            this.dataGridViewGenedReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewGenedReport.Name = "dataGridViewGenedReport";
            this.dataGridViewGenedReport.RowHeadersWidth = 62;
            this.dataGridViewGenedReport.Size = new System.Drawing.Size(863, 533);
            this.dataGridViewGenedReport.TabIndex = 18;
            this.dataGridViewGenedReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGenedReport_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(23, 220);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(172, 75);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // GenerateServiceRequestReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1088, 654);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewGenedReport);
            this.Controls.Add(this.btnBack);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "GenerateServiceRequestReport";
            this.Text = "GenerateServiceRequestReport";
            this.Load += new System.EventHandler(this.GenerateServiceRequestReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenedReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewGenedReport;
        private System.Windows.Forms.Button btnBack;
    }
}