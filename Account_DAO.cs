using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class Account_DAO
    {
        Connection_to_SQL connection = new Connection_to_SQL();
        public void AddAccount(Account acc, string TenQuanHe)
        {
            string sqlStr = string.Format("INSERT INTO {0} (TenDangNhap, HoTen ,GioiTinh,DiaChi, NgayThangNamSinh,Email,SoDienThoai,MatKhau) VALUES ('{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", TenQuanHe, acc.getTenDangNhap, acc.getHoTen, acc.getGioiTinh, acc.getDiaChi, acc.getNgayThangNamSinh, acc.getEmail, acc.getSoDienThoai, acc.getMatKhau);
            //connection.ThucThi(acc, sqlStr);
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhap", acc.getTenDangNhap);
                    cmd.Parameters.AddWithValue("@HoTen", acc.getHoTen);
                    cmd.Parameters.AddWithValue("@GioiTinh", acc.getGioiTinh);
                    cmd.Parameters.AddWithValue("@DiaChi", acc.getDiaChi);
                    cmd.Parameters.AddWithValue("@NgayThangNamSinh", acc.getNgayThangNamSinh);
                    cmd.Parameters.AddWithValue("@Email", acc.getEmail);
                    cmd.Parameters.AddWithValue("@SoDienThoai", acc.getSoDienThoai);
                    cmd.Parameters.AddWithValue("@MatKhau", acc.getMatKhau);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public void UpdateAccount(Account acc, string TenQuanHe)
        {
            string SQL = string.Format("UPDATE {0} SET  HoTen ='{1}',GioiTinh ='{2}',DiaChi ='{3}',NgayThangNamSinh ='{4}',Email ='{5}',SoDienThoai ='{6}',MatKhau ='{7}' WHERE TenDangNhap ='{8}'", TenQuanHe, acc.getHoTen, acc.getGioiTinh, acc.getDiaChi, acc.getNgayThangNamSinh, acc.getEmail, acc.getSoDienThoai, acc.getMatKhau, acc.getTenDangNhap);
            connection.ThucThi(acc, SQL);
        }
    }
}
