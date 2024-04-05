﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuLich
{
    public partial class Customer_Information : Form
    {
        Modify modify = new Modify();
        public string tk;
        public string mk;
        public Image tenAnh;
        public string tenKhachSan;
        public string TenKhachHang;
        public string sdt;
        public string soKhach;
        public string soPhongConTrong;
        public string Gia;
        double giaTien;
        KHACHSAN ks;
        DateTime checkin;
        DateTime checkout;
        KhachHang kh;
        Room phong;
        DatPhong datphong;

        public Customer_Information()
        {
            InitializeComponent();
        }

        public Customer_Information(KHACHSAN ks, Room phong, DateTime checkin, DateTime checkout)
        {
            this.checkin = checkin;
            this.checkout = checkout;
            this.phong = phong;
            this.ks = ks;
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
//            string GiaChuyenDoi = Gia;
//<<<<<<< HEAD
//            double giaTien;
//=======

//>>>>>>> 2a2040a2d5be76e6f0a9afa5f94dfa2fe7d7b4d0
//            double.TryParse(GiaChuyenDoi, out giaTien);

//            ptb_Anh.Image = tenAnh;
//            label15.Text = tenKhachSan;
//            label17.Text = soKhach;
//            label19.Text = soPhongConTrong;
//            label20.Text = Gia;
//            lbl_CostRoom.Text = Gia;
//            lbl_Cost.Text = Gia;
//            giaTien *= 1.13;
//<<<<<<< HEAD

//            lbl_LastCost.Text = giaTien.ToString();
//=======
//            lbl_LastCost.Text = giaTien.ToString();
//            if (lbl_MaGiamGia.Visible == true && cbb_MaGiamGia.Visible == true)
//            {
//                string query = "Select * from UuDai where Tk = '" + tk + "' and MAKS = '" + 2 + "' ";
//                var result = modify.UuDai(query);
//                List<int> GiaTriUuDai = new List<int>();
//                GiaTriUuDai.Add(0);
//                foreach (var item in result)
//                {
//                    GiaTriUuDai.Add(item.GiaTriUuDai);
//                }
//                cbb_MaGiamGia.DataSource = GiaTriUuDai;
//                cbb_MaGiamGia.Text = 0.ToString();
//            }
//>>>>>>> 2a2040a2d5be76e6f0a9afa5f94dfa2fe7d7b4d0
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_NEXT_Click(object sender, EventArgs e)
        {
            this.kh = new KhachHang(txt_HoVaTen.Text, txt_SoDienThoai.Text, txt_GioiTinh.Text, dtp_NgayThangNamSinh.Value, txt_Email.Text, txt_DiaChi.Text);
            this.datphong = new DatPhong(kh, ks, phong, checkin, checkout, 1, 10000000, "Đã thanh toán", "11111");
            MessageBox.Show(datphong.Phong.MAPHONG.ToString());
            Payment_Information f = new Payment_Information();
            f.DP = datphong;
            //f.tenAnh = tenAnh;
            //f.tenKhachSan = tenKhachSan;
            //f.soKhach = soKhach;
            //f.soPhongConTrong = soPhongConTrong;
            //f.Gia = Gia;
            //f.sdt = txt_SoDienThoai.Text;
            //f.TenKhachHang = txt_HoVaTen.Text;
            //f.NgayNhan = NgayNhan;
            //f.NgayTra = NgayTra;
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_Customer_information_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Information_Shown(object sender, EventArgs e)
        {
            panel1.VerticalScroll.Value = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Email_Click(object sender, EventArgs e)
        {

        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            fLogin k = new fLogin();
            k.KiemTra(2);
            k.tenAnh = tenAnh;
            k.tenKhachSan = tenKhachSan;
            k.soKhach = soKhach;
            k.soPhongConTrong = soPhongConTrong;
            k.Gia = Gia;
            k.sdt = txt_SoDienThoai.Text;
            k.TenKhachHang = txt_HoVaTen.Text;
            k.NgayNhan = checkin;
            k.NgayTra = checkout;
            this.Hide();
            k.ShowDialog();
            this.Close();
        }
        public void HienThi()
        {
            lbl_NhanUuDai.Visible = false;
            btn_DangNhap.Visible = false;
            lbl_MaGiamGia.Visible = true;
            cbb_MaGiamGia.Visible = true;
            Account acc = new Account(null, null, null, null, DateTime.MinValue, null, null, null);
            string query = "Select * from TaiKhoan1 where TenDangNhap = '" + tk + "' and MatKhau = '" + mk + "' ";
            var result = modify.accounts(query);
            if (result.Count() != 0)
            {
                acc = result.First();
            }
            txt_HoVaTen.Text = acc.getHoTen;
            txt_GioiTinh.Text = acc.getGioiTinh;
            txt_Email.Text = acc.getEmail;
            txt_SoDienThoai.Text = acc.getSoDienThoai;
            txt_DiaChi.Text = acc.getDiaChi;
            dtp_NgayThangNamSinh.Value = acc.getNgayThangNamSinh;
        }

        private void btn_ThayDoi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_DichVuVaThue_Click(object sender, EventArgs e)
        {

        }

        private void cbb_MaGiamGia_SelectedValueChanged(object sender, EventArgs e)
        {
            double gia = giaTien;
            gia = gia - double.Parse(cbb_MaGiamGia.Text) / 100 * gia;
            lbl_LastCost.Text = gia.ToString();
        }

        public DateTime CheckIn
        {
            get { return checkin ; }
            set { checkin = value ; }
        }

        public DateTime CheckOut
        {
            get { return checkout; }
            set { checkout = value; }
        }

    }
}
