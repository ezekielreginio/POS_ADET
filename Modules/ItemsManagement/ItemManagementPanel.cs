using MySql.Data.MySqlClient;
using POS_ADET.Classes;
using POS_ADET.Classes.DB;
using POS_ADET.Classes.Dropbox;
using POS_ADET.Controls;
using POS_ADET.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ZXing;

namespace POS_ADET.Modules.ItemsManagement
{
    public partial class ItemManagementPanel : Form
    {

        //Private Instances:
        private connector conn = new connector();
        private ItemCard currentItem;
        private OpenFileDialog choofdlog = new OpenFileDialog();
        private Validation validate = new Validation();

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
            string itemCode = textFieldItemCode.getValue();
            string itemName = textFieldItemName.getValue();
            string itemPrice = textFieldItemPrice.getValue();
            string qty = textFieldQty.getValue();
            string itemPicture = lblFilePath.Text;

            var inputs = new List<TextField>();
            inputs.Add(textFieldItemCode);
            
            Validation validateInst = new Validation();
            validateInst.validate(inputs);

            bool inputs_are_valid = true;

            inputs_are_valid = validate.validate_int(textFieldItemCode);


            if (inputs_are_valid)
            {
                
                //DropBox dbx = new DropBox();
                //var url = "";
                //if (itemPicture != string.Empty)
                //{
                //    url = dbx.Upload(itemPicture, "/items", itemName + ".png").Result;
                //}
                string fpath = @"\Items\" + itemName + @".png";
                string appPath = Path.GetDirectoryName(Application.ExecutablePath) + fpath;
                try
                {
                    File.Copy(itemPicture, appPath);
                    //picProduct.Image = new Bitmap(itemPicture);
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Unable to open file " + exp.Message);
                }

                //var url = "";
                //if (itemPicture != string.Empty)
                //{
                //    //url = dbx.Upload(itemPicture, "/items", itemName + ".png").Result;
                //}

                var data = new Dictionary<string, string>()
                {
                    { "code", itemCode },
                    { "name", itemName },
                    { "price", itemPrice },
                    { "qty", qty },
                    { "photo", fpath }
                };

                if (buttonSaveItem.Text == "Save")
                    conn.writeProcedure("item_add", data);

                else if (buttonSaveItem.Text == "Update")
                    conn.writeProcedure("item_edit", data);


                conn.closeConn();

                generateQR(itemCode, itemName);
                queryItems();

                resetFields();
            }
        }


        private void txtItemCode_Leave(object sender, EventArgs e)
        {
            string qrString = textFieldItemCode.getValue();
            string fileName = textFieldItemName.getValue();
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

            itemInst.GetPictureBox().MouseClick += (sender, e) => singleSelect(sender, e);
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
                    textFieldItemCode.setValue(reader["code"].ToString());
                    textFieldItemName.setValue(reader["name"].ToString());
                    textFieldItemPrice.setValue(reader["price"].ToString());
                    textFieldQty.setValue(reader["qty"].ToString());
                    //picboxItem.Load(reader["photo"].ToString()+"&raw=1");
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
            textFieldItemCode.resetField();
            textFieldItemName.resetField();
            textFieldItemPrice.resetField();
            textFieldQty.resetField();
            picboxItem.Image= null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
    }
}
