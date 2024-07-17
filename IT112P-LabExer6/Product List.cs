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
    public partial class Product_List : Form
    {
        public Product_List()
        {
            InitializeComponent();
            FillTable();
        }

        private void rbProductID_CheckedChanged(object sender, EventArgs e) //radio button for product ID
        {
           if(rbProductID.Checked==true)
            {
                OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=UserData.Mdb");
                connect.Open();
                string selectproductid = "SELECT itemid as [Item ID], itemname as [Item Name], itemtype as [Item Type], itemdesc as [Item Description], date_add as [Date Added], quantity as [Quantity] FROM ItemInventory WHERE itemid LIKE '%"+cbSearch.Text+"%'";
                OleDbDataAdapter dbadapter = new OleDbDataAdapter(selectproductid, connect);
                DataTable mytable = new DataTable();
                dbadapter.Fill(mytable);
                dgvInventory.DataSource = mytable;
                connect.Close();
            }
        }

        private void rbItemType_CheckedChanged(object sender, EventArgs e) //radio button for item type
        {
            if (rbItemType.Checked == true)
            {

                OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=UserData.Mdb");
                connect.Open();
                string selectitemdesc = "SELECT itemid as [Item ID], itemname as [Item Name], itemtype as [Item Type], itemdesc as [Item Description], date_add as [Date Added], quantity as [Quantity] FROM ItemInventory WHERE itemtype LIKE '%" + cbSearch.Text + "%'";
                OleDbDataAdapter dbadapter = new OleDbDataAdapter(selectitemdesc, connect);
                DataTable mytable = new DataTable();
                dbadapter.Fill(mytable);
                dgvInventory.DataSource = mytable;
                connect.Close();
            }
        }

        private void rbItemDesc_CheckedChanged(object sender, EventArgs e) //radio button for item description
        {
            if (rbItemDesc.Checked == true)
            {
                OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=UserData.Mdb");
                connect.Open();
                string selectitemdesc = "SELECT itemid as [Item ID], itemname as [Item Name], itemtype as [Item Type], itemdesc as [Item Description], date_add as [Date Added], quantity as [Quantity] FROM ItemInventory WHERE itemdesc LIKE '%" + cbSearch.Text + "%'";
                OleDbDataAdapter dbadapter = new OleDbDataAdapter(selectitemdesc, connect);
                DataTable mytable = new DataTable();
                dbadapter.Fill(mytable);
                dgvInventory.DataSource = mytable;
                connect.Close();
            }

        }

        private void rbProductName_CheckedChanged(object sender, EventArgs e) //radiobutton for product name
        {
            if (rbProductName.Checked == true)
            {
                OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=UserData.Mdb");
                connect.Open();
                string selectproductname = "SELECT itemid as [Item ID], itemname as [Item Name], itemtype as [Item Type], itemdesc as [Item Description], date_add as [Date Added], quantity as [Quantity] FROM ItemInventory WHERE itemname LIKE '%" + cbSearch.Text + "%'";
                OleDbDataAdapter dbadapter = new OleDbDataAdapter(selectproductname, connect);
                DataTable mytable = new DataTable();
                dbadapter.Fill(mytable);
                dgvInventory.DataSource = mytable;
                connect.Close();
            }

        }

        private void rbItemQuantity_CheckedChanged(object sender, EventArgs e) //radiobutton for item quantity
        {
            if (rbItemQuantity.Checked == true)
            {
                try
                {
                    OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=UserData.Mdb");
                    connect.Open();
                    string selectitemquantity = "SELECT itemid as [Item ID], itemname as [Item Name], itemtype as [Item Type], itemdesc as [Item Description], date_add as [Date Added], quantity as [Quantity] FROM ItemInventory WHERE quantity >= " + int.Parse(cbSearch.Text) + "";
                    OleDbDataAdapter dbadapter = new OleDbDataAdapter(selectitemquantity, connect);
                    DataTable mytable = new DataTable();
                    dbadapter.Fill(mytable);
                    dgvInventory.DataSource = mytable;
                    connect.Close();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter numbers only for this search!");
                }
            }
        }

        private void rbSafetyLevel_CheckedChanged(object sender, EventArgs e) //radio button for safety level
        {
            if (rbSafetyLevel.Checked == true)
                {
                    OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=UserData.Mdb");
                    connect.Open();
                    string safesql = "Select itemid as [Product ID],  itemname as [Product Name], quantity as [Quantity]  FROM ItemInventory WHERE quantity<=100 ORDER BY quantity DESC";
                    OleDbDataAdapter read = new OleDbDataAdapter(safesql, connect);
                    DataTable mytable = new DataTable();
                    read.Fill(mytable);
                    dgvInventory.DataSource = mytable;
                    connect.Close();
                }
            }

        private void rbExpired_CheckedChanged(object sender, EventArgs e) //radio button for expired products
        {
            if(rbExpired.Checked==true)
            {
                string datenow = System.DateTime.Now.ToShortDateString();
                OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=UserData.Mdb");
                connect.Open();
                string expiredsql = "Select date_add as [Date Added], itemid as [Item ID], itemname as [Item Name], quantity as [Item Quantity], date_exp as [Date of Expiration] FROM  ItemInventory WHERE Date() > date_exp";
                OleDbDataAdapter read = new OleDbDataAdapter(expiredsql, connect);
                DataTable mytable = new DataTable();
                read.Fill(mytable);
                dgvInventory.DataSource = mytable;
                connect.Close();
            }
        }

        private void cbSearch_KeyDown(object sender, KeyEventArgs e) //combobox search when ENTER key is pressed
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchvalue = cbSearch.Text;
                int cellnum = 0;

                dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                try
                {
                    dgvInventory.ClearSelection(); //clears the highlight every time a new search is conducted
                    foreach (DataGridViewRow row in dgvInventory.Rows)
                    {
                        if (row.Cells[cellnum].Value.ToString().Equals(searchvalue))
                        {
                            row.Selected = true; //highlights the item related to the PRODUCT ID typed in cbSearch
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e) //when a cell in datagridview is selected
        {
            try
            {
                DataGridViewRow row = this.dgvInventory.Rows[e.RowIndex];
                cbSearch.Text = row.Cells[1].Value.ToString(); //putting the ITEM NAME of the selected item to cbSearch
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void FillTable() //populating the datagridview
        {
            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=UserData.Mdb");
            connect.Open();
            string selectinv = "SELECT itemid as [Item ID], itemname as [Item Name], itemtype as [Item Type], itemdesc as [Item Description], date_add as [Date Added], quantity as [Quantity] FROM ItemInventory";
            OleDbDataAdapter dbadapter = new OleDbDataAdapter(selectinv, connect);
            DataTable mytable = new DataTable();
            dbadapter.Fill(mytable);
            dgvInventory.DataSource = mytable; //dgvInvetory name of data grid view.
            connect.Close();
        }

        private void button_Clear_Click(object sender, EventArgs e) //clears all fileds and radio button
        {
            rbExpired.Checked = false;
            rbItemDesc.Checked = false;
            rbItemQuantity.Checked = false;
            rbItemType.Checked = false;
            rbProductID.Checked = false;
            rbProductName.Checked = false;
            rbSafetyLevel.Checked = false;
            cbSearch.Text = null;
            cbSearch.SelectedIndex = -1;
            cbSearch.Focus();
            FillTable();
        }

        private void btnCancel_Click(object sender, EventArgs e) //cancel button
        {
            this.Close();
        }

        private void button_Display_Click(object sender, EventArgs e) //display all items from inventory
        {
            FillTable();
            button_Clear_Click(null,null);
        }
    }
    
}
