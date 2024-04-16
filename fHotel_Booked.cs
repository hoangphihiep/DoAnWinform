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
            List<DatPhong> list = new SupFHotelBooked().KhachSanSapToi(taiKhoan);
            foreach (DatPhong dp in list)
            {
                UPhongDaDat uPhongDaDat = new UPhongDaDat(dp);
                flb_PhongDaDat.Controls.Add(uPhongDaDat);
            }
        }

        private void pSapDen_Paint(object sender, PaintEventArgs e)
        {
            List<DatPhong> list = new SupFHotelBooked().KhachSanSapToi(taiKhoan);
            foreach(DatPhong dp in list)
            {
                UPhongDaDat uPhongDaDat = new UPhongDaDat(dp);
                flb_PhongDaDat.Controls.Add(uPhongDaDat);
            }
        }

        private void pDangTraiNghiem_Paint(object sender, PaintEventArgs e)
        {
            List<DatPhong> list = new SupFHotelBooked().KhachSanDangTraiNghiem(taiKhoan);
            foreach (DatPhong dp in list)
            {
                UPhongDaDat uPhongDaDat = new UPhongDaDat(dp);
                flb_PhongDaDat.Controls.Add(uPhongDaDat);
            }
        }

        private void pDaTraiNghiem_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
