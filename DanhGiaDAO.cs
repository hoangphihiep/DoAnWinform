using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class DanhGiaDAO
    {
        public void Add (DanhGia comment)
        {
            SqlConnection conn = Connection_to_SQL.getConnection();
            try
            {
                string sqlString = "INSERT INTO DANHGIA(MAKS, TENKH, DIEM, NOIDUNG) VALUES (@maks, @tenkh, @diem, @noidung)";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlString, conn))
                {
                    cmd.Parameters.AddWithValue("@maks", comment.Maks);
                    cmd.Parameters.AddWithValue("@tenkh", comment.TenKH.ToString());
                    cmd.Parameters.AddWithValue("@diem", comment.Diem);
                    cmd.Parameters.AddWithValue("@noidung", comment.NoiDung.ToString());
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

        public List<DanhGia> GetDanhGia(int maks)
        {
            SqlConnection conn = Connection_to_SQL.getConnection();
            conn.Open();
            try
            {
                List<DanhGia> list = new List<DanhGia>();
                string sqlString = string.Format("SELECT * FROM DANHGIA WHERE MAKS = {0}", maks);
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string tenKH = reader.GetString(reader.GetOrdinal("TENKH"));
                    int diem = reader.GetInt32(reader.GetOrdinal("DIEM"));
                    string noidung = reader.GetString(reader.GetOrdinal("NOIDUNG"));
                    DanhGia dg = new DanhGia(tenKH, diem, noidung, maks);
                    list.Add(dg);
                }
                return list;
            }catch(Exception ex)
            { }
            finally
            {
                conn.Close();
            }
            return null;
        }

    }
}
