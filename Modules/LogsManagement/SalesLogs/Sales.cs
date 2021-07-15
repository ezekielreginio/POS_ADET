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

namespace POS_ADET.Modules.LogsManagement.SalesLogs
{
    public partial class Sales : Form
    {
        private DataTable dto;
        private connector conn = new connector();
        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            dgvLog.DataSource = conn.getDataTable("sales_log_view_all");

            dto = GetDataTableFromDGV(dgvLog);
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

        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible)
                {
                    // You could potentially name the column based on the DGV column name (beware of dupes)
                    // or assign a type based on the data type of the data bound to this DGV column.
                    dt.Columns.Add();
                }
            }

            object[] cellValues = new object[dgv.Columns.Count];
            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }

            return dt;
        }

        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            SearchDataGrid(dgvLog, dto, txtSearch.Text);
        }

        private void dgvLog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Receipts rc = new Receipts();
            rc.Show();
        }
    }
}
