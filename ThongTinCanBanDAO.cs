using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class ThongTinCanBanDAO
    {
        Connection_to_SQL connection = new Connection_to_SQL();
        public void Add(ThongTinCanBan acc, string TenQuanHe)
        {
            string sqlStr = string.Format("INSERT INTO {0} (MAKS, TK ,TENKH,MOTA, KCTHANHPHO,KCSANBAY,SAO) VALUES ('{1}','{2}','{3}','{4}','{5}','{6}','{7}')", TenQuanHe, acc.MAKS, acc.TK, acc.TENKH, acc.MOTA, acc.KCTHANHPHO, acc.KCSANBAY, acc.SAO);
            connection.ThucThi(acc, sqlStr);
        }
    }
}
