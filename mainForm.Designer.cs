
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
            this.btnItemsManagement = new System.Windows.Forms.Button();
            this.btnUsersManagement = new System.Windows.Forms.Button();
            this.btnSalesManagement = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sidePanel.SuspendLayout();
            this.sidepanelMenu.SuspendLayout();
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
            // panelUsersManagement
            // 
            this.panelUsersManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelUsersManagement.Controls.Add(this.btnClients);
            this.panelUsersManagement.Controls.Add(this.btnEmployees);
            this.panelUsersManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsersManagement.Location = new System.Drawing.Point(0, 160);
            this.panelUsersManagement.Name = "panelUsersManagement";
            this.panelUsersManagement.Size = new System.Drawing.Size(205, 67);
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
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prime Industries";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mainPanel
            // 
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
            this.btnSalesAnalytics.Location = new System.Drawing.Point(0, 258);
            this.btnSalesAnalytics.Name = "btnSalesAnalytics";
            this.btnSalesAnalytics.Size = new System.Drawing.Size(205, 31);
            this.btnSalesAnalytics.TabIndex = 0;
            this.btnSalesAnalytics.Text = "Sales Analytics";
            this.btnSalesAnalytics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalesAnalytics.UseVisualStyleBackColor = true;
            // 
            // btnItemsManagement
            // 
            this.btnItemsManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnItemsManagement.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnItemsManagement.FlatAppearance.BorderSize = 0;
            this.btnItemsManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemsManagement.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnItemsManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnItemsManagement.Image = global::POS_ADET.Properties.Resources.settings;
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
    }
}