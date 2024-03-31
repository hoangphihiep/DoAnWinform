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
    public partial class Customer_Information : Form
    {
        public string tk;
        public string mk;
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
            Modify modify = new Modify();
            fLogin k = new fLogin();
            this.Hide();
            k.ShowDialog();
            this.Close();
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
    }
}
