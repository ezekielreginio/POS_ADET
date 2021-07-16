using MySql.Data.MySqlClient;
using POS_ADET.Classes.DB;
using POS_ADET.Classes.Dropbox;
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

namespace POS_ADET.Modules.UsersManagement
{
    public partial class EmployeeManagementPanel : Form
    {
        int id = 0;
        private connector conn = new connector();
        public EmployeeManagementPanel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void clearFields()
        {
            txtEmployeeName.ResetText();
            txtEmployeeUsername.ResetText();
            txtEmployeePassword.ResetText();
            txtEmployeeEmail.ResetText();
            txtEmployeeId.ResetText();
            txtEmployeePosition.ResetText();
        }
        public void showEmployees()
        {
            empTable.Rows.Clear();
            empTable.Refresh();
            MySqlDataReader emps = conn.readProcedure("employee_view_all");
            while (emps.Read())
            {
                empTable.Rows.Add(
                    new object[]
                    {
                        emps["emp_id"],
                        emps["emp_fullname"],
                        emps["emp_email"],
                        emps["emp_position"],
                    }
                );
            }
            empTable.Refresh();
            conn.closeConn();
        }

        private void buttonSaveEmployee_Click(object sender, EventArgs e)
        {
           
                string emp_fullname = txtEmployeeName.Text;
                string emp_username = txtEmployeeUsername.Text;
                string emp_password = txtEmployeePassword.Text;
                string emp_email = txtEmployeeEmail.Text;
                string emp_position = txtEmployeePosition.Text;
                string string_id = txtEmployeeId.Text;
                //string emp_position = txtEmployeePosition.Text;
                string itemPicture = lblFilePath.Text;

                //DropBox dbx = new DropBox();
                //var url = dbx.Upload(itemPicture, "/items", itemName + ".png").Result;
                //Console.WriteLine(url);

                var data = new Dictionary<string, string>()
            {
                {"id", string_id },
                { "emp_fullname", emp_fullname },
                { "emp_username", emp_username },
                { "emp_password", emp_password },
                { "emp_email", emp_email},
                {"emp_position", emp_position },
                
                //{ "emp_position", emp_position }
            };
                if (buttonSaveEmployee.Text == "Save")
                { conn.writeProcedure("employee_add", data);
                conn.closeConn();
                }
                else
            {
                conn.writeProcedure("employee_update", data);
                conn.closeConn();
            }
            //generateQR(itemCode, itemName);
            //queryItems();

            clearFields();
            showEmployees();
                //async void upload()
                //{
                //    DropBox dbx = new DropBox();
                //    string link = dbx.Upload(itemPicture, "/items", itemName + ".png").Result;
                //    Console.WriteLine(link);

                //}


                //generateQR(itemCode, itemName);

                //txtItemCode.ResetText();
                //txtItemName.ResetText();
                //txtItemPrice.ResetText();
                //txtQty.ResetText();

                //string query = "CALL `item_add`("+ itemCode + ", @itemName, @itemPrice, @qty)";
                //conn.executeQuery("CALL `item_add`(" + itemCode + ", '" + itemName + "', " + itemPrice + ", " + qty + ")");
            
        }

        private void empTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(empTable.Rows[e.RowIndex].Cells[0].Value.ToString());
            //MessageBox.Show("" + id);
            buttonEmployeeDisable.Visible = true;

            string employee_fullname = txtEmployeeName.Text;
            string employee_username = txtEmployeeUsername.Text;
            string employee_password = txtEmployeePassword.Text;
            string employee_email = txtEmployeeEmail.Text;
            string employee__position = txtEmployeePosition.Text;
            string string_id = id.ToString();
            var data = new Dictionary<string, string>()
            {
                { "emp_fullname", employee_fullname },
                { "emp_username", employee_username },
                { "emp_password", employee_password },
                { "emp_email", employee_email},
                { "emp_position", employee__position},
                { "id",string_id},
            };
            MySqlDataReader reader = conn.readProcedure("employee_view_row", data);
            while (reader.Read())
            {

                string idnum = reader.GetValue(0).ToString();
                string fullname = reader.GetValue(1).ToString();
                string username = reader.GetValue(2).ToString();
                string password = reader.GetValue(3).ToString();
                string email = reader.GetValue(4).ToString();
                string position = reader.GetValue(5).ToString();
                txtEmployeeName.Text = fullname;
                txtEmployeePassword.Text = password;
                txtEmployeeEmail.Text = email;
                txtEmployeeId.Text = idnum;
                txtEmployeeUsername.Text = username;
                txtEmployeePosition.Text = position;

            }
            buttonSaveEmployee.Text = "Update";
            buttonAddNew.Visible = true;
            conn.closeConn();
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            buttonSaveEmployee.Text = "Save";
            buttonAddNew.Visible = false;
            //buttonClientDisable.Visible = false;
            clearFields();
        }

        private void buttonEmployeeDisable_Click(object sender, EventArgs e)
        {
            string string_id = txtEmployeeId.Text;
            if (MessageBox.Show("Confirm employee termination?", "Confirm ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var data = new Dictionary<string, string>()
                {
                    {"id", string_id },
                };
                conn.writeProcedure("employee_disable", data);
                conn.closeConn();
                showEmployees();
                clearFields();
            }
            else
            {


            }
        }
    }
    
}
