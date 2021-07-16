
namespace POS_ADET.Modules.ReturnRefundManagement
{
    partial class ReturnRefundManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnRefundManagement));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label2 = new System.Windows.Forms.Label();
            this.txtORNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tableItems = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableReturnRefund = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDevices = new System.Windows.Forms.ComboBox();
            this.qrScanner = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cboOption = new System.Windows.Forms.ComboBox();
            this.cboReason = new System.Windows.Forms.ComboBox();
            this.panelReturnForm = new System.Windows.Forms.Panel();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.txtQty = new Bunifu.UI.WinForms.BunifuTextBox();
            this.formItemName = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnFinish = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnRemove = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.returnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.option = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableReturnRefund)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrScanner)).BeginInit();
            this.panelReturnForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Return/Refund Management";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtORNo
            // 
            this.txtORNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtORNo.DefaultText = "";
            this.txtORNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtORNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtORNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtORNo.DisabledState.Parent = this.txtORNo;
            this.txtORNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtORNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtORNo.FocusedState.Parent = this.txtORNo;
            this.txtORNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtORNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtORNo.HoverState.Parent = this.txtORNo;
            this.txtORNo.Location = new System.Drawing.Point(248, 78);
            this.txtORNo.Name = "txtORNo";
            this.txtORNo.PasswordChar = '\0';
            this.txtORNo.PlaceholderText = "";
            this.txtORNo.SelectedText = "";
            this.txtORNo.ShadowDecoration.Parent = this.txtORNo;
            this.txtORNo.Size = new System.Drawing.Size(361, 26);
            this.txtORNo.TabIndex = 19;
            this.txtORNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtORNo_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(151, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "OR #:";
            // 
            // tableItems
            // 
            this.tableItems.AllowCustomTheming = false;
            this.tableItems.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.tableItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tableItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableItems.DefaultCellStyle = dataGridViewCellStyle4;
            this.tableItems.EnableHeadersVisualStyles = false;
            this.tableItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tableItems.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.tableItems.HeaderBgColor = System.Drawing.Color.Empty;
            this.tableItems.HeaderForeColor = System.Drawing.Color.White;
            this.tableItems.Location = new System.Drawing.Point(156, 127);
            this.tableItems.MultiSelect = false;
            this.tableItems.Name = "tableItems";
            this.tableItems.RowHeadersVisible = false;
            this.tableItems.RowTemplate.Height = 40;
            this.tableItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableItems.Size = new System.Drawing.Size(453, 535);
            this.tableItems.TabIndex = 20;
            this.tableItems.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.tableItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableItems_CellClick);
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
            this.qty.ReadOnly = true;
            // 
            // total
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.total.DefaultCellStyle = dataGridViewCellStyle3;
            this.total.FillWeight = 101.5228F;
            this.total.HeaderText = "         Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // tableReturnRefund
            // 
            this.tableReturnRefund.AllowCustomTheming = false;
            this.tableReturnRefund.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.tableReturnRefund.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tableReturnRefund.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableReturnRefund.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableReturnRefund.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tableReturnRefund.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableReturnRefund.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tableReturnRefund.ColumnHeadersHeight = 40;
            this.tableReturnRefund.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.returnID,
            this.returnItemName,
            this.returnQty,
            this.option,
            this.reason,
            this.ogQty});
            this.tableReturnRefund.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.tableReturnRefund.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tableReturnRefund.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tableReturnRefund.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tableReturnRefund.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tableReturnRefund.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.tableReturnRefund.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tableReturnRefund.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.tableReturnRefund.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.tableReturnRefund.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tableReturnRefund.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.tableReturnRefund.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.tableReturnRefund.CurrentTheme.Name = null;
            this.tableReturnRefund.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tableReturnRefund.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tableReturnRefund.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tableReturnRefund.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tableReturnRefund.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableReturnRefund.DefaultCellStyle = dataGridViewCellStyle7;
            this.tableReturnRefund.EnableHeadersVisualStyles = false;
            this.tableReturnRefund.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tableReturnRefund.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.tableReturnRefund.HeaderBgColor = System.Drawing.Color.Empty;
            this.tableReturnRefund.HeaderForeColor = System.Drawing.Color.White;
            this.tableReturnRefund.Location = new System.Drawing.Point(658, 294);
            this.tableReturnRefund.MultiSelect = false;
            this.tableReturnRefund.Name = "tableReturnRefund";
            this.tableReturnRefund.RowHeadersVisible = false;
            this.tableReturnRefund.RowTemplate.Height = 40;
            this.tableReturnRefund.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableReturnRefund.Size = new System.Drawing.Size(323, 322);
            this.tableReturnRefund.TabIndex = 20;
            this.tableReturnRefund.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.tableReturnRefund.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableReturnRefund_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(657, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Item/s For Return/Refund";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboDevices
            // 
            this.cboDevices.FormattingEnabled = true;
            this.cboDevices.Location = new System.Drawing.Point(11, 102);
            this.cboDevices.Name = "cboDevices";
            this.cboDevices.Size = new System.Drawing.Size(134, 21);
            this.cboDevices.TabIndex = 21;
            // 
            // qrScanner
            // 
            this.qrScanner.Location = new System.Drawing.Point(11, 127);
            this.qrScanner.Name = "qrScanner";
            this.qrScanner.Size = new System.Drawing.Size(134, 113);
            this.qrScanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qrScanner.TabIndex = 22;
            this.qrScanner.TabStop = false;
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
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnRefresh.CustomizableEdges = borderEdges1;
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
            this.btnRefresh.Location = new System.Drawing.Point(13, 246);
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
            this.btnRefresh.TabIndex = 23;
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRefresh.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRefresh.TextMarginLeft = 0;
            this.btnRefresh.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnRefresh.UseDefaultRadiusAndThickness = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cboOption
            // 
            this.cboOption.FormattingEnabled = true;
            this.cboOption.Items.AddRange(new object[] {
            "Exchange",
            "Refund"});
            this.cboOption.Location = new System.Drawing.Point(102, 108);
            this.cboOption.Name = "cboOption";
            this.cboOption.Size = new System.Drawing.Size(147, 21);
            this.cboOption.TabIndex = 1;
            this.cboOption.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // cboReason
            // 
            this.cboReason.FormattingEnabled = true;
            this.cboReason.Items.AddRange(new object[] {
            "Damaged",
            "Factory Defect",
            "Incorrect Size"});
            this.cboReason.Location = new System.Drawing.Point(102, 137);
            this.cboReason.Name = "cboReason";
            this.cboReason.Size = new System.Drawing.Size(147, 21);
            this.cboReason.TabIndex = 1;
            this.cboReason.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // panelReturnForm
            // 
            this.panelReturnForm.Controls.Add(this.lblFilePath);
            this.panelReturnForm.Controls.Add(this.txtQty);
            this.panelReturnForm.Controls.Add(this.cboReason);
            this.panelReturnForm.Controls.Add(this.cboOption);
            this.panelReturnForm.Controls.Add(this.formItemName);
            this.panelReturnForm.Controls.Add(this.bunifuLabel4);
            this.panelReturnForm.Controls.Add(this.bunifuLabel3);
            this.panelReturnForm.Controls.Add(this.bunifuLabel5);
            this.panelReturnForm.Controls.Add(this.bunifuLabel1);
            this.panelReturnForm.Controls.Add(this.bunifuLabel2);
            this.panelReturnForm.Location = new System.Drawing.Point(658, 68);
            this.panelReturnForm.Name = "panelReturnForm";
            this.panelReturnForm.Size = new System.Drawing.Size(323, 183);
            this.panelReturnForm.TabIndex = 24;
            this.panelReturnForm.TabStop = true;
            this.panelReturnForm.Visible = false;
            this.panelReturnForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(157, 254);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(0, 13);
            this.lblFilePath.TabIndex = 27;
            // 
            // txtQty
            // 
            this.txtQty.AcceptsReturn = false;
            this.txtQty.AcceptsTab = false;
            this.txtQty.AnimationSpeed = 200;
            this.txtQty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtQty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtQty.BackColor = System.Drawing.Color.Transparent;
            this.txtQty.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtQty.BackgroundImage")));
            this.txtQty.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtQty.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtQty.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtQty.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtQty.BorderRadius = 1;
            this.txtQty.BorderThickness = 1;
            this.txtQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQty.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtQty.DefaultText = "";
            this.txtQty.FillColor = System.Drawing.Color.White;
            this.txtQty.HideSelection = true;
            this.txtQty.IconLeft = null;
            this.txtQty.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQty.IconPadding = 10;
            this.txtQty.IconRight = null;
            this.txtQty.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQty.Lines = new string[0];
            this.txtQty.Location = new System.Drawing.Point(102, 77);
            this.txtQty.MaxLength = 32767;
            this.txtQty.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtQty.Modified = false;
            this.txtQty.Multiline = false;
            this.txtQty.Name = "txtQty";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtQty.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtQty.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtQty.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtQty.OnIdleState = stateProperties4;
            this.txtQty.Padding = new System.Windows.Forms.Padding(3);
            this.txtQty.PasswordChar = '\0';
            this.txtQty.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtQty.PlaceholderText = "Enter text";
            this.txtQty.ReadOnly = false;
            this.txtQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQty.SelectedText = "";
            this.txtQty.SelectionLength = 0;
            this.txtQty.SelectionStart = 0;
            this.txtQty.ShortcutsEnabled = true;
            this.txtQty.Size = new System.Drawing.Size(147, 25);
            this.txtQty.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtQty.TabIndex = 2;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQty.TextMarginBottom = 0;
            this.txtQty.TextMarginLeft = 3;
            this.txtQty.TextMarginTop = 0;
            this.txtQty.TextPlaceholder = "Enter text";
            this.txtQty.UseSystemPasswordChar = false;
            this.txtQty.WordWrap = true;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // formItemName
            // 
            this.formItemName.AllowParentOverrides = false;
            this.formItemName.AutoEllipsis = false;
            this.formItemName.CursorType = null;
            this.formItemName.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.formItemName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.formItemName.Location = new System.Drawing.Point(102, 48);
            this.formItemName.Name = "formItemName";
            this.formItemName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.formItemName.Size = new System.Drawing.Size(0, 0);
            this.formItemName.TabIndex = 0;
            this.formItemName.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.formItemName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.bunifuLabel4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuLabel4.Location = new System.Drawing.Point(6, 135);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(59, 23);
            this.bunifuLabel4.TabIndex = 0;
            this.bunifuLabel4.Text = "Reason:";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.bunifuLabel3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuLabel3.Location = new System.Drawing.Point(6, 106);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(64, 23);
            this.bunifuLabel3.TabIndex = 0;
            this.bunifuLabel3.Text = "Options:";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.bunifuLabel5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuLabel5.Location = new System.Drawing.Point(6, 77);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(35, 23);
            this.bunifuLabel5.TabIndex = 0;
            this.bunifuLabel5.Text = "QTY:";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.bunifuLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuLabel1.Location = new System.Drawing.Point(6, 8);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(203, 28);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "Exchange/Refund Form";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.bunifuLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuLabel2.Location = new System.Drawing.Point(6, 48);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(90, 23);
            this.bunifuLabel2.TabIndex = 0;
            this.bunifuLabel2.Text = "Item Name:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnFinish
            // 
            this.btnFinish.AllowAnimations = true;
            this.btnFinish.AllowMouseEffects = true;
            this.btnFinish.AllowToggling = false;
            this.btnFinish.AnimationSpeed = 200;
            this.btnFinish.AutoGenerateColors = false;
            this.btnFinish.AutoRoundBorders = false;
            this.btnFinish.AutoSizeLeftIcon = true;
            this.btnFinish.AutoSizeRightIcon = true;
            this.btnFinish.BackColor = System.Drawing.Color.Transparent;
            this.btnFinish.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnFinish.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFinish.BackgroundImage")));
            this.btnFinish.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFinish.ButtonText = "Finish";
            this.btnFinish.ButtonTextMarginLeft = 0;
            this.btnFinish.ColorContrastOnClick = 45;
            this.btnFinish.ColorContrastOnHover = 45;
            this.btnFinish.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnFinish.CustomizableEdges = borderEdges2;
            this.btnFinish.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFinish.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnFinish.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnFinish.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnFinish.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnFinish.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFinish.ForeColor = System.Drawing.Color.White;
            this.btnFinish.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinish.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnFinish.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnFinish.IconMarginLeft = 11;
            this.btnFinish.IconPadding = 10;
            this.btnFinish.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinish.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnFinish.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnFinish.IconSize = 25;
            this.btnFinish.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnFinish.IdleBorderRadius = 1;
            this.btnFinish.IdleBorderThickness = 1;
            this.btnFinish.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnFinish.IdleIconLeftImage = null;
            this.btnFinish.IdleIconRightImage = null;
            this.btnFinish.IndicateFocus = false;
            this.btnFinish.Location = new System.Drawing.Point(831, 623);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnFinish.OnDisabledState.BorderRadius = 1;
            this.btnFinish.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFinish.OnDisabledState.BorderThickness = 1;
            this.btnFinish.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnFinish.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnFinish.OnDisabledState.IconLeftImage = null;
            this.btnFinish.OnDisabledState.IconRightImage = null;
            this.btnFinish.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnFinish.onHoverState.BorderRadius = 1;
            this.btnFinish.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFinish.onHoverState.BorderThickness = 1;
            this.btnFinish.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnFinish.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnFinish.onHoverState.IconLeftImage = null;
            this.btnFinish.onHoverState.IconRightImage = null;
            this.btnFinish.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnFinish.OnIdleState.BorderRadius = 1;
            this.btnFinish.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFinish.OnIdleState.BorderThickness = 1;
            this.btnFinish.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnFinish.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnFinish.OnIdleState.IconLeftImage = null;
            this.btnFinish.OnIdleState.IconRightImage = null;
            this.btnFinish.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnFinish.OnPressedState.BorderRadius = 1;
            this.btnFinish.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFinish.OnPressedState.BorderThickness = 1;
            this.btnFinish.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnFinish.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnFinish.OnPressedState.IconLeftImage = null;
            this.btnFinish.OnPressedState.IconRightImage = null;
            this.btnFinish.Size = new System.Drawing.Size(150, 39);
            this.btnFinish.TabIndex = 25;
            this.btnFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFinish.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFinish.TextMarginLeft = 0;
            this.btnFinish.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnFinish.UseDefaultRadiusAndThickness = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.AllowAnimations = true;
            this.btnRemove.AllowMouseEffects = true;
            this.btnRemove.AllowToggling = false;
            this.btnRemove.AnimationSpeed = 200;
            this.btnRemove.AutoGenerateColors = false;
            this.btnRemove.AutoRoundBorders = false;
            this.btnRemove.AutoSizeLeftIcon = true;
            this.btnRemove.AutoSizeRightIcon = true;
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemove.BackgroundImage")));
            this.btnRemove.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRemove.ButtonText = "Remove";
            this.btnRemove.ButtonTextMarginLeft = 0;
            this.btnRemove.ColorContrastOnClick = 45;
            this.btnRemove.ColorContrastOnHover = 45;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnRemove.CustomizableEdges = borderEdges3;
            this.btnRemove.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRemove.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRemove.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRemove.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRemove.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnRemove.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnRemove.IconMarginLeft = 11;
            this.btnRemove.IconPadding = 10;
            this.btnRemove.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnRemove.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnRemove.IconSize = 25;
            this.btnRemove.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRemove.IdleBorderRadius = 1;
            this.btnRemove.IdleBorderThickness = 1;
            this.btnRemove.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnRemove.IdleIconLeftImage = null;
            this.btnRemove.IdleIconRightImage = null;
            this.btnRemove.IndicateFocus = false;
            this.btnRemove.Location = new System.Drawing.Point(658, 622);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRemove.OnDisabledState.BorderRadius = 1;
            this.btnRemove.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRemove.OnDisabledState.BorderThickness = 1;
            this.btnRemove.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRemove.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRemove.OnDisabledState.IconLeftImage = null;
            this.btnRemove.OnDisabledState.IconRightImage = null;
            this.btnRemove.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnRemove.onHoverState.BorderRadius = 1;
            this.btnRemove.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRemove.onHoverState.BorderThickness = 1;
            this.btnRemove.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnRemove.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnRemove.onHoverState.IconLeftImage = null;
            this.btnRemove.onHoverState.IconRightImage = null;
            this.btnRemove.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRemove.OnIdleState.BorderRadius = 1;
            this.btnRemove.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRemove.OnIdleState.BorderThickness = 1;
            this.btnRemove.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnRemove.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnRemove.OnIdleState.IconLeftImage = null;
            this.btnRemove.OnIdleState.IconRightImage = null;
            this.btnRemove.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnRemove.OnPressedState.BorderRadius = 1;
            this.btnRemove.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRemove.OnPressedState.BorderThickness = 1;
            this.btnRemove.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnRemove.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnRemove.OnPressedState.IconLeftImage = null;
            this.btnRemove.OnPressedState.IconRightImage = null;
            this.btnRemove.Size = new System.Drawing.Size(150, 39);
            this.btnRemove.TabIndex = 25;
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemove.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRemove.TextMarginLeft = 0;
            this.btnRemove.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnRemove.UseDefaultRadiusAndThickness = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // returnID
            // 
            this.returnID.HeaderText = "ID";
            this.returnID.Name = "returnID";
            this.returnID.Visible = false;
            // 
            // returnItemName
            // 
            this.returnItemName.FillWeight = 181.2614F;
            this.returnItemName.HeaderText = "Item Name";
            this.returnItemName.Name = "returnItemName";
            this.returnItemName.ReadOnly = true;
            // 
            // returnQty
            // 
            this.returnQty.HeaderText = "Qty";
            this.returnQty.Name = "returnQty";
            // 
            // option
            // 
            this.option.HeaderText = "Type";
            this.option.Name = "option";
            this.option.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.option.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // reason
            // 
            this.reason.HeaderText = "Reason";
            this.reason.Name = "reason";
            this.reason.Visible = false;
            // 
            // ogQty
            // 
            this.ogQty.HeaderText = "ogQty";
            this.ogQty.Name = "ogQty";
            this.ogQty.Visible = false;
            // 
            // ReturnRefundManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(993, 720);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.panelReturnForm);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.qrScanner);
            this.Controls.Add(this.cboDevices);
            this.Controls.Add(this.tableReturnRefund);
            this.Controls.Add(this.tableItems);
            this.Controls.Add(this.txtORNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnRefundManagement";
            this.Text = "ReturnRefundManagement";
            ((System.ComponentModel.ISupportInitialize)(this.tableItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableReturnRefund)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrScanner)).EndInit();
            this.panelReturnForm.ResumeLayout(false);
            this.panelReturnForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtORNo;
        private System.Windows.Forms.Label label8;
        private Bunifu.UI.WinForms.BunifuDataGridView tableItems;
        private Bunifu.UI.WinForms.BunifuDataGridView tableReturnRefund;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDevices;
        private System.Windows.Forms.PictureBox qrScanner;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRefresh;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cboOption;
        private System.Windows.Forms.ComboBox cboReason;
        private System.Windows.Forms.Panel panelReturnForm;
        private Bunifu.UI.WinForms.BunifuTextBox txtQty;
        private Bunifu.UI.WinForms.BunifuLabel formItemName;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnFinish;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn option;
        private System.Windows.Forms.DataGridViewTextBoxColumn reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogQty;
    }
}