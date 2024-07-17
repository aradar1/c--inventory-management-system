namespace IT112P_LabExer6
{
    partial class PurchaseHistory
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbSearchPurchase = new System.Windows.Forms.GroupBox();
            this.rbQuantity = new System.Windows.Forms.RadioButton();
            this.rbTransactionID = new System.Windows.Forms.RadioButton();
            this.rbDateOfTransaction = new System.Windows.Forms.RadioButton();
            this.rbProductName = new System.Windows.Forms.RadioButton();
            this.rbGross = new System.Windows.Forms.RadioButton();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.rbQuantity2 = new System.Windows.Forms.RadioButton();
            this.gbSearchPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(31, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // gbSearchPurchase
            // 
            this.gbSearchPurchase.Controls.Add(this.rbQuantity2);
            this.gbSearchPurchase.Controls.Add(this.rbGross);
            this.gbSearchPurchase.Controls.Add(this.rbProductName);
            this.gbSearchPurchase.Controls.Add(this.rbDateOfTransaction);
            this.gbSearchPurchase.Controls.Add(this.rbTransactionID);
            this.gbSearchPurchase.Controls.Add(this.rbQuantity);
            this.gbSearchPurchase.Location = new System.Drawing.Point(168, 12);
            this.gbSearchPurchase.Name = "gbSearchPurchase";
            this.gbSearchPurchase.Size = new System.Drawing.Size(606, 75);
            this.gbSearchPurchase.TabIndex = 1;
            this.gbSearchPurchase.TabStop = false;
            this.gbSearchPurchase.Text = "Search by:";
            // 
            // rbQuantity
            // 
            this.rbQuantity.AutoSize = true;
            this.rbQuantity.Location = new System.Drawing.Point(6, 21);
            this.rbQuantity.Name = "rbQuantity";
            this.rbQuantity.Size = new System.Drawing.Size(114, 17);
            this.rbQuantity.TabIndex = 0;
            this.rbQuantity.TabStop = true;
            this.rbQuantity.Text = "Most Quantity Sold";
            this.rbQuantity.UseVisualStyleBackColor = true;
            this.rbQuantity.CheckedChanged += new System.EventHandler(this.rbQuantity_CheckedChanged);
            // 
            // rbTransactionID
            // 
            this.rbTransactionID.AutoSize = true;
            this.rbTransactionID.Location = new System.Drawing.Point(118, 21);
            this.rbTransactionID.Name = "rbTransactionID";
            this.rbTransactionID.Size = new System.Drawing.Size(95, 17);
            this.rbTransactionID.TabIndex = 1;
            this.rbTransactionID.TabStop = true;
            this.rbTransactionID.Text = "Transaction ID";
            this.rbTransactionID.UseVisualStyleBackColor = true;
            this.rbTransactionID.CheckedChanged += new System.EventHandler(this.rbTransactionID_CheckedChanged);
            // 
            // rbDateOfTransaction
            // 
            this.rbDateOfTransaction.AutoSize = true;
            this.rbDateOfTransaction.Location = new System.Drawing.Point(228, 21);
            this.rbDateOfTransaction.Name = "rbDateOfTransaction";
            this.rbDateOfTransaction.Size = new System.Drawing.Size(119, 17);
            this.rbDateOfTransaction.TabIndex = 2;
            this.rbDateOfTransaction.TabStop = true;
            this.rbDateOfTransaction.Text = "Date of Transaction";
            this.rbDateOfTransaction.UseVisualStyleBackColor = true;
            this.rbDateOfTransaction.CheckedChanged += new System.EventHandler(this.rbDateOfTransaction_CheckedChanged);
            // 
            // rbProductName
            // 
            this.rbProductName.AutoSize = true;
            this.rbProductName.Location = new System.Drawing.Point(353, 21);
            this.rbProductName.Name = "rbProductName";
            this.rbProductName.Size = new System.Drawing.Size(93, 17);
            this.rbProductName.TabIndex = 3;
            this.rbProductName.TabStop = true;
            this.rbProductName.Text = "Product Name";
            this.rbProductName.UseVisualStyleBackColor = true;
            this.rbProductName.CheckedChanged += new System.EventHandler(this.rbProductName_CheckedChanged);
            // 
            // rbGross
            // 
            this.rbGross.AutoSize = true;
            this.rbGross.Location = new System.Drawing.Point(452, 20);
            this.rbGross.Name = "rbGross";
            this.rbGross.Size = new System.Drawing.Size(52, 17);
            this.rbGross.TabIndex = 4;
            this.rbGross.TabStop = true;
            this.rbGross.Text = "Gross";
            this.rbGross.UseVisualStyleBackColor = true;
            this.rbGross.CheckedChanged += new System.EventHandler(this.rbGross_CheckedChanged);
            // 
            // dgvInventory
            // 
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(31, 103);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.Size = new System.Drawing.Size(781, 347);
            this.dgvInventory.TabIndex = 2;
            // 
            // rbQuantity2
            // 
            this.rbQuantity2.AutoSize = true;
            this.rbQuantity2.Location = new System.Drawing.Point(6, 45);
            this.rbQuantity2.Name = "rbQuantity2";
            this.rbQuantity2.Size = new System.Drawing.Size(117, 17);
            this.rbQuantity2.TabIndex = 5;
            this.rbQuantity2.TabStop = true;
            this.rbQuantity2.Text = "Least Quantity Sold";
            this.rbQuantity2.UseVisualStyleBackColor = true;
            this.rbQuantity2.CheckedChanged += new System.EventHandler(this.rbQuantity2_CheckedChanged);
            // 
            // PurchaseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 514);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.gbSearchPurchase);
            this.Controls.Add(this.comboBox1);
            this.Name = "PurchaseHistory";
            this.Text = "PurchaseHistory";
            this.gbSearchPurchase.ResumeLayout(false);
            this.gbSearchPurchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox gbSearchPurchase;
        private System.Windows.Forms.RadioButton rbQuantity;
        private System.Windows.Forms.RadioButton rbGross;
        private System.Windows.Forms.RadioButton rbProductName;
        private System.Windows.Forms.RadioButton rbDateOfTransaction;
        private System.Windows.Forms.RadioButton rbTransactionID;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.RadioButton rbQuantity2;
    }
}