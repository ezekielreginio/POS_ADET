
namespace POS_ADET.Modules.POSManagement
{
    partial class POSManagement
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POSManagement));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.tableItemCatalog = new System.Windows.Forms.TableLayoutPanel();
            this.tableItems = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btnPay = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.qrScanner = new System.Windows.Forms.PictureBox();
            this.cboDevices = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtCode = new System.Windows.Forms.Label();
            this.pos_adetDataSet = new POS_ADET.pos_adetDataSet();
            this.itemcatalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.item_catalogTableAdapter = new POS_ADET.pos_adetDataSetTableAdapters.item_catalogTableAdapter();
            this.btnRefresh = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtItemCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.pos_adetDataSet1 = new POS_ADET.pos_adetDataSet1();
            this.itemcatalogBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.item_catalogTableAdapter1 = new POS_ADET.pos_adetDataSet1TableAdapters.item_catalogTableAdapter();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableItems)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qrScanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_adetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemcatalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_adetDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemcatalogBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "POS System";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tableItemCatalog
            // 
            this.tableItemCatalog.AutoScroll = true;
            this.tableItemCatalog.ColumnCount = 3;
            this.tableItemCatalog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableItemCatalog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableItemCatalog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableItemCatalog.Location = new System.Drawing.Point(19, 96);
            this.tableItemCatalog.Name = "tableItemCatalog";
            this.tableItemCatalog.RowCount = 4;
            this.tableItemCatalog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableItemCatalog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableItemCatalog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableItemCatalog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableItemCatalog.Size = new System.Drawing.Size(493, 612);
            this.tableItemCatalog.TabIndex = 9;
            // 
            // tableItems
            // 
            this.tableItems.AllowCustomTheming = false;
            this.tableItems.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.tableItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tableItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tableItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tableItems.ColumnHeadersHeight = 40;
            this.tableItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.itemName,
            this.price,
            this.qty,
            this.total});
            this.tableItems.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.tableItems.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tableItems.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tableItems.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tableItems.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tableItems.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.tableItems.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tableItems.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.tableItems.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.tableItems.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tableItems.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.tableItems.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.tableItems.CurrentTheme.Name = null;
            this.tableItems.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tableItems.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tableItems.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tableItems.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tableItems.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableItems.DefaultCellStyle = dataGridViewCellStyle8;
            this.tableItems.EnableHeadersVisualStyles = false;
            this.tableItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tableItems.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.tableItems.HeaderBgColor = System.Drawing.Color.Empty;
            this.tableItems.HeaderForeColor = System.Drawing.Color.White;
            this.tableItems.Location = new System.Drawing.Point(538, 96);
            this.tableItems.MultiSelect = false;
            this.tableItems.Name = "tableItems";
            this.tableItems.RowHeadersVisible = false;
            this.tableItems.RowTemplate.Height = 40;
            this.tableItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableItems.Size = new System.Drawing.Size(445, 395);
            this.tableItems.TabIndex = 10;
            this.tableItems.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.tableItems.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableItems_CellEndEdit);
            // 
            // btnPay
            // 
            this.btnPay.AllowAnimations = true;
            this.btnPay.AllowMouseEffects = true;
            this.btnPay.AllowToggling = false;
            this.btnPay.AnimationSpeed = 200;
            this.btnPay.AutoGenerateColors = false;
            this.btnPay.AutoRoundBorders = false;
            this.btnPay.AutoSizeLeftIcon = true;
            this.btnPay.AutoSizeRightIcon = true;
            this.btnPay.BackColor = System.Drawing.Color.Transparent;
            this.btnPay.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnPay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPay.BackgroundImage")));
            this.btnPay.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPay.ButtonText = "PAY";
            this.btnPay.ButtonTextMarginLeft = 0;
            this.btnPay.ColorContrastOnClick = 45;
            this.btnPay.ColorContrastOnHover = 45;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnPay.CustomizableEdges = borderEdges3;
            this.btnPay.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPay.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPay.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPay.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPay.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPay.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPay.IconMarginLeft = 11;
            this.btnPay.IconPadding = 10;
            this.btnPay.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPay.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPay.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPay.IconSize = 25;
            this.btnPay.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPay.IdleBorderRadius = 1;
            this.btnPay.IdleBorderThickness = 1;
            this.btnPay.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnPay.IdleIconLeftImage = null;
            this.btnPay.IdleIconRightImage = null;
            this.btnPay.IndicateFocus = false;
            this.btnPay.Location = new System.Drawing.Point(831, 669);
            this.btnPay.Name = "btnPay";
            this.btnPay.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPay.OnDisabledState.BorderRadius = 1;
            this.btnPay.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPay.OnDisabledState.BorderThickness = 1;
            this.btnPay.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPay.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPay.OnDisabledState.IconLeftImage = null;
            this.btnPay.OnDisabledState.IconRightImage = null;
            this.btnPay.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnPay.onHoverState.BorderRadius = 1;
            this.btnPay.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPay.onHoverState.BorderThickness = 1;
            this.btnPay.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnPay.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnPay.onHoverState.IconLeftImage = null;
            this.btnPay.onHoverState.IconRightImage = null;
            this.btnPay.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPay.OnIdleState.BorderRadius = 1;
            this.btnPay.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPay.OnIdleState.BorderThickness = 1;
            this.btnPay.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnPay.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnPay.OnIdleState.IconLeftImage = null;
            this.btnPay.OnIdleState.IconRightImage = null;
            this.btnPay.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPay.OnPressedState.BorderRadius = 1;
            this.btnPay.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPay.OnPressedState.BorderThickness = 1;
            this.btnPay.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPay.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnPay.OnPressedState.IconLeftImage = null;
            this.btnPay.OnPressedState.IconRightImage = null;
            this.btnPay.Size = new System.Drawing.Size(150, 39);
            this.btnPay.TabIndex = 11;
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPay.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPay.TextMarginLeft = 0;
            this.btnPay.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPay.UseDefaultRadiusAndThickness = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Total Amount: ";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.White;
            this.lblTotalAmount.Location = new System.Drawing.Point(198, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(50, 25);
            this.lblTotalAmount.TabIndex = 12;
            this.lblTotalAmount.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(102, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tax:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(35, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Net Amount:";
            // 
            // lblNet
            // 
            this.lblNet.AutoSize = true;
            this.lblNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNet.ForeColor = System.Drawing.Color.White;
            this.lblNet.Location = new System.Drawing.Point(189, 77);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(40, 20);
            this.lblNet.TabIndex = 12;
            this.lblNet.Text = "0.00";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblTotalAmount);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblTax);
            this.panel1.Controls.Add(this.lblNet);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(676, 535);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 113);
            this.panel1.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(150, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "PHP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(150, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "PHP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(151, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "PHP";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.ForeColor = System.Drawing.Color.White;
            this.lblTax.Location = new System.Drawing.Point(189, 42);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(40, 20);
            this.lblTax.TabIndex = 12;
            this.lblTax.Text = "0.00";
            // 
            // qrScanner
            // 
            this.qrScanner.Location = new System.Drawing.Point(536, 535);
            this.qrScanner.Name = "qrScanner";
            this.qrScanner.Size = new System.Drawing.Size(134, 113);
            this.qrScanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qrScanner.TabIndex = 15;
            this.qrScanner.TabStop = false;
            // 
            // cboDevices
            // 
            this.cboDevices.FormattingEnabled = true;
            this.cboDevices.Location = new System.Drawing.Point(536, 508);
            this.cboDevices.Name = "cboDevices";
            this.cboDevices.Size = new System.Drawing.Size(134, 21);
            this.cboDevices.TabIndex = 16;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtCode
            // 
            this.txtCode.AutoSize = true;
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.ForeColor = System.Drawing.Color.White;
            this.txtCode.Location = new System.Drawing.Point(547, 669);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(0, 20);
            this.txtCode.TabIndex = 12;
            this.txtCode.Click += new System.EventHandler(this.label5_Click);
            // 
            // pos_adetDataSet
            // 
            this.pos_adetDataSet.DataSetName = "pos_adetDataSet";
            this.pos_adetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemcatalogBindingSource
            // 
            this.itemcatalogBindingSource.DataMember = "item_catalog";
            this.itemcatalogBindingSource.DataSource = this.pos_adetDataSet;
            // 
            // item_catalogTableAdapter
            // 
            this.item_catalogTableAdapter.ClearBeforeFill = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.AllowAnimations = true;
            this.btnRefresh.AllowMouseEffects = true;
            this.btnRefresh.AllowToggling = false;
            this.btnRefresh.AnimationSpeed = 200;
            this.btnRefresh.AutoGenerateColors = false;
            this.btnRefresh.AutoRoundBorders = false;
            this.btnRefresh.AutoSizeLeftIcon = true;
            this.btnRefresh.AutoSizeRightIcon = true;
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRefresh.ButtonText = "Refresh Scanner";
            this.btnRefresh.ButtonTextMarginLeft = 0;
            this.btnRefresh.ColorContrastOnClick = 45;
            this.btnRefresh.ColorContrastOnHover = 45;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnRefresh.CustomizableEdges = borderEdges4;
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRefresh.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRefresh.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRefresh.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRefresh.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnRefresh.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnRefresh.IconMarginLeft = 11;
            this.btnRefresh.IconPadding = 10;
            this.btnRefresh.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnRefresh.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnRefresh.IconSize = 25;
            this.btnRefresh.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.IdleBorderRadius = 1;
            this.btnRefresh.IdleBorderThickness = 1;
            this.btnRefresh.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.IdleIconLeftImage = null;
            this.btnRefresh.IdleIconRightImage = null;
            this.btnRefresh.IndicateFocus = false;
            this.btnRefresh.Location = new System.Drawing.Point(538, 669);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRefresh.OnDisabledState.BorderRadius = 1;
            this.btnRefresh.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRefresh.OnDisabledState.BorderThickness = 1;
            this.btnRefresh.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRefresh.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRefresh.OnDisabledState.IconLeftImage = null;
            this.btnRefresh.OnDisabledState.IconRightImage = null;
            this.btnRefresh.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnRefresh.onHoverState.BorderRadius = 1;
            this.btnRefresh.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRefresh.onHoverState.BorderThickness = 1;
            this.btnRefresh.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnRefresh.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.onHoverState.IconLeftImage = null;
            this.btnRefresh.onHoverState.IconRightImage = null;
            this.btnRefresh.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.OnIdleState.BorderRadius = 1;
            this.btnRefresh.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRefresh.OnIdleState.BorderThickness = 1;
            this.btnRefresh.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.OnIdleState.IconLeftImage = null;
            this.btnRefresh.OnIdleState.IconRightImage = null;
            this.btnRefresh.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnRefresh.OnPressedState.BorderRadius = 1;
            this.btnRefresh.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRefresh.OnPressedState.BorderThickness = 1;
            this.btnRefresh.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnRefresh.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.OnPressedState.IconLeftImage = null;
            this.btnRefresh.OnPressedState.IconRightImage = null;
            this.btnRefresh.Size = new System.Drawing.Size(132, 39);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRefresh.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRefresh.TextMarginLeft = 0;
            this.btnRefresh.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnRefresh.UseDefaultRadiusAndThickness = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(533, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Item Code:";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemCode.DefaultText = "";
            this.txtItemCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtItemCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtItemCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemCode.DisabledState.Parent = this.txtItemCode;
            this.txtItemCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItemCode.FocusedState.Parent = this.txtItemCode;
            this.txtItemCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtItemCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItemCode.HoverState.Parent = this.txtItemCode;
            this.txtItemCode.Location = new System.Drawing.Point(657, 54);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.PasswordChar = '\0';
            this.txtItemCode.PlaceholderText = "";
            this.txtItemCode.SelectedText = "";
            this.txtItemCode.ShadowDecoration.Parent = this.txtItemCode;
            this.txtItemCode.Size = new System.Drawing.Size(324, 26);
            this.txtItemCode.TabIndex = 17;
            // 
            // pos_adetDataSet1
            // 
            this.pos_adetDataSet1.DataSetName = "pos_adetDataSet1";
            this.pos_adetDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemcatalogBindingSource1
            // 
            this.itemcatalogBindingSource1.DataMember = "item_catalog";
            this.itemcatalogBindingSource1.DataSource = this.pos_adetDataSet1;
            // 
            // item_catalogTableAdapter1
            // 
            this.item_catalogTableAdapter1.ClearBeforeFill = true;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // itemName
            // 
            this.itemName.FillWeight = 181.2614F;
            this.itemName.HeaderText = "Item Name";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            // 
            // price
            // 
            this.price.FillWeight = 58.60786F;
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.FillWeight = 58.60786F;
            this.qty.HeaderText = "Qty";
            this.qty.Name = "qty";
            // 
            // total
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.total.DefaultCellStyle = dataGridViewCellStyle7;
            this.total.FillWeight = 101.5228F;
            this.total.HeaderText = "         Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // POSManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(993, 720);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.cboDevices);
            this.Controls.Add(this.qrScanner);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.tableItems);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.tableItemCatalog);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "POSManagement";
            this.Text = "POSManagement";
            this.Load += new System.EventHandler(this.POSManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableItems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qrScanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_adetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemcatalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pos_adetDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemcatalogBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableItemCatalog;
        private Bunifu.UI.WinForms.BunifuDataGridView tableItems;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox qrScanner;
        private System.Windows.Forms.ComboBox cboDevices;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label txtCode;
        private pos_adetDataSet pos_adetDataSet;
        private System.Windows.Forms.BindingSource itemcatalogBindingSource;
        private pos_adetDataSetTableAdapters.item_catalogTableAdapter item_catalogTableAdapter;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRefresh;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtItemCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTax;
        private pos_adetDataSet1 pos_adetDataSet1;
        private System.Windows.Forms.BindingSource itemcatalogBindingSource1;
        private pos_adetDataSet1TableAdapters.item_catalogTableAdapter item_catalogTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}