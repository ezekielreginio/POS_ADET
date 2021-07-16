using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_ADET.Controls
{

    public partial class ItemCard : UserControl
    {
        private int _itemID;

        private DataGridViewRow rowPosition;

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

        public DataGridViewRow RowPosition { get => rowPosition; set => rowPosition = value; }

        public PictureBox GetPictureBox()
        {
            return pictureItem;
        }

        public Label GetItemName()
        {
            return labelItemName;
        }
        public void setItemName(string itemName)
        {
            labelItemName.Text = itemName;
        }

        public Label GetItemPrice()
        {
            return labelPrice;
        }
        public void setItemPrice(string itemPrice)
        {
            labelPrice.Text = "PHP "+itemPrice;
        }

        public void setItemImage(string image)
        {
            //pictureItem.Load(Path.GetDirectoryName(Application.ExecutablePath)+imagePath);
            try
            {
                Byte[] bytes = Convert.FromBase64String(image);
                MemoryStream stream = new MemoryStream(bytes);
                Bitmap Image = new Bitmap(stream);

                pictureItem.Image = Image;
            }

             catch (Exception)
            {

                throw;
            }
        }

        public Image getItemImage()
        {
            return pictureItem.Image;
        }

        public bool getSelectedStatus()
        {
            if ((Color)panelBorder.BackgroundColor == Color.Transparent)
            {
                return false;
            }
            else
            {
                return true;
            }
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

        

        private void labelItemName_Paint(object sender, PaintEventArgs e)
        {
            labelItemName.Parent = pictureItem;
            
        }
    }
    
}
