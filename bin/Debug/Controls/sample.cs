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
    public partial class sample : UserControl
    {
        public sample()
        {
            InitializeComponent();
        }

        private int id;

        public int getID()
        {
            return id;
        }

        public void setID(int id)
        {
            this.id = id;
        }

    }
}
