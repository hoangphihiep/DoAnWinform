using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class KhachHangDAO
    {
        public void AddKhachHang(KhachHang kh, int makh)
        {
            SqlConnection conn = Connection_to_SQL.getConnection();
            try
            {
                conn.Open();
                string sqlString = "INSERT INTO KHACHHANG (MAKH, TENKH, GIOITINH, BDATE, SDT, GMAIL, DIACHI) VALUES (@makh,@tenkh, @gioitinh, @bdate, @sdt, @gmail, @diachi)";
                using (SqlCommand cmd = new SqlCommand(sqlString, conn))
                {
                    cmd.Parameters.AddWithValue("@makh", makh);
                    cmd.Parameters.AddWithValue("@tenkh", kh.Ten);
                    cmd.Parameters.AddWithValue("@gioitinh", kh.Gt);
                    cmd.Parameters.AddWithValue("@bdate", kh.Bdate);
                    cmd.Parameters.AddWithValue("@sdt", kh.Sdt);
                    cmd.Parameters.AddWithValue("@gmail", kh.Gmail);
                    cmd.Parameters.AddWithValue("@diachi", kh.DiaChi);
                    cmd.ExecuteNonQuery();
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public KhachHang Get(int makh)
        {
            string sqlString = string.Format("SELECT * FROM KHACHHANG WHERE MAKH= '{0}'", makh);
            SqlConnection conn = Connection_to_SQL.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(sqlString, conn);
            command.CommandTimeout = 120;
            SqlDataReader reader = command.ExecuteReader();
            string tenkh = reader.GetString(reader.GetOrdinal("TENKH"));
            string gt = reader.GetString(reader.GetOrdinal("GIOITINH"));
            DateTime bdate = reader.GetDateTime(reader.GetOrdinal("BDATE"));
            string sdt = reader.GetString(reader.GetOrdinal("SDT"));
            string gmail = reader.GetString(reader.GetOrdinal("GMAIL"));
            string diachi = reader.GetString(reader.GetOrdinal("DIACHI"));
            KhachHang kh = new KhachHang(makh, tenkh, sdt, gt, bdate, gmail, diachi);
            return kh;
        }

    }
}
