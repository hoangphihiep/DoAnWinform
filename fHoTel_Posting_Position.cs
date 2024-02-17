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
    public partial class fHoTel_Posting_Position : Form
    {
        public fHoTel_Posting_Position()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_NhungTienNghi_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_DatTenChoKhachSan_Click(object sender, EventArgs e)
        {

        }

        private void lbl_HayTanDung_Click(object sender, EventArgs e)
        {

        }

        private void lbl_KhachHangSeODau_Click(object sender, EventArgs e)
        {

        }

        private void fHoTel_Posting_Position_Load(object sender, EventArgs e)
        {

        }

        private void lbl_NhungDacDiem_Click(object sender, EventArgs e)
        {

        }

        private void lbl_DatTen_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ChonLoaiHinh_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ChonMotTrongSo_Click(object sender, EventArgs e)
        {

        }

        private void lbl_MoTaNhaCuaBan_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ChinhSachHuy_Click(object sender, EventArgs e)
        {

        }

        private void clb_ChinhSachHuy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_XepLoaiSao_Click(object sender, EventArgs e)
        { }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl__Click(object sender, EventArgs e)
        {

        }

        private void txt_TenToaNhaTangCanHo_TextChanged(object sender, EventArgs e)
        {

        }
        public int kiemtratrang2;
        private void btn_TiepTheo_Click(object sender, EventArgs e)
        {
            fHotel_Posting_Convinient f = new fHotel_Posting_Convinient();
            if (kiemtratrang2 == 1)
            {
                f.kiemtratrang3 = 1;
            }
            else
            {
                f.kiemtratrang3 = 0;
            }
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void txt_MaBuuDien_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
