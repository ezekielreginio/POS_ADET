using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_ADET.Classes.DAL.Models
{
    public class TransactionData
    {

        private int transaction_id;
        private double totalAmount = 0;
        private double tax = 0;
        private double net = 0;
        private List<TransactionItem> items = new List<TransactionItem>();
        private double cash = 0;
        private DateTime transactionDate;
        
        public double TotalAmount
        {
            get => totalAmount;

            set
            {
                totalAmount = value;
                tax = totalAmount * 0.12;
                net = totalAmount - tax;
            }
        }
        public double Tax { get => tax; set => tax = value; }
        public double Net { get => net; set => net = value; }
        public double Cash { get => cash; set => cash = value; }
        public int Transaction_id { get => transaction_id; set => transaction_id = value; }
        public DateTime TransactionDate { get => transactionDate; set => transactionDate = value; }
        internal List<TransactionItem> Items { get => items; set => items = value; }

        public void setItemsFromDataTable(DataTable datatable)
        {
            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                items.Add(new TransactionItem { 
                    ItemName = datatable.Rows[i]["Item Name"].ToString(),
                    Price = Convert.ToDouble(datatable.Rows[i]["Price"]),
                    Qty = Convert.ToInt32(datatable.Rows[i]["Qty"])
                });
            }
        }

    }
    

}
