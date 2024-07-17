namespace IT112P_LabExer6
{
    partial class UpdateItem
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
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.gbInventory = new System.Windows.Forms.GroupBox();
            this.label_DateTime = new System.Windows.Forms.Label();
            this.cmbItemType = new System.Windows.Forms.ComboBox();
            this.lblItemType = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClearItem = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtItemDesc = new System.Windows.Forms.RichTextBox();
            this.lblItemDesc = new System.Windows.Forms.Label();
            this.lblDate_e = new System.Windows.Forms.Label();
            this.txtItemQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.lblItemID = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.gbInventory.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(324, 14);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.Size = new System.Drawing.Size(567, 344);
            this.dgvInventory.TabIndex = 6;
            this.dgvInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellClick);
            // 
            // gbInventory
            // 
            this.gbInventory.Controls.Add(this.label_DateTime);
            this.gbInventory.Controls.Add(this.cmbItemType);
            this.gbInventory.Controls.Add(this.lblItemType);
            this.gbInventory.Controls.Add(this.btnCancel);
            this.gbInventory.Controls.Add(this.btnClearItem);
            this.gbInventory.Controls.Add(this.btnUpdate);
            this.gbInventory.Controls.Add(this.txtItemDesc);
            this.gbInventory.Controls.Add(this.lblItemDesc);
            this.gbInventory.Controls.Add(this.lblDate_e);
            this.gbInventory.Controls.Add(this.txtItemQuantity);
            this.gbInventory.Controls.Add(this.lblQuantity);
            this.gbInventory.Controls.Add(this.txtItemID);
            this.gbInventory.Controls.Add(this.lblItemID);
            this.gbInventory.Controls.Add(this.txtItemName);
            this.gbInventory.Controls.Add(this.lblItemName);
            this.gbInventory.Location = new System.Drawing.Point(20, 12);
            this.gbInventory.Name = "gbInventory";
            this.gbInventory.Size = new System.Drawing.Size(288, 344);
            this.gbInventory.TabIndex = 5;
            this.gbInventory.TabStop = false;
            this.gbInventory.Text = "Inventory Form";
            // 
            // label_DateTime
            // 
            this.label_DateTime.AutoSize = true;
            this.label_DateTime.Location = new System.Drawing.Point(103, 140);
            this.label_DateTime.Name = "label_DateTime";
            this.label_DateTime.Size = new System.Drawing.Size(136, 13);
            this.label_DateTime.TabIndex = 18;
            this.label_DateTime.Text = "MM/DD/YYYY HH:MM:SS";
            // 
            // cmbItemType
            // 
            this.cmbItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItemType.FormattingEnabled = true;
            this.cmbItemType.Items.AddRange(new object[] {
            "FOOD",
            "DRINK"});
            this.cmbItemType.Location = new System.Drawing.Point(106, 109);
            this.cmbItemType.Name = "cmbItemType";
            this.cmbItemType.Size = new System.Drawing.Size(121, 21);
            this.cmbItemType.TabIndex = 3;
            // 
            // lblItemType
            // 
            this.lblItemType.AutoSize = true;
            this.lblItemType.Location = new System.Drawing.Point(6, 112);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(57, 13);
            this.lblItemType.TabIndex = 14;
            this.lblItemType.Text = "Item Type:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(194, 301);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "C&ancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClearItem
            // 
            this.btnClearItem.Location = new System.Drawing.Point(106, 301);
            this.btnClearItem.Name = "btnClearItem";
            this.btnClearItem.Size = new System.Drawing.Size(75, 23);
            this.btnClearItem.TabIndex = 6;
            this.btnClearItem.Text = "&Clear";
            this.btnClearItem.UseVisualStyleBackColor = true;
            this.btnClearItem.Click += new System.EventHandler(this.btnClearItem_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(17, 301);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtItemDesc
            // 
            this.txtItemDesc.Location = new System.Drawing.Point(106, 174);
            this.txtItemDesc.Name = "txtItemDesc";
            this.txtItemDesc.Size = new System.Drawing.Size(163, 121);
            this.txtItemDesc.TabIndex = 4;
            this.txtItemDesc.Text = "";
            // 
            // lblItemDesc
            // 
            this.lblItemDesc.AutoSize = true;
            this.lblItemDesc.Location = new System.Drawing.Point(6, 174);
            this.lblItemDesc.Name = "lblItemDesc";
            this.lblItemDesc.Size = new System.Drawing.Size(86, 13);
            this.lblItemDesc.TabIndex = 9;
            this.lblItemDesc.Text = "Item Description:";
            // 
            // lblDate_e
            // 
            this.lblDate_e.AutoSize = true;
            this.lblDate_e.Location = new System.Drawing.Point(6, 140);
            this.lblDate_e.Name = "lblDate_e";
            this.lblDate_e.Size = new System.Drawing.Size(67, 13);
            this.lblDate_e.TabIndex = 6;
            this.lblDate_e.Text = "Date Added:";
            // 
            // txtItemQuantity
            // 
            this.txtItemQuantity.Location = new System.Drawing.Point(106, 80);
            this.txtItemQuantity.Name = "txtItemQuantity";
            this.txtItemQuantity.Size = new System.Drawing.Size(121, 20);
            this.txtItemQuantity.TabIndex = 2;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(6, 87);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(75, 13);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Item Quantity: ";
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(106, 27);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(121, 20);
            this.txtItemID.TabIndex = 0;
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(6, 30);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(44, 13);
            this.lblItemID.TabIndex = 2;
            this.lblItemID.Text = "Item ID:";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(106, 54);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(121, 20);
            this.txtItemName.TabIndex = 1;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(6, 57);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(61, 13);
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "Item Name:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UpdateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 370);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.gbInventory);
            this.Name = "UpdateItem";
            this.Text = "UpdateItem";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.gbInventory.ResumeLayout(false);
            this.gbInventory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.GroupBox gbInventory;
        private System.Windows.Forms.ComboBox cmbItemType;
        private System.Windows.Forms.Label lblItemType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClearItem;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RichTextBox txtItemDesc;
        private System.Windows.Forms.Label lblItemDesc;
        private System.Windows.Forms.Label lblDate_e;
        private System.Windows.Forms.TextBox txtItemQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label label_DateTime;
        private System.Windows.Forms.Timer timer1;
    }
}