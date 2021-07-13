using POS_ADET.Classes.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_ADET.Controls.Receipt
{
    public partial class ReceiptItem : UserControl
    {
        private TransactionItem transactionItem = new TransactionItem();


        public ReceiptItem()
        {
            InitializeComponent();
        }

        internal TransactionItem TransactionItem { get => transactionItem; set => transactionItem = value; }

        public void setItemName(string value)
        {
            lblItemName.Text = value;
        }
        
        public void setItemPrice(string value)
        {
            lblPrice.Text = value;
        }

        public void setItemData(TransactionItem item)
        {
            lblItemName.Text = item.ItemName;
            lblPrice.Text = item.Price.ToString("F");
            lblQty.Text = item.Qty.ToString();
            lblTotal.Text = (item.Price * item.Qty).ToString("F");
        }

    }
}
