using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
            fHotel_Details f = new fHotel_Details(maks);
            //this.Hide();

            f.ShowDialog();

            this.Show();
        }
        public int maks;
        public int viTri;
        public string tenViTri;
        public string tenKhachSan;
        public string tien;
        public string khoangCach;
        public string anhBia;
        public string soLuong;
        public void ShowKhoangCach()
        {
            lbl_KhoangCach.Visible = true;
        }
        public void HideKhoangCach()
        {
            lbl_KhoangCach.Visible = false;
        }
        public void ShowSoKhach()
        {
            lbl_SoLuong.Visible = true;
        }
        public void HideSoKhach()
        {
            lbl_SoLuong.Visible = false;
        }
        private void UKhungKetQua_Load(object sender, EventArgs e)
        {
            this.Size = new Size(917, 137);
            this.Location = new Point(35, viTri);
            lbl_TenKhachSan.Size = new Size(437, 38);
            lbl_TenKhachSan.Location = new Point(200, 10);
            pictureBox1.Size = new Size(185, 111);
            pictureBox1.Location = new Point(15, 10);
            lbl_ViTri.Size = new Size(56, 20);
            lbl_ViTri.Location = new Point(217, 101);
            lbl_Tien.Size = new Size(59, 20);
            lbl_Tien.Location = new Point(706, 67);
            lbl_KhoangCach.Size = new Size(97, 20);
            lbl_KhoangCach.Location = new Point(217, 67);
            lbl_SoLuong.Size = new Size(73, 20);
            lbl_SoLuong.Location = new Point(706, 101);
            lbl_ViTri.Text = tenViTri;
            lbl_TenKhachSan.Text = tenKhachSan;
            lbl_Tien.Text = tien;
            lbl_KhoangCach.Text = khoangCach;
            pictureBox1.Image = Image.FromFile(anhBia);
            lbl_SoLuong.Text = soLuong;
            /*if (hinhanh != null)
            {
                using (MemoryStream ms = new MemoryStream(hinhanh))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }*/
        }
    }
}
