
namespace POS_ADET.Controls
{
    partial class ItemCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemCard));
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelItemName = new System.Windows.Forms.Label();
            this.pictureItem = new System.Windows.Forms.PictureBox();
            this.panelBorder = new Bunifu.UI.WinForms.BunifuPanel();
            this.pictureChecked = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureChecked)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPrice.Location = new System.Drawing.Point(4, 18);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Padding = new System.Windows.Forms.Padding(5);
            this.labelPrice.Size = new System.Drawing.Size(72, 23);
            this.labelPrice.TabIndex = 0;
            this.labelPrice.Text = "PHP 89990";
            this.labelPrice.Click += new System.EventHandler(this.pictureItem_Click);
            // 
            // labelItemName
            // 
            this.labelItemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelItemName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemName.Location = new System.Drawing.Point(20, 65);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Padding = new System.Windows.Forms.Padding(3);
            this.labelItemName.Size = new System.Drawing.Size(112, 21);
            this.labelItemName.TabIndex = 1;
            this.labelItemName.Text = "IPhone 12 Pro Max";
            this.labelItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelItemName.Click += new System.EventHandler(this.pictureItem_Click);
            this.labelItemName.Paint += new System.Windows.Forms.PaintEventHandler(this.labelItemName_Paint);
            // 
            // pictureItem
            // 
            this.pictureItem.Image = global::POS_ADET.Properties.Resources.iphone;
            this.pictureItem.Location = new System.Drawing.Point(4, 4);
            this.pictureItem.Name = "pictureItem";
            this.pictureItem.Size = new System.Drawing.Size(147, 143);
            this.pictureItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureItem.TabIndex = 4;
            this.pictureItem.TabStop = false;
            // 
            // panelBorder
            // 
            this.panelBorder.BackgroundColor = System.Drawing.Color.Transparent;
            this.panelBorder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBorder.BackgroundImage")));
            this.panelBorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBorder.BorderColor = System.Drawing.Color.Transparent;
            this.panelBorder.BorderRadius = 3;
            this.panelBorder.BorderThickness = 1;
            this.panelBorder.Location = new System.Drawing.Point(0, 0);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.ShowBorders = true;
            this.panelBorder.Size = new System.Drawing.Size(157, 152);
            this.panelBorder.TabIndex = 5;
            // 
            // pictureChecked
            // 
            this.pictureChecked.BackColor = System.Drawing.Color.White;
            this.pictureChecked.Image = ((System.Drawing.Image)(resources.GetObject("pictureChecked.Image")));
            this.pictureChecked.Location = new System.Drawing.Point(124, 120);
            this.pictureChecked.Margin = new System.Windows.Forms.Padding(0);
            this.pictureChecked.Name = "pictureChecked";
            this.pictureChecked.Size = new System.Drawing.Size(27, 27);
            this.pictureChecked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureChecked.TabIndex = 7;
            this.pictureChecked.TabStop = false;
            this.pictureChecked.Visible = false;
            // 
            // ItemCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureChecked);
            this.Controls.Add(this.labelItemName);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.pictureItem);
            this.Controls.Add(this.panelBorder);
            this.Name = "ItemCard";
            this.Size = new System.Drawing.Size(158, 155);
            this.Load += new System.EventHandler(this.ItemCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureChecked)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.PictureBox pictureItem;
        private Bunifu.UI.WinForms.BunifuPanel panelBorder;
        private System.Windows.Forms.PictureBox pictureChecked;
    }
}
