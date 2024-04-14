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
            List<PhongDaDat> listPhongDat = new List<PhongDaDat>();
            truyen.Truyen3(taiKhoan, listPhongDat);
            foreach (PhongDaDat i in listPhongDat)
            {
                UPhongDaDat uc = new UPhongDaDat(i);
                flb_PhongDaDat.Controls.Add(uc);
            }
            listPhongDat.Clear();
        }
    }
}
