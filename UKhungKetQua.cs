using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuLich
{
    public partial class UKhungKetQua : UserControl
    {
        KHACHSAN ks;
        public UKhungKetQua()
        {
            InitializeComponent();
        }

        public UKhungKetQua(KHACHSAN ks)
        {
            InitializeComponent();
            this.ks = ks;
            lbl_ViTri.Text = ks.TINH + ", " + ks.THANHPHO;
            lbl_TenKhachSan.Text = ks.TENKS;
            lbl_Tien.Text = ks.GIA.ToString() + " VNĐ";
            lbl_KhoangCachTP.Text = ks.THANHPHO + " " + ks.khoangCachTP.ToString() + " km đến trung tâm";
            lbl_KhoangCachSanBay.Text = ks.khoangCachSanBay.ToString() + " km đến sân bay gần nhất";
            lbl_danhGia.Text = "Đánh giá: " + ks.SAO.ToString();
            pictureBox1.Image = Image.FromFile(ks.diaChiAnh);
            lbl_SoLuong.Text = ks.soLuongKhach.ToString();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            fHotel_Details f = new fHotel_Details(ks);
            f.CheckIn = checkin;
            f.CheckOut = checkout;
            f.tenTaiKhoan = tenTaiKhoan;
            f.ShowDialog();

            this.Show();
        }
        public int maks;
        public int viTri;
        public string tenViTri;
        public string tenKhachSan;
        public string tien;
        public string khoangCach;
        public string anhBia;
        public string soLuong;
        public string tenTinh;
        public string tenTP;
        public string tenTaiKhoan;
        DateTime checkin;
        DateTime checkout;
        public void ShowdanhGia()
        {
            lbl_danhGia.Visible = true;
            lbl_KhoangCachTP.Visible = false;
            lbl_KhoangCachSanBay.Visible = false;
        }
        public void ShowKhoangCachTP()
        {
            lbl_KhoangCachTP.Visible = true;
            lbl_danhGia.Visible = false;
            lbl_KhoangCachSanBay.Visible = false;
        }
        public void ShowKhoangCachSB()
        {
            lbl_KhoangCachSanBay.Visible = true;
            lbl_danhGia.Visible = false;
            lbl_KhoangCachTP.Visible = false;
        }
        public void ShowSoKhach()
        {
            lbl_SoLuong.Visible = true;
        }
        public void HideSoKhach()
        {
            lbl_SoLuong.Visible = false;
        }
        private void UKhungKetQua_Load(object sender, EventArgs e)
        {
            this.Size = new Size(917, 137);
            this.Location = new Point(35, viTri);
            lbl_TenKhachSan.Size = new Size(437, 38);
            lbl_TenKhachSan.Location = new Point(200, 10);
            pictureBox1.Size = new Size(185, 111);
            pictureBox1.Location = new Point(15, 10);
            lbl_ViTri.Size = new Size(56, 20);
            lbl_ViTri.Location = new Point(217, 101);
            lbl_Tien.Size = new Size(59, 20);
            lbl_Tien.Location = new Point(706, 67);
            lbl_KhoangCachTP.Size = new Size(97, 20);
            lbl_KhoangCachTP.Location = new Point(217, 67);
            lbl_SoLuong.Size = new Size(73, 20);
            lbl_SoLuong.Location = new Point(706, 101);
            lbl_KhoangCachSanBay.Size = new Size(153, 20);
            lbl_KhoangCachSanBay.Location = new Point(217, 67);
            lbl_danhGia.Size = new Size(69, 20);
            lbl_danhGia.Location = new Point(217, 67);
        }

        public DateTime CheckIn
        {
            get { return checkin; }
            set { checkin = value; }
        }

        public DateTime CheckOut
        {
            get { return checkout; }
            set { checkout = value; }
        }

    }
}
