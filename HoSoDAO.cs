using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class HoSoDAO
    {
        Connection_to_SQL connection = new Connection_to_SQL();
        public void Add(HoSo acc, string TenQuanHe)
        {
            string sqlStr = string.Format("INSERT INTO {0} (MAKS, TK ,TENCHUKS,SODIENTHOAI, EMAIL,DIACHI,TENTHANHPHO,TINH,THEDIENTU,NGANHANG) VALUES ('{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", TenQuanHe, acc.MAKS, acc.TK, acc.TENCHUKS, acc.SODIENTHOAI, acc.EMAIL, acc.DIACHI, acc.TENTHANHPHO, acc.TINH,acc.THEDIENTU, acc.NGANHANG);
            connection.ThucThi(acc, sqlStr);
        }
        public void Update(HoSo acc, string TenQuanHe)
        {
            string SQL = string.Format("UPDATE {0} SET TENCHUKS = '{1}', SODIENTHOAI = '{2}', EMAIL = '{3}', DIACHI = '{4}', TENTHANHPHO = '{5}', TINH = '{6}', THEDIENTU = '{7}', NGANHANG = '{8}' WHERE MAKS = '{9}' AND TK = '{10}'", TenQuanHe, acc.TENCHUKS, acc.SODIENTHOAI, acc.EMAIL, acc.DIACHI, acc.TENTHANHPHO, acc.TINH, acc.THEDIENTU, acc.NGANHANG, acc.MAKS, acc.TK);
            connection.ThucThi(acc, SQL);
        }
    }
}
