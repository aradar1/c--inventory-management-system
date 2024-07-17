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
    public partial class PurchaseHistory : Form
    {
        public PurchaseHistory()
        {
            InitializeComponent();
        }

        private void rbQuantity_CheckedChanged(object sender, EventArgs e)
        {
            if (rbQuantity.Checked == true)
            {
                OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=UserData.Mdb");
                connect.Open();
                string mostsql = "Select quantity as Quantity, Product_ID as [Product ID], price as [Price], amount as [Amount], Product_Name as [Product Name] FROM SalesReport Order by quantity desc";
                OleDbDataAdapter read = new OleDbDataAdapter(mostsql, connect);
                DataTable mytable = new DataTable();
                read.Fill(mytable);
                dgvInventory.DataSource = mytable;
                connect.Close();
            }
        }

        private void rbTransactionID_CheckedChanged(object sender, EventArgs e)
        {
            if(rbTransactionID.Checked==true)
            {
                OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=UserData.Mdb");
                connect.Open();
                string transactionsql = "Select Transaction_ID as [Transaction ID],quantity as Quantity, Product_ID as [Product ID], price as [Price], amount as [Amount], Product_Name as [Product Name] FROM SalesReport";
                OleDbDataAdapter read = new OleDbDataAdapter(transactionsql, connect);
                DataTable mytable = new DataTable();
                read.Fill(mytable);
                dgvInventory.DataSource = mytable;
                connect.Close();
            }

        }

        private void rbDateOfTransaction_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbProductName_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbGross_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbQuantity2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbQuantity2.Checked == true)
            {
                OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=UserData.Mdb");
                connect.Open();
                string leastsql = "Select quantity as Quantity, Product_ID as [Product ID], price as [Price], amount as [Amount], Product_Name as [Product Name] FROM SalesReport Order by quantity asc";
                OleDbDataAdapter read = new OleDbDataAdapter(leastsql, connect);
                DataTable mytable = new DataTable();
                read.Fill(mytable);
                dgvInventory.DataSource = mytable;
                connect.Close();
            }
        }
 
    }
}
