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
    public partial class Payment_Information : Form
    {
        public Payment_Information()
        {
            InitializeComponent();
        }

        private void lbl_All_Click(object sender, EventArgs e)
        {

        }

        private void txt_Ten_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Customer_Information f = new Customer_Information();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btn_BookNow_Click(object sender, EventArgs e)
        {
            fPayment_Slip f = new fPayment_Slip();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void Payment_Information_Load(object sender, EventArgs e)
        {

        }

        private void Payment_Information_Shown(object sender, EventArgs e)
        {
            panel1.VerticalScroll.Value = 0;
        }
    }
}
