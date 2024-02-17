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
    public partial class fHotel_Posting_Profile : Form
    {
        public fHotel_Posting_Profile()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_HoTen_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Ho_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Ten_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_QuocGia_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_DiaChi_Click(object sender, EventArgs e)
        {

        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int kiemtratrang6;
        private void btn_TiepTheo_Click(object sender, EventArgs e)
        {
            fHotel_Posting_Upload f = new fHotel_Posting_Upload();
            if (kiemtratrang6 == 1)
            {
                f.kiemtratrang7 = 1;
            }
            else
            {
                f.kiemtratrang7 = 0;
            }
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void fHotel_Posting_Profile_Load(object sender, EventArgs e)
        {

        }
    }
}
