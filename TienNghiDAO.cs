using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class TienNghiDAO
    {
        Connection_to_SQL connection = new Connection_to_SQL();
        public void Add(TienNghi acc, string TenQuanHe)
        {
            string sqlStr = string.Format("INSERT INTO {0} (MAKS, TK, MAYLANH, NHAHANG, HOBOI, LETAN24H, WIFI, QUAYLETAN, DICHVUTHUDOINGOAITE, DICHVUTIECCUOI, DICHVUHOTRODATTOUR, NHANVIENDANGONNGU, BAIDAUXE, TIEMCAFE, THANGMAY, QUAYBAR, BUASANG, QUAYBARBENHOBOI) VALUES ({1}, '{2}', {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}, {18})", TenQuanHe, acc.MAKS, acc.TK, acc.MAYLANH, acc.NHAHANG, acc.HOBOI, acc.LETAN24H, acc.WIFI, acc.QUAYLETAN, acc.DICHVUTHUDOINGOAITE, acc.DICHVUTIECCUOI, acc.DICHVUHOTRODATTOUR, acc.NHANVIENDANGONNGU, acc.BAIDAUXE, acc.TIEMCAFE, acc.THANGMAY, acc.QUAYBAR, acc.BUASANG, acc.QUAYBARBENHOBOI);
            //connection.ThucThi(acc, sqlStr);
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                {
                    cmd.Parameters.AddWithValue("@MAKS", acc.MAKS);
                    cmd.Parameters.AddWithValue("@TK", acc.TK);
                    cmd.Parameters.AddWithValue("@MAYLANH", acc.MAYLANH);
                    cmd.Parameters.AddWithValue("@NHAHANG", acc.NHAHANG);
                    cmd.Parameters.AddWithValue("@HOBOI", acc.HOBOI);
                    cmd.Parameters.AddWithValue("@LETAN24H", acc.LETAN24H);
                    cmd.Parameters.AddWithValue("@WIFI", acc.WIFI);
                    cmd.Parameters.AddWithValue("@QUAYLETAN", acc.QUAYLETAN);
                    cmd.Parameters.AddWithValue("@DICHVUTHUDOINGOAITE", acc.DICHVUTHUDOINGOAITE);
                    cmd.Parameters.AddWithValue("@DICHVUTIECCUOI", acc.DICHVUTIECCUOI);
                    cmd.Parameters.AddWithValue("@DICHVUHOTRODATTOUR", acc.DICHVUHOTRODATTOUR);
                    cmd.Parameters.AddWithValue("@NHANVIENDANGONNGU", acc.NHANVIENDANGONNGU);
                    cmd.Parameters.AddWithValue("@BAIDAUXE", acc.BAIDAUXE);
                    cmd.Parameters.AddWithValue("@TIEMCAFE", acc.TIEMCAFE);
                    cmd.Parameters.AddWithValue("@THANGMAY", acc.THANGMAY);
                    cmd.Parameters.AddWithValue("@QUAYBAR", acc.QUAYBAR);
                    cmd.Parameters.AddWithValue("@BUASANG", acc.BUASANG);
                    cmd.Parameters.AddWithValue("@QUAYBARBENHOBOI", acc.QUAYBARBENHOBOI);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public void Update(TienNghi acc, string TenQuanHe)
        {
            string SQL = string.Format("UPDATE {0} SET MAYLANH = '{1}', NHAHANG = '{2}', HOBOI = '{3}', LETAN24H = '{4}', WIFI = '{5}',QUAYLETAN = '{6}',DICHVUTHUDOINGOAITE = '{7}',DICHVUTIECCUOI = '{8}',DICHVUHOTRODATTOUR = '{9}', NHANVIENDANGONNGU = '{10}', BAIDAUXE = '{11}', TIEMCAFE = '{12}', THANGMAY = '{13}',QUAYBAR = '{14}',BUASANG = '{15}',QUAYBARBENHOBOI = '{16}' WHERE MAKS = '{17}' AND TK = '{18}'", TenQuanHe, acc.MAYLANH, acc.NHAHANG, acc.HOBOI, acc.LETAN24H, acc.WIFI, acc.QUAYLETAN, acc.DICHVUTHUDOINGOAITE, acc.DICHVUTIECCUOI, acc.DICHVUHOTRODATTOUR, acc.NHANVIENDANGONNGU, acc.BAIDAUXE, acc.TIEMCAFE, acc.THANGMAY, acc.QUAYBAR, acc.BUASANG, acc.QUAYBARBENHOBOI ,acc.MAKS, acc.TK);
            //connection.ThucThi(acc, SQL);
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(SQL, conn))
                {
                    cmd.Parameters.AddWithValue("@MAKS", acc.MAKS);
                    cmd.Parameters.AddWithValue("@TK", acc.TK);
                    cmd.Parameters.AddWithValue("@MAYLANH", acc.MAYLANH);
                    cmd.Parameters.AddWithValue("@NHAHANG", acc.NHAHANG);
                    cmd.Parameters.AddWithValue("@HOBOI", acc.HOBOI);
                    cmd.Parameters.AddWithValue("@LETAN24H", acc.LETAN24H);
                    cmd.Parameters.AddWithValue("@WIFI", acc.WIFI);
                    cmd.Parameters.AddWithValue("@QUAYLETAN", acc.QUAYLETAN);
                    cmd.Parameters.AddWithValue("@DICHVUTHUDOINGOAITE", acc.DICHVUTHUDOINGOAITE);
                    cmd.Parameters.AddWithValue("@DICHVUTIECCUOI", acc.DICHVUTIECCUOI);
                    cmd.Parameters.AddWithValue("@DICHVUHOTRODATTOUR", acc.DICHVUHOTRODATTOUR);
                    cmd.Parameters.AddWithValue("@NHANVIENDANGONNGU", acc.NHANVIENDANGONNGU);
                    cmd.Parameters.AddWithValue("@BAIDAUXE", acc.BAIDAUXE);
                    cmd.Parameters.AddWithValue("@TIEMCAFE", acc.TIEMCAFE);
                    cmd.Parameters.AddWithValue("@THANGMAY", acc.THANGMAY);
                    cmd.Parameters.AddWithValue("@QUAYBAR", acc.QUAYBAR);
                    cmd.Parameters.AddWithValue("@BUASANG", acc.BUASANG);
                    cmd.Parameters.AddWithValue("@QUAYBARBENHOBOI", acc.QUAYBARBENHOBOI);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}
