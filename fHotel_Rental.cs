using DoAnDuLich;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DuLich
{
    public partial class fHotel_Rental : Form
    {
        public fHotel_Rental()
        {
            InitializeComponent();
        }
        public int kiemtratrang7;
        void DeleteColor()
        {
            label_ThongTin.ForeColor = Color.Black;
            label32.ForeColor = Color.Black;
            label30.ForeColor = Color.Black;
            label33.ForeColor = Color.Black;
            label34.ForeColor = Color.Black;
            label35.ForeColor = Color.Black;
        }
        private void btn_TiepTheo_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Đăng tải hoàn tất ");
            if (kiemtratrang7 == 1)
            {
                hien_thi_khach_san_phu_hop k = new hien_thi_khach_san_phu_hop();
                k.ShowMenuStrip();
                k.HideDangNhap();
                k.HideDangKy();
                k.HideDangKyKS();
                k.HidePanle2();
                k.kiemtradangkiKS1 = 2;
                this.Hide();
                k.ShowDialog();
                k.Close();
            }
            else
            {
                FTrangChuTK f = new FTrangChuTK();
                f.HideDangKyKS();
                f.ShowMenuStrip();
                f.HideDangNhap();
                f.HideDangKy();
                f.HidePanel3();
                f.kiemtradangkiKS = 1;
                this.Hide();
                f.ShowDialog();
                Application.Exit();
                // dong tat ca form con lai
            }
        }

        private void pn_ThongTin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fHotel_Rental_Load(object sender, EventArgs e)
        {

        }

        private void lbl_ThongTin_Click(object sender, EventArgs e)
        {
            DeleteColor();
            pn_Goc.VerticalScroll.Value = 0;
        }

        private void label32_Click(object sender, EventArgs e)
        {
            DeleteColor();
            pn_Goc.VerticalScroll.Value = 620;
        }

        private void label30_Click(object sender, EventArgs e)
        {
            DeleteColor();
            pn_Goc.VerticalScroll.Value = 1000;
        }

        private void label33_Click(object sender, EventArgs e)
        {
            DeleteColor();
            pn_Goc.VerticalScroll.Value = 1700;
        }

        private void label34_Click(object sender, EventArgs e)
        {
            DeleteColor();
            pn_Goc.VerticalScroll.Value = 2630;
        }

        private void label35_Click(object sender, EventArgs e)
        {
            DeleteColor();
            pn_Goc.VerticalScroll.Value = 3000;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
