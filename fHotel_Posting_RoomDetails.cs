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
    public partial class fHotel_Posting_RoomDetails : Form
    {
        public fHotel_Posting_RoomDetails()
        {
            InitializeComponent();
        }

        private void lbl_TienNghi_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ChiTietPhongO_Click(object sender, EventArgs e)
        {

        }

        private void txt_TenToaNhaTangCanHo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_QuocGia_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_TenPhong_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void lbl_GiaToiThieuMoiDem_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            fHotel_Posting_Convinient f = new fHotel_Posting_Convinient();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
        public int kiemtratrang4;
        private void btn_TiepTheo_Click(object sender, EventArgs e)
        {
            fHotel_Posting_Image f = new fHotel_Posting_Image();
            if (kiemtratrang4 == 1)
            {
                f.kiemtratrang5 = 1;
            }
            else
            {
                f.kiemtratrang5 = 0;
            }
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void fHotel_Posting_RoomDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
