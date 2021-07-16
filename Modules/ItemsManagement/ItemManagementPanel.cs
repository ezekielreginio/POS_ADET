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
using System.Data.Linq;
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


        private void buttonSaveItem_Click(object sender, EventArgs e)
        {
            string itemCode = textFieldItemCode.getValue();
            string itemName = textFieldItemName.getValue();
            string itemPrice = textFieldItemPrice.getValue();
            string qty = textFieldQty.getValue();
            string itemPicture = lblFilePath.Text;
            string fpath = String.Empty;

            bool[] input_validations = new bool[] { textFieldItemCode.IsValid, textFieldItemName.IsValid, textFieldItemPrice.IsValid, textFieldQty.IsValid };
            bool inputs_are_valid = !input_validations.Contains(false);



            if (inputs_are_valid)
            {
                //Dropbox API for Image Uploading:
                //DropBox dbx = new DropBox();
                //var url = "";
                //if (itemPicture != string.Empty)
                //{
                //    url = dbx.Upload(itemPicture, "/items", itemName + ".png").Result;
                //}
                //var url = "";
                //if (itemPicture != string.Empty)
                //{
                //    //url = dbx.Upload(itemPicture, "/items", itemName + ".png").Result;
                //}


                //File Upload on Resources:
                //string fpath = @"\Items\" + itemName + @".png";
                //string appPath = Path.GetDirectoryName(Application.ExecutablePath) + fpath;
                //try
                //{
                //    File.Copy(itemPicture, appPath);
                //    //picProduct.Image = new Bitmap(itemPicture);
                //}
                //catch (Exception exp)
                //{
                //    MessageBox.Show("Unable to open file " + exp.Message);
                //}
                try
                {
                    byte[] imageArray = null;
                    if (itemPicture == String.Empty)
                    {
                        if (buttonSaveItem.Text == "Save")
                        {
                            throw new FileNotFoundException();
                        }
                            
                        else if (buttonSaveItem.Text == "Update")
                        {
                            ImageConverter converter = new ImageConverter();
                            imageArray = (byte[])converter.ConvertTo(picboxItem.Image, typeof(byte[]));
                        }
                    }
                    else if(itemPicture != String.Empty)
                        imageArray = System.IO.File.ReadAllBytes(itemPicture);
                        
                    fpath = Convert.ToBase64String(imageArray);

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
                    {
                        buttonAddItem_Click(null, null);
                        conn.writeProcedure("item_edit", data);
                    }

                    conn.closeConn();
                    queryItems();
                    QRCode.generateQR(itemCode, itemName);
                    resetFields();

                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show("Please Upload an Item Picture");
                }
                catch (DuplicateKeyException ex)
                {
                    MessageBox.Show("Item with ID already exist");
                }
                catch (Exception ex)
                {

                    if(ex.Message.Contains("Duplicate entry"))
                        MessageBox.Show("Item with ID:"+ itemCode + " already exist");;
                }
                finally
                {
                    conn.closeConn();
                }
                

                
            }
            else
            {
                MessageBox.Show("Invalid Submission: Kindly Check Your Inputs");
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
                textFieldItemCode.setEnabled(false);
                buttonAddItem.Text = "Add New Item";
                btnChangeImgBox.Visible = true;
                btnChangeImgBox.Text = "See QR";

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
                    Byte[] bytes = Convert.FromBase64String(reader["photo"].ToString());
                    MemoryStream stream = new MemoryStream(bytes);
                    Bitmap Image = new Bitmap(stream);


                    textFieldItemCode.setValue(reader["code"].ToString());
                    textFieldItemName.setValue(reader["name"].ToString());
                    textFieldItemPrice.setValue(reader["price"].ToString());
                    textFieldQty.setValue(reader["qty"].ToString());
                    picboxItem.Image = Image;
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

            tableItemCatalog.AutoScroll = false;
            tableItemCatalog.HorizontalScroll.Enabled = false;
            tableItemCatalog.HorizontalScroll.Visible = false;
            tableItemCatalog.AutoScroll = true;


        }

        private void resetFields()
        {
            textFieldItemCode.resetField();
            textFieldItemName.resetField();
            textFieldItemPrice.resetField();
            textFieldQty.resetField();
            picboxItem.Image= null;
            lblFilePath.Text = String.Empty;
            textFieldItemCode.setEnabled(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            string[] valid_ext = { ".jpg", ".jpeg", ".png", ".porn", ".xvid", ".nhen", ".xnxx", ".gif"};

            try
            {
                if (choofdlog.ShowDialog() == DialogResult.OK)
                {
                    string sFileName = choofdlog.FileName;
                    FileInfo fileInfo = new FileInfo(sFileName);

                    if (!valid_ext.Contains(fileInfo.Extension))
                        throw new IOException();

                    lblFilePath.Text = sFileName;
                    picboxItem.Image = Image.FromFile(sFileName);
                    string[] arrAllFiles = choofdlog.FileNames; //used when Multiselect = true           
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Invalid File Type. Please Upload another File. (Valid File Types: JPG, JPEG, PNG, GIF)");
            }
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            if(buttonAddItem.Text == "Add New Item")
            {
                buttonAddItem.Text = "Clear";
                currentItem.deselect();
                buttonSaveItem.Text = "Save";
            }
            resetFields();
            
            
        }

        private void tableItemCatalog_Paint(object sender, PaintEventArgs e)
        {
            //tableItemCatalog.HorizontalScroll.Enabled = false;
            //tableItemCatalog.AutoScroll = false;
            //tableItemCatalog.VerticalScroll.Visible = false;
            //tableItemCatalog.AutoScroll = true;
            
        }

        private void btnChangeImgBox_Click(object sender, EventArgs e)
        {
            if(btnChangeImgBox.Text == "See QR")
            {
                btnChangeImgBox.Text = "View Item Image";
                Bitmap qr = QRCode.generateQR(textFieldItemCode.getValue(), textFieldItemName.getValue(), false);
                picboxItem.Image = qr;

            }
            else
            {
                btnChangeImgBox.Text = "See QR";
                picboxItem.Image = currentItem.getItemImage();
            }
        }
    }
}
