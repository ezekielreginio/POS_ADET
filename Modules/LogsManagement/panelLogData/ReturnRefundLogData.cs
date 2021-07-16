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
    public partial class ReturnRefundLogData : UserControl
    {
        //private List<ReturnItems> items = new List<ReturnItems>();
        //internal List<ReturnItems> Items { get => items; set => items = value; }
        public ReturnRefundLogData()
        {
            InitializeComponent();
        }
        public void setReturnTransactionId(string value)
        {
            txtReturnTransactionId.Text = value;
        }
        public void setTransactionId(string value)
        {
            txtTransactionId.Text = value;
        }
        public void setDate(string value)
        {
            txtDate.Text = value;
        }
        public void setdgvReturnItems(DataTable datatable)
        {
            dgvReturnItems.DataSource = datatable;
            dgvReturnItems.Columns["Name"].Width = 150;
            dgvReturnItems.Columns["Qty"].Width = 35;
            
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void log_id_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dgvReturnItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTransactionId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReturnTransactionId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
