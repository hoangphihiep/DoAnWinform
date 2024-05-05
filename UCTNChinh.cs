using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuLich
{
    public partial class UCTNChinh : UserControl
    {
        TienNghiChinh tnc;
        public UCTNChinh(TienNghiChinh tnc)
        {
            this.tnc = tnc;
            InitializeComponent();
        }

        private void UCTNChinh_Load(object sender, EventArgs e)
        {
            ptbTNC.Image = Image.FromFile(tnc.HinhAnh);
            lblTNC.Text = tnc.TenTN;
        }
    }
}
