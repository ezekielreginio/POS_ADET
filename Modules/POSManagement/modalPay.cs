using Bunifu.UI.WinForms.BunifuButton;
using MySql.Data.MySqlClient;
using POS_ADET.Classes.DAL.Models;
using POS_ADET.Classes.DB;
using POS_ADET.Controls;
using POS_ADET.Controls.Receipt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_ADET.Modules.POSManagement
{
    public partial class modalPay : Form
    {
        //private attributes
        private double totalTransactionAmount;
        private connector conn = new connector();
        private TransactionData transactionData = new TransactionData();
        private POSManagement posPanel = new POSManagement();



        public double TotalTransactionAmount 
        { 
            get => totalTransactionAmount;
            set
            {
                totalTransactionAmount = value;
                labelTotalTransactionAmount.Text = totalTransactionAmount.ToString("F");
            }
        }

        internal TransactionData TransactionData { get => transactionData; set => transactionData = value; }
        public POSManagement PosPanel { get => posPanel; set => posPanel = value; }

        public modalPay()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            transactionData.Cash = Convert.ToDouble(txtTenderedAmount.Text);

            var data = new Dictionary<string, string>()
            {
                { "totalAmount", labelTotalTransactionAmount.Text }
            };
            string transaction_id = String.Empty;
            MySqlDataReader result = conn.readProcedure("transaction_create", data);
            while (result.Read())
            {
                transaction_id = result["last_transaction_id"].ToString();
            }
            conn.closeConn();

            transactionData.Transaction_id = Convert.ToInt32(transaction_id);
            foreach (TransactionItem item in transactionData.Items)
            {
                data = new Dictionary<string, string>()
                {
                    { "transaction_id", transaction_id},
                    { "item_code", item.Code.ToString()},
                    { "qty", item.Qty.ToString()},
                    { "price", item.Price.ToString()}
                };
                conn.writeProcedure("transaction_add_item", data);
                conn.closeConn();
            }
            Receipts receipt = new Receipts();
            
            receipt.addData(transactionData);
            receipt.Show();

            posPanel.resetFields();

            this.Close();
        }
        private void quickInput_Click(object sender, EventArgs e)
        {
            BunifuButton btn = sender as BunifuButton;
            txtTenderedAmount.Text = btn.Text;
        }

        
    }
}
