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
    public partial class fHotel_Posting_Image : Form
    {
        public fHotel_Posting_Image()
        {
            InitializeComponent();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_ThietLap_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ChiTietPhong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_QuyDoiTac_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_HinhAnhRatQuanTrong_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_QuyDoiTac_Click_1(object sender, EventArgs e)
        {

        }
        public int kiemtratrang5;
        private void btn_TiepTheo_Click(object sender, EventArgs e)
        {
            fHotel_Posting_Profile f = new fHotel_Posting_Profile();
            if (kiemtratrang5 == 1)
            {
                f.kiemtratrang6 = 1;
            }
            else
            {
                f.kiemtratrang6 = 0;
            }
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void lbl_Anh_Click(object sender, EventArgs e)
        {

        }

        private void fHotel_Posting_Image_Load(object sender, EventArgs e)
        {

        }
    }
}
