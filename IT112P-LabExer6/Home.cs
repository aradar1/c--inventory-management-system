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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            DisableMenu(null, null);
        }

        /*disable menu by defualt prior to login*/
        public void DisableMenu(object sender, EventArgs e)
        {
            newUserToolStripMenuItem.Enabled = false;
            updateUserToolStripMenuItem.Enabled = false;
            deleteUserToolStripMenuItem.Enabled = false;
            addNewProductToolStripMenuItem.Enabled = false;
            updateProductInfoToolStripMenuItem.Enabled = false;
            purchaseHistoryToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = false;
            loginToolStripMenuItem.Enabled = true;
        }

        /*enable menu when ADMIN account is confirmed*/
        public void EnableMenu(string access)
        {
            if (access == "Administrator")
            {
                newUserToolStripMenuItem.Enabled = true;
                updateUserToolStripMenuItem.Enabled = true;
                deleteUserToolStripMenuItem.Enabled = true;
                addNewProductToolStripMenuItem.Enabled = true;
                updateProductInfoToolStripMenuItem.Enabled = true;
                purchaseHistoryToolStripMenuItem.Enabled = true;
                logoutToolStripMenuItem.Enabled = true;
                loginToolStripMenuItem.Enabled = false;
            }
            else
            {
                logoutToolStripMenuItem.Enabled = true;
                loginToolStripMenuItem.Enabled = false;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg = "A machine problem created by Fidel, Boholst, Ollet and Panganiban \nfor IT112P.";
            MessageBox.Show(msg, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string userAction = "Logout";

            string username, access, datetime;

            /*retrieval of values from the Global class*/
            username = Global.iniVar.sResult1;
            access = Global.iniVar.sResult2;
            datetime = System.DateTime.Now.ToString();

            OleDbConnection fideldbconnect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=UserData.Mdb");
            fideldbconnect.Open();
            string insertlogout = "INSERT INTO UserLog(u_name, access_type, date_time, log_event) VALUES('" + username + "', '" + access + "', '" + datetime + "', '" + userAction + "')";
            OleDbCommand dbcommand = new OleDbCommand(insertlogout, fideldbconnect);
            dbcommand.ExecuteNonQuery();

            DisableMenu(null, null);
            MessageBox.Show("Logout successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewUser newuser = new NewUser();
            newuser.ShowDialog();
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateUser update = new UpdateUser();
            update.ShowDialog();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteUser delete = new DeleteUser();
            delete.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemInventory newitem = new ItemInventory();
            newitem.ShowDialog();
        }

        private void updateProductInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateItem updateitem = new UpdateItem();
            updateitem.ShowDialog();
        }

        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product_List list = new Product_List();
            list.ShowDialog();
        }

        private void receiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Receipt rec = new Receipt();
            rec.ShowDialog();
        }

        private void purchaseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseHistory ph = new PurchaseHistory();
            ph.ShowDialog();
        }

        private void purchaseProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm pf = new ProductForm();
            pf.ShowDialog();
        }
    }
}
