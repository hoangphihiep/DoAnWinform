using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class KhachSanThuocTaiKhoanDAO
    {
        Connection_to_SQL connection = new Connection_to_SQL();
        public void Add(KhachSanThuocTaiKhoan acc, string TenQuanHe)
        {
            string sqlStr = string.Format("INSERT INTO {0} (TaiKhoan, MaKS) VALUES ('{1}','{2}')", TenQuanHe, acc.TaiKhoan, acc.MaKS);
            connection.ThucThi(acc, sqlStr);
        }
    }
}
