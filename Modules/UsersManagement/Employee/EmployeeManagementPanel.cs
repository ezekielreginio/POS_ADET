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

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveEmployee_Click(object sender, EventArgs e)
        {
           
                string emp_fullname = txtEmployeeName.Text;
                string emp_username = txtEmployeeUsername.Text;
                string emp_password = txtEmployeePassword.Text;
                string emp_email = txtEmployeeEmail.Text;
                //string emp_position = txtEmployeePosition.Text;
                string itemPicture = lblFilePath.Text;

                //DropBox dbx = new DropBox();
                //var url = dbx.Upload(itemPicture, "/items", itemName + ".png").Result;
                //Console.WriteLine(url);

                var data = new Dictionary<string, string>()
            {
                { "emp_fullname", emp_fullname },
                { "emp_username", emp_username },
                { "emp_password", emp_password },
                { "emp_email", emp_email},
                //{ "emp_position", emp_position }
            };
                conn.writeProcedure("employee_add", data);
                conn.closeConn();

                //generateQR(itemCode, itemName);
                //queryItems();

                txtEmployeeName.ResetText();
                txtEmployeeUsername.ResetText();
                txtEmployeePassword.ResetText();
                txtEmployeeEmail.ResetText();

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
            

    }
    
}
