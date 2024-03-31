using System;
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
        public string tk;
        public string mk;
        public Image tenAnh;
        public string tenKhachSan;
        public string soKhach;
        public string soPhongConTrong;
        public string Gia;
        public DateTime NgayNhan;
        public DateTime NgayTra;
        public Customer_Information()
        {
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

            string GiaChuyenDoi = Gia;
            // Loại bỏ phần văn bản " VND"
            GiaChuyenDoi = GiaChuyenDoi.Replace(" VND", "");

            // Loại bỏ dấu chấm
            GiaChuyenDoi = GiaChuyenDoi.Replace(".", "");

            // Chuyển đổi thành kiểu double

            double giaTien;
            double.TryParse(GiaChuyenDoi, out giaTien);

            ptb_Anh.Image = tenAnh;
            label15.Text = tenKhachSan;
            label17.Text = soKhach;
            label19.Text = soPhongConTrong;
            label20.Text = Gia;
            lbl_CostRoom.Text = Gia;
            lbl_Cost.Text = Gia;

            giaTien *= 1.13;
            // Chuyển đổi số double thành chuỗi và thêm dấu chấm
            string giaTienChuoi = giaTien.ToString("#,##0");

            // Thêm phần văn bản " VND" vào cuối chuỗi
            giaTienChuoi += " VND";

            lbl_LastCost.Text = giaTienChuoi;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_NEXT_Click(object sender, EventArgs e)
        {
            Payment_Information f = new Payment_Information();
            f.tenAnh = tenAnh;
            f.tenKhachSan = tenKhachSan;
            f.soKhach = soKhach;
            f.soPhongConTrong = soPhongConTrong;
            f.Gia = Gia;
            f.sdt = txt_SoDienThoai.Text;
            f.TenKhachHang = txt_HoVaTen.Text;
            f.NgayNhan = NgayNhan;
            f.NgayTra = NgayTra;
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
            this.Hide();
            k.ShowDialog();
            this.Close();
        }
        public void HienThi()
        {
            Modify modify = new Modify();
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
    }
}
