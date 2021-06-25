using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_ADET.DAL.Models
{
    class ItemCatalog
    {
        public int code { get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public int qty { get; set; }
        public string photo { get; set; }
    }
}
