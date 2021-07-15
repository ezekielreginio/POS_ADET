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

namespace POS_ADET.Modules.LogsManagement.ItemLogs
{
    public partial class Item : Form
    {
        private DataTable dto;
        private connector conn = new connector();
        public Item()
        {
            InitializeComponent();
        }

        private void PanelLogsManagement_Load(object sender, EventArgs e)
        {
            string[] columnheaders = new string[] { 
            "Item ID",
            "Log Type",
            "Time"
            };
            dto = conn.getDataTable("item_log_view_all");
            for (int i = 0; i  < dto.Columns.Count; i++)
            {
                dto.Columns[i].ColumnName = columnheaders[i];
            }
            dgvLog.DataSource = dto;

            
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

        }
    }
}
