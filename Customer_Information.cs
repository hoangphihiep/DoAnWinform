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
        public string lastcost;
        double giaTien;
        int giamgia;
        public KHACHSAN ks;
        public DateTime checkin;
        public DateTime checkout;
        public KhachHang kh;
        public Room phong;
        public DatPhong datphong;

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
            string GiaChuyenDoi = phong.GIA.ToString();
            double giaTien;
            double.TryParse(GiaChuyenDoi, out giaTien);

            pictureBox1.Image = tenAnh;
            label15.Text = ks.TENKS;
            label17.Text = phong.SOKHACH.ToString();
            label19.Text = (phong.SOPHONG - phong.SOPHONGDD).ToString();
            label20.Text = phong.GIA.ToString();
            lbl_CostRoom.Text = phong.GIA.ToString();
            lbl_Cost.Text = phong.GIA.ToString();
            giaTien *= 1.13;
            double truncatedNumber = Math.Round(giaTien, 2);
            lbl_LastCost.Text = truncatedNumber.ToString();
            //Ma giam gia theo tk
            if (lbl_MaGiamGia.Visible == true && cbb_MaGiamGia.Visible == true)
            {
                string query = "Select * from UuDai where Tk = '" + tk + "' and MAKS = '" + ks.MAKS + "' ";
                var result = modify.UuDai(query);
                List<int> GiaTriUuDai = new List<int>();
                GiaTriUuDai.Add(0);
                foreach (var item in result)
                {
                    GiaTriUuDai.Add(item.GiaTriUuDai);
                }
                cbb_MaGiamGia.DataSource = GiaTriUuDai;
                cbb_MaGiamGia.Text = 0.ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_NEXT_Click(object sender, EventArgs e)
        {
            lastcost = lbl_LastCost.Text;
            this.kh = new KhachHang(txt_HoVaTen.Text, txt_SoDienThoai.Text, txt_GioiTinh.Text, dtp_NgayThangNamSinh.Value, txt_Email.Text, txt_DiaChi.Text);
            this.datphong = new DatPhong(kh, ks, phong, checkin, checkout, 1, 10000000, "Đã thanh toán", "11111");
            datphong.Phong = this.phong;
            Payment_Information f = new Payment_Information();
            f.DP = datphong;
            f.SetLastCost(lastcost);
            f.giamgia = giamgia;
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
            k.ks = ks;
            k.phong = phong;
            k.kh = kh;
            k.datphong = datphong;
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
            // dtp_NgayThangNamSinh.Value = acc.getNgayThangNamSinh;
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
            double gia = phong.GIA;
            gia *= 1.13;
            gia = gia - double.Parse(cbb_MaGiamGia.Text) / 100 * gia;
            double truncatedNumber = Math.Round(gia, 2);
            lbl_LastCost.Text = truncatedNumber.ToString();
            lastcost = truncatedNumber.ToString();
            giamgia = int.Parse(cbb_MaGiamGia.Text);
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

        public Room Phong
        {
            get { return phong; }
            set { phong = value; }
        }

    }
}
