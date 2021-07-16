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
            if (txtUsername.Text=="admin" && txtPassword.Text=="123")
            {
                LoadingPage loadingPage = new LoadingPage();
                loadingPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }
    }
}
