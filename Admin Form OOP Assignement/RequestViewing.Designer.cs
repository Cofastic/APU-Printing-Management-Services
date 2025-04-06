namespace Admin_Form_OOP_Assignement
{
    partial class RequestViewing
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
            this.DGVRequests = new System.Windows.Forms.DataGridView();
            this.requestListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.requestDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.requestListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestListBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVRequests
            // 
            this.DGVRequests.AllowUserToAddRows = false;
            this.DGVRequests.AllowUserToDeleteRows = false;
            this.DGVRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRequests.Location = new System.Drawing.Point(255, 111);
            this.DGVRequests.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DGVRequests.Name = "DGVRequests";
            this.DGVRequests.ReadOnly = true;
            this.DGVRequests.RowHeadersWidth = 51;
            this.DGVRequests.Size = new System.Drawing.Size(852, 558);
            this.DGVRequests.TabIndex = 0;
            this.DGVRequests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRequests_CellContentClick);
            // 
            // requestListBindingSource1
            // 
            this.requestListBindingSource1.DataMember = "RequestList";
            // 
            // requestDataBindingSource
            // 
            this.requestDataBindingSource.DataMember = "RequestData";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(396, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 46);
            this.label3.TabIndex = 9;
            this.label3.Text = "View Requests";
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(46, 582);
            this.buttonReturn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(150, 89);
            this.buttonReturn.TabIndex = 10;
            this.buttonReturn.Text = "Return ";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // requestListBindingSource
            // 
            this.requestListBindingSource.DataMember = "RequestList";
            // 
            // RequestViewing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Admin_Form_OOP_Assignement.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1120, 685);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGVRequests);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "RequestViewing";
            this.Text = "Requests View";
            this.Load += new System.EventHandler(this.RequestViewing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestListBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVRequests;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.BindingSource requestListBindingSource;
        private System.Windows.Forms.BindingSource requestDataBindingSource;
        private System.Windows.Forms.BindingSource requestListBindingSource1;
    }
}