using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_ADET.Classes.DAL.Models
{
    class TotalTransaction
    {
        double totalAmount = 0;
        double tax = 0;
        double net = 0;

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
    }
}
