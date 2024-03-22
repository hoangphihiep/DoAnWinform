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
            try
            {
                if (txt_MaKhachSan.Text == "")
                    MessageBox.Show("Hãy nhập mã khách sạn");
                else
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
                        hoSo.TENTHANHPHO = cbb_ThanhPho.Text;
                        hoSo.TINH = cbb_Tinh.Text;
                        hoSo.THEDIENTU = TheDienTu;
                        hoSo.NGANHANG = NganHang;
                        Dao.Update(hoSo, "HOSO");
                        MessageBox.Show("Chỉnh sửa thành công");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbl_Email_Click(object sender, EventArgs e)
        {

        }

        private void UHoSo_Load(object sender, EventArgs e)
        {

        }

        private void UHoSo_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Modify modify = new Modify();
                if (txt_MaKhachSan.Text == "")
                    MessageBox.Show("Hãy nhập mã khách sạn");
                else
                {
                    string query = "Select * from HOSO where TK = '" + tentk + "' and MAKS = '" + txt_MaKhachSan.Text + "' ";
                    HoSoDAO Dao = new HoSoDAO();
                    List<HoSo> list_HoSo = modify.HoSo(query);
                    if (list_HoSo.Count() != 0)
                    {
                        HoSo hoSo1 = list_HoSo[0];
                        txt_DiaChi.Text = hoSo1.DIACHI;
                        txt_Email.Text = hoSo1.EMAIL;
                        txt_HoVaTenChuKhachSan.Text = hoSo1.TENCHUKS;
                        txt_SoDienThoai.Text = hoSo1.SODIENTHOAI;
                        cbb_ThanhPho.Text = hoSo1.TENTHANHPHO;
                        cbb_Tinh.Text = hoSo1.TINH;
                        bool check0 = hoSo1.THEDIENTU != 0;
                        bool check1 = hoSo1.NGANHANG != 0;

                        checkedListBox3.SetItemChecked(0, check0);
                        checkedListBox3.SetItemChecked(1, check1);
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại mã khách sạn này");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
