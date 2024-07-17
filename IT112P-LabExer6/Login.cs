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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        /*Timer for real-time date and time displayed thru a label control*/
        private void timer_DateTime_Tick(object sender, EventArgs e)
        {
            label_DateTime.Text = System.DateTime.Now.ToString();
        }

        /*When OK button is clicked*/
        private void button_OK_Click(object sender, EventArgs e)
        {
            var home = Application.OpenForms.OfType<Home>().Single(); /*creating an instance to access a method from another form*/

            OleDbConnection fideldbconnect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=UserData.Mdb"); /*setup connection to database*/
            fideldbconnect.Open();

            string uName = textBox_Uname.Text;
            string userAccess = comboBox_AccessType.SelectedItem.ToString();
            string dateTime = label_DateTime.Text;
            string userAction = "Login";

            /*to set values in the Global class and use it in Home form for Logout event*/
            Global.iniVar.sResult1 = uName;
            Global.iniVar.sResult2 = userAccess;
            Global.iniVar.sResult3 = dateTime;

            /*to check if an account exists*/
            string selectsql = "SELECT * FROM Information WHERE u_name='" + textBox_Uname.Text + "' AND p_word='" + textBox_Pword.Text + "' AND access_type='" + comboBox_AccessType.SelectedItem.ToString() + "'";
            /*for password case-sensitivity*/
            string selectpass = "SELECT p_word FROM Information WHERE p_word='" + textBox_Pword.Text + "'";
            /*for user-log record*/
            string insertlogin = "INSERT INTO UserLog(u_name, access_type, date_time, log_event) VALUES('" + uName + "', '" + userAccess + "', '" + dateTime + "', '" + userAction + "')";

            try
            {
                OleDbCommand dbcommand = new OleDbCommand(selectsql, fideldbconnect);
                OleDbDataReader dbreader = dbcommand.ExecuteReader();

                if (dbreader.HasRows)
                {
                    OleDbCommand dbcommand1 = new OleDbCommand(selectpass, fideldbconnect);
                    OleDbDataReader dbreader1 = dbcommand1.ExecuteReader();
                    dbreader1.Read();
                    if (dbreader1["p_word"].ToString() == textBox_Pword.Text)
                    {
                        home.EnableMenu(comboBox_AccessType.SelectedItem.ToString());
                        OleDbCommand dbcommand2 = new OleDbCommand(insertlogin, fideldbconnect);
                        dbcommand2.ExecuteNonQuery();
                        MessageBox.Show("Login successfull!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Login Unsuccessful. \nPlease check your input and make sure \nyour access type is correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        textBox_Uname.Clear();
                        textBox_Pword.Clear();
                        comboBox_AccessType.SelectedIndex = -1;
                        textBox_Uname.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Login Unsuccessful. \nPlease check your input and make sure \nyour access type is correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    textBox_Uname.Clear();
                    textBox_Pword.Clear();
                    comboBox_AccessType.SelectedIndex = -1;
                    textBox_Uname.Focus();
                }
            }
            catch (OleDbException error)
            {
                MessageBox.Show("Error: " + error.Message, "Error");
                textBox_Uname.Clear();
                textBox_Pword.Clear();
                comboBox_AccessType.SelectedIndex = -1;
                textBox_Uname.Focus();
            }
            finally
            {
                fideldbconnect.Close();
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e) /*when CANCEL button is clicked*/
        {
            this.Close();
        }
    }
}
