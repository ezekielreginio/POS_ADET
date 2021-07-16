using POS_ADET.Classes;
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
        //private instances
        private Validation validate = new Validation();
        
        private bool isValid = false;
        public bool IsValid { get => isValid; set => isValid = value; }

        //private properties
        public enum FieldTypes
        {
            String,
            Integer, 
            Currency
        }
        private FieldTypes fieldType = FieldTypes.String;

        public TextField()
        {
            InitializeComponent();
        }

        //Custom Properties
        [
           Category("TextField")
        ]
        public FieldTypes FieldType
        {
            get
            {
                return fieldType;
            }
            set
            {
                fieldType = value;
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
            isValid = false;
            this.ActiveControl = lblErrNotif;
            lblErrNotif.Visible = true;
            //txtItemCode.Invalidate();
            //txtItemCode.BorderColor = Color.Red;
            //txtItemCode.Border.Thickness = 3;
        }

        public void setEnabled(bool value)
        {
            txtItemCode.Enabled = value;
        }

        public void resetInvalid()
        {
            lblErrNotif.Visible = false;
            isValid = true;
        }

        public void resetField()
        {
            resetInvalid();
            txtItemCode.Text = String.Empty;
        }

        private void txtItemCode_Validating(object sender, CancelEventArgs e)
        {
            switch (this.fieldType)
            {
                case FieldTypes.Integer:
                    e.Cancel = validate.validate_field(this.getValue(), @"^[0-9]+$");
                    break;
                case FieldTypes.String:
                    e.Cancel = validate.validate_field(this.getValue(), @"^[A-Za-z0-9()' ]+$");
                    break;
                case FieldTypes.Currency:
                    e.Cancel = validate.validate_field(this.getValue(), @"^[0-9.]+$");
                    break;
            }

            if (e.Cancel)
            {
                setInvalid();
            }
            else
            {
                resetInvalid();
            }
        }
    }
}
