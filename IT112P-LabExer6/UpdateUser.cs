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
    public partial class UpdateUser : Form
    {
        public UpdateUser()
        {
            InitializeComponent();
            FillTable();
        }
        /*displays data in textboxes when any cell is clicked in the DataGridView*/
        private void dataGridView_Update_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = this.dataGridView_Update.Rows[e.RowIndex];
            textBox_Fname.Text = row.Cells[0].Value.ToString();
            textBox_Lname.Text = row.Cells[1].Value.ToString();
            maskedTextBox_Mobile.Text = row.Cells[2].Value.ToString();
            textBox_Uname.Text = row.Cells[3].Value.ToString();
            textBox_Pword.Text = row.Cells[4].Value.ToString();
            comboBox_AccessType.Text = row.Cells[5].Value.ToString();
        }
         /*when CANCEL button is clicked*/
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*when SAVE button is clicked*/
        private void button_Save_Click(object sender, EventArgs e)
        {
            OleDbConnection fideldbconnect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=UserData.Mdb");
            fideldbconnect.Open();
            string updatesql ="UPDATE Information SET user_firstname='"+textBox_Fname.Text+"', user_lastname='"+textBox_Lname.Text+"', mobile_num='"+maskedTextBox_Mobile.Text+"', u_name='"+textBox_Uname.Text+"', p_word='"+textBox_Pword.Text+"', access_type='"+comboBox_AccessType.SelectedItem.ToString()+ "' WHERE user_firstname='" + textBox_Fname.Text + "' AND user_lastname='" + textBox_Lname.Text + "'";
            OleDbCommand dbcommand = new OleDbCommand(updatesql, fideldbconnect);
            dbcommand.ExecuteNonQuery();
            fideldbconnect.Close();
            DialogResult result = MessageBox.Show("Update Successful.", "Success" ,MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                FillTable();
            }
            ClearAll(null,null);
        }
        /*method to clear fields*/
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

        /*method to fill DataGridView*/
        public void FillTable()
        {
            OleDbConnection fideldbconnect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=UserData.Mdb");
            fideldbconnect.Open();
            string selectsql = "SELECT user_firstname as [Firstname], user_lastname as [Lastname], mobile_num as [Mobile], u_name as [Username], p_word as [Password], access_type as [Access Type] FROM Information";
            OleDbDataAdapter dbadapter = new OleDbDataAdapter(selectsql, fideldbconnect);
            DataTable mytable = new DataTable();
            dbadapter.Fill(mytable);
            dataGridView_Update.DataSource = mytable;
        }
    }
}
