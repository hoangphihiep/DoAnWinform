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
        public void AddKhachHang(KhachHang kh)
        {
            SqlConnection conn = Connection_to_SQL.getConnection();
            try
            {
                conn.Open();
                string sqlString = "INSERT INTO KHACHHANG (TENKH, GIOITINH, BDATE, SDT, GMAIL, DIACHI) VALUES (@tenkh, @gioitinh, @bdate, @sdt, @gmail, @diachi)";
                using (SqlCommand cmd = new SqlCommand(sqlString, conn))
                {
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
    }
}
