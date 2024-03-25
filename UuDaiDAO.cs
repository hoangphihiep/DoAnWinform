using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class UuDaiDAO
    {
        Connection_to_SQL connection = new Connection_to_SQL();
        public void Add(UuDai acc, string TenQuanHe)
        {
            string sqlStr = string.Format("INSERT INTO {0} (MAKS, MAUUDAI ,TENUUDAI,GIATRIUUDAI,Tk) VALUES ('{1}','{2}','{3}','{4}','{5}')", TenQuanHe, acc.MaKS, acc.MaUuDai, acc.TenUuDai, acc.GiaTriUuDai,acc.TK);
            //connection.ThucThi(acc, sqlStr);
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                {
                    cmd.Parameters.AddWithValue("@MAKS", acc.MaKS);
                    cmd.Parameters.AddWithValue("@MAUUDAI", acc.MaUuDai);
                    cmd.Parameters.AddWithValue("@TENUUDAI", acc.TenUuDai);
                    cmd.Parameters.AddWithValue("@GIATRIUUDAI", acc.GiaTriUuDai);
                    cmd.Parameters.AddWithValue("@Tk", acc.TK);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public void Update(UuDai acc, string TenQuanHe)
        {
            string SQL = string.Format("UPDATE {0} SET TENUUDAI = '{1}', GIATRIUUDAI = '{2}' WHERE MAKS = '{3}' AND MAUUDAI = '{4}' AND Tk = '{5}'", TenQuanHe, acc.TenUuDai, acc.GiaTriUuDai, acc.MaKS, acc.MaUuDai,acc.TK);
            //connection.ThucThi(acc, SQL);
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(SQL, conn))
                {
                    cmd.Parameters.AddWithValue("@MAKS", acc.MaKS);
                    cmd.Parameters.AddWithValue("@MAUUDAI", acc.MaUuDai);
                    cmd.Parameters.AddWithValue("@TENUUDAI", acc.TenUuDai);
                    cmd.Parameters.AddWithValue("@GIATRIUUDAI", acc.GiaTriUuDai);
                    cmd.Parameters.AddWithValue("@Tk", acc.TK);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public void Delete(UuDai acc, string TenQuanHe)
        {
            string SQL = string.Format("DELETE FROM {0} WHERE MAKS = '{1}' and MAUUDAI = '{2}' AND Tk = '{3}' ", TenQuanHe, acc.MaKS,acc.MaUuDai,acc.TK);
            //connection.ThucThi(acc, SQL);
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(SQL, conn))
                {
                    cmd.Parameters.AddWithValue("@MAKS", acc.MaKS);
                    cmd.Parameters.AddWithValue("@MAUUDAI", acc.MaUuDai);
                    cmd.Parameters.AddWithValue("@TENUUDAI", acc.TenUuDai);
                    cmd.Parameters.AddWithValue("@GIATRIUUDAI", acc.GiaTriUuDai);
                    cmd.Parameters.AddWithValue("@Tk", acc.TK);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}
