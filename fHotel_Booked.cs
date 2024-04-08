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
    public partial class fHotel_booked : Form
    {
        public string taiKhoan;
        public DateTime ngayDen;
        TruyenDuLieu truyen = new TruyenDuLieu();
        public fHotel_booked()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            fPayment_Slip f = new fPayment_Slip();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void fHotel_booked_Load(object sender, EventArgs e)
        {
            truyen.Truyen3(taiKhoan);
            List<PhongDaDat> listPhongDat = new List<PhongDaDat>();
            for (int j = 0; j < truyen.soLuong; j++)
            {
                PhongDaDat pd = new PhongDaDat(truyen.maKS[j], truyen.maPhong[j], truyen.tenPhong[j], truyen.tenKhachSan[j], truyen.tenTinh[j], truyen.tenThanhPho[j], truyen.diaChi[j], truyen.soLuongPhong[j], truyen.soTienThanhToan[j], truyen.address[j],truyen.soKhach[j],ngayDen);
                listPhongDat.Add(pd);
                UPhongDaDat uc = new UPhongDaDat(pd);
                uc.viTri = j * 148;
                flowLayoutPanel1.Controls.Add(uc);
            }
        }
    }
}
