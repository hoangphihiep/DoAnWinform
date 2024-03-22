using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.Pkcs;
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
        public void ShowPanel2()
        {
            panel2.Visible = true;
        }
        public void HidePanle2()
        {
            panel2.Visible = false;
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
        public int KT_DangNhap1 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (KT_DangNhap1 == 0)
            {
                MessageBox.Show("Bạn chưa có tài khoản!!! Vui lòng tạo tài khoản", "Thông báo", MessageBoxButtons.OKCancel);
            }
            else
            {
                int t = 1;
                fHotel_Rental f = new fHotel_Rental();
                KT_DangNhap1++;
                f.kiemtratrang7 = t;
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
        }
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            int t = 0;
            fLogin f = new fLogin();
            t = 1;
            KT_DangNhap1++;
            f.KiemTra(t);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            fRegister f = new fRegister();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        public string diadiem;
        private void hien_thi_khach_san_phu_hop_Load(object sender, EventArgs e)
        {
            btn_DangNhap.FlatStyle = FlatStyle.Flat;
            btn_DangNhap.FlatAppearance.BorderSize = 0;
            btn_DangKy.FlatStyle = FlatStyle.Flat;
            btn_DangKy.FlatAppearance.BorderSize = 0;
            btn_DangKyKS.FlatStyle = FlatStyle.Flat;
            btn_DangKyKS.FlatAppearance.BorderSize = 0;
            btn_MyTaiKhoan.FlatStyle = FlatStyle.Flat;
            btn_MyTaiKhoan.FlatAppearance.BorderSize = 0;
            //MessageBox.Show(diadiem);
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
            lb_TimKiem.AutoCompleteMode = AutoCompleteMode.Suggest;
            lb_TimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            lb_TimKiem.AutoCompleteCustomSource = data;
            string query = "SELECT * FROM ThongTinCanBan inner join ViTri ON ThongTinCanBan.MAKS = ViTri.MAKS WHERE ViTri.Tinh = @diadiem";
            SqlConnection conn = Connection_to_SQL.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@diadiem", diadiem);
            command.CommandTimeout = 120;
            SqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                string tenTinh = reader.GetString(reader.GetOrdinal("TINH"));
                string tenThanhPho = reader.GetString(reader.GetOrdinal("TENTHANHPHO"));
                string tenKhachSan = reader.GetString(reader.GetOrdinal("TENKH"));
                //byte[] hinhanh = (byte[])reader["HinhAnh"];
                int giaColumnIndex = reader.GetOrdinal("GIA");
                UKhungKetQua uc = new UKhungKetQua();// tab phu hop nhat
                uc.viTri = i * 148;
                uc.tenViTri = tenThanhPho + ", " + tenTinh;
                uc.tenKhachSan = tenKhachSan;
                if (!reader.IsDBNull(giaColumnIndex))
                {
                    int gia = reader.GetInt32(giaColumnIndex);
                    string tienThapNhat = gia.ToString() + " VNĐ";
                    uc.tien = tienThapNhat;
                }
                // uc.hinhanh = hinhanh;
                tab_PhuHopNhat.Controls.Add(uc);
                i++;
            }
            int j = 0;
            conn.Close();
            string query1 = "SELECT * FROM ThongTinCanBan inner join ViTri ON ThongTinCanBan.MAKS = ViTri.MAKS WHERE ViTri.Tinh = @diadiem AND ThongTinCanBan.GIA = (SELECT MIN(GIA) FROM ThongTinCanBan)";
            SqlConnection conn1 = Connection_to_SQL.getConnection();
            conn1.Open();
            SqlCommand command1 = new SqlCommand(query1, conn1);
            command1.Parameters.AddWithValue("@diadiem", diadiem);
            SqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                string tenTinh = reader1.GetString(reader1.GetOrdinal("TINH"));
                string tenThanhPho = reader1.GetString(reader1.GetOrdinal("TENTHANHPHO"));
                string tenKhachSan = reader1.GetString(reader1.GetOrdinal("TENKH"));
                UKhungKetQua uc = new UKhungKetQua();
                uc.viTri = j * 148;
                uc.tenViTri = tenThanhPho + ", " + tenTinh;
                uc.tenKhachSan = tenKhachSan;
                int giaColumnIndex = reader1.GetOrdinal("GIA");
                if (!reader1.IsDBNull(giaColumnIndex))
                {
                    int gia = reader1.GetInt32(giaColumnIndex);
                    string tienThapNhat = gia.ToString() + " VNĐ";
                    uc.tien = tienThapNhat;
                }
                tab_GiaThapNhat.Controls.Add(uc);
                j++;
            }
            conn1.Close();
        }
        public int kiemtradangkiKS1;
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
            if (kiemtradangkiKS1 == 2)
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
            fCollections f = new fCollections();
            f.kiemtratrang = 1;
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            ShowDangNhap();
            ShowDangKy();
            HideMenuStrip();
            ShowPanel2();
            panel_menu.Visible = false;
            KT_DangNhap1 = 0;
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btn_TimKiem_Click_1(object sender, EventArgs e)
        {
            for (int i = tab_PhuHopNhat.Controls.Count - 1; i >= 0; i--)
            {
                Control control = tab_PhuHopNhat.Controls[i];
                if (control is UserControl)
                {
                    tab_PhuHopNhat.Controls.RemoveAt(i);
                    control.Dispose(); // Giải phóng bộ nhớ cho UserControl
                }
            }
            diadiem = lb_TimKiem.Text;
            string query = "SELECT * FROM ThongTinTimKiem WHERE TenViTri = @diadiem";
            SqlConnection conn = Connection_to_SQL.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@diadiem", diadiem);
            SqlDataReader reader = command.ExecuteReader();
            int j = 0;
            while (reader.Read())
            {
                string tenViTri = reader.GetString(reader.GetOrdinal("TenViTri"));
                string tenKhachSan = reader.GetString(reader.GetOrdinal("TenKhachSan"));
                UKhungKetQua uc = new UKhungKetQua();
                uc.viTri = j * 148;
                uc.tenViTri = tenViTri;
                uc.tenKhachSan = tenKhachSan;
                tab_PhuHopNhat.Controls.Add(uc);
                j++;
            }
            conn.Close();
        }
    }
}
