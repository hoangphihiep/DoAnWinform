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
    public partial class U_HienThiPhong : UserControl
    {
        public Image tenAnh;
        public string tenKhachSan;
        public string soKhach;
        public string soPhongConTrong;
        public string Gia;
        public DateTime NgayNhan;
        public DateTime NgayTra;
        public U_HienThiPhong()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TruyenDaTa();
            Customer_Information f = new Customer_Information();
            f.tenAnh = tenAnh;
            f.tenKhachSan = tenKhachSan;
            f.soKhach = soKhach;
            f.soPhongConTrong = soPhongConTrong;
            f.Gia = Gia;
            this.Hide();
            f.ShowDialog();

        }
        public void TruyenDaTa()
        {
            tenAnh = pictureBox14.Image;
            tenKhachSan = label15.Text;
            soKhach = label17.Text;
            soPhongConTrong = label19.Text;
            Gia = label20.Text;
        }
    }
}
