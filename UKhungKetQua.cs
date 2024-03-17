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
    public partial class UKhungKetQua : UserControl
    {
        public UKhungKetQua()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            fHotel_Details f = new fHotel_Details();
            //this.Hide();
            f.ShowDialog();
            this.Show();
        }

        public int viTri;
        public string tenViTri;
        public string tenKhachSan;
        public byte[] hinhanh;
        private void UKhungKetQua_Load(object sender, EventArgs e)
        {
            this.Size = new Size(917, 137);
            this.Location = new Point(35, viTri);
            lbl_TenKhachSan.Size = new Size(437, 38);
            lbl_TenKhachSan.Location = new Point(353, 10);
            pictureBox1.Size = new Size(185, 111);
            pictureBox1.Location = new Point(15, 10);
            lbl_ViTri.Size = new Size(56, 20);
            lbl_ViTri.Location = new Point(217, 101);
            lbl_ViTri.Text = tenViTri;
            lbl_TenKhachSan.Text = tenKhachSan;
            if (hinhanh != null)
            {
                using (MemoryStream ms = new MemoryStream(hinhanh))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
        }
    }
}
