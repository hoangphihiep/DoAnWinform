using DoAnDuLich;

namespace DuLich
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private int y;
        public void KiemTra(int x)
        {
            y = x;
        }
        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            fRegister f = new fRegister();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void txt_TenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txt_TenDangNhap_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txt_TenDangNhap_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_TenDangNhap.Text == "Tên tài khoản")
            {
                txt_TenDangNhap.Clear();
            }
        }

        private void txt_MatKhau_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_MatKhau.Text == "Mật khẩu")
            {
                txt_MatKhau.Clear();
            }
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (y == 1)
            {
                hien_thi_khach_san_phu_hop k = new hien_thi_khach_san_phu_hop();
                k.KT_DangNhap1++;
                k.ShowMenuStrip();
                k.HideDangNhap();
                k.HideDangKy();
                this.Hide();
                k.ShowDialog();
                this.Close();
            }
            else
            {
                FTrangChuTK f = new FTrangChuTK();
                f.KT_DangNhap++;
                f.ShowMenuStrip();
                f.HideDangNhap();
                f.HideDangKy();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
        }
    }
}