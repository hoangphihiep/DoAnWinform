﻿using DoAnDuLich;
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
    public partial class fHotel_Posting_Upload : Form
    {
        public fHotel_Posting_Upload()
        {
            InitializeComponent();
        }

        private void lbl_NhungDacDiem_Click(object sender, EventArgs e)
        {
        }

        private void clb_ChinhSachHuy_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lbl_NhungTienNghi_Click(object sender, EventArgs e)
        {
        }

        private void lbl_ThongTinCoIch_Click(object sender, EventArgs e)
        {
        }

        private void ccb_Den1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbb_Tu2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void lbl_XepLoaiSao_Click(object sender, EventArgs e)
        {
        }

        private void lbl_ChiCanMotVai_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_AmHieu_Click(object sender, EventArgs e)
        {

        }

        private void cb_ToiDongY_CheckedChanged(object sender, EventArgs e)
        {

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
                f.kiemtradangkiKS = 1;
                this.Hide();
                f.ShowDialog();
                Application.Exit();
                // dong tat ca form con lai
            }
        }

        private void fHotel_Posting_Upload_Load(object sender, EventArgs e)
        {

        }
    }
}
