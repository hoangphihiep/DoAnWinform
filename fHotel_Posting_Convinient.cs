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
    public partial class fHotel_Posting_Convinient : Form
    {
        public fHotel_Posting_Convinient()
        {
            InitializeComponent();
        }

        private void fHotel_Posting_Convinient_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lbl_KhachHangSeODau_Click(object sender, EventArgs e)
        {

        }

        private void lbl_KhachHangChiNhanDuoc_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lbl_ViTriCuaBan_Click(object sender, EventArgs e)
        {
        }

        private void lbl_DiaChi_Click(object sender, EventArgs e)
        {

        }

        private void txt_DiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_TenToaNhaTangCanHo_Click(object sender, EventArgs e)
        {
        }

        private void txt_TenToaNhaTangCanHo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_QuocGia_Click(object sender, EventArgs e)
        {
        }

        private void lbl_ThanhPho_Click(object sender, EventArgs e)
        {
        }

        private void txt_MaBuuDien_TextChanged(object sender, EventArgs e)
        {
        }

        private void lbl_Zip_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lbl_TieuBangTinh_Click(object sender, EventArgs e)
        {

        }

        private void clb_LoiVao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_DoAnToanVaSachSe_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ChoKhachThayRang_Click(object sender, EventArgs e)
        {
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int kiemtratrang3;
        private void btn_TiepTheo_Click(object sender, EventArgs e)
        {
            fHotel_Posting_RoomDetails f = new fHotel_Posting_RoomDetails();
            if (kiemtratrang3 == 1)
            {
                f.kiemtratrang4 = 1;
            }
            else
            {
                f.kiemtratrang4 = 0;
            }
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
