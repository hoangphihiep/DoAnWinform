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
    public partial class UTienNghi : UserControl
    {
        public string tentk;
        public UTienNghi()
        {
            InitializeComponent();
        }

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            TienNghi tienNghi = new TienNghi(int.Parse(txt_MaKhachSan.Text), tentk, 0, 0, 0, 0, 0,0, 0, 0, 0, 0,0, 0, 0, 0, 0, 0);
            string query = "Select * from TIENGNHI where MAKS = '" + int.Parse(txt_MaKhachSan.Text) + "' and TK = '" + tentk + "' ";
            TienNghiDAO Dao = new TienNghiDAO();
            List<TienNghi> list_HoSo = modify.TienNghi(query);
            if (list_HoSo.Count() != 0)
            {
                int tienNghiChinh0 = clb_TienNghiChinh.GetItemChecked(0) ? 1 : 0;
                int tienNghiChinh1 = clb_TienNghiChinh.GetItemChecked(1) ? 1 : 0;
                int tienNghiChinh2 = clb_TienNghiChinh.GetItemChecked(2) ? 1 : 0;
                int tienNghiChinh3 = clb_TienNghiChinh.GetItemChecked(3) ? 1 : 0;
                int tienNghiChinh4 = clb_TienNghiChinh.GetItemChecked(4) ? 1 : 0;

                int dichVuKhachSan0 = clb_DichVuKhachSan.GetItemChecked(0) ? 1 : 0;
                int dichVuKhachSan1 = clb_DichVuKhachSan.GetItemChecked(1) ? 1 : 0;
                int dichVuKhachSan2 = clb_DichVuKhachSan.GetItemChecked(2) ? 1 : 0;
                int dichVuKhachSan3 = clb_DichVuKhachSan.GetItemChecked(3) ? 1 : 0;
                int dichVuKhachSan4 = clb_DichVuKhachSan.GetItemChecked(4) ? 1 : 0;

                int tienNghiCongCong0 = clb_TienNghiCongCong.GetItemChecked(0) ? 1 : 0;
                int tienNghiCongCong1 = clb_TienNghiCongCong.GetItemChecked(1) ? 1 : 0;
                int tienNghiCongCong2 = clb_TienNghiCongCong.GetItemChecked(2) ? 1 : 0;

                int amThuc0 = clb_AmThuc.GetItemChecked(0) ? 1 : 0;
                int amThuc1 = clb_AmThuc.GetItemChecked(1) ? 1 : 0;
                int amThuc2 = clb_AmThuc.GetItemChecked(2) ? 1 : 0;

                Dao.Update(tienNghi, "TIENGNHI");
                MessageBox.Show("Chỉnh sửa thành công");
            }
        }

        private void UTienNghi_Load(object sender, EventArgs e)
        {

        }
    }
}
