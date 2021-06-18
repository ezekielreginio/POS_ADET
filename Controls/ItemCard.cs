using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_ADET.Controls
{
    public partial class ItemCard : UserControl
    {
        public ItemCard()
        {
            InitializeComponent();
        }

        public void setItemName(string itemName)
        {
            labelItemName.Text = itemName;
        }

        public void setItemPrice(string itemPrice)
        {
            labelPrice.Text = "PHP "+itemPrice;
        }

        public void setItemImage(string imagePath)
        {
            pictureItem.Load(@"C:\Users\Zeke\Pictures\icons\products\iphone.jpg");
            //pictureItem.Load(imagePath+"&raw=1");
        }


        private void ItemCard_Load(object sender, EventArgs e)
        {

        }
    }
}
