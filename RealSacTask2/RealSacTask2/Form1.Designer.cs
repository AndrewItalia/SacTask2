namespace RealSacTask2
{
    partial class Form1
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
            this.btnImportfile = new System.Windows.Forms.Button();
            this.dgvBookSales = new System.Windows.Forms.DataGridView();
            this.Textbook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchaser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchaseprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saleprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookSales)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImportfile
            // 
            this.btnImportfile.BackColor = System.Drawing.Color.RosyBrown;
            this.btnImportfile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportfile.ForeColor = System.Drawing.Color.White;
            this.btnImportfile.Location = new System.Drawing.Point(12, 27);
            this.btnImportfile.Name = "btnImportfile";
            this.btnImportfile.Size = new System.Drawing.Size(163, 62);
            this.btnImportfile.TabIndex = 0;
            this.btnImportfile.Text = "Calculate Profit";
            this.btnImportfile.UseVisualStyleBackColor = false;
            this.btnImportfile.Click += new System.EventHandler(this.btnImportfile_Click);
            // 
            // dgvBookSales
            // 
            this.dgvBookSales.AllowUserToAddRows = false;
            this.dgvBookSales.AllowUserToDeleteRows = false;
            this.dgvBookSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBookSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Textbook,
            this.Subject,
            this.Seller,
            this.Purchaser,
            this.Purchaseprice,
            this.Saleprice,
            this.Profit});
            this.dgvBookSales.Location = new System.Drawing.Point(12, 109);
            this.dgvBookSales.Name = "dgvBookSales";
            this.dgvBookSales.ReadOnly = true;
            this.dgvBookSales.RowHeadersWidth = 62;
            this.dgvBookSales.RowTemplate.Height = 28;
            this.dgvBookSales.Size = new System.Drawing.Size(1091, 349);
            this.dgvBookSales.TabIndex = 1;
            // 
            // Textbook
            // 
            this.Textbook.HeaderText = "Textbook";
            this.Textbook.MinimumWidth = 8;
            this.Textbook.Name = "Textbook";
            this.Textbook.ReadOnly = true;
            this.Textbook.Width = 150;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Subject";
            this.Subject.MinimumWidth = 8;
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            this.Subject.Width = 150;
            // 
            // Seller
            // 
            this.Seller.HeaderText = "Seller";
            this.Seller.MinimumWidth = 8;
            this.Seller.Name = "Seller";
            this.Seller.ReadOnly = true;
            this.Seller.Width = 150;
            // 
            // Purchaser
            // 
            this.Purchaser.HeaderText = "Purchaser";
            this.Purchaser.MinimumWidth = 8;
            this.Purchaser.Name = "Purchaser";
            this.Purchaser.ReadOnly = true;
            this.Purchaser.Width = 150;
            // 
            // Purchaseprice
            // 
            this.Purchaseprice.HeaderText = "Purchased Price";
            this.Purchaseprice.MinimumWidth = 8;
            this.Purchaseprice.Name = "Purchaseprice";
            this.Purchaseprice.ReadOnly = true;
            this.Purchaseprice.Width = 150;
            // 
            // Saleprice
            // 
            this.Saleprice.HeaderText = "Sale Price";
            this.Saleprice.MinimumWidth = 8;
            this.Saleprice.Name = "Saleprice";
            this.Saleprice.ReadOnly = true;
            this.Saleprice.Width = 150;
            // 
            // Profit
            // 
            this.Profit.HeaderText = "Profit";
            this.Profit.MinimumWidth = 8;
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            this.Profit.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 470);
            this.Controls.Add(this.dgvBookSales);
            this.Controls.Add(this.btnImportfile);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImportfile;
        private System.Windows.Forms.DataGridView dgvBookSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Textbook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seller;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchaser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchaseprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saleprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
    }
}

