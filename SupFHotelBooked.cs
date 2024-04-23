using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class SupFHotelBooked
    {
        public List<DatPhong> KhachSanSapToi(string taikhoan)
        {
            string query = string.Format("SELECT * FROM DATPHONG WHERE TENDANGNHAP = @taiKhoan");
            SqlConnection conn = Connection_to_SQL.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@taiKhoan", taikhoan);
            List<DatPhong> list = new List<DatPhong>();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int maDat = reader.GetInt32(reader.GetOrdinal("MADAT"));
                DatPhong dp = new DatPhongDAO().GetWithMaDat(maDat);
                if(DateTime.Now < dp.NgayNhan)
                    list.Add(dp);
            }
            return list;
        }

        public List<DatPhong> KhachSanDangTraiNghiem(string taikhoan)
        {
            string query = string.Format("SELECT * FROM DATPHONG WHERE TENDANGNHAP = @taiKhoan");
            SqlConnection conn = Connection_to_SQL.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@taiKhoan", taikhoan);
            List<DatPhong> list = new List<DatPhong>();
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                int maDat = reader.GetInt32(reader.GetOrdinal("MADAT"));
                DatPhong dp = new DatPhongDAO().GetWithMaDat(maDat);
                if ((DateTime.Now > dp.NgayNhan)&&(DateTime.Now < dp.NgayTra))
                    list.Add(dp);
            }
            return list;
        }

        public List<DatPhong> KhachSanDaTraiNghiem(string taikhoan)
        {
            string query = string.Format("SELECT * FROM DATPHONG WHERE TENDANGNHAP = @taiKhoan");
            SqlConnection conn = Connection_to_SQL.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@taiKhoan", taikhoan);
            List<DatPhong> list = new List<DatPhong>();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int maDat = reader.GetInt32(reader.GetOrdinal("MADAT"));
                DatPhong dp = new DatPhongDAO().GetWithMaDat(maDat);
                if (DateTime.Now > dp.NgayTra)
                    list.Add(dp);
            }
            return list;
        }

        public string AnhPhong(int maphong)
        {
            string query = string.Format("SELECT * FROM PHONG WHERE MAPHONG = @maphong");
            SqlConnection conn = Connection_to_SQL.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@maphong", maphong);
            List<DatPhong> list = new List<DatPhong>();
            SqlDataReader reader = command.ExecuteReader();
            return reader.GetString(reader.GetOrdinal("Anh"));
        }

    }
}
