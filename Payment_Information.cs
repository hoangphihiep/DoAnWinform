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
    public partial class Payment_Information : Form
    {
        public string tk;
        public string mk;
        public Image tenAnh;
        public string tenKhachSan;
        public string soKhach;
        public string soPhongConTrong;
        public string Gia;
        public string sdt;
        public string TenKhachHang;
        public DateTime NgayNhan;
        public DateTime NgayTra;
        public Payment_Information()
        {
            InitializeComponent();
        }

        private void lbl_All_Click(object sender, EventArgs e)
        {

        }

        private void txt_Ten_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Customer_Information f = new Customer_Information();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btn_BookNow_Click(object sender, EventArgs e)
        {
            fPayment_Slip f = new fPayment_Slip();
            f.tenAnh = tenAnh;
            f.tenKhachSan = tenKhachSan;
            f.soKhach = soKhach;
            f.soPhongConTrong = soPhongConTrong;
            f.Gia = Gia;
            f.SetSDT(sdt);
            f.SetTenKhachHang(TenKhachHang);
            f.NgayNhan = NgayNhan;
            f.NgayTra = NgayTra;
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void Payment_Information_Load(object sender, EventArgs e)
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

        private void Payment_Information_Shown(object sender, EventArgs e)
        {
            panel1.VerticalScroll.Value = 0;
        }
    }
}
