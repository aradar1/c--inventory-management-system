namespace IT112P_LabExer6
{
    partial class Product_List
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
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.rbItemDesc = new System.Windows.Forms.RadioButton();
            this.rbItemType = new System.Windows.Forms.RadioButton();
            this.rbProductName = new System.Windows.Forms.RadioButton();
            this.rbProductID = new System.Windows.Forms.RadioButton();
            this.rbExpired = new System.Windows.Forms.RadioButton();
            this.rbSafetyLevel = new System.Windows.Forms.RadioButton();
            this.rbItemQuantity = new System.Windows.Forms.RadioButton();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Display = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.gbSearch.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(12, 124);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.Size = new System.Drawing.Size(700, 302);
            this.dgvInventory.TabIndex = 7;
            this.dgvInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellClick);
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.rbItemQuantity);
            this.gbSearch.Controls.Add(this.rbItemDesc);
            this.gbSearch.Controls.Add(this.rbItemType);
            this.gbSearch.Controls.Add(this.rbProductName);
            this.gbSearch.Controls.Add(this.rbProductID);
            this.gbSearch.Location = new System.Drawing.Point(12, 12);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(347, 77);
            this.gbSearch.TabIndex = 9;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search by:";
            // 
            // rbItemDesc
            // 
            this.rbItemDesc.AutoSize = true;
            this.rbItemDesc.Location = new System.Drawing.Point(16, 47);
            this.rbItemDesc.Name = "rbItemDesc";
            this.rbItemDesc.Size = new System.Drawing.Size(101, 17);
            this.rbItemDesc.TabIndex = 4;
            this.rbItemDesc.TabStop = true;
            this.rbItemDesc.Text = "Item Description";
            this.rbItemDesc.UseVisualStyleBackColor = true;
            this.rbItemDesc.CheckedChanged += new System.EventHandler(this.rbItemDesc_CheckedChanged);
            // 
            // rbItemType
            // 
            this.rbItemType.AutoSize = true;
            this.rbItemType.Location = new System.Drawing.Point(134, 47);
            this.rbItemType.Name = "rbItemType";
            this.rbItemType.Size = new System.Drawing.Size(69, 17);
            this.rbItemType.TabIndex = 3;
            this.rbItemType.TabStop = true;
            this.rbItemType.Text = "ItemType";
            this.rbItemType.UseVisualStyleBackColor = true;
            this.rbItemType.CheckedChanged += new System.EventHandler(this.rbItemType_CheckedChanged);
            // 
            // rbProductName
            // 
            this.rbProductName.AutoSize = true;
            this.rbProductName.Location = new System.Drawing.Point(134, 24);
            this.rbProductName.Name = "rbProductName";
            this.rbProductName.Size = new System.Drawing.Size(93, 17);
            this.rbProductName.TabIndex = 1;
            this.rbProductName.TabStop = true;
            this.rbProductName.Text = "Product Name";
            this.rbProductName.UseVisualStyleBackColor = true;
            this.rbProductName.CheckedChanged += new System.EventHandler(this.rbProductName_CheckedChanged);
            // 
            // rbProductID
            // 
            this.rbProductID.AutoSize = true;
            this.rbProductID.Location = new System.Drawing.Point(16, 24);
            this.rbProductID.Name = "rbProductID";
            this.rbProductID.Size = new System.Drawing.Size(76, 17);
            this.rbProductID.TabIndex = 0;
            this.rbProductID.TabStop = true;
            this.rbProductID.Text = "Product ID";
            this.rbProductID.UseVisualStyleBackColor = true;
            this.rbProductID.CheckedChanged += new System.EventHandler(this.rbProductID_CheckedChanged);
            // 
            // rbExpired
            // 
            this.rbExpired.AutoSize = true;
            this.rbExpired.Location = new System.Drawing.Point(6, 24);
            this.rbExpired.Name = "rbExpired";
            this.rbExpired.Size = new System.Drawing.Size(105, 17);
            this.rbExpired.TabIndex = 8;
            this.rbExpired.TabStop = true;
            this.rbExpired.Text = "Expired Products";
            this.rbExpired.UseVisualStyleBackColor = true;
            this.rbExpired.CheckedChanged += new System.EventHandler(this.rbExpired_CheckedChanged);
            // 
            // rbSafetyLevel
            // 
            this.rbSafetyLevel.AutoSize = true;
            this.rbSafetyLevel.Location = new System.Drawing.Point(6, 47);
            this.rbSafetyLevel.Name = "rbSafetyLevel";
            this.rbSafetyLevel.Size = new System.Drawing.Size(116, 17);
            this.rbSafetyLevel.TabIndex = 7;
            this.rbSafetyLevel.TabStop = true;
            this.rbSafetyLevel.Text = "Below Safety Level";
            this.rbSafetyLevel.UseVisualStyleBackColor = true;
            this.rbSafetyLevel.CheckedChanged += new System.EventHandler(this.rbSafetyLevel_CheckedChanged);
            // 
            // rbItemQuantity
            // 
            this.rbItemQuantity.AutoSize = true;
            this.rbItemQuantity.Location = new System.Drawing.Point(251, 24);
            this.rbItemQuantity.Name = "rbItemQuantity";
            this.rbItemQuantity.Size = new System.Drawing.Size(87, 17);
            this.rbItemQuantity.TabIndex = 6;
            this.rbItemQuantity.TabStop = true;
            this.rbItemQuantity.Text = "Item Quantity";
            this.rbItemQuantity.UseVisualStyleBackColor = true;
            this.rbItemQuantity.CheckedChanged += new System.EventHandler(this.rbItemQuantity_CheckedChanged);
            // 
            // cbSearch
            // 
            this.cbSearch.AccessibleDescription = "";
            this.cbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(12, 95);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(242, 21);
            this.cbSearch.TabIndex = 10;
            this.cbSearch.Text = "Type product id here...";
            this.cbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbSearch_KeyDown);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(438, 95);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbExpired);
            this.groupBox2.Controls.Add(this.rbSafetyLevel);
            this.groupBox2.Location = new System.Drawing.Point(365, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 77);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter:";
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(356, 95);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(76, 23);
            this.button_Clear.TabIndex = 14;
            this.button_Clear.Text = "Clear &All";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Display
            // 
            this.button_Display.Location = new System.Drawing.Point(275, 95);
            this.button_Display.Name = "button_Display";
            this.button_Display.Size = new System.Drawing.Size(75, 23);
            this.button_Display.TabIndex = 15;
            this.button_Display.Text = "&Display All";
            this.button_Display.UseVisualStyleBackColor = true;
            this.button_Display.Click += new System.EventHandler(this.button_Display_Click);
            // 
            // Product_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Display);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.dgvInventory);
            this.Name = "Product_List";
            this.Text = "Product_List";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.RadioButton rbProductName;
        private System.Windows.Forms.RadioButton rbProductID;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.RadioButton rbItemType;
        private System.Windows.Forms.RadioButton rbItemDesc;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rbItemQuantity;
        private System.Windows.Forms.RadioButton rbSafetyLevel;
        private System.Windows.Forms.RadioButton rbExpired;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Display;
    }
}