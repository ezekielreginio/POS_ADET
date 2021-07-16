
namespace POS_ADET
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sidePanel = new System.Windows.Forms.Panel();
            this.sidepanelMenu = new System.Windows.Forms.Panel();
            this.panelLogs = new System.Windows.Forms.Panel();
            this.btnSalesLogs = new System.Windows.Forms.Button();
            this.btnReturnRefundLogs = new System.Windows.Forms.Button();
            this.btnItemLogs = new System.Windows.Forms.Button();
            this.panelUsersManagement = new System.Windows.Forms.Panel();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.panelSalesManagementSubmenu = new System.Windows.Forms.Panel();
            this.btnRefund = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.sidePanelHeader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnSalesAnalytics = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnItemsManagement = new System.Windows.Forms.Button();
            this.btnUsersManagement = new System.Windows.Forms.Button();
            this.btnSalesManagement = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sidePanel.SuspendLayout();
            this.sidepanelMenu.SuspendLayout();
            this.panelLogs.SuspendLayout();
            this.panelUsersManagement.SuspendLayout();
            this.panelSalesManagementSubmenu.SuspendLayout();
            this.sidePanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.sidePanel.Controls.Add(this.sidepanelMenu);
            this.sidePanel.Controls.Add(this.sidePanelHeader);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(205, 720);
            this.sidePanel.TabIndex = 1;
            // 
            // sidepanelMenu
            // 
            this.sidepanelMenu.AutoScroll = true;
            this.sidepanelMenu.Controls.Add(this.btnSalesAnalytics);
            this.sidepanelMenu.Controls.Add(this.panelLogs);
            this.sidepanelMenu.Controls.Add(this.button1);
            this.sidepanelMenu.Controls.Add(this.btnItemsManagement);
            this.sidepanelMenu.Controls.Add(this.panelUsersManagement);
            this.sidepanelMenu.Controls.Add(this.btnUsersManagement);
            this.sidepanelMenu.Controls.Add(this.panelSalesManagementSubmenu);
            this.sidepanelMenu.Controls.Add(this.btnLogout);
            this.sidepanelMenu.Controls.Add(this.btnSalesManagement);
            this.sidepanelMenu.Controls.Add(this.btnDashboard);
            this.sidepanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidepanelMenu.Location = new System.Drawing.Point(0, 150);
            this.sidepanelMenu.Name = "sidepanelMenu";
            this.sidepanelMenu.Size = new System.Drawing.Size(205, 572);
            this.sidepanelMenu.TabIndex = 1;
            // 
            // panelLogs
            // 
            this.panelLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelLogs.Controls.Add(this.btnSalesLogs);
            this.panelLogs.Controls.Add(this.btnReturnRefundLogs);
            this.panelLogs.Controls.Add(this.btnItemLogs);
            this.panelLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogs.Location = new System.Drawing.Point(0, 319);
            this.panelLogs.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogs.Name = "panelLogs";
            this.panelLogs.Size = new System.Drawing.Size(205, 90);
            this.panelLogs.TabIndex = 3;
            this.panelLogs.Visible = false;
            // 
            // btnSalesLogs
            // 
            this.btnSalesLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalesLogs.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalesLogs.FlatAppearance.BorderSize = 0;
            this.btnSalesLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesLogs.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalesLogs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSalesLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesLogs.Location = new System.Drawing.Point(0, 62);
            this.btnSalesLogs.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalesLogs.Name = "btnSalesLogs";
            this.btnSalesLogs.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnSalesLogs.Size = new System.Drawing.Size(205, 31);
            this.btnSalesLogs.TabIndex = 1;
            this.btnSalesLogs.Text = "Sales Logs";
            this.btnSalesLogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesLogs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalesLogs.UseVisualStyleBackColor = true;
            this.btnSalesLogs.Click += new System.EventHandler(this.btnSalesLogs_Click);
            // 
            // btnReturnRefundLogs
            // 
            this.btnReturnRefundLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReturnRefundLogs.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReturnRefundLogs.FlatAppearance.BorderSize = 0;
            this.btnReturnRefundLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnRefundLogs.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReturnRefundLogs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnReturnRefundLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnRefundLogs.Location = new System.Drawing.Point(0, 31);
            this.btnReturnRefundLogs.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturnRefundLogs.Name = "btnReturnRefundLogs";
            this.btnReturnRefundLogs.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnReturnRefundLogs.Size = new System.Drawing.Size(205, 31);
            this.btnReturnRefundLogs.TabIndex = 0;
            this.btnReturnRefundLogs.Text = "Return/Refund Logs";
            this.btnReturnRefundLogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnRefundLogs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReturnRefundLogs.UseVisualStyleBackColor = true;
            this.btnReturnRefundLogs.Click += new System.EventHandler(this.btnReturnRefundLogs_Click);
            // 
            // btnItemLogs
            // 
            this.btnItemLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnItemLogs.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnItemLogs.FlatAppearance.BorderSize = 0;
            this.btnItemLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemLogs.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnItemLogs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnItemLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItemLogs.Location = new System.Drawing.Point(0, 0);
            this.btnItemLogs.Margin = new System.Windows.Forms.Padding(0);
            this.btnItemLogs.Name = "btnItemLogs";
            this.btnItemLogs.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnItemLogs.Size = new System.Drawing.Size(205, 31);
            this.btnItemLogs.TabIndex = 0;
            this.btnItemLogs.Text = "Item Logs";
            this.btnItemLogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItemLogs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnItemLogs.UseVisualStyleBackColor = true;
            this.btnItemLogs.Click += new System.EventHandler(this.btnItemLogs_Click);
            // 
            // panelUsersManagement
            // 
            this.panelUsersManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelUsersManagement.Controls.Add(this.btnClients);
            this.panelUsersManagement.Controls.Add(this.btnEmployees);
            this.panelUsersManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsersManagement.Location = new System.Drawing.Point(0, 160);
            this.panelUsersManagement.Name = "panelUsersManagement";
            this.panelUsersManagement.Size = new System.Drawing.Size(273, 47);
            this.panelUsersManagement.TabIndex = 1;
            this.panelUsersManagement.Visible = false;
            // 
            // btnClients
            // 
            this.btnClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClients.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClients.FlatAppearance.BorderSize = 0;
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClients.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClients.Location = new System.Drawing.Point(0, 31);
            this.btnClients.Margin = new System.Windows.Forms.Padding(0);
            this.btnClients.Name = "btnClients";
            this.btnClients.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnClients.Size = new System.Drawing.Size(205, 31);
            this.btnClients.TabIndex = 0;
            this.btnClients.Text = "Clients";
            this.btnClients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Visible = false;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployees.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.Location = new System.Drawing.Point(0, 0);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(0);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnEmployees.Size = new System.Drawing.Size(205, 31);
            this.btnEmployees.TabIndex = 0;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // panelSalesManagementSubmenu
            // 
            this.panelSalesManagementSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelSalesManagementSubmenu.Controls.Add(this.btnRefund);
            this.panelSalesManagementSubmenu.Controls.Add(this.btnPOS);
            this.panelSalesManagementSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSalesManagementSubmenu.Location = new System.Drawing.Point(0, 62);
            this.panelSalesManagementSubmenu.Name = "panelSalesManagementSubmenu";
            this.panelSalesManagementSubmenu.Size = new System.Drawing.Size(205, 67);
            this.panelSalesManagementSubmenu.TabIndex = 1;
            this.panelSalesManagementSubmenu.Visible = false;
            // 
            // btnRefund
            // 
            this.btnRefund.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRefund.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRefund.FlatAppearance.BorderSize = 0;
            this.btnRefund.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefund.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRefund.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnRefund.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefund.Location = new System.Drawing.Point(0, 31);
            this.btnRefund.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnRefund.Size = new System.Drawing.Size(205, 31);
            this.btnRefund.TabIndex = 0;
            this.btnRefund.Text = "Return/Refund";
            this.btnRefund.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefund.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefund.UseVisualStyleBackColor = true;
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPOS.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPOS.FlatAppearance.BorderSize = 0;
            this.btnPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPOS.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPOS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPOS.Location = new System.Drawing.Point(0, 0);
            this.btnPOS.Margin = new System.Windows.Forms.Padding(0);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnPOS.Size = new System.Drawing.Size(205, 31);
            this.btnPOS.TabIndex = 0;
            this.btnPOS.Text = "POS System";
            this.btnPOS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPOS.UseVisualStyleBackColor = true;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(3, 529);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(171, 31);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // sidePanelHeader
            // 
            this.sidePanelHeader.Controls.Add(this.label2);
            this.sidePanelHeader.Controls.Add(this.pictureBox1);
            this.sidePanelHeader.Controls.Add(this.label1);
            this.sidePanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanelHeader.Location = new System.Drawing.Point(0, 0);
            this.sidePanelHeader.Name = "sidePanelHeader";
            this.sidePanelHeader.Size = new System.Drawing.Size(205, 150);
            this.sidePanelHeader.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(36, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome, User";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prime Apparel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mainPanel.Location = new System.Drawing.Point(205, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(993, 720);
            this.mainPanel.TabIndex = 2;
            // 
            // btnSalesAnalytics
            // 
            this.btnSalesAnalytics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalesAnalytics.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalesAnalytics.FlatAppearance.BorderSize = 0;
            this.btnSalesAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesAnalytics.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalesAnalytics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSalesAnalytics.Image = global::POS_ADET.Properties.Resources.diagram2;
            this.btnSalesAnalytics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesAnalytics.Location = new System.Drawing.Point(0, 379);
            this.btnSalesAnalytics.Name = "btnSalesAnalytics";
            this.btnSalesAnalytics.Size = new System.Drawing.Size(205, 31);
            this.btnSalesAnalytics.TabIndex = 0;
            this.btnSalesAnalytics.Text = "Sales Analytics";
            this.btnSalesAnalytics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalesAnalytics.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.Image = global::POS_ADET.Properties.Resources.diagram2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "logs";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnItemsManagement
            // 
            this.btnItemsManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnItemsManagement.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnItemsManagement.FlatAppearance.BorderSize = 0;
            this.btnItemsManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemsManagement.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnItemsManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
           // this.btnItemsManagement.Image = global::POS_ADET.Properties.Resources.settings;
            this.btnItemsManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItemsManagement.Location = new System.Drawing.Point(0, 227);
            this.btnItemsManagement.Name = "btnItemsManagement";
            this.btnItemsManagement.Size = new System.Drawing.Size(205, 31);
            this.btnItemsManagement.TabIndex = 0;
            this.btnItemsManagement.Text = "Items Management";
            this.btnItemsManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnItemsManagement.UseVisualStyleBackColor = true;
            this.btnItemsManagement.Click += new System.EventHandler(this.btnItemsManagement_Click);
            // 
            // btnUsersManagement
            // 
            this.btnUsersManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsersManagement.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUsersManagement.FlatAppearance.BorderSize = 0;
            this.btnUsersManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsersManagement.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnUsersManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnUsersManagement.Image = global::POS_ADET.Properties.Resources.Conact;
            this.btnUsersManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsersManagement.Location = new System.Drawing.Point(0, 129);
            this.btnUsersManagement.Name = "btnUsersManagement";
            this.btnUsersManagement.Size = new System.Drawing.Size(205, 31);
            this.btnUsersManagement.TabIndex = 0;
            this.btnUsersManagement.Text = "Users Management";
            this.btnUsersManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsersManagement.UseVisualStyleBackColor = true;
            this.btnUsersManagement.Click += new System.EventHandler(this.btnUsersManagement_Click);
            // 
            // sidePanelHeader
            // 
            this.sidePanelHeader.Controls.Add(this.label2);
            this.sidePanelHeader.Controls.Add(this.pictureBox1);
            this.sidePanelHeader.Controls.Add(this.label1);
            this.sidePanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanelHeader.Location = new System.Drawing.Point(0, 0);
            this.sidePanelHeader.Name = "sidePanelHeader";
            this.sidePanelHeader.Size = new System.Drawing.Size(205, 150);
            this.sidePanelHeader.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(36, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome, User";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prime Apparel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mainPanel.Location = new System.Drawing.Point(205, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(993, 720);
            this.mainPanel.TabIndex = 2;
            // 
            // btnSalesAnalytics
            // 
            this.btnSalesAnalytics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalesAnalytics.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalesAnalytics.FlatAppearance.BorderSize = 0;
            this.btnSalesAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesAnalytics.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalesAnalytics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSalesAnalytics.Image = global::POS_ADET.Properties.Resources.diagram2;
            this.btnSalesAnalytics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesAnalytics.Location = new System.Drawing.Point(0, 379);
            this.btnSalesAnalytics.Name = "btnSalesAnalytics";
            this.btnSalesAnalytics.Size = new System.Drawing.Size(205, 31);
            this.btnSalesAnalytics.TabIndex = 0;
            this.btnSalesAnalytics.Text = "Sales Analytics";
            this.btnSalesAnalytics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalesAnalytics.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.Image = global::POS_ADET.Properties.Resources.diagram2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "logs";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnItemsManagement
            // 
            this.btnItemsManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnItemsManagement.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnItemsManagement.FlatAppearance.BorderSize = 0;
            this.btnItemsManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemsManagement.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnItemsManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            //this.btnItemsManagement.Image = global::POS_ADET.Properties.Resources.settings;
            this.btnItemsManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItemsManagement.Location = new System.Drawing.Point(0, 227);
            this.btnItemsManagement.Name = "btnItemsManagement";
            this.btnItemsManagement.Size = new System.Drawing.Size(205, 31);
            this.btnItemsManagement.TabIndex = 0;
            this.btnItemsManagement.Text = "Items Management";
            this.btnItemsManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnItemsManagement.UseVisualStyleBackColor = true;
            this.btnItemsManagement.Click += new System.EventHandler(this.btnItemsManagement_Click);
            // 
            // btnUsersManagement
            // 
            this.btnUsersManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsersManagement.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUsersManagement.FlatAppearance.BorderSize = 0;
            this.btnUsersManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsersManagement.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnUsersManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnUsersManagement.Image = global::POS_ADET.Properties.Resources.Conact;
            this.btnUsersManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsersManagement.Location = new System.Drawing.Point(0, 129);
            this.btnUsersManagement.Name = "btnUsersManagement";
            this.btnUsersManagement.Size = new System.Drawing.Size(205, 31);
            this.btnUsersManagement.TabIndex = 0;
            this.btnUsersManagement.Text = "Users Management";
            this.btnUsersManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsersManagement.UseVisualStyleBackColor = true;
            this.btnUsersManagement.Click += new System.EventHandler(this.btnUsersManagement_Click);
            // 
            // btnSalesManagement
            // 
            this.btnSalesManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalesManagement.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalesManagement.FlatAppearance.BorderSize = 0;
            this.btnSalesManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesManagement.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalesManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSalesManagement.Image = global::POS_ADET.Properties.Resources.diagram1;
            this.btnSalesManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesManagement.Location = new System.Drawing.Point(0, 31);
            this.btnSalesManagement.Name = "btnSalesManagement";
            this.btnSalesManagement.Size = new System.Drawing.Size(205, 31);
            this.btnSalesManagement.TabIndex = 0;
            this.btnSalesManagement.Text = "Sales Management";
            this.btnSalesManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalesManagement.UseVisualStyleBackColor = true;
            this.btnSalesManagement.Click += new System.EventHandler(this.btnSalesManagement_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDashboard.Image = global::POS_ADET.Properties.Resources.diagram;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(205, 31);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Visible = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS_ADET.Properties.Resources.Untitled_11;
            this.pictureBox1.Location = new System.Drawing.Point(58, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainForm";
            this.sidePanel.ResumeLayout(false);
            this.sidepanelMenu.ResumeLayout(false);
            this.panelLogs.ResumeLayout(false);
            this.panelUsersManagement.ResumeLayout(false);
            this.panelSalesManagementSubmenu.ResumeLayout(false);
            this.sidePanelHeader.ResumeLayout(false);
            this.sidePanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel sidepanelMenu;
        private System.Windows.Forms.Button btnSalesAnalytics;
        private System.Windows.Forms.Button btnItemsManagement;
        private System.Windows.Forms.Panel panelUsersManagement;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnUsersManagement;
        private System.Windows.Forms.Panel panelSalesManagementSubmenu;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSalesManagement;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel sidePanelHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panelLogs;
        private System.Windows.Forms.Button btnReturnRefundLogs;
        private System.Windows.Forms.Button btnItemLogs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalesLogs;
    }
}