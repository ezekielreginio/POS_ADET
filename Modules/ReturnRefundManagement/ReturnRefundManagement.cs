using AForge.Video;
using AForge.Video.DirectShow;
using MySql.Data.MySqlClient;
using POS_ADET.Classes;
using POS_ADET.Classes.DAL.Models;
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
        private TransactionData transactionData = new TransactionData();
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
                    queryTransactionItems(id);
                }
            }
        }
        public void stopScanner()
        {

            captureDevice.Stop();
            timer1.Stop();
        }

        private void queryTransactionItems(string id)
        {
            transactionData.Transaction_id = Convert.ToInt32(id);
            transactionData.Items.Clear();
            var data = new Dictionary<string, string>()
                    {
                        { "transaction_id", id }
                    };
            MySqlDataReader reader = conn.readProcedure("transaction_view_record", data);
            MySqlDataReader dummy = reader;
            resetModule();

            
            while (reader.Read())
            {
                transactionData.TransactionDate = (DateTime)reader["date"];

                transactionData.Items.Add
                (
                    new TransactionItem
                    {
                        Code = Convert.ToInt32(reader["code"]),
                        ItemName = reader["name"].ToString(),
                        Price = Convert.ToDouble(reader["price"]),
                        Qty = Convert.ToInt32(reader["qty"]),
                        
                    }
                );
            }


            txtORNo.Text = id;

            DateTime currentDate = DateTime.Today;
            TimeSpan dateInterval = currentDate.Subtract(transactionData.TransactionDate);
            if(dateInterval.Days <= 30)
            {
                foreach (TransactionItem item in transactionData.Items)
                {
                    tableItems.Rows.Add(
                        new object[]
                        {
                                item.Code,
                                item.ItemName,
                                item.Price,
                                item.Qty,
                                "PHP "+(item.Price * item.Qty).ToString()
                        }
                    );
                }
            }
            else
            {
                MessageBox.Show("Sorry, This Transaction has Exceeded The 30-Day Return Policy and Cannot Be Processed");
            }
            //bool flag = true;
            //if (dummy.Read())
            //{
            //    DateTime currentDate = DateTime.Today;
            //    DateTime transactionDate = (DateTime)dummy["date"];
            //    MessageBox.Show(transactionDate.ToString());
            //}
            //if (flag)
            //{
            //    while (reader.Read())
            //    {


            //        //int dateInterval = 
            //        tableItems.Rows.Add(
            //            new object[]
            //            {
            //                    reader["code"].ToString(),
            //                    reader["name"].ToString(),
            //                    reader["price"].ToString(),
            //                    reader["qty"].ToString(),
            //                    "PHP "+(Convert.ToDouble(reader["price"]) * Convert.ToInt32(reader["qty"])).ToString()
            //            }
            //        );


            //    }
            //}
            conn.closeConn();
        }

        private void resetModule()
        {
            tableItems.Rows.Clear();
            tableItems.Refresh();

            tableReturnRefund.Rows.Clear();
            tableReturnRefund.Refresh();

            resetRefundForm();
        }

        private void resetRefundForm()
        {
            formItemName.Text = String.Empty;
            txtQty.Text = String.Empty;
            cboOption.Text = String.Empty;
            cboReason.Text = String.Empty;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            captureDevice.Start();
            timer1.Start();
        }

        private void tableItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelReturnForm.Visible = true;
            DataGridViewRow row = tableItems.SelectedRows[0];
            bool hasDuplicate = false;

            foreach (DataGridViewRow r in tableReturnRefund.Rows)
            {
                if (row.Cells["id"].Value.ToString() == r.Cells["returnID"].Value.ToString())
                {
                    hasDuplicate = true;
                }
            }
            if (!hasDuplicate)
            {
                int position = tableReturnRefund.Rows.Add(
                    new object[]
                    {
                        row.Cells["id"].Value,
                        row.Cells["itemName"].Value,
                        
                    }
                );

                formItemName.Text = row.Cells["itemName"].Value.ToString();

                tableReturnRefund.Rows[position].Selected = true;
                tableReturnRefund.Rows[position].Cells["ogQty"].Value = row.Cells["qty"].Value;
                resetRefundForm();
            }
            
        }

        
        private void txtORNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                resetModule();
                queryTransactionItems(txtORNo.Text);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
              e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
            
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(tableReturnRefund.SelectedRows[0].Cells["ogQty"].Value) >= Convert.ToInt32(txtQty.Text) || txtQty.Text == null)
                    tableReturnRefund.SelectedRows[0].Cells["returnQty"].Value = txtQty.Text;
                else
                {
                    MessageBox.Show("Invalid Qty. The Input Qty exceeds the QTY of the transaction item");
                    txtQty.Text = "";
                }
                    
            }
            catch (Exception)
            {
                //tableReturnRefund.SelectedRows[0].Cells["returnQty"].Value = "";
            }
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tableReturnRefund.SelectedRows[0].Cells["option"].Value = cboOption.SelectedItem;
        }

        private void tableReturnRefund_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            formItemName.Text = tableReturnRefund.SelectedRows[0].Cells["returnItemName"].Value.ToString();
            try
            {
                if(tableReturnRefund.SelectedRows[0].Cells["returnQty"].Value == null)
                    txtQty.Text = String.Empty;
                else
                    txtQty.Text = tableReturnRefund.SelectedRows[0].Cells["returnQty"].Value.ToString();

                if (tableReturnRefund.SelectedRows[0].Cells["option"].Value == null)
                    cboOption.Text = String.Empty;
                else
                    cboOption.Text = tableReturnRefund.SelectedRows[0].Cells["option"].Value.ToString();

                if (tableReturnRefund.SelectedRows[0].Cells["reason"].Value == null)
                    cboReason.Text = String.Empty;
                else
                    cboReason.Text = tableReturnRefund.SelectedRows[0].Cells["reason"].Value.ToString();

            }
            catch (NullReferenceException)
            {
            }
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            tableReturnRefund.Rows.Remove(tableReturnRefund.SelectedRows[0]);
            resetRefundForm();
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tableReturnRefund.SelectedRows[0].Cells["reason"].Value = cboReason.SelectedItem;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            string transaction_id = String.Empty;
            var data = new Dictionary<string, string>()
            {
                { "transaction_id", transactionData.Transaction_id.ToString() }
            };

            MySqlDataReader result = conn.readProcedure("return_transaction_create", data);
            while (result.Read())
            {
                transaction_id = result["last_transaction_id"].ToString();
            }
            conn.closeConn();

            DataTable dataReturnItems = DGVtoDataTable.GetDataTableFromDGV(tableReturnRefund);

            foreach (DataRow row in dataReturnItems.Rows)
            {
                data = new Dictionary<string, string>()
                {
                    { "return_transaction_id", transactionData.Transaction_id.ToString() },
                    { "item_code", row["returnID"].ToString()},
                    { "qty", row["returnQty"].ToString()},
                    { "type", row["option"].ToString()},
                    { "reason", row["reason"].ToString()},
                };
                conn.writeProcedure("return_transaction_add_item", data);

                conn.closeConn();
            }
            resetModule();
            MessageBox.Show("Return Transaction Successfully Processed");
        }
    }
}
