using DoAnDuLich;
using DuLich;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.IO;
using System.Security.Policy;

namespace DoAnDuLich
{
    public partial class FTrangChuTK : Form
    {
        public string rename;
        public string tentk;
        public string mk;
        public string MaKS;
        public FTrangChuTK()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btn_MyTaiKhoan.Text = rename;
            if (pictureBox1.Visible == false)
            {
                btn_next.Parent = pictureBox1;
                btn_next.BackColor = Color.Transparent;
                btn_back.Parent = pictureBox1;
                btn_back.BackColor = Color.Transparent;
                btn_DangNhap.Parent = pictureBox1;
                btn_DangNhap.BackColor = Color.Transparent;
                btn_DangKy.Parent = pictureBox1;
                btn_DangKy.BackColor = Color.Transparent;
                btn_DangKyKS.Parent = pictureBox1;
                btn_DangKyKS.BackColor = Color.Transparent;
                btn_MyTaiKhoan.Parent = pictureBox1;
                btn_MyTaiKhoan.BackColor = Color.Transparent;
                btn_DangNhap.FlatStyle = FlatStyle.Flat;
                btn_DangNhap.FlatAppearance.BorderSize = 0;
                btn_DangKy.FlatStyle = FlatStyle.Flat;
                btn_DangKy.FlatAppearance.BorderSize = 0;
                btn_DangKyKS.FlatStyle = FlatStyle.Flat;
                btn_DangKyKS.FlatAppearance.BorderSize = 0;
                btn_MyTaiKhoan.FlatStyle = FlatStyle.Flat;
                btn_MyTaiKhoan.FlatAppearance.BorderSize = 0;
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
            timer1.Interval = 8000; // 3000 milliseconds = 3 seconds
            timer1.Tick += timer1_Tick;
            timer1.Start();

            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            data.Add("An Giang");
            data.Add("Bà rịa Vũng Tàu");
            data.Add("Bạc Liêu");
            data.Add("Bắc Giang");
            data.Add("Bắc Kạn");
            data.Add("Bắc Ninh");
            data.Add("Bến Tre");
            data.Add("Bình Dương");
            data.Add("Bình Định");
            data.Add("Bình Phước");
            data.Add("Bình Thuận");
            data.Add("Cà Mau");
            data.Add("Cao Bằng");
            data.Add("Cần Thơ");
            data.Add("Đà Nẵng");
            data.Add("Đắk Lắk");
            data.Add("Đắk Nông");
            data.Add("Điện Biên");
            data.Add("Đồng Nai");
            data.Add("Đồng Tháp");
            data.Add("Gia Lai");
            data.Add("Hà Giang");
            data.Add("Hà Nam");
            data.Add("Hà Nội");
            data.Add("Hà Tĩnh");
            data.Add("Hải Dương");
            data.Add("Hải Phòng");
            data.Add("Hậu Giang");
            data.Add("Hòa Bình");
            data.Add("Hưng Yên");
            data.Add("Khánh Hòa");
            data.Add("Kiên Giang");
            data.Add("Kon Tum");
            data.Add("Lai Châu");
            data.Add("Lạng Sơn");
            data.Add("Lào Cai");
            data.Add("Lâm Đồng");
            data.Add("Long An");
            data.Add("Nam Định");
            data.Add("Nghệ An");
            data.Add("Ninh Bình");
            data.Add("Ninh Thuận");
            data.Add("Phú Thọ");
            data.Add("Phú Yên");
            data.Add("Quảng Bình");
            data.Add("Quảng Nam");
            data.Add("Quảng Ngãi");
            data.Add("Quảng Ninh");
            data.Add("Quảng Trị");
            data.Add("Sóc Trăng");
            data.Add("Sơn La");
            data.Add("Tây Ninh");
            data.Add("Thái Bình");
            data.Add("Thái Nguyên");
            data.Add("Thanh Hóa");
            data.Add("Thừa Thiên Huế");
            data.Add("Tiền Giang");
            data.Add("TP Hồ Chí Minh");
            data.Add("Trà Vinh");
            data.Add("Tuyên Quang");
            data.Add("Vĩnh Long");
            data.Add("Vĩnh Phúc");
            data.Add("Yên Bái");
            txt_DiaDiem.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_DiaDiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_DiaDiem.AutoCompleteCustomSource = data;
        }
        private void timer1_Tick(object sender, EventArgs e)
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
                btn_DangNhap.Parent = pictureBox2;
                btn_DangNhap.BackColor = Color.Transparent;
                btn_DangKy.Parent = pictureBox2;
                btn_DangKy.BackColor = Color.Transparent;
                btn_DangKyKS.Parent = pictureBox2;
                btn_DangKyKS.BackColor = Color.Transparent;
                btn_MyTaiKhoan.Parent = pictureBox2;
                btn_MyTaiKhoan.BackColor = Color.Transparent;
                btn_DangNhap.FlatStyle = FlatStyle.Flat;
                btn_DangNhap.FlatAppearance.BorderSize = 0;
                btn_DangKy.FlatStyle = FlatStyle.Flat;
                btn_DangKy.FlatAppearance.BorderSize = 0;
                btn_DangKyKS.FlatStyle = FlatStyle.Flat;
                btn_DangKyKS.FlatAppearance.BorderSize = 0;
                btn_MyTaiKhoan.FlatStyle = FlatStyle.Flat;
                btn_MyTaiKhoan.FlatAppearance.BorderSize = 0;

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
                btn_DangNhap.Parent = pictureBox3;
                btn_DangNhap.BackColor = Color.Transparent;
                btn_DangKy.Parent = pictureBox3;
                btn_DangKy.BackColor = Color.Transparent;
                btn_DangKyKS.Parent = pictureBox3;
                btn_DangKyKS.BackColor = Color.Transparent;
                btn_MyTaiKhoan.Parent = pictureBox3;
                btn_MyTaiKhoan.BackColor = Color.Transparent;
                btn_DangNhap.FlatStyle = FlatStyle.Flat;
                btn_DangNhap.FlatAppearance.BorderSize = 0;
                btn_DangKy.FlatStyle = FlatStyle.Flat;
                btn_DangKy.FlatAppearance.BorderSize = 0;
                btn_DangKyKS.FlatStyle = FlatStyle.Flat;
                btn_DangKyKS.FlatAppearance.BorderSize = 0;
                btn_MyTaiKhoan.FlatStyle = FlatStyle.Flat;
                btn_MyTaiKhoan.FlatAppearance.BorderSize = 0;
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
                btn_DangNhap.Parent = pictureBox4;
                btn_DangNhap.BackColor = Color.Transparent;
                btn_DangKy.Parent = pictureBox4;
                btn_DangKy.BackColor = Color.Transparent;
                btn_DangKyKS.Parent = pictureBox4;
                btn_DangKyKS.BackColor = Color.Transparent;
                btn_MyTaiKhoan.Parent = pictureBox4;
                btn_MyTaiKhoan.BackColor = Color.Transparent;
                btn_DangNhap.FlatStyle = FlatStyle.Flat;
                btn_DangNhap.FlatAppearance.BorderSize = 0;
                btn_DangKy.FlatStyle = FlatStyle.Flat;
                btn_DangKy.FlatAppearance.BorderSize = 0;
                btn_DangKyKS.FlatStyle = FlatStyle.Flat;
                btn_DangKyKS.FlatAppearance.BorderSize = 0;
                btn_MyTaiKhoan.FlatStyle = FlatStyle.Flat;
                btn_MyTaiKhoan.FlatAppearance.BorderSize = 0;
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
                btn_DangNhap.Parent = pictureBox5;
                btn_DangNhap.BackColor = Color.Transparent;
                btn_DangKy.Parent = pictureBox5;
                btn_DangKy.BackColor = Color.Transparent;
                btn_DangKyKS.Parent = pictureBox5;
                btn_DangKyKS.BackColor = Color.Transparent;
                btn_MyTaiKhoan.Parent = pictureBox5;
                btn_MyTaiKhoan.BackColor = Color.Transparent;
                btn_DangNhap.FlatStyle = FlatStyle.Flat;
                btn_DangNhap.FlatAppearance.BorderSize = 0;
                btn_DangKy.FlatStyle = FlatStyle.Flat;
                btn_DangKy.FlatAppearance.BorderSize = 0;
                btn_DangKyKS.FlatStyle = FlatStyle.Flat;
                btn_DangKyKS.FlatAppearance.BorderSize = 0;
                btn_MyTaiKhoan.FlatStyle = FlatStyle.Flat;
                btn_MyTaiKhoan.FlatAppearance.BorderSize = 0;
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
                btn_DangNhap.Parent = pictureBox1;
                btn_DangNhap.BackColor = Color.Transparent;
                btn_DangKy.Parent = pictureBox1;
                btn_DangKy.BackColor = Color.Transparent;
                btn_DangKyKS.Parent = pictureBox1;
                btn_DangKyKS.BackColor = Color.Transparent;
                btn_MyTaiKhoan.Parent = pictureBox1;
                btn_MyTaiKhoan.BackColor = Color.Transparent;
                btn_DangNhap.FlatStyle = FlatStyle.Flat;
                btn_DangNhap.FlatAppearance.BorderSize = 0;
                btn_DangKy.FlatStyle = FlatStyle.Flat;
                btn_DangKy.FlatAppearance.BorderSize = 0;
                btn_DangKyKS.FlatStyle = FlatStyle.Flat;
                btn_DangKyKS.FlatAppearance.BorderSize = 0;
                btn_MyTaiKhoan.FlatStyle = FlatStyle.Flat;
                btn_MyTaiKhoan.FlatAppearance.BorderSize = 0;
            }
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
                btn_DangNhap.Parent = pictureBox2;
                btn_DangNhap.BackColor = Color.Transparent;
                btn_DangKy.Parent = pictureBox2;
                btn_DangKy.BackColor = Color.Transparent;
                btn_DangKyKS.Parent = pictureBox2;
                btn_DangKyKS.BackColor = Color.Transparent;
                btn_MyTaiKhoan.Parent = pictureBox2;
                btn_MyTaiKhoan.BackColor = Color.Transparent;
                btn_DangNhap.FlatStyle = FlatStyle.Flat;
                btn_DangNhap.FlatAppearance.BorderSize = 0;
                btn_DangKy.FlatStyle = FlatStyle.Flat;
                btn_DangKy.FlatAppearance.BorderSize = 0;
                btn_DangKyKS.FlatStyle = FlatStyle.Flat;
                btn_DangKyKS.FlatAppearance.BorderSize = 0;
                btn_MyTaiKhoan.FlatStyle = FlatStyle.Flat;
                btn_MyTaiKhoan.FlatAppearance.BorderSize = 0;

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
                btn_DangNhap.Parent = pictureBox3;
                btn_DangNhap.BackColor = Color.Transparent;
                btn_DangKy.Parent = pictureBox3;
                btn_DangKy.BackColor = Color.Transparent;
                btn_DangKyKS.Parent = pictureBox3;
                btn_DangKyKS.BackColor = Color.Transparent;
                btn_MyTaiKhoan.Parent = pictureBox3;
                btn_MyTaiKhoan.BackColor = Color.Transparent;
                btn_DangNhap.FlatStyle = FlatStyle.Flat;
                btn_DangNhap.FlatAppearance.BorderSize = 0;
                btn_DangKy.FlatStyle = FlatStyle.Flat;
                btn_DangKy.FlatAppearance.BorderSize = 0;
                btn_DangKyKS.FlatStyle = FlatStyle.Flat;
                btn_DangKyKS.FlatAppearance.BorderSize = 0;
                btn_MyTaiKhoan.FlatStyle = FlatStyle.Flat;
                btn_MyTaiKhoan.FlatAppearance.BorderSize = 0;
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
                btn_DangNhap.Parent = pictureBox4;
                btn_DangNhap.BackColor = Color.Transparent;
                btn_DangKy.Parent = pictureBox4;
                btn_DangKy.BackColor = Color.Transparent;
                btn_DangKyKS.Parent = pictureBox4;
                btn_DangKyKS.BackColor = Color.Transparent;
                btn_MyTaiKhoan.Parent = pictureBox4;
                btn_MyTaiKhoan.BackColor = Color.Transparent;
                btn_DangNhap.FlatStyle = FlatStyle.Flat;
                btn_DangNhap.FlatAppearance.BorderSize = 0;
                btn_DangKy.FlatStyle = FlatStyle.Flat;
                btn_DangKy.FlatAppearance.BorderSize = 0;
                btn_DangKyKS.FlatStyle = FlatStyle.Flat;
                btn_DangKyKS.FlatAppearance.BorderSize = 0;
                btn_MyTaiKhoan.FlatStyle = FlatStyle.Flat;
                btn_MyTaiKhoan.FlatAppearance.BorderSize = 0;
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
                btn_DangNhap.Parent = pictureBox5;
                btn_DangNhap.BackColor = Color.Transparent;
                btn_DangKy.Parent = pictureBox5;
                btn_DangKy.BackColor = Color.Transparent;
                btn_DangKyKS.Parent = pictureBox5;
                btn_DangKyKS.BackColor = Color.Transparent;
                btn_MyTaiKhoan.Parent = pictureBox5;
                btn_MyTaiKhoan.BackColor = Color.Transparent;
                btn_DangNhap.FlatStyle = FlatStyle.Flat;
                btn_DangNhap.FlatAppearance.BorderSize = 0;
                btn_DangKy.FlatStyle = FlatStyle.Flat;
                btn_DangKy.FlatAppearance.BorderSize = 0;
                btn_DangKyKS.FlatStyle = FlatStyle.Flat;
                btn_DangKyKS.FlatAppearance.BorderSize = 0;
                btn_MyTaiKhoan.FlatStyle = FlatStyle.Flat;
                btn_MyTaiKhoan.FlatAppearance.BorderSize = 0;
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
                btn_DangNhap.Parent = pictureBox1;
                btn_DangNhap.BackColor = Color.Transparent;
                btn_DangKy.Parent = pictureBox1;
                btn_DangKy.BackColor = Color.Transparent;
                btn_DangKyKS.Parent = pictureBox1;
                btn_DangKyKS.BackColor = Color.Transparent;
                btn_MyTaiKhoan.Parent = pictureBox1;
                btn_MyTaiKhoan.BackColor = Color.Transparent;
                btn_DangNhap.FlatStyle = FlatStyle.Flat;
                btn_DangNhap.FlatAppearance.BorderSize = 0;
                btn_DangKy.FlatStyle = FlatStyle.Flat;
                btn_DangKy.FlatAppearance.BorderSize = 0;
                btn_DangKyKS.FlatStyle = FlatStyle.Flat;
                btn_DangKyKS.FlatAppearance.BorderSize = 0;
                btn_MyTaiKhoan.FlatStyle = FlatStyle.Flat;
                btn_MyTaiKhoan.FlatAppearance.BorderSize = 0;
            }
        }
        public void HideMenuStrip()
        {
            //hien menustrip
            btn_MyTaiKhoan.Visible = false;
        }
        public void ShowMenuStrip()
        {
            btn_MyTaiKhoan.Visible = true;
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
        public void HideDangKyKS()
        {
            btn_DangKyKS.Visible = false;
        }
        public void ShowPanel3()
        {
            panel3.Visible = true;
        }
        public void HidePanel3()
        {
            panel3.Visible = false;
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
        public int KT_DangNhap = 0;
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            int t = 0;
            fLogin f = new fLogin();
            KT_DangNhap++;
            f.KiemTra(t);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void FTrangChuTK_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (KT_DangNhap == 0)
            {
                if (MessageBox.Show("Bạn thực sự có muốn thoát không ? ", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                Application.Exit();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public int kiemtradangnhap;
        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(txt_DiaDiem.Text);
            hien_thi_khach_san_phu_hop k = new hien_thi_khach_san_phu_hop();
            if (btn_MyTaiKhoan.Visible == true && btn_DangKyKS.Visible == true)
            {

                k.ShowMenuStrip();
                k.HideDangKy();
                k.HideDangNhap();
                k.HidePanle2();
                k.diadiem = txt_DiaDiem.Text;
                k.diaDiem2 = txt_DiaDiem.Text;
                int number = int.Parse(soLuongNguoiLon.Value.ToString());
                int number1 = int.Parse(soLuongTreEm.Value.ToString());
                k.soLuongNguoiLon = number;
                k.soLuongTreEm = number1;
                k.tenKhachHang = tentk;
                k.ngayDen = date_ngayDen.Value;
                k.ngayDi = date_NgayDi.Value;
                this.Hide();
                k.ShowDialog();
                this.Show();
            }
            else if (btn_MyTaiKhoan.Visible == true && btn_DangKyKS.Visible == false)
            {
                k.ShowMenuStrip();
                k.HideDangKy();
                k.HideDangNhap();
                k.HideDangKyKS();
                k.HidePanle2();
                k.diadiem = txt_DiaDiem.Text;
                k.diaDiem2 = txt_DiaDiem.Text;
                int number = int.Parse(soLuongNguoiLon.Value.ToString());
                int number1 = int.Parse(soLuongTreEm.Value.ToString());
                k.soLuongNguoiLon = number;
                k.soLuongTreEm = number1;
                k.tenKhachHang = tentk;
                k.ngayDen = date_ngayDen.Value;
                k.ngayDi = date_NgayDi.Value;
                this.Hide();
                k.ShowDialog();
                this.Show();
            }
            else
            {
                k.diadiem = txt_DiaDiem.Text;
                k.diaDiem2 = txt_DiaDiem.Text;
                int number = int.Parse(soLuongNguoiLon.Value.ToString());
                int number1 = int.Parse(soLuongTreEm.Value.ToString());
                k.soLuongNguoiLon = number;
                k.soLuongTreEm = number1;
                k.tenKhachHang = tentk;
                k.ngayDen = date_ngayDen.Value;
                k.ngayDi = date_NgayDi.Value;
                this.Hide();
                k.ShowDialog();
                this.Show();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (KT_DangNhap == 0)
            {
                MessageBox.Show("Bạn chưa có tài khoản!!! Vui lòng tạo tài khoản", "Thông báo", MessageBoxButtons.OKCancel);
            }
            else
            {
                int t = 0;
                fHotel_Rental f = new fHotel_Rental();
                f.tk = tentk;
                f.mk = mk;
                KT_DangNhap++;
                f.kiemtratrang7 = t;
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kháchSạnĐãĐặtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public int kiemtradangkiKS;
        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }
        public void ShowThongTinTaiKhoan()
        {
            btn_ThongTinTaiKhoan.Visible = true;
        }
        public void ShowKSDaDat()
        {
            btn_KSDaDat.Visible = true;
        }
        public void ShowThoat()
        {
            btn_Thoat.Visible = true;
        }
        public void HideThongTinTaiKhoan()
        {
            btn_ThongTinTaiKhoan.Visible = false;
        }
        public void HideKSDaDat()
        {
            btn_KSDaDat.Visible = false;
        }
        public void HideThoat()
        {
            btn_Thoat.Visible = false;
        }
        int dem = 0;

        private void btn_MyTaiKhoan_Click(object sender, EventArgs e)
        {
            if (dem % 2 == 0)
            {
                panel_menu.Visible = true;
                dem++;
            }
            else
            {
                panel_menu.Visible = false;
                dem++;
            }
        }

        private void btn_ThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            fThongTinTaiKhoan t = new fThongTinTaiKhoan();
            t.tentk = tentk;
            t.mk = mk;
            if (kiemtradangkiKS == 1)
            {
                this.Hide();
                t.ShowThongTinKS();
                t.ShowDialog();
                this.Show();
            }
            else
            {
                this.Hide();
                t.ShowDialog();
                this.Show();
            }
        }

        private void btn_KSDaDat_Click(object sender, EventArgs e)
        {
            fHotel_booked f = new fHotel_booked();
            //f.kiemtratrang = 1;
            f.taiKhoan = tentk;
            f.ngayDen = date_ngayDen.Value;
            MessageBox.Show(tentk);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            ShowDangKy();
            ShowDangNhap();
            HideMenuStrip();
            ShowPanel3();
            panel_menu.Visible = false;
            KT_DangNhap = 0;
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