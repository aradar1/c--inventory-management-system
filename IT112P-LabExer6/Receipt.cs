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
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
            fillTable();
            lblDate.Text = DateTime.Now.ToString();
        }
        public void fillTable()
        {
            OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=UserData.Mdb");
            connection.Open();
            string receipt = "SELECT quantity as [Quantity],productname as [Product Name],price as [Price],amount as [Amount] FROM SalesReport";
            OleDbDataAdapter dbadapter = new OleDbDataAdapter(receipt, connection);
            DataTable myTable = new DataTable();
            dbadapter.Fill(myTable);
            dataReceipt.DataSource = myTable;
            connection.Close();
        }
        private void receipt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
