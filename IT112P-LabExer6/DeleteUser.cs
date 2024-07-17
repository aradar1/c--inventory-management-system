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
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
            FillTable();
        }
        /*when DELETE button is clicked*/
        private void button_Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                OleDbConnection fideldbconnect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=UserData.Mdb");
                fideldbconnect.Open();
                string selectsql = "DELETE * FROM Information WHERE user_firstname='" + textBox_Fname.Text + "' AND user_lastname='" + textBox_Lname.Text + "'";
                OleDbCommand fidelcmd = new OleDbCommand(selectsql, fideldbconnect);
                fidelcmd.ExecuteNonQuery();
                fideldbconnect.Close();
                DialogResult res = MessageBox.Show("Record deleted.", "Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    FillTable();
                }
                ClearAll(null,null);
            }
            else
            {
                FillTable();
                ClearAll(null,null);
            }
        }

        /*displays data in textboxes when any cell is clicked in the DataGridView*/
        private void dataGridView_Delete_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView_Delete.Rows[e.RowIndex];
            textBox_Fname.Text = row.Cells[0].Value.ToString();
            textBox_Lname.Text = row.Cells[1].Value.ToString();
            maskedTextBox_Mobile.Text = row.Cells[2].Value.ToString();
            textBox_Uname.Text = row.Cells[3].Value.ToString();
            textBox_Pword.Text = row.Cells[4].Value.ToString();
            comboBox_AccessType.Text = row.Cells[5].Value.ToString();
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
            dataGridView_Delete.DataSource = mytable;
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
        }

        /*when CANCEL button is clicked*/
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
