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
            dgvReturnItems.Columns["Qty"].Width = 30;
            dgvReturnItems.Columns["Type"].Width = 50;
            s
        }
    }
}
