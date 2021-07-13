using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_ADET.Classes.DAL.Models
{
    public class TransactionItem
    {
        private int code;
        private double price;
        private int qty;
        private string itemName;

        public int Code { get => code; set => code = value; }
        public double Price { get => price; set => price = value; }
        public int Qty { get => qty; set => qty = value; }
        public string ItemName { get => itemName; set => itemName = value; }
    }
}
