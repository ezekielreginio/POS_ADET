using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //openPanel(new panelDashboard());
        }

        private void btnSalesManagement_Click(object sender, EventArgs e)
        {
            panelSalesManagementSubmenu.Visible = !(panelSalesManagementSubmenu.Visible);
        }

        private void btnUsersManagement_Click(object sender, EventArgs e)
        {
            panelUsersManagement.Visible = !(panelUsersManagement.Visible);
        }

        private Form activeForm = null;
        private void openPanel(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            mainPanel.Controls.Add(childForm);
            mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            
        }

        private void btnItemsManagement_Click(object sender, EventArgs e)
        {
            //openPanel(new formItemManagement());
        }
    }
}
