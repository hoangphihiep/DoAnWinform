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

namespace DuLich
{
    public partial class fHotel_Rental : Form
    {
        public fHotel_Rental()
        {
            InitializeComponent();
        }
        public int kiemtratrang7;
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
    }
}
