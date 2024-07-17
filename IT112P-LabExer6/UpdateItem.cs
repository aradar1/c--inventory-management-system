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
    public partial class UpdateItem : Form
    {
        public UpdateItem()
        {
            InitializeComponent();
            FillTable();
            DisableFields(null,null);
        }
        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EnableFields(null,null);
            DataGridViewRow row = this.dgvInventory.Rows[e.RowIndex];
            txtItemID.Text = row.Cells[0].Value.ToString();
            txtItemName.Text = row.Cells[1].Value.ToString();
            cmbItemType.Text = row.Cells[2].Value.ToString();
            txtItemDesc.Text = row.Cells[3].Value.ToString();
            txtItemQuantity.Text = row.Cells[4].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string itemid, itemname, date_add, itemdesc, itemtype, date_exp;
            int quantity;
            int expirydays = 10;

            System.DateTime today = System.DateTime.Now;
            System.DateTime expire = today.AddDays(expirydays); //setting the expiry date upon updation of items

            itemtype = cmbItemType.Text;
            itemid = txtItemID.Text;
            itemname = txtItemName.Text;
            itemdesc = txtItemDesc.Text;
            date_add = label_DateTime.Text;
            date_exp = expire.ToShortDateString(); //date of expiration should be in short date format like in MS Access
            quantity = int.Parse(txtItemQuantity.Text);

            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=UserData.Mdb");
            connect.Open();
            string updateinventory = "UPDATE ItemInventory SET itemid='"+itemid+"', itemname='"+itemname+"', itemtype='"+itemtype+"', itemdesc='"+itemdesc+"', date_add='"+date_add+"', quantity="+quantity+", date_exp='"+date_exp+"' WHERE itemid='"+itemid+"' ";
            OleDbCommand update = new OleDbCommand(updateinventory, connect);
            update.ExecuteNonQuery();
            connect.Close();
            DialogResult res = MessageBox.Show("Data Insertion Successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(res == DialogResult.OK)
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
            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=UserData.Mdb");
            connect.Open();
            string selectinv = "SELECT itemid as [Item ID], itemname as [Item Name], itemtype as [Item Type], itemdesc as [Item Description], quantity as [Quantity] FROM ItemInventory";
            OleDbDataAdapter dbadapter = new OleDbDataAdapter(selectinv, connect);
            DataTable mytable = new DataTable();
            dbadapter.Fill(mytable);
            dgvInventory.DataSource = mytable;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_DateTime.Text = System.DateTime.Now.ToString();
        }

        private void DisableFields(object sender, EventArgs e)
        {
            txtItemID.Enabled = false;
            txtItemName.Enabled = false;
            txtItemQuantity.Enabled = false;
            txtItemDesc.Enabled = false;
        }

        private void EnableFields(object sender, EventArgs e)
        {
            txtItemName.Enabled = true;
            txtItemQuantity.Enabled = true;
            txtItemDesc.Enabled = true;
        }
    }
}
