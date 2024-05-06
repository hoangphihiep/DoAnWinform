using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuLich
{
    public partial class UCPhong : UserControl
    {
        public Image tenAnh;
        public string tenKhachSan;
        public string soKhach;
        public string soPhongConTrong;
        public string Gia;
        DateTime checkin;
        DateTime checkout;
        public string tenTaiKhoan;
        Room room;
        KHACHSAN ks;
        public UCPhong(KHACHSAN ks, Room room, DateTime checkin, DateTime checkout)
        {
            this.ks = ks;
            this.checkin = checkin;
            this.checkout = checkout;
            this.room = room;
            InitializeComponent();
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UCPhong_Load(object sender, EventArgs e)
        {
            lblName1.Text = room.TENPHONG.ToString();
            lblName2.Text = room.TENPHONG.ToString();
            lblSoKhach.Text = room.SOKHACH.ToString();
            lblSoGiuong.Text = room.SOGIUONG.ToString();
            int phongtrong = room.SOPHONG - room.SOPHONGDD;
            //MessageBox.Show(room.TENPHONG.ToString());
            lblSoPhongTrong.Text = phongtrong.ToString();
            lblPrice.Text = room.GIA.ToString();
            //ptbAnh.Image = Image.FromFile(tenAnh);
            ptbAnh.Image = Image.FromFile(room.HinhAnh);
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            Customer_Information f = new Customer_Information(ks,room,checkin, checkout);
            f.tenAnh = ptbAnh.Image;
            f.TENTAIKHOAN = tenTaiKhoan;
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
