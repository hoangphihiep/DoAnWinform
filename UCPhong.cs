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
        public DateTime NgayNhan;
        public DateTime NgayTra;
        Room room;
        public UCPhong(Room room)
        {
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
            lblSoPhongTrong.Text = phongtrong.ToString();
            lblPrice.Text = room.GIA.ToString();
            //ptbAnh.Image = Image.FromFile(tenAnh);
            ptbAnh.Image = Image.FromFile(room.HinhAnh);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TruyenDaTa();
            Customer_Information f = new Customer_Information();
            f.tenAnh = ptbAnh.Image;
            f.tenKhachSan = tenKhachSan;
            f.soKhach = soKhach;
            f.soPhongConTrong = soPhongConTrong;
            f.Gia = Gia;
            f.NgayNhan = NgayNhan;
            f.NgayTra = NgayTra;
            this.Hide();
            f.ShowDialog();
        }
        public void TruyenDaTa()
        {
            tenAnh = ptbAnh.Image;
            tenKhachSan = lblName2.Text;
            soKhach = lblSoKhach.Text;
            soPhongConTrong = lblSoPhongTrong.Text;
            Gia = lblPrice.Text;
        }
    }
}
