using DoAnDuLich;
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
    public partial class fCollections : Form
    {
        public fCollections()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
        public int kiemtratrang;
        private void fCollections_Load(object sender, EventArgs e)
        {
            if (kiemtratrang != 1)
            {
                FTrangChuTK f1 = new FTrangChuTK();
                this.Hide();
                f1.ShowDialog();
                this.Close();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            fHotel_booked f1 = new fHotel_booked();
            this.Hide();
            f1.ShowDialog();
            this.Show();
        }
    }
}