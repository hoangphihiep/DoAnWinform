using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DuLich
{
    public class ThongTinCanBanDAO
    {
        Connection_to_SQL connection = new Connection_to_SQL();
        public void Add(ThongTinCanBan acc, string TenQuanHe)
        {
            string sqlStr = string.Format("INSERT INTO {0} (MAKS, TK ,TENKH,MOTA, KCTHANHPHO,KCSANBAY,SAO,AnhBia) VALUES ('{1}','{2}',N'{3}',N'{4}','{5}','{6}','{7}','{8}')", TenQuanHe, acc.MAKS, acc.TK, acc.TENKH, acc.MOTA, acc.KCTHANHPHO, acc.KCSANBAY, acc.SAO,acc.AnhBia);
            //connection.ThucThi(acc, sqlStr);
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                {
                    cmd.Parameters.AddWithValue("@MAKS", acc.MAKS);
                    cmd.Parameters.AddWithValue("@TK", acc.TK);
                    cmd.Parameters.AddWithValue("@TENKH", acc.TENKH);
                    cmd.Parameters.AddWithValue("@MOTA", acc.MOTA);
                    cmd.Parameters.AddWithValue("@KCTHANHPHO", acc.KCTHANHPHO);
                    cmd.Parameters.AddWithValue("@KCSANBAY", acc.KCSANBAY);
                    cmd.Parameters.AddWithValue("@SAO", acc.SAO);
                    string relativePath = ExtractRelativePath(acc.AnhBia);
                    SqlParameter addressParam = new SqlParameter("@AnhBia", relativePath ?? (object)DBNull.Value);
                    cmd.Parameters.Add(addressParam);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public void Update(ThongTinCanBan acc, string TenQuanHe)
        {
            string SQL = string.Format("UPDATE {0} SET TENKH = '{1}', MOTA = '{2}', KCTHANHPHO = '{3}', KCSANBAY = '{4}', SAO = '{5}',AnhBia = '{6}' WHERE MAKS = '{7}' AND TK = '{8}'", TenQuanHe, acc.TENKH, acc.MOTA, acc.KCTHANHPHO, acc.KCSANBAY, acc.SAO,acc.AnhBia, acc.MAKS, acc.TK);
            //connection.ThucThi(acc, SQL);
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(SQL, conn))
                {
                    cmd.Parameters.AddWithValue("@MAKS", acc.MAKS);
                    cmd.Parameters.AddWithValue("@TK", acc.TK);
                    cmd.Parameters.AddWithValue("@TENKH", acc.TENKH);
                    cmd.Parameters.AddWithValue("@MOTA", acc.MOTA);
                    cmd.Parameters.AddWithValue("@KCTHANHPHO", acc.KCTHANHPHO);
                    cmd.Parameters.AddWithValue("@KCSANBAY", acc.KCSANBAY);
                    cmd.Parameters.AddWithValue("@SAO", acc.SAO);
                    string relativePath = ExtractRelativePath(acc.AnhBia);
                    SqlParameter addressParam = new SqlParameter("@AnhBia", relativePath ?? (object)DBNull.Value);
                    cmd.Parameters.Add(addressParam);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        static string ExtractRelativePath(string fullPath)
        {
            if (fullPath.Contains("hinhanh"))
            {
                int index = fullPath.IndexOf(@"hinhanh\");
                return fullPath.Substring(index);
            }
            else if (fullPath.Contains("Image"))
            {
                int index = fullPath.IndexOf(@"Image\");
                return fullPath.Substring(index);
            }
            return "Không chứa chuỗi 'hinhanh' hoặc 'Image'.";

        }
    }
}
