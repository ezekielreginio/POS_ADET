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
                }
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

        private void txtORNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
