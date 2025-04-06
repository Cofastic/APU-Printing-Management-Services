namespace Admin_Form_OOP_Assignment
{
    partial class CompleteRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompleteRequest));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.acceptRequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.acceptRequestDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelWorkerID = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbReqID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptRequestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptRequestDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(232, 192);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1066, 537);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // acceptRequestBindingSource
            // 
            this.acceptRequestBindingSource.DataMember = "AcceptRequest";
            this.acceptRequestBindingSource.DataSource = this.acceptRequestDataSetBindingSource;
            // 
            // labelWorkerID
            // 
            this.labelWorkerID.AutoSize = true;
            this.labelWorkerID.BackColor = System.Drawing.Color.Transparent;
            this.labelWorkerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWorkerID.ForeColor = System.Drawing.Color.White;
            this.labelWorkerID.Location = new System.Drawing.Point(226, 105);
            this.labelWorkerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWorkerID.Name = "labelWorkerID";
            this.labelWorkerID.Size = new System.Drawing.Size(200, 33);
            this.labelWorkerID.TabIndex = 3;
            this.labelWorkerID.Text = "labelWorkerID";
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(628, 808);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(252, 71);
            this.btnComplete.TabIndex = 5;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1410, 849);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(146, 63);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbReqID
            // 
            this.cmbReqID.FormattingEnabled = true;
            this.cmbReqID.Location = new System.Drawing.Point(1353, 222);
            this.cmbReqID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbReqID.Name = "cmbReqID";
            this.cmbReqID.Size = new System.Drawing.Size(180, 28);
            this.cmbReqID.TabIndex = 7;
            this.cmbReqID.SelectedIndexChanged += new System.EventHandler(this.cmbReqID_SelectedIndexChanged);
            // 
            // CompleteRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1599, 948);
            this.Controls.Add(this.cmbReqID);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelWorkerID);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CompleteRequest";
            this.Text = "CompleteRequest";
            this.Load += new System.EventHandler(this.CompleteRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelWorkerID;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.BindingSource acceptRequestDataSetBindingSource;
        private System.Windows.Forms.BindingSource acceptRequestBindingSource;
        private System.Windows.Forms.ComboBox cmbReqID;
    }
}