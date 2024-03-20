using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DuLich
{
    public partial class UThongTinKhachSan : UserControl
    {
        public string tentk;
        public UThongTinKhachSan()
        {
            InitializeComponent();
        }

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            ThongTinCanBan thongTinCanBan = new ThongTinCanBan(int.Parse(txt_MaKhachSan.Text), tentk, null, null, null, null, 0);
            Modify modify = new Modify();

            string query = "Select * from HOSO where MAKS = '" + int.Parse(txt_MaKhachSan.Text) + "' and TK = '" + tentk + "' ";
            ThongTinCanBanDAO Dao = new ThongTinCanBanDAO();
            List<ThongTinCanBan> list = modify.ThongTinCanBan(query);
            if (list.Count() != 0)
            {
                thongTinCanBan.TENKH = txt_TenKS.Text;
                thongTinCanBan.MOTA = txt_MoTa.Text;
                thongTinCanBan.KCTHANHPHO = int.Parse(txt_KhoangCachTP.Text);
                thongTinCanBan.KCSANBAY = int.Parse(txt_KhoangCachSB.Text);
                thongTinCanBan.SAO = int.Parse(cbb_DanhGiaSao.Text);
                Dao.Update(thongTinCanBan, "TaiKhoan1");
            }

        }
    }
}
