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

namespace POS_ADET.Modules.UsersManagement.Client
{
    public partial class ClientManagementPanel : Form
    {
        int id = 0;
        private connector conn = new connector();
        public ClientManagementPanel()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clearFields()
        {
            txtClientName.ResetText();
            txtClientUsername.ResetText();
            txtClientPassword.ResetText();
            txtClientEmail.ResetText();
        }
        private void buttonSaveClient_Click(object sender, EventArgs e)
        {
            
            string client_fullname = txtClientName.Text;
            string client_username = txtClientUsername.Text;
            string client_password = txtClientPassword.Text;
            string client_email = txtClientEmail.Text;
            string string_id = txtClientId.Text;
            string client_status = "1";
            //string emp_position = txtEmployeePosition.Text;
            string itemPicture = lblFilePath.Text;

            //DropBox dbx = new DropBox();
            //var url = dbx.Upload(itemPicture, "/items", itemName + ".png").Result;
            //Console.WriteLine(url);

            var data = new Dictionary<string, string>()
            {
                //ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());  
                {"id", string_id},
                { "client_fullname", client_fullname },
                { "client_username", client_username },
                { "client_password", client_password },
                { "client_email", client_email},
                {"client_status", "1" },

                
                //{ "emp_position", emp_position }
            };
            if(buttonSaveClient.Text == "Save")
            {
                conn.writeProcedure("client_add", data);
                clientTable.Rows.Clear();
                clientTable.Refresh();
            }
            else if(buttonSaveClient.Text == "Update")
            {
                conn.writeProcedure("client_update", data);
                clientTable.Rows.Clear();
                clientTable.Refresh();
            }
            
            
            conn.closeConn();
            showClients();
            //generateQR(itemCode, itemName);
            //queryItems();

            clearFields();

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
        public void showClients()
        {
            clientTable.Rows.Clear();
            clientTable.Refresh();
            MySqlDataReader clients = conn.readProcedure("client_view_all");
            while (clients.Read()) 
            {
                clientTable.Rows.Add(
                    new object[]
                    {
                        clients["client_id"],
                        clients["client_fullname"],
                        clients["client_email"]
                    }
                );
            }
            clientTable.Refresh();
            conn.closeConn();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clientTable_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(clientTable.Rows[e.RowIndex].Cells[0].Value.ToString());
            
            MessageBox.Show(""+id);
        }

        private void clientTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            



        }

        private void clientTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(clientTable.Rows[e.RowIndex].Cells[0].Value.ToString());
            //MessageBox.Show("" + id);
            //buttonClientDisable.Visible = true;
            
            string client_fullname = txtClientName.Text;
            string client_username = txtClientUsername.Text;
            string client_password = txtClientPassword.Text;
            string client_email = txtClientEmail.Text;
            string string_id = id.ToString();
            var data = new Dictionary<string, string>()
            {
                { "client_fullname", client_fullname },
                { "client_username", client_username },
                { "client_password", client_password },
                { "client_email", client_email},
                {"id",string_id},
            };
            MySqlDataReader reader = conn.readProcedure("client_view_row", data);
            while(reader.Read())
            {

                string idnum = reader.GetValue(0).ToString();
                string fullname = reader.GetValue(1).ToString();
                string username = reader.GetValue(2).ToString();
                string password = reader.GetValue(3).ToString();
                string email = reader.GetValue(4).ToString();
                txtClientName.Text = fullname;
                txtClientUsername.Text = username;
                txtClientPassword.Text = password;
                txtClientEmail.Text = email;
                txtClientId.Text = idnum;

            }
            buttonSaveClient.Text = "Update";
            buttonAddNew.Visible = true;
            conn.closeConn();
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            buttonSaveClient.Text = "Save";
            buttonAddNew.Visible = false;
            //buttonClientDisable.Visible = false;
            clearFields();
        }

        private void buttonClientDisable_Click(object sender, EventArgs e)
        {
            string string_id = txtClientId.Text;
            
            if (MessageBox.Show("Confirm client disable?", "Confirm ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var data = new Dictionary<string, string>()
                {
                    {"id", string_id },
                };
                conn.writeProcedure("client_disable", data);
                conn.closeConn();
                showClients();
                clearFields();
            }
            else
            {
                

            }
            
        }



        //private void getClients()
        //{
        //    var data = new Dictionary<string, string>()
        //    {
        //        { "client_fullname", client_fullname },
        //        { "client_username", client_username },
        //        { "client_password", client_password },
        //        { "client_email", client_email},
        //        { "emp_position", emp_position }
        //    };
        //    readProcedure("client_view_all", data);
        //}
        //DESKTOP-6DNE4CI

    }




    
}
