using MySql.Data.MySqlClient;
using POS_ADET.Classes.DB;
using POS_ADET.Classes.Dropbox;
using POS_ADET.Controls;
using POS_ADET.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ZXing;

namespace POS_ADET.Modules.ItemsManagement
{
    public partial class ItemManagementPanel : Form
    {
        private connector conn = new connector();
        ItemCard currentItem;
        public ItemManagementPanel()
        {
            InitializeComponent();
        }


        public void setCurrentItem(ItemCard currentItem)
        {
           this.currentItem = currentItem;
        }

        public ItemCard getCurrentItem()
        {
            return currentItem;
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ItemManagementPanel_Load(object sender, EventArgs e)
        {

        }

       

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            tableItemCatalog.HorizontalScroll.Enabled = false;
        }

        private void buttonSaveItem_Click(object sender, EventArgs e)
        {
            string itemCode = txtItemCode.Text;
            string itemName = txtItemName.Text;
            string itemPrice = txtItemPrice.Text;
            string qty = txtQty.Text;
            string itemPicture = lblFilePath.Text;

            DropBox dbx = new DropBox();
            var url = "";
            if (itemPicture != string.Empty)
            {
                url = dbx.Upload(itemPicture, "/items", itemName + ".png").Result;
            }

            var data = new Dictionary<string, string>()
                {
                    { "code", itemCode },
                    { "name", itemName },
                    { "price", itemPrice },
                    { "qty", qty },
                    { "photo", url }
                };

            if (buttonSaveItem.Text == "Save")
                conn.writeProcedure("item_add", data);
               
            else if(buttonSaveItem.Text == "Update")
                conn.writeProcedure("item_edit", data);
            

            conn.closeConn();

            generateQR(itemCode, itemName);
            queryItems();

            resetFields();
        }


        private void txtItemCode_Leave(object sender, EventArgs e)
        {
            string qrString = txtItemCode.Text;
            string fileName = txtItemName.Text;
            string filePath = @"C:\qr\"+ fileName+".png";

            BarcodeWriter barcodeW = new BarcodeWriter();

            barcodeW.Format = BarcodeFormat.QR_CODE;

            barcodeW.Write(qrString).Save(filePath);


        }


        // User-Defined Functions:

        private void generateQR(String qrString, String fileName)
        {
            
            string filePath = @"C:\qr\" + fileName + ".png";

            BarcodeWriter barcodeW = new BarcodeWriter();

            barcodeW.Format = BarcodeFormat.QR_CODE;

            barcodeW.Write(qrString).Save(filePath);
        }

        private void generateItem(int code, String itemName, String itemPrice, String imageUrl)
        {
            ItemCard itemInst = new ItemCard();

            itemInst.itemID = code;
            itemInst.setItemName(itemName);
            itemInst.setItemPrice(itemPrice);
            itemInst.setItemImage(imageUrl);

            itemInst.GetPictureBox().MouseClick += (sender, e)=>singleSelect(sender, e);
            itemInst.GetItemName().MouseClick += (sender, e) => singleSelect(sender, e);
            itemInst.GetItemPrice().MouseClick += (sender, e) => singleSelect(sender, e);
            tableItemCatalog.Controls.Add(itemInst);

            void singleSelect(object sender, EventArgs e)
            {
                if (currentItem != null)
                    currentItem.deselect();
                currentItem = itemInst;
                itemInst.setSelected();

                var data = new Dictionary<string, string>()
                {
                    { "code", itemInst.itemID.ToString() }
                };
                MySqlDataReader reader = conn.readProcedure("item_view", data);
                while (reader.Read())
                {
                    txtItemCode.Text = reader["code"].ToString();
                    txtItemName.Text = reader["name"].ToString();
                    txtItemPrice.Text = reader["price"].ToString();
                    txtQty.Text = reader["qty"].ToString();
                    picboxItem.Load(reader["photo"].ToString()+"&raw=1");
                    buttonAddItem.Visible = true;
                    buttonSaveItem.Text = "Update";
                }
                conn.closeConn();
                //List<ItemCatalog> itemInfo = new List<ItemCatalog>();

            }
        }


        public void queryItems()
        {
            tableItemCatalog.Controls.Clear();
            MySqlDataReader reader = conn.readProcedure("item_view_all", null);
            while (reader.Read())
            {
                int itemCode = (int)reader.GetValue(0);
                string itemName = reader.GetValue(1).ToString();
                string itemPrice = reader.GetValue(2).ToString(); 
                string imageURL = reader.GetValue(4).ToString();
                generateItem(itemCode, itemName, itemPrice, imageURL);
            }
            conn.closeConn();
        }

        private void resetFields()
        {
            txtItemCode.ResetText();
            txtItemName.ResetText();
            txtItemPrice.ResetText();
            txtQty.ResetText();
            picboxItem.Image= null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                lblFilePath.Text = sFileName;
                picboxItem.Image = Image.FromFile(sFileName);
                string[] arrAllFiles = choofdlog.FileNames; //used when Multiselect = true           
            }
                
            
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            currentItem.deselect();
            buttonAddItem.Visible = false;
            buttonSaveItem.Text = "Save";
            resetFields();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableItemCatalog_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
