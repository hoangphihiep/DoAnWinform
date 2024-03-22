using System;
using System.Collections.Generic;
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
            string sqlStr = string.Format("INSERT INTO {0} (MAKS, MAUUDAI ,TENUUDAI,GIATRIUUDAI) VALUES ('{1}','{2}','{3}','{4}')", TenQuanHe, acc.MaKS, acc.MaUuDai, acc.TenUuDai, acc.GiaTriUuDai);
            connection.ThucThi(acc, sqlStr);
        }
        public void Update(UuDai acc, string TenQuanHe)
        {
            string SQL = string.Format("UPDATE {0} SET TENUUDAI = '{1}', GIATRIUUDAI = '{2}' WHERE MAKS = '{3}' AND MAUUDAI = '{4}'", TenQuanHe, acc.TenUuDai, acc.GiaTriUuDai, acc.MaKS, acc.MaUuDai);
            connection.ThucThi(acc, SQL);
        }
        public void Delete(UuDai acc, string TenQuanHe)
        {
            string SQL = string.Format("DELETE FROM {0} WHERE MAKS = '{1}' and MAUUDAI = '{2}' ", TenQuanHe, acc.MaKS,acc.MaUuDai);
            connection.ThucThi(acc, SQL);
        }
    }
}
