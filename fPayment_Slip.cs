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
    public partial class fPayment_Slip : Form
    {
        public fPayment_Slip()
        {
            InitializeComponent();
        }

        private void fPayment_Slip_Load(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Payment_Information f = new Payment_Information();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btn_BookNow_Click(object sender, EventArgs e)
        {

        }
    }
}
