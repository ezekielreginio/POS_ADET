using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_ADET.Classes.DAL.Models
{
    
    public class ReturnData
    {
        private string name;
        private int qty;
        private string type;
        

        public string Name { get => name; set => name = value; }
        public int Qty { get => qty; set => qty = value; }
        public string Type { get => type; set => type = value; }
        
        
    }
    
}
