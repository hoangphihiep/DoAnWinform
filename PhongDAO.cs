using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class PhongDAO
    {
        Connection_to_SQL connection = new Connection_to_SQL();
        public void Add(Phong acc, string TenQuanHe)
        {
            string sqlStr = string.Format("INSERT INTO {0} (MAPHONG, SOKHACH ,SOGIUONG,GIA, KICHTHUOC,TaiKhoan,GIATHEMKHACH,MAKS) VALUES ('{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", TenQuanHe, acc.MaPhong, acc.SoKhach, acc.SoGiuong, acc.Gia, acc.KichThuoc, acc.TaiKhoan, acc.GiaThemKhach, acc.MaKS);
            connection.ThucThi(acc, sqlStr);
        }
        public void Update(Phong acc, string TenQuanHe)
        {
            string SQL = string.Format("UPDATE {0} SET SOKHACH = '{1}', SOGIUONG = '{2}', GIA = '{3}', KICHTHUOC = '{4}', GIATHEMKHACH = '{5}' WHERE TaiKhoan = '{6}' AND MAKS = '{7}' AND MAPHONG ='{8}'", TenQuanHe, acc.SoKhach, acc.SoGiuong, acc.Gia, acc.KichThuoc, acc.GiaThemKhach, acc.TaiKhoan, acc.MaKS, acc.MaPhong);
            connection.ThucThi(acc, SQL);
        }
    }
}
