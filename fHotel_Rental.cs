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
    public partial class fHotel_Rental : Form
    {
        public fHotel_Rental()
        {
            InitializeComponent();
        }
        public int kiemtratrang1;
        private void pn_ThongTin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_ThietLap_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ThietLap_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TiepTheo_Click(object sender, EventArgs e)
        {
            fHotel_Posting_Upload f = new fHotel_Posting_Upload();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void fHotel_Rental_Load(object sender, EventArgs e)
        {

        }

        private void lbl_XacDinhViTri_Click(object sender, EventArgs e)
        {

        }

        private void txt_DiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbb_TenThanhPho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbb_Tinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_PhongTam_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
