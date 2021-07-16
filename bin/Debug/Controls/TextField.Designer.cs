
namespace POS_ADET.Controls
{
    partial class TextField
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextField));
            this.txtItemCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblErrNotif = new Bunifu.UI.WinForms.BunifuLabel();
            this.SuspendLayout();
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
            this.txtItemCode.Location = new System.Drawing.Point(0, 0);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.PasswordChar = '\0';
            this.txtItemCode.PlaceholderText = "";
            this.txtItemCode.SelectedText = "";
            this.txtItemCode.ShadowDecoration.Parent = this.txtItemCode;
            this.txtItemCode.Size = new System.Drawing.Size(288, 36);
            this.txtItemCode.TabIndex = 8;
            this.txtItemCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtItemCode_Validating);
            // 
            // lblErrNotif
            // 
            this.lblErrNotif.AllowParentOverrides = false;
            this.lblErrNotif.AutoEllipsis = false;
            this.lblErrNotif.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblErrNotif.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblErrNotif.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblErrNotif.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblErrNotif.ForeColor = System.Drawing.Color.Red;
            this.lblErrNotif.Location = new System.Drawing.Point(0, 36);
            this.lblErrNotif.Name = "lblErrNotif";
            this.lblErrNotif.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblErrNotif.Size = new System.Drawing.Size(288, 15);
            this.lblErrNotif.TabIndex = 9;
            this.lblErrNotif.Text = "Invalid Input. Please try Again";
            this.lblErrNotif.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrNotif.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblErrNotif.Visible = false;
            // 
            // TextField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblErrNotif);
            this.Controls.Add(this.txtItemCode);
            this.Name = "TextField";
            this.Size = new System.Drawing.Size(288, 52);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtItemCode;
        private Bunifu.UI.WinForms.BunifuLabel lblErrNotif;
    }
}
