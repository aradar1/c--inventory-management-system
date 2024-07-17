﻿namespace IT112P_LabExer6
{
    partial class DeleteUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteUser));
            this.dataGridView_Delete = new System.Windows.Forms.DataGridView();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.groupBox_UpdateUser = new System.Windows.Forms.GroupBox();
            this.groupBox_Create = new System.Windows.Forms.GroupBox();
            this.comboBox_AccessType = new System.Windows.Forms.ComboBox();
            this.label_Role = new System.Windows.Forms.Label();
            this.label_Pword = new System.Windows.Forms.Label();
            this.textBox_Pword = new System.Windows.Forms.TextBox();
            this.textBox_Uname = new System.Windows.Forms.TextBox();
            this.label_Uname = new System.Windows.Forms.Label();
            this.label_Mobile = new System.Windows.Forms.Label();
            this.maskedTextBox_Mobile = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Lname = new System.Windows.Forms.TextBox();
            this.textBox_Fname = new System.Windows.Forms.TextBox();
            this.label_Lname = new System.Windows.Forms.Label();
            this.label_Fname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Delete)).BeginInit();
            this.groupBox_UpdateUser.SuspendLayout();
            this.groupBox_Create.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Delete
            // 
            this.dataGridView_Delete.AllowUserToAddRows = false;
            this.dataGridView_Delete.AllowUserToDeleteRows = false;
            this.dataGridView_Delete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Delete.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Delete.Name = "dataGridView_Delete";
            this.dataGridView_Delete.ReadOnly = true;
            this.dataGridView_Delete.Size = new System.Drawing.Size(689, 458);
            this.dataGridView_Delete.TabIndex = 0;
            this.dataGridView_Delete.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Delete_CellClick);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(848, 390);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 0;
            this.button_Delete.Text = "&Delete User";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(929, 390);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 1;
            this.button_Cancel.Text = "&Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // groupBox_UpdateUser
            // 
            this.groupBox_UpdateUser.Controls.Add(this.groupBox_Create);
            this.groupBox_UpdateUser.Controls.Add(this.label_Mobile);
            this.groupBox_UpdateUser.Controls.Add(this.maskedTextBox_Mobile);
            this.groupBox_UpdateUser.Controls.Add(this.textBox_Lname);
            this.groupBox_UpdateUser.Controls.Add(this.textBox_Fname);
            this.groupBox_UpdateUser.Controls.Add(this.label_Lname);
            this.groupBox_UpdateUser.Controls.Add(this.label_Fname);
            this.groupBox_UpdateUser.Location = new System.Drawing.Point(713, 75);
            this.groupBox_UpdateUser.Name = "groupBox_UpdateUser";
            this.groupBox_UpdateUser.Size = new System.Drawing.Size(374, 309);
            this.groupBox_UpdateUser.TabIndex = 2;
            this.groupBox_UpdateUser.TabStop = false;
            this.groupBox_UpdateUser.Text = "User Information";
            // 
            // groupBox_Create
            // 
            this.groupBox_Create.Controls.Add(this.comboBox_AccessType);
            this.groupBox_Create.Controls.Add(this.label_Role);
            this.groupBox_Create.Controls.Add(this.label_Pword);
            this.groupBox_Create.Controls.Add(this.textBox_Pword);
            this.groupBox_Create.Controls.Add(this.textBox_Uname);
            this.groupBox_Create.Controls.Add(this.label_Uname);
            this.groupBox_Create.Location = new System.Drawing.Point(51, 169);
            this.groupBox_Create.Name = "groupBox_Create";
            this.groupBox_Create.Size = new System.Drawing.Size(300, 127);
            this.groupBox_Create.TabIndex = 6;
            this.groupBox_Create.TabStop = false;
            this.groupBox_Create.Text = "Update Account";
            // 
            // comboBox_AccessType
            // 
            this.comboBox_AccessType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AccessType.Enabled = false;
            this.comboBox_AccessType.FormattingEnabled = true;
            this.comboBox_AccessType.Items.AddRange(new object[] {
            "Administrator",
            "Guest"});
            this.comboBox_AccessType.Location = new System.Drawing.Point(118, 95);
            this.comboBox_AccessType.Name = "comboBox_AccessType";
            this.comboBox_AccessType.Size = new System.Drawing.Size(111, 21);
            this.comboBox_AccessType.TabIndex = 5;
            // 
            // label_Role
            // 
            this.label_Role.AutoSize = true;
            this.label_Role.Location = new System.Drawing.Point(32, 98);
            this.label_Role.Name = "label_Role";
            this.label_Role.Size = new System.Drawing.Size(72, 13);
            this.label_Role.TabIndex = 13;
            this.label_Role.Text = "Access Type:";
            // 
            // label_Pword
            // 
            this.label_Pword.AutoSize = true;
            this.label_Pword.Location = new System.Drawing.Point(32, 67);
            this.label_Pword.Name = "label_Pword";
            this.label_Pword.Size = new System.Drawing.Size(56, 13);
            this.label_Pword.TabIndex = 8;
            this.label_Pword.Text = "Password:";
            // 
            // textBox_Pword
            // 
            this.textBox_Pword.Enabled = false;
            this.textBox_Pword.Location = new System.Drawing.Point(118, 64);
            this.textBox_Pword.Name = "textBox_Pword";
            this.textBox_Pword.PasswordChar = '*';
            this.textBox_Pword.Size = new System.Drawing.Size(159, 20);
            this.textBox_Pword.TabIndex = 4;
            // 
            // textBox_Uname
            // 
            this.textBox_Uname.Enabled = false;
            this.textBox_Uname.Location = new System.Drawing.Point(118, 35);
            this.textBox_Uname.Name = "textBox_Uname";
            this.textBox_Uname.Size = new System.Drawing.Size(159, 20);
            this.textBox_Uname.TabIndex = 3;
            // 
            // label_Uname
            // 
            this.label_Uname.AutoSize = true;
            this.label_Uname.Location = new System.Drawing.Point(30, 38);
            this.label_Uname.Name = "label_Uname";
            this.label_Uname.Size = new System.Drawing.Size(58, 13);
            this.label_Uname.TabIndex = 7;
            this.label_Uname.Text = "Username:";
            // 
            // label_Mobile
            // 
            this.label_Mobile.AutoSize = true;
            this.label_Mobile.Location = new System.Drawing.Point(48, 119);
            this.label_Mobile.Name = "label_Mobile";
            this.label_Mobile.Size = new System.Drawing.Size(41, 13);
            this.label_Mobile.TabIndex = 5;
            this.label_Mobile.Text = "Mobile:";
            // 
            // maskedTextBox_Mobile
            // 
            this.maskedTextBox_Mobile.Enabled = false;
            this.maskedTextBox_Mobile.Location = new System.Drawing.Point(124, 116);
            this.maskedTextBox_Mobile.Mask = "9999-999-9999";
            this.maskedTextBox_Mobile.Name = "maskedTextBox_Mobile";
            this.maskedTextBox_Mobile.Size = new System.Drawing.Size(143, 20);
            this.maskedTextBox_Mobile.TabIndex = 2;
            // 
            // textBox_Lname
            // 
            this.textBox_Lname.Enabled = false;
            this.textBox_Lname.Location = new System.Drawing.Point(124, 74);
            this.textBox_Lname.Name = "textBox_Lname";
            this.textBox_Lname.Size = new System.Drawing.Size(227, 20);
            this.textBox_Lname.TabIndex = 1;
            // 
            // textBox_Fname
            // 
            this.textBox_Fname.Enabled = false;
            this.textBox_Fname.Location = new System.Drawing.Point(124, 38);
            this.textBox_Fname.Name = "textBox_Fname";
            this.textBox_Fname.Size = new System.Drawing.Size(227, 20);
            this.textBox_Fname.TabIndex = 0;
            // 
            // label_Lname
            // 
            this.label_Lname.AutoSize = true;
            this.label_Lname.Location = new System.Drawing.Point(48, 77);
            this.label_Lname.Name = "label_Lname";
            this.label_Lname.Size = new System.Drawing.Size(56, 13);
            this.label_Lname.TabIndex = 1;
            this.label_Lname.Text = "Lastname:";
            // 
            // label_Fname
            // 
            this.label_Fname.AutoSize = true;
            this.label_Fname.Location = new System.Drawing.Point(48, 41);
            this.label_Fname.Name = "label_Fname";
            this.label_Fname.Size = new System.Drawing.Size(55, 13);
            this.label_Fname.TabIndex = 0;
            this.label_Fname.Text = "Firstname:";
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 483);
            this.Controls.Add(this.groupBox_UpdateUser);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.dataGridView_Delete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DeleteUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete User";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Delete)).EndInit();
            this.groupBox_UpdateUser.ResumeLayout(false);
            this.groupBox_UpdateUser.PerformLayout();
            this.groupBox_Create.ResumeLayout(false);
            this.groupBox_Create.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Delete;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.GroupBox groupBox_UpdateUser;
        private System.Windows.Forms.GroupBox groupBox_Create;
        private System.Windows.Forms.ComboBox comboBox_AccessType;
        private System.Windows.Forms.Label label_Role;
        private System.Windows.Forms.Label label_Pword;
        private System.Windows.Forms.TextBox textBox_Pword;
        private System.Windows.Forms.TextBox textBox_Uname;
        private System.Windows.Forms.Label label_Uname;
        private System.Windows.Forms.Label label_Mobile;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Mobile;
        private System.Windows.Forms.TextBox textBox_Lname;
        private System.Windows.Forms.TextBox textBox_Fname;
        private System.Windows.Forms.Label label_Lname;
        private System.Windows.Forms.Label label_Fname;
    }
}