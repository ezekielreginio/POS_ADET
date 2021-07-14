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

namespace POS_ADET.Modules.Dashboard
{
    public partial class dashboardPanel : Form
    {
        private DataTable dto;
        private connector conn = new connector();
        public dashboardPanel()
        {
            InitializeComponent();
        }

        private void dashboardPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pos_adetDataSet2.item_catalog_log' table. You can move, or remove it, as needed.
            //this.item_catalog_logTableAdapter.Fill(this.pos_adetDataSet2.item_catalog_log);

            dgvLog.DataSource = conn.getDataTable("item_log_view_all");

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

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {
            SearchDataGrid(dgvLog, dto, txtSearch.Text);
        }
    }
}
