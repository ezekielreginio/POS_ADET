using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_ADET.Modules.LogsManagement
{
    public partial class ItemLogData : UserControl
    {
        public ItemLogData()
        {
            InitializeComponent();
        }
        //getter setter method
        public void setLogId(string value)
        {
            txtLogId.Text = value;
        }
        public void setItemCode(string value)
        {
            txtItemCode.Text = value;
        }
        public void setLogType(string value)
        {
            txtLogType.Text = value;
        }
        public void setTime(string value)
        {
            txtTime.Text = value;
        }
        public void setLogDesc(string value)
        {
            txtLogDesc.Text = value;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
