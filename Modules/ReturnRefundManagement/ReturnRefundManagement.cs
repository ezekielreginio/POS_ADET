using AForge.Video;
using AForge.Video.DirectShow;
using MySql.Data.MySqlClient;
using POS_ADET.Classes.DB;
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
using ZXing.Common;

namespace POS_ADET.Modules.ReturnRefundManagement
{
    public partial class ReturnRefundManagement : Form
    {
        private connector conn = new connector();

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        public ReturnRefundManagement()
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
                    }
                };
                Result result = barcodeReader.Decode((Bitmap)qrScanner.Image);
                if (result != null)
                {
                    
                    String id = result.ToString();
                    
                    var data = new Dictionary<string, string>()
                    {
                        { "transaction_id", id }
                    };
                    MySqlDataReader reader = conn.readProcedure("transaction_view_record", data);
                    
                    tableItems.Rows.Clear();
                    tableItems.Refresh();
                    txtORNo.Text = id;
                    while (reader.Read())
                    {
                        tableItems.Rows.Add(
                        new object[]
                        {
                            reader["code"].ToString(),
                            reader["name"].ToString(),
                            reader["price"].ToString(),
                            reader["qty"].ToString(),
                            "PHP "+(Convert.ToDouble(reader["price"]) * Convert.ToInt32(reader["qty"])).ToString()

                        }
                    );
                    }
                        
                    
                    

                    conn.closeConn();
                    //    DataGridViewRow rowHolder = null;
                }
                //{


                //    String id = result.ToString();
                //    var data = new Dictionary<string, string>()
                //    {
                //        { "code", id }
                //    };
                //    MySqlDataReader reader = conn.readProcedure("item_view", data);
                //    DataGridViewRow rowHolder = null;
                //    bool beepFire = false;
                //    while (reader.Read())
                //    {
                //        beepFire = true;
                //        foreach (DataGridViewRow row in tableItems.Rows)
                //        {
                //            if (reader["name"].ToString() == row.Cells["itemName"].Value.ToString())
                //            {
                //                rowHolder = row;
                //            }
                //        }
                //        if (rowHolder != null)
                //        {
                //            rowHolder.Cells["qty"].Value = Convert.ToInt32(rowHolder.Cells["qty"].Value) + 1;
                //            rowHolder.Cells["total"].Value = Convert.ToInt32(rowHolder.Cells["qty"].Value) * Convert.ToDouble(rowHolder.Cells["price"].Value);
                //        }

                //        else
                //        {
                //            tableItems.Rows.Add(
                //            new object[]
                //                {
                //                    reader["code"].ToString(),
                //                    reader["name"].ToString(),
                //                    reader["price"].ToString(),
                //                    1,
                //                    "PHP "+reader["price"].ToString()

                //                }
                //            );

                //        }

                //    }
                //    if (beepFire)
                //    {
                //        playbeep();
                //    }

                //    conn.closeConn();
                //    updateTransactionTotal();
                //    txtCode.Text = id;

                //}
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            captureDevice.Start();
            timer1.Start();
        }

        private void tableItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = tableItems.SelectedRows[0];
            tableReturnRefund.Rows.Add(
                new object[]
                {
                    row.Cells["id"].Value,
                    row.Cells["itemName"].Value
                }
            );
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
