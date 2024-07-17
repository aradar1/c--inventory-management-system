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
    public partial class NewProductForm : Form
    {
       
        public NewProductForm()
        {
            InitializeComponent();
            FillTable();
            OleDbConnection newcart = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=UserData.Mdb");
            newcart.Open();
            string deleteold = "DELETE * FROM ShoppingCart";
            OleDbCommand del = new OleDbCommand(deleteold, newcart);
            del.ExecuteNonQuery();
            newcart.Close();
            DisableFields(null, null);
        }
        private void maxstocks()
        {
            int stocks;
            stocks = int.Parse(txtStocks.Text);
            numQuantity.Maximum = stocks;
            int val = Convert.ToInt32(Math.Round(numQuantity.Value, 0));
            if (val > stocks)
            {
                MessageBox.Show("NOT ENOUGH STOCKS");
            }
        }
        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EnableFields(null, null);
        //    maxstocks();
            DataGridViewRow row = this.dgvInventory.Rows[e.RowIndex];
        //    txtItemID.Text = row.Cells[0].Value.ToString();
            txtItemName.Text = row.Cells[0].Value.ToString();
            txtStocks.Text = row.Cells[1].Value.ToString();
            
       //     cmbItemType.Text = row.Cells[1].Value.ToString();
         //   txtItemDesc.Text = row.Cells[2].Value.ToString();
          //  txtItemQuantity.Text = row.Cells[4].Value.ToString();

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OleDbConnection fideldbconnect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=UserData.Mdb");
            fideldbconnect.Open();
            try
            {
                //counter += Convert.ToInt32(Math.Round(numQuantity.Value, 0));
                string invsql = "Select itemname,quantity from ItemInventory Where itemname ='" + txtItemName.Text + "'";
                string cartsql = "Select itemname,quantity from ShoppingCart Where itemname ='" + txtItemName.Text + "'";
                OleDbCommand checkinv = new OleDbCommand(invsql, fideldbconnect);
                OleDbCommand checkcart = new OleDbCommand(cartsql, fideldbconnect);
                OleDbDataReader readinv = checkinv.ExecuteReader();
                OleDbDataReader readcart = checkcart.ExecuteReader();
                readinv.Read();
                readcart.Read();
                if (readinv.HasRows && readcart.HasRows)
                {
                    if (Convert.ToInt32(readcart["quantity"]) > Convert.ToInt32(readinv["quantity"]))
                    {
                        MessageBox.Show("We do not have enough stocks.", "Limited Stocks", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        numQuantity.Value = 1;
                    }
                    else if (readinv["itemname"].ToString() == txtItemName.Text)
                    {
                        int up = 0, down = 0;
                        up = Convert.ToInt32(readcart["quantity"]) + Convert.ToInt32(Math.Round(numQuantity.Value, 0));
                        down = Convert.ToInt32(readinv["quantity"]) - Convert.ToInt32(Math.Round(numQuantity.Value, 0));
                        string updatecart = "UPDATE ShoppingCart SET quantity=" + up + " WHERE itemname ='" + txtItemName.Text + "'";
                       // string updateinv = "UPDATE ItemInventory SET quantity=" + down + " WHERE itemname = '" + txtItemName.Text + "'";
                        OleDbCommand updatec = new OleDbCommand(updatecart, fideldbconnect);
                       // OleDbCommand updatei = new OleDbCommand(updateinv, fideldbconnect);
                        updatec.ExecuteNonQuery();
                       // updatei.ExecuteNonQuery();

                        FillTable();
                        FillTable2();
                    }
                }
                  else
                    {
                        // string itemname, date_e, itemdesc;

                        //     itemid = txtItemID.Text;
                        // itemname = txtItemName.Text;
                        // itemdesc = txtItemDesc.Text;
                        // date_e = System.DateTime.Now.ToString();
                        int down = 0;
                        down = Convert.ToInt32(readinv["quantity"]) - Convert.ToInt32(Math.Round(numQuantity.Value, 0));
                        int val = Convert.ToInt32(Math.Round(numQuantity.Value, 0));
                        string insertcart = "INSERT INTO ShoppingCart VALUES('" + txtItemName.Text + "', " + numQuantity.Value + ")";
          //              string updateinv = "UPDATE ItemInventory SET quantity=" + down + " WHERE itemname = '" + txtItemName.Text + "'";
                        
                        /* string selectsql = "SELECT u_name FROM Information WHERE u_name='"+textBox_Uname.Text+"'";

                           OleDbCommand dbcommand1 = new OleDbCommand(selectsql, fideldbconnect);
                           OleDbDataReader dbreader1 = dbcommand1.ExecuteReader();
                           dbreader1.Read(); */

                        OleDbCommand dbcommand = new OleDbCommand(insertcart, fideldbconnect);
          //              OleDbCommand dbcommand1 = new OleDbCommand(updateinv, fideldbconnect);
                        dbcommand.ExecuteNonQuery();
          //              dbcommand1.ExecuteNonQuery();
                        // fideldbconnect.Close();
                        //    btnClearItem_Click(null, null);
                        FillTable();
                        FillTable2();
                    }

                
            }
            catch (OleDbException error)
            {
                MessageBox.Show(error.Message);
                Clear();
            }
            finally
            {
                fideldbconnect.Close();
                dgvInventory.Update();
                dgvInventory.Refresh();
                dataGridViewCart.Update();
                dataGridViewCart.Refresh();
            }


        }

        private void btnClearItem_Click(object sender, EventArgs e)
        {
          //  txtItemID.Clear();
            txtItemName.Clear();
            txtItemDesc.Clear();
         //   txtItemQuantity.Clear();
         //   cmbItemType.SelectedIndex = -1;
          //  txtItemID.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void FillTable()
        {
            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=UserData.Mdb");
            connect.Open();
            string selectinv = "SELECT itemname as [Item Name], quantity as [Quantity],price as [Price] FROM ItemInventory";
            OleDbDataAdapter dbadapter = new OleDbDataAdapter(selectinv, connect);
            DataTable mytable = new DataTable();
            dbadapter.Fill(mytable);
            dgvInventory.DataSource = mytable;
            connect.Close();
        }
        public void FillTable2()
        {
            int val = Convert.ToInt32(Math.Round(numQuantity.Value, 0));
            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=UserData.Mdb");
            connect.Open();
            string selectinv = "SELECT itemname as [Item Name], quantity as [Quantity] FROM [ShoppingCart]";
            OleDbDataAdapter dbadapter = new OleDbDataAdapter(selectinv, connect);
            DataTable mytable = new DataTable();
            dbadapter.Fill(mytable);
            dataGridViewCart.DataSource = mytable;
            connect.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_DateTime.Text = System.DateTime.Now.ToString();
        }

        private void DisableFields(object sender, EventArgs e)
        {
        //    txtItemID.Enabled = false;
            txtItemName.Enabled = false;
          //  txtItemQuantity.Enabled = false;
            txtItemDesc.Enabled = false;
        }

        private void EnableFields(object sender, EventArgs e)
        {
            txtItemName.Enabled = true;
          //  txtItemQuantity.Enabled = true;
            txtItemDesc.Enabled = true;
        }

     
        private void UpdateItem_Load(object sender, EventArgs e)
        {

        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            maxstocks();

        }

        private void NewProductForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridViewCart.Rows[e.RowIndex];
            //    txtItemID.Text = row.Cells[0].Value.ToString();
          
        }
        public void Clear()
        {
            txtItemDesc.Clear();
            txtStocks.Clear();
            txtuserName.Clear();
            txtItemName.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            OleDbConnection dbconnect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=UserData.Mdb");
            dbconnect.Open();
            string invsql = "Select itemname,quantity from ItemInventory Where itemname ='" + txtItemName.Text + "'";
            OleDbCommand checkinv = new OleDbCommand(invsql, dbconnect);
            OleDbDataReader readinv = checkinv.ExecuteReader();
            readinv.Read();
            int down = 0;
            down = Convert.ToInt32(readinv["quantity"]) - Convert.ToInt32(Math.Round(numQuantity.Value, 0));
            string updateinv = "UPDATE ItemInventory SET quantity=" + down + " WHERE itemname = '" + txtItemName.Text + "'";
            OleDbCommand updatei = new OleDbCommand(updateinv, dbconnect);
            updatei.ExecuteNonQuery();
            FillTable();
            FillTable2();

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

   
    }
}
