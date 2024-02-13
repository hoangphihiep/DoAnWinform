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
    public partial class hien_thi_khach_san_phu_hop : Form
    {
        public hien_thi_khach_san_phu_hop()
        {
            InitializeComponent();
            trackBar1.Value = 50; // Giá trị mặc định
            trackBar1.Scroll += trackBar1_Scroll;
            trackBar2.Value = 4000000; // Giá trị mặc định
            trackBar2.Scroll += trackBar2_Scroll;
            int value = trackBar1.Value;
            lbl_Min.Text = $"{value}";
            int value2 = trackBar2.Value;
            value = trackBar2.Maximum - value2;
            lbl_max.Text = value.ToString();
        }
        public void HideMenuStrip()
        {
            //hien menustrip
            MenuStripTaiKhoan.Visible = false;
        }
        public void ShowMenuStrip()
        {
            MenuStripTaiKhoan.Visible = true;
        }
        public void HideDangNhap()
        {
            btn_DangNhap.Visible = false;
        }
        public void ShowDangNhap()
        {
            btn_DangNhap.Visible = true;
        }
        public void HideDangKy()
        {
            btn_DangKy.Visible = false;
        }
        public void ShowDangKy()
        {
            btn_DangKy.Visible = true;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int value = trackBar1.Value;
            // Xử lý giá trị mới tại đây
            lbl_Min.Text = $"{value}";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            int value = trackBar2.Value;

            // Tính giá trị đảo ngược của value
            value = trackBar2.Maximum - value;

            // Hiển thị giá trị đảo ngược lên label
            lbl_max.Text = value.ToString();


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fHotel_Posting f = new fHotel_Posting();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            int t = 0;
            fLogin f = new fLogin();
            t = 1;
            f.KiemTra(t);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            fRegister f = new fRegister();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void hien_thi_khach_san_phu_hop_Load(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDangNhap();
            ShowDangKy();
            HideMenuStrip();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            fHotel_Details f = new fHotel_Details();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void kháchSạnĐãĐặtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCollections f = new fCollections();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
