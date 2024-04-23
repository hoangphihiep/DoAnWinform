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
                    cmd.Parameters.AddWithValue("@maks", comment.Maks.ToString());
                    cmd.Parameters.AddWithValue("@tenkh", comment.TenKH.ToString());
                    cmd.Parameters.AddWithValue("@diem", comment.Diem.ToString());
                    cmd.Parameters.AddWithValue("@noidung", comment.NoiDung.ToString());
                    MessageBox.Show(comment.Maks.ToString());
                    MessageBox.Show(comment.TenKH);
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


    }
}
