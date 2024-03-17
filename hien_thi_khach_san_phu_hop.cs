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
            string query = "SELECT * FROM ThongTinTimKiem WHERE TenViTri = @diadiem";
            SqlConnection conn = Connection_to_SQL.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@diadiem", diadiem);
            command.CommandTimeout = 120;
            SqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                string tenViTri = reader.GetString(reader.GetOrdinal("TenViTri"));
                string tenKhachSan = reader.GetString(reader.GetOrdinal("TenKhachSan"));
                byte[] hinhanh = (byte[])reader["HinhAnh"];
                UKhungKetQua uc = new UKhungKetQua();
                uc.viTri = i * 148;
                uc.tenViTri = tenViTri;
                uc.tenKhachSan = tenKhachSan;
                uc.hinhanh = hinhanh;
                tab_PhuHopNhat.Controls.Add(uc);
                i++;
            }
            conn.Close();
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
