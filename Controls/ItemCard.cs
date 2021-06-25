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
        private int _itemID;
        public ItemCard()
        {
            InitializeComponent();
        }
        
        public int itemID
        {
            get
            {
                return _itemID;
            }
            set
            {
                _itemID = value;
            }
        }

        public PictureBox GetPictureBox()
        {
            return pictureItem;
        }

        public Label GetItemName()
        {
            return labelItemName;
        }

        public Label GetItemPrice()
        {
            return labelPrice;
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
            //pictureItem.BackgroundImage = Properties.Resources.iphone;
            //pictureItem.Load(@"C:\Users\Zeke\Pictures\icons\products\iphone.jpg");
            if(imagePath != string.Empty)
                pictureItem.Load(imagePath+"&raw=1");
        }

        public void setSelected()
        {
            if ((Color)panelBorder.BackgroundColor == Color.Transparent)
            {
                panelBorder.BackgroundColor = Color.FromArgb(0, 126, 249);
                pictureChecked.Visible = true;
            }
            else
            {
                deselect();
            }
        }

        public void deselect()
        {
            panelBorder.BackgroundColor = Color.Transparent;
            pictureChecked.Visible = false;
            
        }

        private void ItemCard_Load(object sender, EventArgs e)
        {

        }

        private void pictureItem_Click(object sender, EventArgs e)
        {

            
            //Console.WriteLine(pictureItem.Parent.Parent.Parent);
            //Control control = pictureItem.Parent.Parent.Parent;

        }

        private void labelItemName_Paint(object sender, PaintEventArgs e)
        {
            labelItemName.Parent = pictureItem;
            
        }
    }
    
}
