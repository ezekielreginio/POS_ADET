using POS_ADET.Modules.Dashboard;
using POS_ADET.Modules.ItemsManagement;
using POS_ADET.Modules.POSManagement;
using POS_ADET.Modules.ReturnRefundManagement;
using POS_ADET.Modules.UsersManagement;
using POS_ADET.Modules.UsersManagement.Client;
using POS_ADET.Modules.LogsManagement.ItemLogs;

using System;
using System.Windows.Forms;
using POS_ADET.Modules.LogsManagement;
using POS_ADET.Modules.LogsManagement.panelLogData;

namespace POS_ADET
{
    public partial class mainForm : Form
    {
        //Private Instances
        POSManagement posMgmt = new POSManagement();
        ReturnRefundManagement retrefMgmt = new ReturnRefundManagement();

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
        public void openPanel(Form childForm)
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
            empMgmt.showEmployees();

            openPanel(empMgmt);
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            ClientManagementPanel clientMgmt = new ClientManagementPanel();
            //empMgmt.queryItems();
            clientMgmt.showClients();
            openPanel(clientMgmt);

        }

        public void btnPOS_Click(object sender, EventArgs e)
        {
            retrefMgmt.stopScanner();
            posMgmt.stopScanner();
            posMgmt = new POSManagement();
            posMgmt.queryItems();
            openPanel(posMgmt);
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            retrefMgmt.stopScanner();
            posMgmt.stopScanner();
            retrefMgmt = new ReturnRefundManagement();
            openPanel(retrefMgmt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelLogs.Visible = true;
        }

        private void btnItemLogs_Click(object sender, EventArgs e)
        {
            panelLogs plm = new panelLogs();
            ItemLogData itemLogData = new ItemLogData();
            plm.Logtype = "itemlog";
            plm.setDataLogPanel(itemLogData);
            openPanel(plm);
            
        }

        private void btnSalesLogs_Click(object sender, EventArgs e)
        {
            panelLogs plm = new panelLogs();
            SalesLogData salesLogData = new SalesLogData();
            plm.Logtype = "saleslog";
            plm.setDataLogPanel(salesLogData);
            openPanel(plm);
        }

        private void btnReturnRefundLogs_Click(object sender, EventArgs e)
        {
            panelLogs plm = new panelLogs();
            ReturnRefundLogData returnRefundLogData = new ReturnRefundLogData();
            plm.Logtype = "returnrefundlog";
            plm.setDataLogPanel(returnRefundLogData);
            openPanel(plm);
        }
<<<<<<< HEAD

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("u sure u wanna logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {

                 
            }
        }
=======
>>>>>>> parent of 5b69e77 (#)
    }
}


