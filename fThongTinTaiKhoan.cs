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
                uUuDai1.SetTenTK(tentk); // Gán giá trị tentk vào UserControl UUuDai
            }
            // Tạo kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(Connection_to_SQL.getConnnection()))
            {
                // Mở kết nối
                connection.Open();

                // Chuỗi truy vấn SQL để lấy Mã phòng từ Tài khoản (TK)
                string query1 = "SELECT DISTINCT QLPHONG.MAPHONG " +
                               "FROM QLPHONG " +
                               "JOIN ThongTinCanBan ON QLPHONG.MAKS = ThongTinCanBan.MAKS " +
                               "WHERE ThongTinCanBan.TK = @TaiKhoan";

                // Tạo và thiết lập đối tượng SqlCommand
                using (SqlCommand command = new SqlCommand(query1, connection))
                {
                    // Thêm tham số cho truy vấn để tránh tình trạng SQL injection
                    command.Parameters.AddWithValue("@TaiKhoan", tentk);

                    // Thực thi truy vấn và đọc dữ liệu
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Đọc từng hàng dữ liệu và thêm Mã phòng vào danh sách
                        while (reader.Read())
                        {
                            int maPhong = reader.GetInt32(0);
                            maPhongList.Add(maPhong);
                        }
                    }
                }
            }
            //uPhong2.Ktr(index, maPhongList);
            //uPhong2.HienThi(index, maPhongList);
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
                string query1 = "SELECT PHONG.GIA as giaPhong,PHONG.SOGIUONG as soGiuong,DATPHONG.SOLUONG as soLK,ViTri.DIACHI as diaChiKS,ThongTinCanBan.GIA as giaKS,ThongTinCanBan.SAO as saoKS,ViTri.TENTHANHPHO as thanhphoks,ViTri.TINH as tinhks,ThongTinCanBan.MAKS as maks, KHACHHANG.DIACHI as DiaChiKH,KHACHHANG.GMAIL as gmail,KHACHHANG.GIOITINH as gTinh,KHACHHANG.BDATE as ngaySinh,KHACHHANG.SDT as soDT, DATPHONG.MADAT as madatphong, KHACHHANG.MAKH as makh,PHONG.MAPHONG as maphong,ThongTinCanBan.TENKH as tenKS, PHONG.TENPHONG as tenphong, DATPHONG.CHECKIN as ngayDen, DATPHONG.CHECKOUT as ngayDi, KHACHHANG.TENKH as tenKH, DATPHONG.SOLUONG as soPhong, DATPHONG.THANHTOAN as tienTT, PHONG.ANH as anhPhong FROM DATPHONG, HUYPHONG, KHACHSAN_THUOC_TAIKHOAN, ThongTinCanBan,PHONG,KHACHHANG,ViTri WHERE ThongTinCanBan.MAKS = ViTri.MAKS AND ThongTinCanBan.MAKS = KHACHSAN_THUOC_TAIKHOAN.MAKS AND DATPHONG.MADAT = HUYPHONG.MADAT AND DATPHONG.MAKS = KHACHSAN_THUOC_TAIKHOAN.MAKS AND DATPHONG.MAPHONG = PHONG.MAPHONG AND DATPHONG.MAKH = KHACHHANG.MAKH AND KHACHSAN_THUOC_TAIKHOAN.TaiKhoan = @tk";
                using (SqlCommand command = new SqlCommand(query1, connection))
                {
                    command.Parameters.AddWithValue("@tk", tentk);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //khách hàng
                            int makhachhang = reader.GetInt32(reader.GetOrdinal("makh"));
                            string tenKH = reader.GetString(reader.GetOrdinal("tenKH"));
                            int soDienThoaiInt = reader.GetInt32(reader.GetOrdinal("soDT"));
                            string soDienThoai = soDienThoaiInt.ToString();
                            string gioiTinh = reader.GetString(reader.GetOrdinal("gTinh"));
                            DateTime ngaySinh = reader.GetDateTime("ngaySinh");
                            string gmail = reader.GetString(reader.GetOrdinal("gmail"));
                            string diaChiKH = reader.GetString(reader.GetOrdinal("DiaChiKH"));
                            //khách sạn
                            int makhachsan = reader.GetInt32(reader.GetOrdinal("maks"));
                            string TENKS = reader.GetString(reader.GetOrdinal("tenKS"));
                            string tinhKS = reader.GetString(reader.GetOrdinal("tinhks"));
                            string thanhphoks = reader.GetString(reader.GetOrdinal("thanhphoks"));
                            int sao = reader.GetInt32(reader.GetOrdinal("saoKS"));
                            double giaKS = reader.GetDouble(reader.GetOrdinal("giaKS"));
                            string diaChiKS = reader.GetString(reader.GetOrdinal("diaChiKS"));
                            //phong
                            int maPhong = reader.GetInt32(reader.GetOrdinal("maphong"));
                            string TENPHONG = reader.GetString(reader.GetOrdinal("tenphong"));
                            MessageBox.Show(TENPHONG);
                            int soLuongPhong = reader.GetInt32(reader.GetOrdinal("soPhong"));
                            string anhPhong = reader.GetString(reader.GetOrdinal("anhPhong"));
                            int soLuongKhach = reader.GetInt32(reader.GetOrdinal("soLK"));
                            int soGiuong = reader.GetInt32(reader.GetOrdinal("soGiuong"));
                            double giaPhong = reader.GetDouble(reader.GetOrdinal("giaPhong"));
                            //đặt phòng
                            int maDatPhong = reader.GetInt32(reader.GetOrdinal("madatphong")); 
                            DateTime ngayDen = reader.GetDateTime("ngayDen");
                            DateTime ngayDi = reader.GetDateTime("ngayDi");                                                 
                            double tongThanhToan = reader.GetDouble(reader.GetOrdinal("tienTT"));
                            KhachHang kh = new KhachHang(makhachhang,tenKH,soDienThoai,gioiTinh,ngaySinh,gmail,diaChiKH);
                            KHACHSAN ks = new KHACHSAN(makhachsan,TENKS,tinhKS, thanhphoks,sao,giaKS,diaChiKS);
                            Room phong = new Room(soLuongKhach, soGiuong, giaPhong,TENPHONG, maPhong, anhPhong);
                            
                            DatPhong dp = new DatPhong(maDatPhong, kh, ks, phong, ngayDen, ngayDi, soLuongPhong, tongThanhToan, "Đã thanh toán", "111111");
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
