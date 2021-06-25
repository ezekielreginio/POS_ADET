
namespace POS_ADET.Modules.UsersManagement
{
    partial class EmployeeManagementPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManagementPanel));
            this.EmpPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.picboxItem = new System.Windows.Forms.PictureBox();
            this.txtEmployeePosition = new Bunifu.UI.WinForms.BunifuDropdown();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.buttonSaveEmployee = new System.Windows.Forms.Button();
            this.txtEmployeeEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmployeePassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmployeeUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emp_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mp_fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxItem)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpPanel
            // 
            this.EmpPanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.EmpPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EmpPanel.BackgroundImage")));
            this.EmpPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EmpPanel.BorderColor = System.Drawing.Color.Transparent;
            this.EmpPanel.BorderRadius = 3;
            this.EmpPanel.BorderThickness = 1;
            this.EmpPanel.Controls.Add(this.dataGridView1);
            this.EmpPanel.Controls.Add(this.panel1);
            this.EmpPanel.Controls.Add(this.panel2);
            this.EmpPanel.Controls.Add(this.label2);
            this.EmpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmpPanel.Location = new System.Drawing.Point(0, 0);
            this.EmpPanel.Name = "EmpPanel";
            this.EmpPanel.ShowBorders = true;
            this.EmpPanel.Size = new System.Drawing.Size(993, 720);
            this.EmpPanel.TabIndex = 0;
            this.EmpPanel.Click += new System.EventHandler(this.bunifuPanel1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(705, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 54);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(31, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add an Employee";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.picboxItem);
            this.panel2.Controls.Add(this.txtEmployeePosition);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblFilePath);
            this.panel2.Controls.Add(this.buttonSaveEmployee);
            this.panel2.Controls.Add(this.txtEmployeeEmail);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtEmployeePassword);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtEmployeeUsername);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtEmployeeName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(705, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 612);
            this.panel2.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(0, 356);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label9.Size = new System.Drawing.Size(173, 38);
            this.label9.TabIndex = 15;
            this.label9.Text = "Employee Image:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picboxItem
            // 
            this.picboxItem.BackColor = System.Drawing.Color.LightGray;
            this.picboxItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picboxItem.Location = new System.Drawing.Point(65, 400);
            this.picboxItem.Name = "picboxItem";
            this.picboxItem.Size = new System.Drawing.Size(160, 140);
            this.picboxItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxItem.TabIndex = 13;
            this.picboxItem.TabStop = false;
            // 
            // txtEmployeePosition
            // 
            this.txtEmployeePosition.BackColor = System.Drawing.Color.Transparent;
            this.txtEmployeePosition.BackgroundColor = System.Drawing.Color.White;
            this.txtEmployeePosition.BorderColor = System.Drawing.Color.Silver;
            this.txtEmployeePosition.BorderRadius = 1;
            this.txtEmployeePosition.Color = System.Drawing.Color.Silver;
            this.txtEmployeePosition.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.txtEmployeePosition.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtEmployeePosition.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtEmployeePosition.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtEmployeePosition.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmployeePosition.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.txtEmployeePosition.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEmployeePosition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtEmployeePosition.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.txtEmployeePosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtEmployeePosition.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.txtEmployeePosition.FillDropDown = true;
            this.txtEmployeePosition.FillIndicator = false;
            this.txtEmployeePosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtEmployeePosition.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmployeePosition.ForeColor = System.Drawing.Color.Black;
            this.txtEmployeePosition.FormattingEnabled = true;
            this.txtEmployeePosition.Icon = null;
            this.txtEmployeePosition.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.txtEmployeePosition.IndicatorColor = System.Drawing.Color.Gray;
            this.txtEmployeePosition.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.txtEmployeePosition.ItemBackColor = System.Drawing.Color.White;
            this.txtEmployeePosition.ItemBorderColor = System.Drawing.Color.White;
            this.txtEmployeePosition.ItemForeColor = System.Drawing.Color.Black;
            this.txtEmployeePosition.ItemHeight = 26;
            this.txtEmployeePosition.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.txtEmployeePosition.ItemHighLightForeColor = System.Drawing.Color.White;
            this.txtEmployeePosition.ItemTopMargin = 3;
            this.txtEmployeePosition.Location = new System.Drawing.Point(0, 324);
            this.txtEmployeePosition.Name = "txtEmployeePosition";
            this.txtEmployeePosition.Size = new System.Drawing.Size(288, 32);
            this.txtEmployeePosition.TabIndex = 13;
            this.txtEmployeePosition.Text = null;
            this.txtEmployeePosition.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.txtEmployeePosition.TextLeftMargin = 5;
            this.txtEmployeePosition.SelectedIndexChanged += new System.EventHandler(this.bunifuDropdown1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Upload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(0, 286);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label4.Size = new System.Drawing.Size(93, 38);
            this.label4.TabIndex = 14;
            this.label4.Text = "Position:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFilePath.Location = new System.Drawing.Point(5, 337);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(52, 13);
            this.lblFilePath.TabIndex = 12;
            this.lblFilePath.Text = "               ";
            // 
            // buttonSaveEmployee
            // 
            this.buttonSaveEmployee.Location = new System.Drawing.Point(108, 546);
            this.buttonSaveEmployee.Name = "buttonSaveEmployee";
            this.buttonSaveEmployee.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveEmployee.TabIndex = 11;
            this.buttonSaveEmployee.Text = "Save";
            this.buttonSaveEmployee.UseVisualStyleBackColor = true;
            this.buttonSaveEmployee.Click += new System.EventHandler(this.buttonSaveEmployee_Click);
            // 
            // txtEmployeeEmail
            // 
            this.txtEmployeeEmail.BorderRadius = 3;
            this.txtEmployeeEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmployeeEmail.DefaultText = "";
            this.txtEmployeeEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmployeeEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmployeeEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmployeeEmail.DisabledState.Parent = this.txtEmployeeEmail;
            this.txtEmployeeEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmployeeEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEmployeeEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmployeeEmail.FocusedState.Parent = this.txtEmployeeEmail;
            this.txtEmployeeEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmployeeEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmployeeEmail.HoverState.Parent = this.txtEmployeeEmail;
            this.txtEmployeeEmail.Location = new System.Drawing.Point(0, 250);
            this.txtEmployeeEmail.Name = "txtEmployeeEmail";
            this.txtEmployeeEmail.PasswordChar = '\0';
            this.txtEmployeeEmail.PlaceholderText = "";
            this.txtEmployeeEmail.SelectedText = "";
            this.txtEmployeeEmail.ShadowDecoration.Parent = this.txtEmployeeEmail;
            this.txtEmployeeEmail.Size = new System.Drawing.Size(288, 36);
            this.txtEmployeeEmail.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(0, 212);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label7.Size = new System.Drawing.Size(150, 38);
            this.label7.TabIndex = 3;
            this.label7.Text = "Email Address:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEmployeePassword
            // 
            this.txtEmployeePassword.BorderRadius = 3;
            this.txtEmployeePassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmployeePassword.DefaultText = "";
            this.txtEmployeePassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmployeePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmployeePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmployeePassword.DisabledState.Parent = this.txtEmployeePassword;
            this.txtEmployeePassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmployeePassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEmployeePassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmployeePassword.FocusedState.Parent = this.txtEmployeePassword;
            this.txtEmployeePassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmployeePassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmployeePassword.HoverState.Parent = this.txtEmployeePassword;
            this.txtEmployeePassword.Location = new System.Drawing.Point(0, 176);
            this.txtEmployeePassword.Name = "txtEmployeePassword";
            this.txtEmployeePassword.PasswordChar = '\0';
            this.txtEmployeePassword.PlaceholderText = "";
            this.txtEmployeePassword.SelectedText = "";
            this.txtEmployeePassword.ShadowDecoration.Parent = this.txtEmployeePassword;
            this.txtEmployeePassword.Size = new System.Drawing.Size(288, 36);
            this.txtEmployeePassword.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(0, 138);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label6.Size = new System.Drawing.Size(106, 38);
            this.label6.TabIndex = 3;
            this.label6.Text = "Password:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEmployeeUsername
            // 
            this.txtEmployeeUsername.BorderRadius = 3;
            this.txtEmployeeUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmployeeUsername.DefaultText = "";
            this.txtEmployeeUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmployeeUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmployeeUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmployeeUsername.DisabledState.Parent = this.txtEmployeeUsername;
            this.txtEmployeeUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmployeeUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEmployeeUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmployeeUsername.FocusedState.Parent = this.txtEmployeeUsername;
            this.txtEmployeeUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmployeeUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmployeeUsername.HoverState.Parent = this.txtEmployeeUsername;
            this.txtEmployeeUsername.Location = new System.Drawing.Point(0, 102);
            this.txtEmployeeUsername.Name = "txtEmployeeUsername";
            this.txtEmployeeUsername.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.txtEmployeeUsername.PasswordChar = '\0';
            this.txtEmployeeUsername.PlaceholderText = "";
            this.txtEmployeeUsername.SelectedText = "";
            this.txtEmployeeUsername.ShadowDecoration.Parent = this.txtEmployeeUsername;
            this.txtEmployeeUsername.Size = new System.Drawing.Size(288, 36);
            this.txtEmployeeUsername.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(0, 64);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label5.Size = new System.Drawing.Size(111, 38);
            this.label5.TabIndex = 3;
            this.label5.Text = "Username:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.BorderRadius = 3;
            this.txtEmployeeName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmployeeName.DefaultText = "";
            this.txtEmployeeName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmployeeName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmployeeName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmployeeName.DisabledState.Parent = this.txtEmployeeName;
            this.txtEmployeeName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmployeeName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEmployeeName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmployeeName.FocusedState.Parent = this.txtEmployeeName;
            this.txtEmployeeName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmployeeName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmployeeName.HoverState.Parent = this.txtEmployeeName;
            this.txtEmployeeName.Location = new System.Drawing.Point(0, 28);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.PasswordChar = '\0';
            this.txtEmployeeName.PlaceholderText = "";
            this.txtEmployeeName.SelectedText = "";
            this.txtEmployeeName.ShadowDecoration.Parent = this.txtEmployeeName;
            this.txtEmployeeName.Size = new System.Drawing.Size(288, 36);
            this.txtEmployeeName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Full Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Text Management";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // emp_id
            // 
            this.emp_id.Name = "emp_id";
            // 
            // mp_fullname
            // 
            this.mp_fullname.Name = "mp_fullname";
            // 
            // emp_email
            // 
            this.emp_email.Name = "emp_email";
            // 
            // emp_position
            // 
            this.emp_position.Name = "emp_position";
            // 
            // EmployeeManagementPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(993, 720);
            this.Controls.Add(this.EmpPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeManagementPanel";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.EmpPanel.ResumeLayout(false);
            this.EmpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel EmpPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button buttonSaveEmployee;
        private Guna.UI2.WinForms.Guna2TextBox txtEmployeeEmail;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtEmployeePassword;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtEmployeeUsername;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtEmployeeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picboxItem;
        private System.Windows.Forms.Button button1;
        private Bunifu.UI.WinForms.BunifuDropdown txtEmployeePosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn mp_fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_position;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}