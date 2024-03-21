using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuLich
{
    public partial class UViTri : UserControl
    {
        public string tentk;
        public UViTri()
        {
            InitializeComponent();
        }

        private void UViTri_Load(object sender, EventArgs e)
        {

        }

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            ViTri viTri = new ViTri(int.Parse(txt_MaKhachSan.Text),tentk,null,null,null);
            string query = "Select * from ViTri where MAKS = '" + int.Parse(txt_MaKhachSan.Text) + "' and TK = '" + tentk + "' ";
            ViTriDao Dao = new ViTriDao();
            List<ViTri> list_HoSo = modify.ViTri(query);
            if (list_HoSo.Count() != 0)
            {
                viTri.DIACHI = txt_DiaChi.Text;
                viTri.TENTHANHPHO = cbb_ThanhPho.Text;
                viTri.TINH = cbb_Tinh.Text;
                Dao.Update(viTri, "ViTri");
                MessageBox.Show("Chỉnh sửa thành công");
            }
        }

        private void lbl_MaKS_Click(object sender, EventArgs e)
        {

        }
    }
}
