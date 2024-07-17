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
    public partial class ItemInventory : Form
    {
        public ItemInventory()
        {
            InitializeComponent();
            FillTable();
        }

        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = this.dgvInventory.Rows[e.RowIndex];
            txtItemID.Text = row.Cells[0].Value.ToString();
            txtItemName.Text = row.Cells[1].Value.ToString();
            cmbItemType.Text = row.Cells[2].Value.ToString();
            txtItemDesc.Text = row.Cells[3].Value.ToString();
            label_DateTime.Text = row.Cells[4].Value.ToString();
            txtItemQuantity.Text = row.Cells[5].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string itemid, itemname, date_add, itemdesc,itemtype, date_exp;
            int itemquantity;
            int expirydays = 10;

            System.DateTime today = System.DateTime.Now;
            System.DateTime expire = today.AddDays(expirydays); //setting the expiry date 

            itemtype = cmbItemType.SelectedItem.ToString();
            itemid = txtItemID.Text;
            itemname = txtItemName.Text;
            itemdesc = txtItemDesc.Text;
            date_add = label_DateTime.Text;
            date_exp = expire.ToShortDateString(); //expiration date should be in short date format like in MS Access
            itemquantity = int.Parse(txtItemQuantity.Text);

            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=UserData.Mdb");
            connect.Open();
            string insertinventory = "INSERT INTO ItemInventory VALUES('"+itemid+"', '"+itemname+"', '"+itemdesc+"', '"+date_add+"', '"+itemquantity+"', '"+itemtype+"', '"+date_exp+"')";
            OleDbCommand execute = new OleDbCommand(insertinventory, connect);
            execute.ExecuteNonQuery();
            connect.Close();
            DialogResult res = MessageBox.Show("Data Insertion Successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                FillTable();
            }
            btnClearItem_Click(null, null);
        }

        private void btnClearItem_Click(object sender, EventArgs e)
        {
            txtItemID.Clear();
            txtItemName.Clear();
            txtItemDesc.Clear();
            txtItemQuantity.Clear();
            cmbItemType.SelectedIndex = -1;
            txtItemID.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FillTable()
        {
            OleDbConnection connect = new OleDbConnection(@"Provider=Microsoft.Jet.OleDb.4.0; Data Source=UserData.Mdb");
            connect.Open();
            string selectinv = "SELECT itemid as [Item ID], itemname as [Item Name], itemtype as [Item Type], itemdesc as [Item Description], date_add as [Date Added], quantity as [Item Quantity], date_exp as [Date of Expiration] FROM ItemInventory";
            OleDbDataAdapter adapt = new OleDbDataAdapter(selectinv, connect);
            DataTable mytable = new DataTable();
            adapt.Fill(mytable);
            dgvInventory.DataSource = mytable;
        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvInventory.Rows[e.RowIndex];
            txtItemID.Text = row.Cells[0].Value.ToString();
            txtItemName.Text = row.Cells[1].Value.ToString();
            cmbItemType.Text = row.Cells[2].Value.ToString();
            txtItemDesc.Text = row.Cells[3].Value.ToString();
            txtItemQuantity.Text = row.Cells[5].Value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_DateTime.Text = System.DateTime.Now.ToString();
        }
    }
}
