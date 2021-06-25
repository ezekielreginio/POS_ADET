using POS_ADET.Classes.Dropbox;
using POS_ADET.Modules.Dashboard;
using POS_ADET.Modules.ItemsManagement;
using POS_ADET.Modules.UsersManagement;
using POS_ADET.Modules.UsersManagement.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_ADET
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
          
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalesManagement_Click(object sender, EventArgs e)
        {
            panelSalesManagementSubmenu.Visible = !(panelSalesManagementSubmenu.Visible);
        }

        private void btnUsersManagement_Click(object sender, EventArgs e)
        {
            panelUsersManagement.Visible = !(panelUsersManagement.Visible);
        }

        //User Defined Functions:
        private Form activeForm = null;
        private void openPanel(Form childForm)
        {
            if (activeForm != null)
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            openPanel(new dashboardPanel());
        }

        private void btnItemsManagement_Click(object sender, EventArgs e)
        {
            ItemManagementPanel itemMgmt = new ItemManagementPanel();
            itemMgmt.queryItems();
            openPanel(itemMgmt);
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            EmployeeManagementPanel empMgmt = new EmployeeManagementPanel();
            //empMgmt.queryItems();
            openPanel(empMgmt);
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            ClientManagementPanel clientMgmt = new ClientManagementPanel();
            //empMgmt.queryItems();
            clientMgmt.showClients();
            openPanel(clientMgmt);

        }
    }
}


