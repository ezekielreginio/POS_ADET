using MySql.Data.MySqlClient;
using POS_ADET.Classes.DB;
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
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Common;
using POS_ADET.Classes.DAL.Models;
using System.IO;

namespace POS_ADET.Modules.POSManagement
{
    public partial class POSManagement : Form
    {
        private connector conn = new connector();

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        
        

        private TotalTransaction totalTransaction = new TotalTransaction();
        public POSManagement()
        {
            InitializeComponent();
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cboDevices.Items.Add(filterInfo.Name);
            cboDevices.SelectedIndex = 0;
            captureDevice = new VideoCaptureDevice(filterInfoCollection[2].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;

            
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            qrScanner.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (qrScanner.Image != null)
            {
                var barcodeReader = new BarcodeReader(null, null, ls => new GlobalHistogramBinarizer(ls))
                {
                        AutoRotate = true,
                    TryInverted = true,
                    Options = new DecodingOptions
                    {
                        TryHarder = true,
                        //PureBarcode = true,
                        /*PossibleFormats = new List<BarcodeFormat>
                        {
                            BarcodeFormat.CODE_128
                            //BarcodeFormat.EAN_8,
                            //BarcodeFormat.CODE_39,
                            //BarcodeFormat.UPC_A
                        }*/
                    }
                }; 
                Result result = barcodeReader.Decode((Bitmap)qrScanner.Image);
                if(result != null)
                {
                    

                    String id = result.ToString();
                    var data = new Dictionary<string, string>()
                    {
                        { "code", id }
                    };
                    MySqlDataReader reader = conn.readProcedure("item_view", data);
                    DataGridViewRow rowHolder = null;
                    bool beepFire = false;
                    while (reader.Read())
                    {
                        beepFire = true;
                        foreach (DataGridViewRow row in tableItems.Rows)
                        {
                            if(reader["name"].ToString() == row.Cells["itemName"].Value.ToString())
                            {
                                rowHolder = row;
                            }
                        }
                        if(rowHolder != null)
                        {
                            rowHolder.Cells["qty"].Value = Convert.ToInt32(rowHolder.Cells["qty"].Value) + 1;
                            rowHolder.Cells["total"].Value = Convert.ToInt32(rowHolder.Cells["qty"].Value) * Convert.ToDouble(rowHolder.Cells["price"].Value);
                        }

                        else
                        {
                            tableItems.Rows.Add(
                            new object[]
                                {
                                    reader["name"].ToString(),
                                    reader["price"].ToString(),
                                    1,
                                    "PHP "+reader["price"].ToString()

                                }
                            );
                            
                        }
                        
                    }
                    if (beepFire)
                    {
                        playbeep();
                    }
                    
                    conn.closeConn();
                    updateTransactionTotal();
                    txtCode.Text = id;
                    
                }
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        //User Defined Methods:
        public void queryItems()
        {
            //tableItemCatalog.Controls.Clear();
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

        private void generateItem(int code, String itemName, String itemPrice, String imageUrl)
        {
            ItemCard itemInst = new ItemCard();
            
            itemInst.itemID = code;
            itemInst.setItemName(itemName);
            itemInst.setItemPrice(itemPrice);
            itemInst.setItemImage(imageUrl);

            tableItemCatalog.Controls.Add(itemInst);

            itemInst.GetPictureBox().MouseClick += (sender, e) => multiSelect(sender, e);
            itemInst.GetItemName().MouseClick += (sender, e) => multiSelect(sender, e);
            itemInst.GetItemPrice().MouseClick += (sender, e) => multiSelect(sender, e);

            void multiSelect(object sender, EventArgs e)
            {
                int qty = 1;
                itemInst.setSelected();
                playbeep();

                DataGridViewRow rowHolder = null;

                try
                {
                    if(txtItemCode.Text != string.Empty)
                    {
                        qty = Convert.ToInt32(txtItemCode.Text);
                    }
                    
                    if (itemInst.getSelectedStatus()) //returns true if item is selected
                    {
                        foreach (DataGridViewRow r in tableItems.Rows)
                        {
                            if (itemName == r.Cells["itemName"].Value.ToString())
                            {
                                rowHolder = r;
                            }
                        }

                        if (rowHolder != null)
                        {
                            rowHolder.Cells["qty"].Value = Convert.ToInt32(rowHolder.Cells["qty"].Value) + 1;
                            rowHolder.Cells["total"].Value = Convert.ToInt32(rowHolder.Cells["qty"].Value) * Convert.ToDouble(rowHolder.Cells["price"].Value);
                        }
                    
                        else
                        {
                            tableItems.Rows.Add(
                            new object[]
                                {
                                    itemName,
                                    itemPrice,
                                    qty,
                                    "PHP "+Convert.ToDecimal(itemPrice)*qty
                                }
                            );
                        }
                        
                        DataGridViewRow row = tableItems.Rows[tableItems.Rows.Count - 1];
                        itemInst.RowPosition = row;
                        updateTransactionTotal();
                        //totalAmount += Convert.ToDecimal(itemPrice) * qty;

                    }
                    else
                    {
                        DataGridViewRow row = itemInst.RowPosition;
                        double total = Convert.ToDouble(row.Cells["qty"].Value) * Convert.ToDouble(row.Cells["price"].Value) * -1;
                        tableItems.Rows.Remove(row);
                        updateTransactionTotal();
                    }

                    txtItemCode.Text = null;

                }
                catch(System.FormatException ex) { if(!String.IsNullOrEmpty(txtItemCode.Text)) MessageBox.Show(txtItemCode.Text +" is not a valid input");  }
                catch (Exception ex) { }
                

            }

            //itemInst.MouseClick += (sender, e) => multiSelect(sender, e);

            //itemInst.GetPictureBox().MouseClick += (sender, e) => multiSelect(sender, e);





            //void multiSelect(object sender, EventArgs e)
            //{
            //    itemInst.setSelected();

            //    tableItems.Rows.Add(
            //        new object[]
            //        {
            //            itemName,
            //            itemPrice,
            //            1,
            //            "PHP "+itemPrice

            //        }
            //    );
            //}

            //void singleSelect(object sender, EventArgs e)
            //{
            //    if (currentItem != null)
            //        currentItem.deselect();
            //    currentItem = itemInst;
            //    itemInst.setSelected();

            //    var data = new Dictionary<string, string>()
            //    {
            //        { "code", itemInst.itemID.ToString() }
            //    };
            //    MySqlDataReader reader = conn.readProcedure("item_view", data);
            //    while (reader.Read())
            //    {
            //        txtItemCode.Text = reader["code"].ToString();
            //        txtItemName.Text = reader["name"].ToString();
            //        txtItemPrice.Text = reader["price"].ToString();
            //        txtQty.Text = reader["qty"].ToString();
            //        //picboxItem.Load(reader["photo"].ToString()+"&raw=1");
            //        buttonAddItem.Visible = true;
            //        buttonSaveItem.Text = "Update";
            //    }
            //    conn.closeConn();
            //    //List<ItemCatalog> itemInfo = new List<ItemCatalog>();

            //}
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            captureDevice.Start();
            timer1.Start();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void POSManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pos_adetDataSet.item_catalog' table. You can move, or remove it, as needed.
            this.item_catalogTableAdapter.Fill(this.pos_adetDataSet.item_catalog);

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            captureDevice.Start();
            timer1.Start();
        }

        private void tableItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int qty = Convert.ToInt32(tableItems.CurrentRow.Cells["qty"].Value);
            double price = Convert.ToDouble(tableItems.CurrentRow.Cells["price"].Value) * qty;

            tableItems.CurrentRow.Cells["total"].Value = "PHP "+price.ToString();

            updateTransactionTotal();
        }

        private void updateTransactionTotal()
        {
            totalTransaction.TotalAmount = 0;
            foreach (DataGridViewRow row in tableItems.Rows)
            {
                totalTransaction.TotalAmount += Convert.ToDouble(row.Cells["price"].Value) * Convert.ToInt32(row.Cells["qty"].Value);
            }

            lblTotalAmount.Text = totalTransaction.TotalAmount.ToString("F");
            lblTax.Text = totalTransaction.Tax.ToString("F");
            lblNet.Text = totalTransaction.Net.ToString("F");
        }

        private void playbeep()
        {
            System.Media.SoundPlayer myPlayer = new System.Media.SoundPlayer();
            myPlayer.SoundLocation = Path.GetDirectoryName(Application.ExecutablePath)+@"\sounds\beep.wav";
            myPlayer.Play();
        }
    }
}
