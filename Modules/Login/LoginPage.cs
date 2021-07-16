using MySql.Data.MySqlClient;
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

namespace POS_ADET.Modules.Login
{
    public partial class LoginPage : Form
    {
        private connector conn = new connector();
        public LoginPage()
        {
            InitializeComponent();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            var data = new Dictionary<string, string>()
            {
                {"username", username},
                {"password", password}
            };
            
            MySqlDataReader reader = conn.readProcedure("login_credentials", data);
            if (reader.HasRows)
            {
                //MessageBox.Show(""+reader.FieldCount);
                LoadingPage loadingPage = new LoadingPage();
                loadingPage.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Invalid Credentials");

            }
            conn.closeConn();
        }
    }
}
