using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace IT112P_LabExer6
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        /*For creating new user */
        private void button_OK_Click(object sender, EventArgs e)
        {
            OleDbConnection fideldbconnect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=UserData.Mdb");
            fideldbconnect.Open();

            string insertsql = "INSERT INTO Information VALUES('" + textBox_Fname.Text + "', '" + textBox_Lname.Text + "', '" + maskedTextBox_Mobile.Text + "', '" + textBox_Uname.Text + "', '" + textBox_Pword.Text + "', '" + comboBox_AccessType.Text + "')";
         /* string selectsql = "SELECT u_name FROM Information WHERE u_name='"+textBox_Uname.Text+"'";

            OleDbCommand dbcommand1 = new OleDbCommand(selectsql, fideldbconnect);
            OleDbDataReader dbreader1 = dbcommand1.ExecuteReader();
            dbreader1.Read(); */

            OleDbCommand dbcommand = new OleDbCommand(insertsql, fideldbconnect);
            dbcommand.ExecuteNonQuery();
            fideldbconnect.Close();
            MessageBox.Show("New user created!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearAll(null, null);
        }

        /*Method for clearing all the fields
          Used when ClEAR button is pressed or after a new user is successfully created*/
        private void ClearAll(object sender, EventArgs e)
        {
            textBox_Fname.Clear();
            textBox_Lname.Clear();
            maskedTextBox_Mobile.Clear();
            textBox_Uname.Clear();
            textBox_Pword.Clear();
            comboBox_AccessType.SelectedIndex = -1;
            textBox_Fname.Focus();
        }

        /*For CLEAR button*/
        private void button_Clear_Click(object sender, EventArgs e)
        {
            ClearAll(null,null);
        }

        /*For CANCEL button*/
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
