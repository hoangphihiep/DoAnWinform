using DoAnDuLich;

namespace DuLich
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        bool check = false;
        public string tk;
        public string mk;
        public Image tenAnh;
        public string tenKhachSan;
        public string TenKhachHang;
        public string sdt;
        public string soKhach;
        public string soPhongConTrong;
        public string Gia;
        public DateTime NgayNhan;
        public DateTime NgayTra;
        public KhachHang kh;
        public Room phong;
        public DatPhong datphong;
        public KHACHSAN ks;
        public string diadiem;
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
        public string taikhoan;
        Modify modify = new Modify();
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string tk = txt_TenDangNhap.Text;
                string mk = txt_MatKhau.Text;
                string name;
                if (tk.Trim() == "")
                    MessageBox.Show("Vui lòng nhập tài khoản");
                else if (mk.Trim() == "")
                    MessageBox.Show("Vui lòng nhập mật khẩu");
                else
                {

                    string query = "Select * from TaiKhoan1 where TenDangNhap = '" + tk + "' and MatKhau = '" + mk + "' ";
                    var result = modify.accounts(query);
                    if (result.Count() != 0)
                    {
                        name = result.FirstOrDefault().getHoTen.ToString();
                        tk = result.FirstOrDefault().getTenDangNhap.ToString();
                        taikhoan = tk;
                        //MessageBox.Show(tk);
                        MessageBox.Show("Đăng nhập thành công");
                        if (y == 1)
                        {
                            hien_thi_khach_san_phu_hop k = new hien_thi_khach_san_phu_hop();
                            //k.tenKhachHang = name;
                            k.KT_DangNhap1++;
                            k.mk = mk;
                            k.tentk = tk;
                            k.tenKhachHang = name;
                            k.diadiem = diadiem;
                            k.ShowMenuStrip();
                            k.HideDangNhap();
                            k.HideDangKy();
                            k.HidePanle2();
                            this.Hide();
                            k.ShowDialog();
                            this.Close();
                        }
                        else if (y == 2)
                        {
                            Customer_Information k = new Customer_Information();
                            k.TENTAIKHOAN = tk;
                            k.tk = tk;
                            k.mk = mk;
                            k.tenAnh = tenAnh;
                            k.tenKhachSan = tenKhachSan;
                            k.soKhach = soKhach;
                            k.soPhongConTrong = soPhongConTrong;
                            k.Gia = Gia;
                            k.sdt = sdt;
                            k.TenKhachHang = TenKhachHang;
                            k.ks = ks;
                            k.phong = phong;
                            k.kh = kh;
                            k.datphong = datphong;
                            k.checkin = NgayNhan;
                            k.checkout = NgayTra;
                            k.HienThi();
                            this.Hide();
                            k.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            FTrangChuTK f = new FTrangChuTK();
                            f.rename = name;
                            f.tentk = tk;
                            f.mk = mk;
                            f.KT_DangNhap++;
                            f.ShowMenuStrip();
                            f.HideDangNhap();
                            f.HideDangKy();
                            f.HidePanel3();
                            this.Hide();
                            f.ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}