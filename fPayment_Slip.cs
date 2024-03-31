using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;
namespace DuLich
{
    public partial class fPayment_Slip : Form
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
        public fPayment_Slip()
        {
            InitializeComponent();
        }

        private void fPayment_Slip_Load(object sender, EventArgs e)
        {
            label11.Text = tenKhachSan;
            //Diachi ????
            label14.Text = sdt;
            label4.Text = TenKhachHang;
            label6.Text = sdt;
            label25.Text = soKhach;
            label27.Text = Gia;
            pictureBox1.Image = tenAnh;
        }
        public void SetSDT(string Sdt)
        {
            sdt = Sdt;
            // Gọi lại phương thức load dữ liệu
            fPayment_Slip_Load(this, EventArgs.Empty);
        }
        public void SetTenKhachHang(string tenKhachHang)
        {
            TenKhachHang = tenKhachHang;
            // Gọi lại phương thức load dữ liệu
            fPayment_Slip_Load(this, EventArgs.Empty);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Payment_Information f = new Payment_Information();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btn_BookNow_Click(object sender, EventArgs e)
        {

        }
    }
}
