using POS_ADET.Classes;
using POS_ADET.Classes.DAL.Models;
using POS_ADET.Controls.Receipt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_ADET.Controls
{
    public partial class Receipts : Form
    {
        public Receipts()
        {
            InitializeComponent();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Receipts_Load(object sender, EventArgs e)
        {

        }

        public void addData(TransactionData transactionData)
        {
            ReceiptItem receiptItem = null;
            lblTotal.Text = transactionData.TotalAmount.ToString("F");
            lblVat.Text = (transactionData.TotalAmount * 0.12).ToString("F");
            lblSubTotal.Text = (transactionData.TotalAmount-(transactionData.TotalAmount * 0.12)).ToString("F");
            lblCash.Text = transactionData.Cash.ToString("F");
            lblChange.Text = (transactionData.Cash - transactionData.TotalAmount).ToString("F");

            string filename = "OR_" + transactionData.Transaction_id;
            Bitmap qr = QRCode.generateQR(transactionData.Transaction_id.ToString(), filename);
            picQR.Image = qr;

            foreach (TransactionItem item in transactionData.Items)
            {
                receiptItem = new ReceiptItem();
                receiptItem.setItemData(item);
                receiptItem.Dock = DockStyle.Top;
                //panelItems.Height = panelItems.Height + 30;

                panelItems.Controls.Add(receiptItem);
            }
            

        }

        private void bunifuSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
            this.Close();
        }

        Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height - 36, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(System.Object sender,
           System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

    }
}
