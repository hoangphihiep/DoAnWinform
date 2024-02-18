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
    public partial class fBanking_Payment : Form
    {
        public fBanking_Payment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fPayment_Slip f =new fPayment_Slip();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
