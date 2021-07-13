
namespace POS_ADET.Modules.ItemsManagement
{
    partial class ItemManagementPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemManagementPanel));
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.buttonSaveItem = new System.Windows.Forms.Button();
            this.picboxItem = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQty = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtItemPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtItemName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableItemCatalog = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuDatePicker1 = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxItem)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(29, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "Items Management";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtItemCode
            // 
            this.txtItemCode.BorderRadius = 3;
            this.txtItemCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemCode.DefaultText = "";
            this.txtItemCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtItemCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtItemCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemCode.DisabledState.Parent = this.txtItemCode;
            this.txtItemCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtItemCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItemCode.FocusedState.Parent = this.txtItemCode;
            this.txtItemCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtItemCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItemCode.HoverState.Parent = this.txtItemCode;
            this.txtItemCode.Location = new System.Drawing.Point(0, 41);
            this.txtItemCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.PasswordChar = '\0';
            this.txtItemCode.PlaceholderText = "";
            this.txtItemCode.SelectedText = "";
            this.txtItemCode.ShadowDecoration.Parent = this.txtItemCode;
            this.txtItemCode.Size = new System.Drawing.Size(446, 55);
            this.txtItemCode.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblFilePath);
            this.panel2.Controls.Add(this.buttonAddItem);
            this.panel2.Controls.Add(this.buttonSaveItem);
            this.panel2.Controls.Add(this.picboxItem);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtQty);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtItemPrice);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtItemName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtItemCode);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(1044, 125);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 967);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFilePath.Location = new System.Drawing.Point(8, 518);
            this.lblFilePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(0, 20);
            this.lblFilePath.TabIndex = 12;
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(4, 907);
            this.buttonAddItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(138, 35);
            this.buttonAddItem.TabIndex = 11;
            this.buttonAddItem.Text = "Add New Item";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Visible = false;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // buttonSaveItem
            // 
            this.buttonSaveItem.Location = new System.Drawing.Point(321, 907);
            this.buttonSaveItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSaveItem.Name = "buttonSaveItem";
            this.buttonSaveItem.Size = new System.Drawing.Size(112, 35);
            this.buttonSaveItem.TabIndex = 11;
            this.buttonSaveItem.Text = "Save";
            this.buttonSaveItem.UseVisualStyleBackColor = true;
            this.buttonSaveItem.Click += new System.EventHandler(this.buttonSaveItem_Click);
            // 
            // picboxItem
            // 
            this.picboxItem.BackColor = System.Drawing.Color.LightGray;
            this.picboxItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picboxItem.Location = new System.Drawing.Point(89, 503);
            this.picboxItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picboxItem.Name = "picboxItem";
            this.picboxItem.Size = new System.Drawing.Size(265, 243);
            this.picboxItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxItem.TabIndex = 10;
            this.picboxItem.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(142, 777);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 53);
            this.button1.TabIndex = 9;
            this.button1.Text = "Upload";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(0, 429);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.label8.Size = new System.Drawing.Size(217, 56);
            this.label8.TabIndex = 3;
            this.label8.Text = "Upload Image";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtQty
            // 
            this.txtQty.BorderRadius = 3;
            this.txtQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQty.DefaultText = "";
            this.txtQty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQty.DisabledState.Parent = this.txtQty;
            this.txtQty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQty.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtQty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQty.FocusedState.Parent = this.txtQty;
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQty.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQty.HoverState.Parent = this.txtQty;
            this.txtQty.Location = new System.Drawing.Point(0, 374);
            this.txtQty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.PlaceholderText = "";
            this.txtQty.SelectedText = "";
            this.txtQty.ShadowDecoration.Parent = this.txtQty;
            this.txtQty.Size = new System.Drawing.Size(446, 55);
            this.txtQty.TabIndex = 8;
            this.txtQty.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(0, 318);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.label7.Size = new System.Drawing.Size(142, 56);
            this.label7.TabIndex = 3;
            this.label7.Text = "Quantity";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.BorderRadius = 3;
            this.txtItemPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemPrice.DefaultText = "";
            this.txtItemPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtItemPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtItemPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemPrice.DisabledState.Parent = this.txtItemPrice;
            this.txtItemPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtItemPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItemPrice.FocusedState.Parent = this.txtItemPrice;
            this.txtItemPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtItemPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItemPrice.HoverState.Parent = this.txtItemPrice;
            this.txtItemPrice.Location = new System.Drawing.Point(0, 263);
            this.txtItemPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.PasswordChar = '\0';
            this.txtItemPrice.PlaceholderText = "";
            this.txtItemPrice.SelectedText = "";
            this.txtItemPrice.ShadowDecoration.Parent = this.txtItemPrice;
            this.txtItemPrice.Size = new System.Drawing.Size(446, 55);
            this.txtItemPrice.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(0, 207);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.label6.Size = new System.Drawing.Size(160, 56);
            this.label6.TabIndex = 3;
            this.label6.Text = "Item Price";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtItemName
            // 
            this.txtItemName.BorderRadius = 3;
            this.txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemName.DefaultText = "";
            this.txtItemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtItemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtItemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemName.DisabledState.Parent = this.txtItemName;
            this.txtItemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtItemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItemName.FocusedState.Parent = this.txtItemName;
            this.txtItemName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtItemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItemName.HoverState.Parent = this.txtItemName;
            this.txtItemName.Location = new System.Drawing.Point(0, 152);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.txtItemName.PasswordChar = '\0';
            this.txtItemName.PlaceholderText = "";
            this.txtItemName.SelectedText = "";
            this.txtItemName.ShadowDecoration.Parent = this.txtItemName;
            this.txtItemName.Size = new System.Drawing.Size(446, 55);
            this.txtItemName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(0, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.label5.Size = new System.Drawing.Size(174, 56);
            this.label5.TabIndex = 3;
            this.label5.Text = "Item Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item Code";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableItemCatalog
            // 
            this.tableItemCatalog.AutoScroll = true;
            this.tableItemCatalog.ColumnCount = 4;
            this.tableItemCatalog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableItemCatalog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableItemCatalog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableItemCatalog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 248F));
            this.tableItemCatalog.Location = new System.Drawing.Point(28, 125);
            this.tableItemCatalog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableItemCatalog.Name = "tableItemCatalog";
            this.tableItemCatalog.RowCount = 4;
            this.tableItemCatalog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 246F));
            this.tableItemCatalog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 246F));
            this.tableItemCatalog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 246F));
            this.tableItemCatalog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 246F));
            this.tableItemCatalog.Size = new System.Drawing.Size(966, 942);
            this.tableItemCatalog.TabIndex = 8;
            this.tableItemCatalog.Paint += new System.Windows.Forms.PaintEventHandler(this.tableItemCatalog_Paint);
            // 
            // bunifuDatePicker1
            // 
            this.bunifuDatePicker1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDatePicker1.BorderRadius = 1;
            this.bunifuDatePicker1.Color = System.Drawing.Color.Silver;
            this.bunifuDatePicker1.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.bunifuDatePicker1.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.bunifuDatePicker1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker1.DisplayWeekNumbers = false;
            this.bunifuDatePicker1.DPHeight = 0;
            this.bunifuDatePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.bunifuDatePicker1.FillDatePicker = false;
            this.bunifuDatePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuDatePicker1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDatePicker1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuDatePicker1.Icon")));
            this.bunifuDatePicker1.IconColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker1.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.bunifuDatePicker1.LeftTextMargin = 5;
            this.bunifuDatePicker1.Location = new System.Drawing.Point(657, 60);
            this.bunifuDatePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuDatePicker1.MinimumSize = new System.Drawing.Size(4, 32);
            this.bunifuDatePicker1.Name = "bunifuDatePicker1";
            this.bunifuDatePicker1.Size = new System.Drawing.Size(328, 32);
            this.bunifuDatePicker1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(100, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add an Item";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1044, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 83);
            this.panel1.TabIndex = 5;
            // 
            // ItemManagementPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1490, 1106);
            this.Controls.Add(this.bunifuDatePicker1);
            this.Controls.Add(this.tableItemCatalog);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ItemManagementPanel";
            this.Text = "ItemManagementPanel";
            this.Load += new System.EventHandler(this.ItemManagementPanel_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxItem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtItemCode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtItemPrice;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtItemName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSaveItem;
        private System.Windows.Forms.PictureBox picboxItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtQty;
        private System.Windows.Forms.TableLayoutPanel tableItemCatalog;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button buttonAddItem;
        private Bunifu.UI.WinForms.BunifuDatePicker bunifuDatePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}