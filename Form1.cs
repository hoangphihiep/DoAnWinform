using DoAnDuLich;
using DuLich;
namespace DoAnDuLich
{
    public partial class FTrangChuTK : Form
    {
        public FTrangChuTK()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == false)
            {
                btn_next.Parent = pictureBox1;
                btn_next.BackColor = Color.Transparent;
                btn_back.Parent = pictureBox1;
                btn_back.BackColor = Color.Transparent;
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
            }
            panel1.Parent = pictureBox1;
            panel1.BackColor = Color.FromArgb(80, 0, 0, 0);
            panel2.Parent = pictureBox1;
            panel2.BackColor = Color.FromArgb(80, 0, 0, 0);
            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                panel1.Parent = pictureBox2;
                panel1.BackColor = Color.FromArgb(80, 0, 0, 0);
                panel2.Parent = pictureBox2;
                panel2.BackColor = Color.FromArgb(80, 0, 0, 0);
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                label4.Parent = pictureBox2;
                label4.BackColor = Color.Transparent;
                btn_next.Parent = pictureBox2;
                btn_next.BackColor = Color.Transparent;
                btn_back.Parent = pictureBox2;
                btn_back.BackColor = Color.Transparent;
            }
            else if (pictureBox2.Visible == true)
            {
                panel1.Parent = pictureBox3;
                panel1.BackColor = Color.FromArgb(80, 0, 0, 0);
                panel2.Parent = pictureBox3;
                panel2.BackColor = Color.FromArgb(80, 0, 0, 0);

                pictureBox1.Visible = false;
                pictureBox3.Visible = true;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                label4.Parent = pictureBox3;
                label4.BackColor = Color.Transparent;
                btn_next.Parent = pictureBox3;
                btn_next.BackColor = Color.Transparent;
                btn_back.Parent = pictureBox3;
                btn_back.BackColor = Color.Transparent;
            }
            else if (pictureBox3.Visible == true)
            {
                panel1.Parent = pictureBox4;
                panel1.BackColor = Color.FromArgb(80, 0, 0, 0);
                panel2.Parent = pictureBox4;
                panel2.BackColor = Color.FromArgb(80, 0, 0, 0);

                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
                label4.Parent = pictureBox4;
                label4.BackColor = Color.Transparent;
                btn_next.Parent = pictureBox4;
                btn_next.BackColor = Color.Transparent;
                btn_back.Parent = pictureBox4;
                btn_back.BackColor = Color.Transparent;
            }
            else if (pictureBox4.Visible == true)
            {
                panel1.Parent = pictureBox5;
                panel1.BackColor = Color.FromArgb(80, 0, 0, 0);
                panel2.Parent = pictureBox5;
                panel2.BackColor = Color.FromArgb(80, 0, 0, 0);

                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                label4.Parent = pictureBox5;
                label4.BackColor = Color.Transparent;
                btn_next.Parent = pictureBox5;
                btn_next.BackColor = Color.Transparent;
                btn_back.Parent = pictureBox5;
                btn_back.BackColor = Color.Transparent;
            }
            else
            {
                panel1.Parent = pictureBox1;
                panel1.BackColor = Color.FromArgb(80, 0, 0, 0);
                panel2.Parent = pictureBox1;
                panel2.BackColor = Color.FromArgb(80, 0, 0, 0);

                pictureBox1.Visible = true;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                label4.Parent = pictureBox1;
                label4.BackColor = Color.Transparent;
                btn_next.Parent = pictureBox1;
                btn_next.BackColor = Color.Transparent;
                btn_back.Parent = pictureBox1;
                btn_back.BackColor = Color.Transparent;
            }
        }
        public void HideMenuStrip()
        {
            //hien menustrip
            menuTaiKhoan.Visible = false;
        }
        public void ShowMenuStrip()
        {
            menuTaiKhoan.Visible = true;
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

        private void btn_back_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Visible == true)
            {
                panel1.Parent = pictureBox2;
                panel1.BackColor = Color.FromArgb(80, 0, 0, 0);
                panel2.Parent = pictureBox2;
                panel2.BackColor = Color.FromArgb(80, 0, 0, 0);

                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                label4.Parent = pictureBox2;
                label4.BackColor = Color.Transparent;
                btn_back.Parent = pictureBox2;
                btn_back.BackColor = Color.Transparent;
                btn_next.Parent = pictureBox2;
                btn_next.BackColor = Color.Transparent;
            }
            else if (pictureBox2.Visible == true)
            {
                panel1.Parent = pictureBox3;
                panel1.BackColor = Color.FromArgb(80, 0, 0, 0);
                panel2.Parent = pictureBox3;
                panel2.BackColor = Color.FromArgb(80, 0, 0, 0);

                pictureBox1.Visible = false;
                pictureBox3.Visible = true;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                label4.Parent = pictureBox3;
                label4.BackColor = Color.Transparent;
                btn_back.Parent = pictureBox3;
                btn_back.BackColor = Color.Transparent;
                btn_next.Parent = pictureBox3;
                btn_next.BackColor = Color.Transparent;
            }
            else if (pictureBox3.Visible == true)
            {
                panel1.Parent = pictureBox4;
                panel1.BackColor = Color.FromArgb(80, 0, 0, 0);
                panel2.Parent = pictureBox4;
                panel2.BackColor = Color.FromArgb(80, 0, 0, 0);

                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
                label4.Parent = pictureBox4;
                label4.BackColor = Color.Transparent;
                btn_back.Parent = pictureBox4;
                btn_back.BackColor = Color.Transparent;
                btn_next.Parent = pictureBox4;
                btn_next.BackColor = Color.Transparent;
            }
            else if (pictureBox4.Visible == true)
            {
                panel1.Parent = pictureBox5;
                panel1.BackColor = Color.FromArgb(80, 0, 0, 0);
                panel2.Parent = pictureBox5;
                panel2.BackColor = Color.FromArgb(80, 0, 0, 0);

                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                label4.Parent = pictureBox5;
                label4.BackColor = Color.Transparent;
                btn_back.Parent = pictureBox5;
                btn_back.BackColor = Color.Transparent;
                btn_next.Parent = pictureBox5;
                btn_next.BackColor = Color.Transparent;
            }
            else
            {
                panel1.Parent = pictureBox1;
                panel1.BackColor = Color.FromArgb(80, 0, 0, 0);
                panel2.Parent = pictureBox1;
                panel2.BackColor = Color.FromArgb(80, 0, 0, 0);

                pictureBox1.Visible = true;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                label4.Parent = pictureBox1;
                label4.BackColor = Color.Transparent;
                btn_back.Parent = pictureBox1;
                btn_back.BackColor = Color.Transparent;
                btn_next.Parent = pictureBox1;
                btn_next.BackColor = Color.Transparent;
            }
        }

        private void btn_next_Paint(object sender, PaintEventArgs e)
        {
            btn_next.BackColor = Color.Transparent;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            fRegister f = new fRegister();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            int t = 0;
            fLogin f = new fLogin();
            f.KiemTra(t);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void FTrangChuTK_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự có muốn thoát không ? ", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hien_thi_khach_san_phu_hop k = new hien_thi_khach_san_phu_hop();
            this.Hide();
            k.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fHotel_Posting f = new fHotel_Posting();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        //private void panel2_Paint(object sender, PaintEventArgs e)
        //{

        //    private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        //    {
        //        ShowDangNhap();
        //        ShowDangKy();
        //        HideMenuStrip();
        //    }
        //}
    }
}