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
    public partial class Customer_Information : Form
    {
        public Customer_Information()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lbl_Payment_information_Click(object sender, EventArgs e)
        {

        }

        private void lbl_HoTen_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Whatbed_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Information_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_NEXT_Click(object sender, EventArgs e)
        {
            Payment_Information f = new Payment_Information();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_Customer_information_Click(object sender, EventArgs e)
        {

        }
    }
}
