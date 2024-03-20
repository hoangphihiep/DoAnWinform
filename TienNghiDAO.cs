using System;
using System.Collections.Generic;
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
            connection.ThucThi(acc, sqlStr);
        }
        public void Update(TienNghi acc, string TenQuanHe)
        {
            string SQL = string.Format("UPDATE {0} SET MAYLANH = '{1}', NHAHANG = '{2}', HOBOI = '{3}', LETAN24H = '{4}', WIFI = '{5}',QUAYLETAN = '{6}',DICHVUTHUDOINGOAITE = '{7}',DICHVUTIECCUOI = '{8}',DICHVUHOTRODATTOUR = '{9}', NHANVIENDANGONNGU = '{10}', BAIDAUXE = '{11}', TIEMCAFE = '{12}', THANGMAY = '{13}',QUAYBAR = '{14}',BUASANG = '{15}',QUAYBARBENHOBOI = '{16}' WHERE MAKS = '{17}' AND TK = '{18}'", TenQuanHe, acc.MAYLANH, acc.NHAHANG, acc.HOBOI, acc.LETAN24H, acc.WIFI, acc.QUAYLETAN, acc.DICHVUTHUDOINGOAITE, acc.DICHVUTIECCUOI, acc.DICHVUHOTRODATTOUR, acc.NHANVIENDANGONNGU, acc.BAIDAUXE, acc.TIEMCAFE, acc.THANGMAY, acc.QUAYBAR, acc.BUASANG, acc.QUAYBARBENHOBOI ,acc.MAKS, acc.TK);
            connection.ThucThi(acc, SQL);
        }
    }
}
