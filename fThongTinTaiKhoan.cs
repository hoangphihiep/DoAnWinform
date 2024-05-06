using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuLich
{
    public partial class fThongTinTaiKhoan : Form
    {
        public string tentk;
        public string mk;
        // Khai báo danh sách để lưu các Mã phòng
        public List<int> maPhongList = new List<int>();
        public int index = 0;
        public fThongTinTaiKhoan()
        {
            InitializeComponent();
        }
        public int maks;

        private void fThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            uPhong3.Size = new Size(1221, 620);
            uThongtin2.tentk = tentk;
            uThongtin2.mk = mk;
            uThongTinKhachSan1.SetTenTK(tentk);
            uThongtin1.tentk = tentk;
            uViTri1.SetTenTK(tentk);
            uHoSo1.SetTenTK(tentk);
            uMatKhau1.tentk = tentk;
            uUuDai1.tentk = tentk;
            uAnh1.tk = tentk;
            uAnh2.SetTenTK(tentk);
            uTienNghi1.SetTenTK(tentk);
            Modify modify = new Modify();
            string query = "Select * from KHACHSAN_THUOC_TAIKHOAN where TaiKhoan = '" + tentk + "' ";
            var result = modify.KhachSanThuocTaiKhoan(query);
            if (result.Count() > 0)
            {
                btn_ThongTinKhachSan.Visible = true;
                btn_ThongTinKhachSan.Visible = true;
                uUuDai1.SetTenTK(tentk);
            }
            using (SqlConnection connection = new SqlConnection(Connection_to_SQL.getConnnection()))
            {
                connection.Open();
                string query1 = "SELECT DISTINCT QLPHONG.MAPHONG " +
                               "FROM QLPHONG " +
                               "JOIN ThongTinCanBan ON QLPHONG.MAKS = ThongTinCanBan.MAKS " +
                               "WHERE ThongTinCanBan.TK = @TaiKhoan";
                using (SqlCommand command = new SqlCommand(query1, connection))
                {
                    command.Parameters.AddWithValue("@TaiKhoan", tentk);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int maPhong = reader.GetInt32(0);
                            maPhongList.Add(maPhong);
                        }
                    }
                }
            }
        }
        public void ShowQLHuy()
        {
            panel6.Visible = true;
            btn_QuanLyHuy.Visible = true;
        }
        public void HideQLHuy()
        {
            panel6.Visible = false;
            uPhong3.Ktr(index, maPhongList);
            uPhong3.HienThi(index, maPhongList);
            btn_QuanLyHuy.Visible = false;
        }
        public void ShowThongTinCanBan()
        {
            btn_ThongTingKS.Visible = true;
        }
        public void ShowViTri()
        {
            btn_ViTri.Visible = true;
        }
        public void ShowChiTietPhong()
        {
            btn_ChiTietPhong.Visible = true;
        }
        public void ShowAnh()
        {
            btn_Anh.Visible = true;
        }
        public void ShowHoSo()
        {
            btn_HoSo.Visible = true;
        }
        public void HideThongTinCanBan()
        {
            btn_ThongTingKS.Visible = false;
        }
        public void HideViTri()
        {
            btn_ViTri.Visible = false;
        }
        public void HideChiTietPhong()
        {
            btn_ChiTietPhong.Visible = false;
        }
        public void HideAnh()
        {
            btn_Anh.Visible = false;
        }
        public void HideHoSo()
        {
            btn_HoSo.Visible = false;
        }
        public void ShowThongTinKS()
        {
            btn_ThongTinKhachSan.Visible = true;
        }
        public void ShowUDai()
        {
            btn_UDai.Visible = true;
        }
        public void HideUDai()
        {
            btn_UDai.Visible = false;
        }
        public void HideTienNghi()
        {
            btn_TienNghi.Visible = false;
        }
        public void ShowTienNghi()
        {
            btn_TienNghi.Visible = true;
        }
        private void btn_ThongTin_Click(object sender, EventArgs e)
        {
            uThongtin2.BringToFront();
            flP_QuanLyHuy.Visible = false;
            flP_QuanLyHuy.SendToBack();
        }

        private void btn_MatKhau_Click(object sender, EventArgs e)
        {
            uMatKhau1.BringToFront();
            flP_QuanLyHuy.Visible = false;
            flP_QuanLyHuy.SendToBack();
        }

        private void btn_ThongTingKS_Click(object sender, EventArgs e)
        {
            uThongTinKhachSan1.BringToFront();
            flP_QuanLyHuy.Visible = false;
            flP_QuanLyHuy.SendToBack();
        }

        private void btn_ViTri_Click(object sender, EventArgs e)
        {
            uViTri1.BringToFront();
            flP_QuanLyHuy.Visible = false;
            flP_QuanLyHuy.SendToBack();
        }

        private void btn_ChiTietPhong_Click(object sender, EventArgs e)
        {
            uPhong2.BringToFront();
            flP_QuanLyHuy.Visible = false;
            flP_QuanLyHuy.SendToBack();
            uPhong3.BringToFront();
        }

        private void btn_Anh_Click(object sender, EventArgs e)
        {
            uAnh2.BringToFront();
            flP_QuanLyHuy.Visible = false;
            flP_QuanLyHuy.SendToBack();
        }

        private void btn_HoSo_Click(object sender, EventArgs e)
        {
            uHoSo1.BringToFront();
            flP_QuanLyHuy.Visible = false;
            flP_QuanLyHuy.SendToBack();
        }
        int dem = 0;
        private void btn_ThongTinKhachSan_Click(object sender, EventArgs e)
        {
            if (dem % 2 == 0)
            {
                ShowThongTinCanBan();
                ShowViTri();
                ShowChiTietPhong();
                ShowAnh();
                ShowHoSo();
                ShowUDai();
                ShowTienNghi();
                ShowQLHuy();
                dem++;
            }
            else
            {
                HideThongTinCanBan();
                HideViTri();
                HideChiTietPhong();
                HideAnh();
                HideHoSo();
                HideUDai();
                HideTienNghi();
                HideQLHuy();
                dem++;
            }
        }

        private void uThongtin2_Load(object sender, EventArgs e)
        {

        }

        private void btn_TienNghi_Click(object sender, EventArgs e)
        {
            uTienNghi1.BringToFront();
            flP_QuanLyHuy.Visible = false;
            flP_QuanLyHuy.SendToBack();
        }

        private void btn_UDai_Click(object sender, EventArgs e)
        {
            uUuDai1.BringToFront();
            flP_QuanLyHuy.Visible = false;
            flP_QuanLyHuy.SendToBack();
        }

        private void btn_QuanLyHuy_Click(object sender, EventArgs e)
        {
            flP_QuanLyHuy.BringToFront();
            flP_QuanLyHuy.Visible = true;
            List<DatPhong> listPhongDat = new List<DatPhong>();
            using (SqlConnection connection = new SqlConnection(Connection_to_SQL.getConnnection()))
            {
                connection.Open();
                string query1 = "SELECT DATPHONG.MADAT as madatphong, KHACHHANG.MAKH as makh,PHONG.MAPHONG as maphong,ThongTinCanBan.TENKH as tenKS, PHONG.TENPHONG as tenphong, DATPHONG.CHECKIN as ngayDen, DATPHONG.CHECKOUT as ngayDi, KHACHHANG.TENKH as tenKH, DATPHONG.SOLUONG as soPhong, DATPHONG.THANHTOAN as tienTT, PHONG.ANH as anhPhong FROM DATPHONG, HUYPHONG, KHACHSAN_THUOC_TAIKHOAN, ThongTinCanBan,PHONG,KHACHHANG WHERE ThongTinCanBan.MAKS = KHACHSAN_THUOC_TAIKHOAN.MAKS AND DATPHONG.MADAT = HUYPHONG.MADAT AND DATPHONG.MAKS = KHACHSAN_THUOC_TAIKHOAN.MAKS AND DATPHONG.MAPHONG = PHONG.MAPHONG AND DATPHONG.MAKH = KHACHHANG.MAKH AND KHACHSAN_THUOC_TAIKHOAN.TaiKhoan = @tk";
                using (SqlCommand command = new SqlCommand(query1, connection))
                {
                    command.Parameters.AddWithValue("@tk", tentk);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int maDatPhong = reader.GetInt32(reader.GetOrdinal("madatphong"));
                            int makhachhang = reader.GetInt32(reader.GetOrdinal("makh"));
                            int maPhong = reader.GetInt32(reader.GetOrdinal("maphong"));
                            string TENKS = reader.GetString(reader.GetOrdinal("tenKS"));
                            MessageBox.Show(TENKS.ToString());
                            string TENPHONG = reader.GetString(reader.GetOrdinal("tenphong"));
                            DateTime ngayDen = reader.GetDateTime("ngayDen");
                            DateTime ngayDi = reader.GetDateTime("ngayDi");
                            string tenKH = reader.GetString(reader.GetOrdinal("tenKH"));
                            int soLuongPhong = reader.GetInt32(reader.GetOrdinal("soPhong"));
                            double tongThanhToan = reader.GetDouble(reader.GetOrdinal("tienTT"));
                            MessageBox.Show(tongThanhToan.ToString());
                            string anhPhong = reader.GetString(reader.GetOrdinal("anhPhong"));
                            DatPhong dp = new DatPhong(maDatPhong, makhachhang, maPhong, TENKS, TENPHONG, tenKH, ngayDen, ngayDi, soLuongPhong, tongThanhToan, anhPhong);
                            //listPhongDat.Add(dp);z
                            UCHuyphongCKS uc = new UCHuyphongCKS(dp);
                            flP_QuanLyHuy.Controls.Add(uc);
                        }
                    }
                }
            }
        }

        private void uChiTietPhongo1_Load(object sender, EventArgs e)
        {

        }

        private void flP_QuanLyHuy_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
