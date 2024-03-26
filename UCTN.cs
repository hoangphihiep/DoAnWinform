using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuLich
{ 
    public partial class UCTN : UserControl
    {
        string tn;
        public UCTN(string tn)
        {
            this.tn = tn;
            lblTN.Text = tn;
            InitializeComponent();
        }
    }
}
