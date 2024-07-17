namespace IT112P_LabExer6
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label_Uname = new System.Windows.Forms.Label();
            this.label_Pword = new System.Windows.Forms.Label();
            this.textBox_Pword = new System.Windows.Forms.TextBox();
            this.textBox_Uname = new System.Windows.Forms.TextBox();
            this.groupBox_Admin = new System.Windows.Forms.GroupBox();
            this.comboBox_AccessType = new System.Windows.Forms.ComboBox();
            this.label_Role = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.label_DateTime = new System.Windows.Forms.Label();
            this.timer_DateTime = new System.Windows.Forms.Timer(this.components);
            this.groupBox_Admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Uname
            // 
            this.label_Uname.AutoSize = true;
            this.label_Uname.Location = new System.Drawing.Point(29, 37);
            this.label_Uname.Name = "label_Uname";
            this.label_Uname.Size = new System.Drawing.Size(58, 13);
            this.label_Uname.TabIndex = 0;
            this.label_Uname.Text = "Username:";
            // 
            // label_Pword
            // 
            this.label_Pword.AutoSize = true;
            this.label_Pword.Location = new System.Drawing.Point(31, 66);
            this.label_Pword.Name = "label_Pword";
            this.label_Pword.Size = new System.Drawing.Size(56, 13);
            this.label_Pword.TabIndex = 1;
            this.label_Pword.Text = "Password:";
            // 
            // textBox_Pword
            // 
            this.textBox_Pword.Location = new System.Drawing.Point(117, 63);
            this.textBox_Pword.Name = "textBox_Pword";
            this.textBox_Pword.PasswordChar = '*';
            this.textBox_Pword.Size = new System.Drawing.Size(159, 20);
            this.textBox_Pword.TabIndex = 1;
            // 
            // textBox_Uname
            // 
            this.textBox_Uname.Location = new System.Drawing.Point(117, 34);
            this.textBox_Uname.Name = "textBox_Uname";
            this.textBox_Uname.Size = new System.Drawing.Size(159, 20);
            this.textBox_Uname.TabIndex = 0;
            // 
            // groupBox_Admin
            // 
            this.groupBox_Admin.Controls.Add(this.comboBox_AccessType);
            this.groupBox_Admin.Controls.Add(this.label_Role);
            this.groupBox_Admin.Controls.Add(this.label_Pword);
            this.groupBox_Admin.Controls.Add(this.button_Cancel);
            this.groupBox_Admin.Controls.Add(this.textBox_Pword);
            this.groupBox_Admin.Controls.Add(this.button_OK);
            this.groupBox_Admin.Controls.Add(this.textBox_Uname);
            this.groupBox_Admin.Controls.Add(this.label_Uname);
            this.groupBox_Admin.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Admin.Name = "groupBox_Admin";
            this.groupBox_Admin.Size = new System.Drawing.Size(349, 159);
            this.groupBox_Admin.TabIndex = 4;
            this.groupBox_Admin.TabStop = false;
            this.groupBox_Admin.Text = "Login";
            // 
            // comboBox_AccessType
            // 
            this.comboBox_AccessType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AccessType.FormattingEnabled = true;
            this.comboBox_AccessType.Items.AddRange(new object[] {
            "Administrator",
            "Guest"});
            this.comboBox_AccessType.Location = new System.Drawing.Point(117, 94);
            this.comboBox_AccessType.Name = "comboBox_AccessType";
            this.comboBox_AccessType.Size = new System.Drawing.Size(111, 21);
            this.comboBox_AccessType.TabIndex = 2;
            // 
            // label_Role
            // 
            this.label_Role.AutoSize = true;
            this.label_Role.Location = new System.Drawing.Point(31, 97);
            this.label_Role.Name = "label_Role";
            this.label_Role.Size = new System.Drawing.Size(72, 13);
            this.label_Role.TabIndex = 13;
            this.label_Role.Text = "Access Type:";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(201, 130);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 4;
            this.button_Cancel.Text = "&Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(117, 130);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 3;
            this.button_OK.Text = "&OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label_DateTime
            // 
            this.label_DateTime.AutoSize = true;
            this.label_DateTime.Location = new System.Drawing.Point(249, 182);
            this.label_DateTime.Name = "label_DateTime";
            this.label_DateTime.Size = new System.Drawing.Size(112, 13);
            this.label_DateTime.TabIndex = 5;
            this.label_DateTime.Text = "mm/dd/yyyy hh:mm:ss";
            // 
            // timer_DateTime
            // 
            this.timer_DateTime.Enabled = true;
            this.timer_DateTime.Tick += new System.EventHandler(this.timer_DateTime_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 206);
            this.Controls.Add(this.label_DateTime);
            this.Controls.Add(this.groupBox_Admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.groupBox_Admin.ResumeLayout(false);
            this.groupBox_Admin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Uname;
        private System.Windows.Forms.Label label_Pword;
        private System.Windows.Forms.TextBox textBox_Pword;
        public System.Windows.Forms.TextBox textBox_Uname;
        private System.Windows.Forms.GroupBox groupBox_Admin;
        public System.Windows.Forms.Label label_DateTime;
        private System.Windows.Forms.Timer timer_DateTime;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_OK;
        public System.Windows.Forms.ComboBox comboBox_AccessType;
        private System.Windows.Forms.Label label_Role;
    }
}