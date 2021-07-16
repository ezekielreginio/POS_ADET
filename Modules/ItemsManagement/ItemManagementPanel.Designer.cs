
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textFieldQty = new POS_ADET.Controls.TextField();
            this.label7 = new System.Windows.Forms.Label();
            this.textFieldItemPrice = new POS_ADET.Controls.TextField();
            this.label6 = new System.Windows.Forms.Label();
            this.textFieldItemName = new POS_ADET.Controls.TextField();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.buttonSaveItem = new System.Windows.Forms.Button();
            this.picboxItem = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textFieldItemCode = new POS_ADET.Controls.TextField();
            this.label3 = new System.Windows.Forms.Label();
            this.tableItemCatalog = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuDatePicker1 = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxItem)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Items Management";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(940, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 66);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(75, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add an Item";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textFieldQty);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textFieldItemPrice);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textFieldItemName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblFilePath);
            this.panel2.Controls.Add(this.buttonAddItem);
            this.panel2.Controls.Add(this.buttonSaveItem);
            this.panel2.Controls.Add(this.picboxItem);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textFieldItemCode);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(940, 118);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 753);
            this.panel2.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(0, 396);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 35);
            this.label8.TabIndex = 3;
            this.label8.Text = "Upload Image";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textFieldQty
            // 
            this.textFieldQty.BackColor = System.Drawing.Color.Transparent;
            this.textFieldQty.Dock = System.Windows.Forms.DockStyle.Top;
            this.textFieldQty.FieldType = POS_ADET.Controls.TextField.FieldTypes.Currency;
            this.textFieldQty.Location = new System.Drawing.Point(0, 332);
            this.textFieldQty.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textFieldQty.Name = "textFieldQty";
            this.textFieldQty.Size = new System.Drawing.Size(384, 64);
            this.textFieldQty.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(0, 297);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 35);
            this.label7.TabIndex = 3;
            this.label7.Text = "Quantity";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textFieldItemPrice
            // 
            this.textFieldItemPrice.BackColor = System.Drawing.Color.Transparent;
            this.textFieldItemPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.textFieldItemPrice.FieldType = POS_ADET.Controls.TextField.FieldTypes.Currency;
            this.textFieldItemPrice.Location = new System.Drawing.Point(0, 233);
            this.textFieldItemPrice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textFieldItemPrice.Name = "textFieldItemPrice";
            this.textFieldItemPrice.Size = new System.Drawing.Size(384, 64);
            this.textFieldItemPrice.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(0, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 35);
            this.label6.TabIndex = 3;
            this.label6.Text = "Item Price";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textFieldItemName
            // 
            this.textFieldItemName.BackColor = System.Drawing.Color.Transparent;
            this.textFieldItemName.Dock = System.Windows.Forms.DockStyle.Top;
            this.textFieldItemName.FieldType = POS_ADET.Controls.TextField.FieldTypes.String;
            this.textFieldItemName.Location = new System.Drawing.Point(0, 134);
            this.textFieldItemName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textFieldItemName.Name = "textFieldItemName";
            this.textFieldItemName.Size = new System.Drawing.Size(384, 64);
            this.textFieldItemName.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(0, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 35);
            this.label5.TabIndex = 3;
            this.label5.Text = "Item Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFilePath.Location = new System.Drawing.Point(16, 434);
            this.lblFilePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(0, 17);
            this.lblFilePath.TabIndex = 12;
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(4, 689);
            this.buttonAddItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(123, 28);
            this.buttonAddItem.TabIndex = 11;
            this.buttonAddItem.Text = "Add New Item";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Visible = false;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // buttonSaveItem
            // 
            this.buttonSaveItem.Location = new System.Drawing.Point(268, 689);
            this.buttonSaveItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSaveItem.Name = "buttonSaveItem";
            this.buttonSaveItem.Size = new System.Drawing.Size(100, 28);
            this.buttonSaveItem.TabIndex = 11;
            this.buttonSaveItem.Text = "Save";
            this.buttonSaveItem.UseVisualStyleBackColor = true;
            this.buttonSaveItem.Click += new System.EventHandler(this.buttonSaveItem_Click);
            // 
            // picboxItem
            // 
            this.picboxItem.BackColor = System.Drawing.Color.LightGray;
            this.picboxItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picboxItem.Location = new System.Drawing.Point(84, 490);
            this.picboxItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picboxItem.Name = "picboxItem";
            this.picboxItem.Size = new System.Drawing.Size(213, 172);
            this.picboxItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxItem.TabIndex = 10;
            this.picboxItem.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 402);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Upload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textFieldItemCode
            // 
            this.textFieldItemCode.BackColor = System.Drawing.Color.Transparent;
            this.textFieldItemCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.textFieldItemCode.FieldType = POS_ADET.Controls.TextField.FieldTypes.Integer;
            this.textFieldItemCode.Location = new System.Drawing.Point(0, 35);
            this.textFieldItemCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textFieldItemCode.Name = "textFieldItemCode";
            this.textFieldItemCode.Size = new System.Drawing.Size(384, 64);
            this.textFieldItemCode.TabIndex = 13;
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
            this.label3.Size = new System.Drawing.Size(137, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item Code";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableItemCatalog
            // 
            this.tableItemCatalog.AutoScroll = true;
            this.tableItemCatalog.ColumnCount = 4;
            this.tableItemCatalog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tableItemCatalog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tableItemCatalog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tableItemCatalog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableItemCatalog.Location = new System.Drawing.Point(25, 118);
            this.tableItemCatalog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableItemCatalog.Name = "tableItemCatalog";
            this.tableItemCatalog.RowCount = 4;
            this.tableItemCatalog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 197F));
            this.tableItemCatalog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 197F));
            this.tableItemCatalog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 197F));
            this.tableItemCatalog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 197F));
            this.tableItemCatalog.Size = new System.Drawing.Size(860, 718);
            this.tableItemCatalog.TabIndex = 8;
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
            this.bunifuDatePicker1.Location = new System.Drawing.Point(592, 47);
            this.bunifuDatePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuDatePicker1.MinimumSize = new System.Drawing.Size(4, 32);
            this.bunifuDatePicker1.Name = "bunifuDatePicker1";
            this.bunifuDatePicker1.Size = new System.Drawing.Size(292, 32);
            this.bunifuDatePicker1.TabIndex = 9;
            // 
            // ItemManagementPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1324, 886);
            this.Controls.Add(this.bunifuDatePicker1);
            this.Controls.Add(this.tableItemCatalog);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ItemManagementPanel";
            this.Text = "ItemManagementPanel";
            this.Load += new System.EventHandler(this.ItemManagementPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSaveItem;
        private System.Windows.Forms.PictureBox picboxItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableItemCatalog;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button buttonAddItem;
        private Bunifu.UI.WinForms.BunifuDatePicker bunifuDatePicker1;
        private Controls.TextField textFieldItemCode;
        private Controls.TextField textFieldItemName;
        private Controls.TextField textFieldItemPrice;
        private Controls.TextField textFieldQty;
    }
}