using MySql.Data.MySqlClient;
using POS_ADET.Classes.DAL.Models;
using POS_ADET.Classes.DB;
using POS_ADET.Modules.LogsManagement.panelLogData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_ADET.Modules.LogsManagement.ItemLogs
{
    public partial class panelLogs : Form
    {
        private DataTable dto;
        private connector conn = new connector();
        private ItemLogData itemLogData;
        private SalesLogData salesLogData;
        private ReturnRefundLogData returnrefundLogData;
        private TransactionData transactionData = new TransactionData();
        private ReturnList returnlist = new ReturnList();
        private string logtype;

        public string Logtype { get => logtype; set => logtype = value; }

        public panelLogs()
        {
            InitializeComponent();
        }
        //Getter stter methods
        public void setDataLogPanel(ItemLogData panel)
        {
            itemLogData = panel;
            lblSubheader.Text = "Item Logs";
            panelLogData.Controls.Add(panel);
        }
        public void setDataLogPanel(SalesLogData panel)
        {
            salesLogData = panel;
            lblSubheader.Text = "Transaction Logs";
            panelLogData.Controls.Add(panel);
        }
        public void setDataLogPanel(ReturnRefundLogData panel)
        {
            returnrefundLogData = panel;
            lblSubheader.Text = "Return Logs";
            panelLogData.Controls.Add(panel);
        }


        private void PanelLogsManagement_Load(object sender, EventArgs e)
        {

            string[] columnheaders = null;
            if (logtype=="itemlog")
            {
                columnheaders = new string[] {
                "Log ID",
                "Log Type",
                "Time"
                };
                dto = conn.getDataTable("item_log_view_all");
            }
            else if (logtype == "saleslog")
            {
                columnheaders = new string[] {
                "Transaction ID",
                "Total Amount",
                "Date"
                };
                dto = conn.getDataTable("transaction_view_all");
            }
            else if (logtype == "returnrefundlog")
            {
                columnheaders = new string[]
                {
                    "Return Transaction ID",
                    "Sales ID",
                    "Date",
                    
                };
                dto = conn.getDataTable("returnrefund_view_all");
            }
            for (int i = 0; i < dto.Columns.Count; i++)
            {
                dto.Columns[i].ColumnName = columnheaders[i];
            }
            dgvLog.DataSource = dto;
            dgvLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }
        public static void SearchDataGrid(DataGridView dataGridView, DataTable dtOrig, string search)
        {
            DataTable dtFiltered = dtOrig.Clone();
            Console.WriteLine("\n\n\n");
            for (int i = 0; i < dtOrig.Rows.Count; i++)
            {
                DataRow row = dtOrig.Rows[i];
                string rowString = String.Concat(row.ItemArray).ToLower(); //Concatenate all columns into single string
                                                                           //Console.WriteLine(rowString);
                if (rowString.Contains(search.ToLower()))
                {
                    dtFiltered.Rows.Add(row.ItemArray); //Add Row to New DataTable if rowString contains search string
                    Console.WriteLine(rowString);
                }
            }

            dataGridView.DataSource = dtFiltered;
        }

        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            SearchDataGrid(dgvLog, dto, txtSearch.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvLog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvLog.SelectedRows[0].Cells[0].Value.ToString();
            
            var data = new Dictionary<string, string>()
            {
                { "id",id }
            };

            if (logtype=="itemlog")
            {
                
                itemLogData.setLogId(id);
                MySqlDataReader reader = conn.readProcedure("item_log_view", data);
                while (reader.Read())
                {
                    itemLogData.setItemCode(reader.GetValue(1).ToString());
                    itemLogData.setLogType(reader.GetValue(3).ToString());
                    itemLogData.setTime(reader.GetValue(4).ToString());
                    itemLogData.setLogDesc(reader.GetValue(2).ToString());
                } 

            }

            else if (logtype=="saleslog")
            {
                salesLogData.setTransactionId(id);
                MySqlDataReader reader = conn.readProcedure("transaction_log_view", data);
                while (reader.Read())
                {
                    salesLogData.setTransactionId (reader.GetValue(0).ToString());
                    salesLogData.setTotalAmount(reader.GetValue(1).ToString());
                    salesLogData.setDate(reader.GetValue(2).ToString());

                    transactionData.Transaction_id = Convert.ToInt32(id);
                    transactionData.TotalAmount = Convert.ToDouble(reader["totalAmount"]);
                    transactionData.TransactionDate = (DateTime)reader.GetValue(2);
                    
                }
                conn.closeConn();
                data = new Dictionary<string, string>()
                    {
                        { "transaction_id",id }
                    };
                DataTable datatable = conn.getDataTable("transaction_view_sales_record", data);
                transactionData.setItemsFromDataTable(datatable);
                salesLogData.TransactionData = transactionData;
                salesLogData.setdgvSalesItem(datatable);

            }
            else if (logtype=="returnrefundlog")
            {
                returnrefundLogData.setReturnTransactionId(id);
                MySqlDataReader reader = conn.readProcedure("return_log_view", data);
                while (reader.Read())
                {
                    
                    returnrefundLogData.setTransactionId(reader.GetValue(1).ToString());
                    returnrefundLogData.setDate(reader.GetValue(2).ToString());
                }
                conn.closeConn();
                data = new Dictionary<string, string>()
                {
                    {"id", id }
                };
                DataTable dataTable = conn.getDataTable("returnitem_join_view", data);
                returnlist.setItemsFromDataTable(dataTable);
                returnrefundLogData.setdgvReturnItems(dataTable);

            }
            conn.closeConn();
        }


        private void dgvLog_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
//Mag The Forest nalang tayo sir