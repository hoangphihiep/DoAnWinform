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

            InitializeComponent();
        }

        private void UCTN_Load(object sender, EventArgs e)
        {
            lblTN.Text = tn;
        }
    }
}
