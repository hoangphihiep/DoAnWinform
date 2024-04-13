using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class Modify
    {
        public Modify() { }
        SqlCommand cmd;
        SqlDataReader data;
        public List<Account> accounts(string table)
        {
            List<Account> accounts = new List<Account>();
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                cmd = new SqlCommand(table, conn);
                data = cmd.ExecuteReader();
                while (data.Read())
                {
                    accounts.Add(new Account(data.GetString(0), data.GetString(1), data.GetString(2), data.GetString(3), data.GetDateTime(4), data.GetString(5), data.GetString(6), data.GetString(7)));
                }
                conn.Close();
            }
            return accounts;
        }
        public List<KhachSanThuocTaiKhoan> KHACHSAN_THUOC_TAIKHOAN(string table)
        {
            List<KhachSanThuocTaiKhoan> accounts = new List<KhachSanThuocTaiKhoan>();
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                cmd = new SqlCommand(table, conn);
                data = cmd.ExecuteReader();
                while (data.Read())
                {
                    accounts.Add(new KhachSanThuocTaiKhoan(data.GetString(0), data.GetInt32(1)));
                }
                conn.Close();
            }
            return accounts;
        }
        public List<HoSo> HoSo(string table)
        {
            List<HoSo> accounts = new List<HoSo>();
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                cmd = new SqlCommand(table, conn);
                data = cmd.ExecuteReader();
                while (data.Read())
                {
                    // Đọc giá trị từ cột 8 và 9 dưới dạng kiểu boolean
                    bool theDienTu = data.GetBoolean(8);
                    bool nganHang = data.GetBoolean(9);

                    // Chuyển đổi giá trị boolean sang số nguyên 0 hoặc 1
                    int theDienTuInt = theDienTu ? 1 : 0;
                    int nganHangInt = nganHang ? 1 : 0;

                    // Thêm đối tượng HoSo vào danh sách
                    accounts.Add(new HoSo(data.GetInt32(0), data.GetString(1), data.GetString(2), data.GetString(3), data.GetString(4), data.GetString(5), data.GetString(6), data.GetString(7), theDienTuInt, nganHangInt));
                }
                conn.Close();
            }
            return accounts;
        }

        public List<ThongTinCanBan> ThongTinCanBan(string table)
        {
            List<ThongTinCanBan> accounts = new List<ThongTinCanBan>();
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                cmd = new SqlCommand(table, conn);
                data = cmd.ExecuteReader();
                while (data.Read())
                {

                    accounts.Add(new ThongTinCanBan(data.GetInt32(0), data.GetString(1), data.GetString(2), data.GetString(3), data.GetInt32(4), data.GetInt32(5), data.GetDouble(6),data.GetInt32(7), data.GetString(8)));
                }
                conn.Close();
            }
            return accounts;
        }

        public List<TienNghi> TienNghi(string table)
        {
            List<TienNghi> tienNghiList = new List<TienNghi>();
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                cmd = new SqlCommand(table, conn);
                SqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    int maks = data.GetInt32(0);
                    string tk = data.GetString(1);
                    int mayLanh = data.GetBoolean(2) ? 1 : 0;
                    int nhaHang = data.GetBoolean(3) ? 1 : 0;
                    int hoBoi = data.GetBoolean(4) ? 1 : 0;
                    int leTan24H = data.GetBoolean(5) ? 1 : 0;
                    int wifi = data.GetBoolean(6) ? 1 : 0;
                    int quayLeTan = data.GetBoolean(7) ? 1 : 0;
                    int dichVuThuDoiNgoaiTe = data.GetBoolean(8) ? 1 : 0;
                    int dichVuTiecCuoi = data.GetBoolean(9) ? 1 : 0;
                    int dichVuHoTroDatTour = data.GetBoolean(10) ? 1 : 0;
                    int nhanVienDangOnNgu = data.GetBoolean(11) ? 1 : 0;
                    int baiDauXe = data.GetBoolean(12) ? 1 : 0;
                    int tiemCafe = data.GetBoolean(13) ? 1 : 0;
                    int thangMay = data.GetBoolean(14) ? 1 : 0;
                    int quayBar = data.GetBoolean(15) ? 1 : 0;
                    int buaSang = data.GetBoolean(16) ? 1 : 0;
                    int quayBarBenHoBoi = data.GetBoolean(17) ? 1 : 0;

                    // Tạo đối tượng TienNghi và thêm vào danh sách
                    TienNghi tienNghi = new TienNghi(maks, tk, mayLanh, nhaHang, hoBoi, leTan24H, wifi, quayLeTan, dichVuThuDoiNgoaiTe, dichVuTiecCuoi, dichVuHoTroDatTour, nhanVienDangOnNgu, baiDauXe, tiemCafe, thangMay, quayBar, buaSang, quayBarBenHoBoi);
                    tienNghiList.Add(tienNghi);
                }
                conn.Close();
            }
            return tienNghiList;
        }


        public List<ViTri> ViTri(string table)
        {
            List<ViTri> accounts = new List<ViTri>();
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                cmd = new SqlCommand(table, conn);
                data = cmd.ExecuteReader();
                while (data.Read())
                {
                    accounts.Add(new ViTri(data.GetInt32(0), data.GetString(1), data.GetString(2), data.GetString(3), data.GetString(4)));
                }
                conn.Close();
            }
            return accounts;
        }
        public List<KhachSanThuocTaiKhoan> KhachSanThuocTaiKhoan(string table)
        {
            List<KhachSanThuocTaiKhoan> accounts = new List<KhachSanThuocTaiKhoan>();
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                cmd = new SqlCommand(table, conn);
                data = cmd.ExecuteReader();
                while (data.Read())
                {
                    accounts.Add(new KhachSanThuocTaiKhoan(data.GetString(0), data.GetInt32(1)));
                }
                conn.Close();
            }
            return accounts;
        }
        public List<UuDai> UuDai(string table)
        {
            List<UuDai> accounts = new List<UuDai>();
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                cmd = new SqlCommand(table, conn);
                data = cmd.ExecuteReader();
                while (data.Read())
                {
                    accounts.Add(new UuDai(data.GetInt32(0), data.GetInt32(1), data.GetString(2), data.GetInt32(3), data.GetString(4)));
                }
                conn.Close();
            }
            return accounts;
        }
        public List<HinhAnh> HinhAnh(string table)
        {
            List<HinhAnh> accounts = new List<HinhAnh>();
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                cmd = new SqlCommand(table, conn);
                data = cmd.ExecuteReader();
                while (data.Read())
                {
                    accounts.Add(new HinhAnh(data.GetString(0), data.GetInt32(1), data.GetString(2), data.GetString(3), data.GetString(4), data.GetString(5), data.GetString(6), data.GetString(7), data.GetInt32(8)));
                }
                conn.Close();
            }
            return accounts;
        }
        public List<Room> Phong(string table)
        {
            List<Room> accounts = new List<Room>();
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                cmd = new SqlCommand(table, conn);
                data = cmd.ExecuteReader();
                while (data.Read())
                {
                    accounts.Add(new Room(data.GetInt32(0), data.GetInt32(1), data.GetDouble(2), data.GetString(3), data.GetInt32(4), data.GetString(5)));
                }
                conn.Close();
            }
            return accounts;
        }
        public List<QL_HinhAnh> QL_HinhAnh(string table)
        {
            List<QL_HinhAnh> accounts = new List<QL_HinhAnh>();
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                cmd = new SqlCommand(table, conn);
                data = cmd.ExecuteReader();
                while (data.Read())
                {
                    accounts.Add(new QL_HinhAnh(data.GetInt32(0), data.GetString(1), data.GetString(2), data.GetInt32(3)));
                }
                conn.Close();
            }
            return accounts;
        }

        public List<QL_TN> QL_TN(string table)
        {
            List<QL_TN> accounts = new List<QL_TN>();
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                cmd = new SqlCommand(table, conn);
                data = cmd.ExecuteReader();
                while (data.Read())
                {
                    accounts.Add(new QL_TN(data.GetInt32(0), data.GetInt32(1)));
                }
                conn.Close();
            }
            return accounts;
        }
    }
}
