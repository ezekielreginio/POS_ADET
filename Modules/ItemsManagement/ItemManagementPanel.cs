using MySql.Data.MySqlClient;
using POS_ADET.Classes.DB;
using POS_ADET.Classes.Dropbox;
using POS_ADET.Controls;
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
        public ItemManagementPanel()
        {
            InitializeComponent();
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
            var url = dbx.Upload(itemPicture, "/items", itemName + ".png").Result;
            Console.WriteLine(url);

            var data = new Dictionary<string, string>()
            {
                { "code", itemCode },
                { "name", itemName },
                { "price", itemPrice },
                { "qty", qty },
                { "photo", url }
            };
            conn.writeProcedure("item_add", data);
            conn.closeConn();

            generateQR(itemCode, itemName);
            queryItems();

            txtItemCode.ResetText();
            txtItemName.ResetText();
            txtItemPrice.ResetText();
            txtQty.ResetText();

            //async void upload()
            //{
            //    DropBox dbx = new DropBox();
            //    string link = dbx.Upload(itemPicture, "/items", itemName + ".png").Result;
            //    Console.WriteLine(link);

            //}


            //generateQR(itemCode, itemName);

            //txtItemCode.ResetText();
            //txtItemName.ResetText();
            //txtItemPrice.ResetText();
            //txtQty.ResetText();

            //string query = "CALL `item_add`("+ itemCode + ", @itemName, @itemPrice, @qty)";
            //conn.executeQuery("CALL `item_add`(" + itemCode + ", '" + itemName + "', " + itemPrice + ", " + qty + ")");
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

        private void generateItem(String itemName, String itemPrice, String imageUrl)
        {
            ItemCard itemInst = new ItemCard();
            itemInst.setItemName(itemName);
            itemInst.setItemPrice(itemPrice);
            itemInst.setItemImage(imageUrl);

            tableItemCatalog.Controls.Add(itemInst);
        }

        public void queryItems()
        {
            tableItemCatalog.Controls.Clear();
            MySqlDataReader reader = conn.readProcedure("item_view_all", null);
            while (reader.Read())
            {
                string itemName = reader.GetValue(1).ToString();
                string itemPrice = reader.GetValue(2).ToString(); 
                string imageURL = reader.GetValue(4).ToString();
                generateItem(itemName, itemPrice, imageURL);
            }
            conn.closeConn();
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
