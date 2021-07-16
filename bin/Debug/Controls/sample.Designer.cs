
namespace POS_ADET.Controls
{
    partial class sample
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
            this.itemPic = new System.Windows.Forms.PictureBox();
            this.itemName = new System.Windows.Forms.Label();
            this.itemPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemPic)).BeginInit();
            this.SuspendLayout();
            // 
            // itemPic
            // 
            this.itemPic.Location = new System.Drawing.Point(25, 45);
            this.itemPic.Name = "itemPic";
            this.itemPic.Size = new System.Drawing.Size(100, 50);
            this.itemPic.TabIndex = 0;
            this.itemPic.TabStop = false;
            // 
            // itemName
            // 
            this.itemName.AutoSize = true;
            this.itemName.Location = new System.Drawing.Point(12, 12);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(35, 13);
            this.itemName.TabIndex = 1;
            this.itemName.Text = "label1";
            // 
            // itemPrice
            // 
            this.itemPrice.AutoSize = true;
            this.itemPrice.Location = new System.Drawing.Point(90, 117);
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.Size = new System.Drawing.Size(35, 13);
            this.itemPrice.TabIndex = 2;
            this.itemPrice.Text = "label2";
            // 
            // sample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.itemPrice);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.itemPic);
            this.Name = "sample";
            ((System.ComponentModel.ISupportInitialize)(this.itemPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox itemPic;
        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.Label itemPrice;
    }
}
