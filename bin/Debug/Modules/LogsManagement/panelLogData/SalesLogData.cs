using POS_ADET.Classes.DAL.Models;
using POS_ADET.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_ADET.Modules.LogsManagement.panelLogData
{
    public partial class SalesLogData : UserControl
    {
        private TransactionData transactionData;

        public TransactionData TransactionData { get => transactionData; set => transactionData = value; }

        public SalesLogData()
        {
            InitializeComponent();
        }
        public void setTransactionId(string value)
        {
            txtTransactionId.Text = value;
        }
        public void setTotalAmount(string value)
        {
            txtTotalAmount.Text = value;
        }
        public void setDate(string value)
        {
            txtDate.Text = value;
        }
        public void setdgvSalesItem(DataTable datatable)
        {
            dgvSalesItem.DataSource = datatable;
            dgvSalesItem.Columns["Item Name"].Width = 150;
        }

        private void dgvSalesItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Receipts receipt = new Receipts();
            receipt.addData(transactionData);
            receipt.Show();
        }
    }
}
