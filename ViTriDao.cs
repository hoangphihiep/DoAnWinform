using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class ViTriDao
    {
        Connection_to_SQL connection = new Connection_to_SQL();
        public void Add(ViTri acc, string TenQuanHe)
        {
            string sqlStr = string.Format("INSERT INTO {0} (MAKS, TK ,DIACHI, TENTHANHPHO,TINH) VALUES ('{1}','{2}','{3}','{4}','{5}')", TenQuanHe, acc.MAKS, acc.TK, acc.DIACHI, acc.TENTHANHPHO, acc.TINH);
            connection.ThucThi(acc, sqlStr);
        }
    }
}
