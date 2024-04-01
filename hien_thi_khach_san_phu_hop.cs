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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DuLich
{
    public partial class hien_thi_khach_san_phu_hop : Form
    {
        TruyenDuLieu truyen = new TruyenDuLieu();
        int value3;
        int value2;
        int value;
        public int soLuongNguoiLon;
        public int soLuongTreEm;
        public hien_thi_khach_san_phu_hop()
        {
            InitializeComponent();
            trackBar1.Value = 50; // Giá trị mặc định
            trackBar1.Scroll += trackBar1_Scroll;
            trackBar2.Value = 4000000; // Giá trị mặc định
            trackBar2.Scroll += trackBar2_Scroll;
            value = trackBar1.Value;
            lbl_Min.Text = $"{value}";
            value2 = trackBar2.Value;
            value3 = trackBar2.Maximum - value2;
            lbl_max.Text = value3.ToString();


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
            data.Add("Bà Rịa Vũng Tàu");
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
            List<int> maksList = new List<int>();
            string query = "SELECT * FROM ThongTinCanBan inner join ViTri ON ThongTinCanBan.MAKS = ViTri.MAKS WHERE ViTri.TINH = @diadiem";
            SqlConnection conn = Connection_to_SQL.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@diadiem", diadiem);
            SqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                int maColumnIndex = reader.GetOrdinal("MAKS");
                if (!reader.IsDBNull(maColumnIndex))
                {
                    int maKS = reader.GetInt32(maColumnIndex); ;
                    maksList.Add(maKS);

                }
                i++;
            }
            conn.Close();
            int soLuong = soLuongNguoiLon + soLuongTreEm;
            if (soLuong > 0)
            {
                truyen.Truyen(diadiem, "TENKH",soLuong);
                for (int j = 0; j < truyen.soLuong; j++)
                {
                    
                    UKhungKetQua uc = new UKhungKetQua();
                    uc.viTri = j * 148;
                    uc.ShowSoKhach();
                    uc.tenViTri = truyen.tenThanhPho[j] + ", " + truyen.tenTinh[j];
                    uc.soLuong = truyen.soKhach[j];
                    uc.tenKhachSan = truyen.tenKhachSan[j];
                    uc.tien = truyen.soTien[j];
                    uc.anhBia = truyen.address[j];
                    uc.maks = maksList[j];

                    tab_PhuHopNhat.Controls.Add(uc);
                }
                truyen.Truyen(diadiem, "GIA",soLuong);
                for (int j = 0; j < truyen.soLuong; j++)
                {
                    UKhungKetQua uc = new UKhungKetQua();
                    uc.viTri = j * 148;
                    uc.ShowSoKhach();
                    uc.tenViTri = truyen.tenThanhPho[j] + ", " + truyen.tenTinh[j];
                    uc.soLuong = truyen.soKhach[j];
                    uc.tenKhachSan = truyen.tenKhachSan[j];
                    uc.tien = truyen.soTien[j];
                    uc.anhBia = truyen.address[j];
                    uc.maks = maksList[j];
                    tab_GiaThapNhat.Controls.Add(uc);
                }
                truyen.Truyen(diadiem, "SAO", soLuong);
                for (int j = 0; j < truyen.soLuong; j++)
                {
                    
                    UKhungKetQua uc = new UKhungKetQua();
                    uc.viTri = j * 148;
                    uc.ShowSoKhach();
                    uc.tenViTri = truyen.tenThanhPho[j] + ", " + truyen.tenTinh[j];
                    uc.soLuong = truyen.soKhach[j];
                    
                    uc.tenKhachSan = truyen.tenKhachSan[j];
                    uc.tien = truyen.soTien[j];
                    uc.khoangCach = truyen.danhGia[j];
                    uc.anhBia = truyen.address[j];
                    uc.maks = maksList[j];
                    uc.ShowKhoangCach();
                    tab_DanhGiaCao.Controls.Add(uc);
                }
            }
            else
            {
                truyen.Truyen(diadiem, "TENKH", soLuong);
                for (int j = 0; j < truyen.soLuong; j++)
                {
                    UKhungKetQua uc = new UKhungKetQua();
                    uc.viTri = j * 148;
                    uc.tenViTri = truyen.tenThanhPho[j] + ", " + truyen.tenTinh[j];
                    uc.tenKhachSan = truyen.tenKhachSan[j];
                    uc.tien = truyen.soTien[j];
                    uc.anhBia = truyen.address[j];
                    uc.maks = maksList[j];
                    MessageBox.Show(truyen.soKhach[j]);
                    tab_PhuHopNhat.Controls.Add(uc);
                }
                truyen.Truyen(diadiem, "GIA", soLuong);
                for (int j = 0; j < truyen.soLuong; j++)
                {
                    UKhungKetQua uc = new UKhungKetQua();
                    uc.viTri = j * 148;
                    uc.tenViTri = truyen.tenThanhPho[j] + ", " + truyen.tenTinh[j];
                    uc.tenKhachSan = truyen.tenKhachSan[j];
                    uc.tien = truyen.soTien[j];
                    uc.anhBia = truyen.address[j];
                    uc.maks = maksList[j];
                    tab_GiaThapNhat.Controls.Add(uc);
                }
                truyen.Truyen(diadiem, "SAO", soLuong);
                for (int j = 0; j < truyen.soLuong; j++)
                {
                    UKhungKetQua uc = new UKhungKetQua();
                    uc.viTri = j * 148;
                    uc.tenViTri = truyen.tenThanhPho[j] + ", " + truyen.tenTinh[j];
                    uc.tenKhachSan = truyen.tenKhachSan[j];
                    uc.tien = truyen.soTien[j];
                    uc.khoangCach = truyen.danhGia[j];
                    uc.anhBia = truyen.address[j];
                    uc.maks = maksList[j];
                    uc.ShowKhoangCach();
                    tab_DanhGiaCao.Controls.Add(uc);
                }
            }
            

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

        public string diaDiem2;
        private void btn_TimKiem_Click_1(object sender, EventArgs e)
        {

            if (lb_TimKiem.Text != "")
            {
                diadiem = lb_TimKiem.Text;
            }
            for (int j = tab_PhuHopNhat.Controls.Count - 1; j >= 0; j--)
            {
                Control control = tab_PhuHopNhat.Controls[j];
                if (control is UserControl)
                {
                    tab_PhuHopNhat.Controls.RemoveAt(j);
                    control.Dispose();
                }
            }

            int min = trackBar1.Value;
            int max = trackBar2.Maximum - trackBar2.Value;
            truyen.Truyen2(diadiem, min, max);
            for (int j = 0; j < truyen.soLuong; j++)
            {
                UKhungKetQua uc = new UKhungKetQua();
                uc.viTri = j * 148;
                uc.tenViTri = truyen.tenThanhPho[j] + ", " + truyen.tenTinh[j];
                uc.tenKhachSan = truyen.tenKhachSan[j];
                uc.tien = truyen.soTien[j];
                uc.anhBia = truyen.address[j];
                tab_PhuHopNhat.Controls.Add(uc);
            }
            // khi có chọn tiện ích
            if (clBox_TienNghiChinh.SelectedIndex != -1 || clBox_TienNghiCC.SelectedIndex != -1 || clBox_DichVu.SelectedIndex != -1 || clBox_AmThuc.SelectedIndex != -1)
            {
                List<int> maksList = new List<int>();
                string query = "SELECT * FROM ViTri WHERE Tinh = @diadiem";
                SqlConnection conn = Connection_to_SQL.getConnection();
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@diadiem", diadiem);
                SqlDataReader reader = command.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    int maColumnIndex = reader.GetOrdinal("MAKS");
                    if (!reader.IsDBNull(maColumnIndex))
                    {
                        int maKS = reader.GetInt32(maColumnIndex); ; // Lấy giá trị MAKS từ cột đầu tiên (0-indexed)
                        maksList.Add(maKS);

                    }
                    i++;
                }
                conn.Close();
                List<int> soLuong = new List<int>();
                foreach (int maks in maksList)
                {
                    int demTrung = 0;
                    demTrung = thucHienDemTrung(maks, demTrung);
                    soLuong.Add(demTrung);
                }
                for (int j = 0; j < soLuong.Count - 1; j++)
                {
                    for (int k = j + 1; k < soLuong.Count; k++)
                    {
                        if (soLuong[j] < soLuong[k])
                        {
                            int t = (int)soLuong[j];
                            soLuong[j] = soLuong[k];
                            soLuong[k] = t;
                            int t1 = (int)maksList[j];
                            maksList[j] = maksList[k];
                            maksList[k] = t1;
                        }

                    }
                }
                int soLuong1 = 0;
                string[] tenTinh = new string[100];
                string[] tenThanhPho = new string[100];
                string[] tenKhachSan = new string[100];
                string[] soTien = new string[100];
                string[] anhBia = new string[100];
                for (int maks = 0; maks < maksList.Count; maks++)
                {
                    string query1 = string.Format("SELECT * FROM ThongTinCanBan inner join ViTri ON ThongTinCanBan.MAKS = ViTri.MAKS WHERE ViTri.MAKS = {0}", maksList[maks]);
                    SqlConnection conn1 = Connection_to_SQL.getConnection();
                    conn1.Open();
                    SqlCommand command1 = new SqlCommand(query1, conn1);
                    SqlDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        tenTinh[soLuong1] = reader1.GetString(reader1.GetOrdinal("TINH"));
                        tenThanhPho[soLuong1] = reader1.GetString(reader1.GetOrdinal("TENTHANHPHO"));
                        tenKhachSan[soLuong1] = reader1.GetString(reader1.GetOrdinal("TENKH"));
                        anhBia[soLuong1] = reader1.GetString(reader1.GetOrdinal("AnhBia"));
                        //maKS[i] = reader.GetString(reader.GetOrdinal("TK"));
                        //byte[] hinhanh = (byte[])reader["HinhAnh"];    
                        int giaColumnIndex = reader1.GetOrdinal("GIA");
                        if (!reader1.IsDBNull(giaColumnIndex))
                        {
                            double gia = reader1.GetDouble(giaColumnIndex);
                            soTien[soLuong1] = gia.ToString() + " VNĐ";
                        }
                        soLuong1++;
                    }

                }
                for (int j = tab_PhuHopNhat.Controls.Count - 1; j >= 0; j--)
                {
                    Control control = tab_PhuHopNhat.Controls[j];
                    if (control is UserControl)
                    {
                        tab_PhuHopNhat.Controls.RemoveAt(j);
                        control.Dispose(); // Giải phóng bộ nhớ cho UserControl
                    }
                }
                for (int j = 0; j < soLuong1; j++)
                {
                    UKhungKetQua uc = new UKhungKetQua();
                    uc.viTri = j * 148;
                    uc.tenViTri = tenThanhPho[j] + ", " + tenTinh[j];
                    uc.tenKhachSan = tenKhachSan[j];
                    uc.tien = soTien[j];
                    uc.anhBia = truyen.address[j];
                    tab_PhuHopNhat.Controls.Add(uc);
                }
            }
        }
        public int thucHienDemTrung(int maks, int demTrung)
        {
            TruyenDuLieuTienNghi tiennghi = new TruyenDuLieuTienNghi();
            tiennghi.thucHienTruyen(maks);
            foreach (string selectedFeature in clBox_TienNghiChinh.CheckedItems)
            {
                if (selectedFeature == tiennghi.mayLanhSelected)
                {
                    demTrung++;
                }
                else if (selectedFeature == tiennghi.nhaHangSelected)
                {
                    demTrung++;
                }
                else if (selectedFeature == tiennghi.hoBoiSelected)
                {
                    demTrung++;
                }
                else if (selectedFeature == tiennghi.leTan24hSelected)
                {
                    demTrung++;
                }
                else if (selectedFeature == tiennghi.WifiSelected)
                {
                    demTrung++;
                }
            }
            foreach (string selectedFeature in clBox_DichVu.CheckedItems)
            {
                if (selectedFeature == tiennghi.quayLeTanSelected)
                {
                    demTrung++;
                }
                else if (selectedFeature == tiennghi.dichVuThuDoiNgoaiTeSelected)
                {
                    demTrung++;
                }
                else if (selectedFeature == tiennghi.dichVuTiecCuoiSelected)
                {
                    demTrung++;
                }
                else if (selectedFeature == tiennghi.dichVuHoTroDatTourSelected)
                {
                    demTrung++;
                }
                else if (selectedFeature == tiennghi.nhanVienDaNgonNguSelected)
                {
                    demTrung++;
                }
            }
            foreach (string selectedFeature in clBox_TienNghiCC.CheckedItems)
            {
                if (selectedFeature == tiennghi.baiDauXeSelected)
                {
                    demTrung++;
                }
                else if (selectedFeature == tiennghi.tiemCaFeSelected)
                {
                    demTrung++;
                }
                else if (selectedFeature == tiennghi.thangMaySelected)
                {
                    demTrung++;
                }
            }
            foreach (string selectedFeature in clBox_AmThuc.CheckedItems)
            {
                if (selectedFeature == tiennghi.quayBarSelected)
                {
                    demTrung++;
                }
                else if (selectedFeature == tiennghi.buaSangSelected)
                {
                    demTrung++;
                }
                else if (selectedFeature == tiennghi.quayBarBenHoBoiSelected)
                {
                    demTrung++;
                }
            }
            return demTrung;
        }
        int demTab = 0;
        private void tabKhoangCach_Click(object sender, EventArgs e)
        {


        }

        private void tabKhoangCach_Move(object sender, EventArgs e)
        {
            if (demTab % 2 == 0)
            {
                panel_KhoangCach.Visible = true;
            }
            else
            {
                panel_KhoangCach.Visible = false;
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage selectedTabPage = tabControl1.SelectedTab;

            if (selectedTabPage == tabKhoangCach)
            {
                panel_KhoangCach.Visible = true;
            }
            else
            {
                panel_KhoangCach.Visible = false;
            }

        }

        private void btn_ThanhPho_Click(object sender, EventArgs e)
        {
            for (int k = tabKhoangCach.Controls.Count - 1; k >= 0; k--)
            {
                Control control = tabKhoangCach.Controls[k];
                if (control is UserControl)
                {
                    tabKhoangCach.Controls.RemoveAt(k);
                    control.Dispose(); // Giải phóng bộ nhớ cho UserControl
                }
            }
            int soLuong = soLuongNguoiLon + soLuongTreEm;
            truyen.Truyen(diadiem, "KCTHANHPHO",soLuong);
            for (int j = 0; j < truyen.soLuong; j++)
            {
                UKhungKetQua uc = new UKhungKetQua();
                uc.viTri = j * 148;
                uc.tenViTri = truyen.tenThanhPho[j] + ", " + truyen.tenTinh[j];
                uc.tenKhachSan = truyen.tenKhachSan[j];
                uc.khoangCach = truyen.khoangCachTP[j] + " km đến trung tâm";
                uc.tien = truyen.soTien[j];
                uc.anhBia = truyen.address[j];
                uc.ShowKhoangCach();
                panel_KhoangCach.Visible = false;
                tabKhoangCach.Controls.Add(uc);
            }
        }

        private void btn_SanBay_Click(object sender, EventArgs e)
        {
            int soLuong = soLuongNguoiLon + soLuongTreEm;
            for (int k = tabKhoangCach.Controls.Count - 1; k >= 0; k--)
            {
                Control control = tabKhoangCach.Controls[k];
                if (control is UserControl)
                {
                    tabKhoangCach.Controls.RemoveAt(k);
                    control.Dispose(); // Giải phóng bộ nhớ cho UserControl
                }
            }
            truyen.Truyen(diadiem, "KCSANBAY", soLuong);
            for (int j = 0; j < truyen.soLuong; j++)
            {
                UKhungKetQua uc = new UKhungKetQua();
                uc.viTri = j * 148;
                uc.tenViTri = truyen.tenThanhPho[j] + ", " + truyen.tenTinh[j];
                uc.tenKhachSan = truyen.tenKhachSan[j];
                uc.khoangCach = truyen.khoangCachSanBay[j] + " km đến sân bay gần nhất";
                uc.tien = truyen.soTien[j];
                uc.anhBia = truyen.address[j];
                uc.ShowKhoangCach();
                panel_KhoangCach.Visible = false;
                tabKhoangCach.Controls.Add(uc);
            }
        }

        private void lb_TimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
