using DoAnDuLich;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DuLich
{
    public partial class hien_thi_khach_san_phu_hop : Form
    {
        TruyenDuLieu truyen = new TruyenDuLieu();
        int value3;
        int value2;
        int value;
        public string tenKhachHang;
        public string tentk;
        public string mk;
        public int soLuongNguoiLon;
        public DateTime ngayDen;
        public DateTime ngayDi;
        public KhachHang kh;
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
            f.diadiem = diadiem;
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
            //MessageBox.Show(tentk);
            btn_MyTaiKhoan.Text = tenKhachHang;
            btn_DangNhap.FlatStyle = FlatStyle.Flat;
            btn_DangNhap.FlatAppearance.BorderSize = 0;
            btn_DangKy.FlatStyle = FlatStyle.Flat;
            btn_DangKy.FlatAppearance.BorderSize = 0;
            btn_DangKyKS.FlatStyle = FlatStyle.Flat;
            btn_DangKyKS.FlatAppearance.BorderSize = 0;
            btn_MyTaiKhoan.FlatStyle = FlatStyle.Flat;
            btn_MyTaiKhoan.FlatAppearance.BorderSize = 0;
            int soLuong = soLuongNguoiLon;
            List<KHACHSAN> listKS = new List<KHACHSAN>();
            truyen.Truyen(diadiem, "TENKH", soLuong, listKS, ngayDen, ngayDi);
            foreach (KHACHSAN i in listKS)
            {

                UKhungKetQua uc = new UKhungKetQua(i);
                uc.tenTaiKhoan = tentk;
                uc.ShowSoKhach();
                flb_PhuHopNhat.Controls.Add(uc);
            }
            listKS.Clear();
            truyen.Truyen(diadiem, "GIA", soLuong, listKS, ngayDen, ngayDi);
            foreach (KHACHSAN i in listKS)
            {
                UKhungKetQua uc = new UKhungKetQua(i);
                uc.tenTaiKhoan = tentk;
                flb_GiaThapNhat.Controls.Add(uc);
            }
            listKS.Clear();
            truyen.Truyen(diadiem, "SAO", soLuong, listKS, ngayDen, ngayDi);
            foreach (KHACHSAN i in listKS)
            {
                UKhungKetQua uc = new UKhungKetQua(i);
                uc.tenTaiKhoan = tentk;
                uc.ShowdanhGia();
                flb_danhGiaCao.Controls.Add(uc);
            }
            listKS.Clear();
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
            t.tentk = tentk;
            t.mk = mk;
            if (kiemtradangkiKS1 == 1)
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
            if (date_ngayDen.Value != DateTime.Now && date_ngayDi.Value != DateTime.Now)
            {
                ngayDen = date_ngayDen.Value;
                ngayDi = date_ngayDi.Value;
            }
            List<KHACHSAN> listKS = new List<KHACHSAN>();
            for (int j = flb_PhuHopNhat.Controls.Count - 1; j >= 0; j--)
            {
                Control control = flb_PhuHopNhat.Controls[j];
                if (control is UserControl)
                {
                    flb_PhuHopNhat.Controls.RemoveAt(j);
                    control.Dispose();
                }
            }
            int min = trackBar1.Value;
            int max = trackBar2.Maximum - trackBar2.Value;
            int soNguoiLon = int.Parse(nUD_nguoiLon.Value.ToString());
            int soLuong2 = soNguoiLon;
            if (soLuong2 == 0)
            {
                soLuong2 = soLuongNguoiLon;
            }
            truyen.Truyen2(diadiem, min, max, soLuong2, listKS, ngayDen, ngayDi);
            foreach (KHACHSAN i in listKS)
            {
                UKhungKetQua uc = new UKhungKetQua(i);
                uc.tenTaiKhoan = tentk;
                uc.ShowSoKhach();
                flb_PhuHopNhat.Controls.Add(uc);
            }
            listKS.Clear();
            if (lb_TimKiem.Text != "")
            {
                diadiem = lb_TimKiem.Text;
                for (int j = flb_PhuHopNhat.Controls.Count - 1; j >= 0; j--)
                {
                    Control control = flb_PhuHopNhat.Controls[j];
                    if (control is UserControl)
                    {
                        flb_PhuHopNhat.Controls.RemoveAt(j);
                        control.Dispose();
                    }
                }
                truyen.Truyen(diadiem, "TENKH", soLuong2, listKS, ngayDen, ngayDi);
                foreach (KHACHSAN i in listKS)
                {
                    UKhungKetQua uc = new UKhungKetQua(i);
                    uc.tenTaiKhoan = tentk;
                    uc.ShowSoKhach();
                    flb_PhuHopNhat.Controls.Add(uc);
                }
                listKS.Clear();
                truyen.Truyen(diadiem, "GIA", soLuong2, listKS, ngayDen, ngayDi);
                foreach (KHACHSAN i in listKS)
                {
                    UKhungKetQua uc = new UKhungKetQua(i);
                    uc.tenTaiKhoan = tentk;
                    flb_GiaThapNhat.Controls.Add(uc);
                }
                listKS.Clear();
                truyen.Truyen(diadiem, "SAO", soLuong2, listKS, ngayDen, ngayDi);
                foreach (KHACHSAN i in listKS)
                {
                    UKhungKetQua uc = new UKhungKetQua(i);
                    uc.tenTaiKhoan = tentk;
                    uc.ShowdanhGia();
                    flb_danhGiaCao.Controls.Add(uc);
                }
                listKS.Clear();
                lb_TimKiem.Clear();
            }
            // khi có chọn tiện ích
            if (clBox_TienNghiChinh.SelectedIndex != -1 || clBox_TienNghiCC.SelectedIndex != -1 || clBox_DichVu.SelectedIndex != -1 || clBox_AmThuc.SelectedIndex != -1)
            {
                for (int j = flb_PhuHopNhat.Controls.Count - 1; j >= 0; j--)
                {
                    Control control = flb_PhuHopNhat.Controls[j];
                    if (control is UserControl)
                    {
                        flb_PhuHopNhat.Controls.RemoveAt(j);

                        control.Dispose();
                    }
                }
                List<int> maksList = new List<int>();
                truyen.Truyen2(diadiem, min, max, soLuong2, listKS, ngayDen, ngayDi);
                foreach (KHACHSAN i in listKS)
                {
                    maksList.Add(i.Maks);

                }
                listKS.Clear();
                List<int> soLuong = new List<int>();
                foreach (int maks in maksList)
                {
                    int demTrung = 0;
                    demTrung = thucHienDemTrung(maks, demTrung);
                    soLuong.Add(demTrung);
                    MessageBox.Show("maks: " + maks.ToString() + "soLuongTrung: " + demTrung.ToString());
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
                truyen.layDuLieuTienNghi(diadiem, soLuong2, min, max, listKS, ngayDen, ngayDi, maksList);
                foreach (KHACHSAN i in listKS)
                {
                    UKhungKetQua uc = new UKhungKetQua(i);
                    uc.tenTaiKhoan = tentk;
                    uc.ShowSoKhach();
                    flb_PhuHopNhat.Controls.Add(uc);
                }
                listKS.Clear();
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
            demTab++;
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
            panel_KhoangCach.Visible = false;
            List<KHACHSAN> listKS = new List<KHACHSAN>();
            for (int k = flp_KhoangCach.Controls.Count - 1; k >= 0; k--)
            {
                Control control = flp_KhoangCach.Controls[k];
                if (control is UserControl)
                {
                    flp_KhoangCach.Controls.RemoveAt(k);
                    control.Dispose(); // Giải phóng bộ nhớ cho UserControl
                }
            }
            int soLuong = soLuongNguoiLon;
            truyen.Truyen(diadiem, "KCTHANHPHO", soLuong, listKS, ngayDen, ngayDi);
            foreach (KHACHSAN i in listKS)
            {
                UKhungKetQua uc = new UKhungKetQua(i);
                uc.tenTaiKhoan = tentk;
                uc.ShowKhoangCachTP();
                flp_KhoangCach.Controls.Add(uc);
            }
            listKS.Clear();
        }

        private void btn_SanBay_Click(object sender, EventArgs e)
        {
            panel_KhoangCach.Visible = false;
            List<KHACHSAN> listKS = new List<KHACHSAN>();
            int soLuong = soLuongNguoiLon;
            for (int k = flp_KhoangCach.Controls.Count - 1; k >= 0; k--)
            {
                Control control = flp_KhoangCach.Controls[k];
                if (control is UserControl)
                {
                    flp_KhoangCach.Controls.RemoveAt(k);
                    control.Dispose(); // Giải phóng bộ nhớ cho UserControl
                }
            }
            truyen.Truyen(diadiem, "KCSANBAY", soLuong, listKS, ngayDen, ngayDi);
            foreach (KHACHSAN i in listKS)
            {
                UKhungKetQua uc = new UKhungKetQua(i);
                uc.tenTaiKhoan = tentk;
                uc.ShowKhoangCachSB();
                flp_KhoangCach.Controls.Add(uc);
            }
            listKS.Clear();
        }

        private void lb_TimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_menuTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void panel_KhoangCach_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}