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
    public partial class UHoSo : UserControl
    {
        public string tentk;
        public string mk;
        public UHoSo()
        {
            InitializeComponent();
        }

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            HoSo hoSo = new HoSo(int.Parse(txt_MaKhachSan.Text), tentk, null, null, null, null, null, null, 0, 0);
            string query = "Select * from HOSO where MAKS = '" + int.Parse(txt_MaKhachSan.Text) + "' and TK = '" + tentk + "' ";
            HoSoDAO Dao = new HoSoDAO();
            List<HoSo> list_HoSo = modify.HoSo(query);
            int TheDienTu = checkedListBox3.GetItemChecked(0) ? 1 : 0;
            int NganHang = checkedListBox3.GetItemChecked(1) ? 1 : 0;
            if (list_HoSo.Count() != 0)
            {
                hoSo.TENCHUKS = txt_HoVaTenChuKhachSan.Text;
                hoSo.SODIENTHOAI = txt_SoDienThoai.Text;
                hoSo.EMAIL = txt_Email.Text;
                hoSo.DIACHI = txt_DiaChi.Text;
                hoSo.TENTHANHPHO = txt_ThanhPho.Text;
                hoSo.TINH = txt_Tinh.Text;
                hoSo.THEDIENTU = TheDienTu;
                hoSo.NGANHANG = NganHang;
                Dao.Update(hoSo, "HOSO");
            }
        }

        private void lbl_Email_Click(object sender, EventArgs e)
        {

        }
    }
}
