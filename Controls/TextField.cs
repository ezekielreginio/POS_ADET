using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_ADET.Controls
{
    public partial class TextField : UserControl
    {
        //private properties
        private string fieldType = "string";

        public TextField()
        {
            InitializeComponent();
        }

        //Custom Properties
        [
           Category("Field"),
           Description("The ending color of the bar.")
        ]

        public string FieldType
        {
            get
            {
                return FieldType;
            }
            set
            {
                FieldType = value;
            }
        }  


        //Getter-Setter Methods:
        public string getValue()
        {
            return txtItemCode.Text;
        }

        public void setValue(string value)
        {
            txtItemCode.Text = value;
        }

        //User Defined Methods
        

        public void setInvalid()
        {
            this.ActiveControl = lblErrNotif;
            lblErrNotif.Visible = true;
            //txtItemCode.Invalidate();
            txtItemCode.BorderColor = Color.Red;
            //txtItemCode.Border.Thickness = 3;
        }

        public void resetInvalid()
        {
            lblErrNotif.Visible = false;
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
