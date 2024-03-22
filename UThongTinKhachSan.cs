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
            try
            {
                ThongTinCanBan thongTinCanBan = new ThongTinCanBan(int.Parse(txt_MaKhachSan.Text), tentk, null, null, null, null, 0);
                Modify modify = new Modify();

                string query = "Select * from ThongTinCanBan where MAKS = '" + int.Parse(txt_MaKhachSan.Text) + "' and TK = '" + tentk + "' ";
                ThongTinCanBanDAO Dao = new ThongTinCanBanDAO();
                List<ThongTinCanBan> list = modify.ThongTinCanBan(query);
                if (list.Count() != 0)
                {
                    thongTinCanBan.TENKH = txt_TenKS.Text;
                    thongTinCanBan.MOTA = txt_MoTa.Text;
                    thongTinCanBan.KCTHANHPHO = int.Parse(txt_KhoangCachTP.Text);
                    thongTinCanBan.KCSANBAY = int.Parse(txt_KhoangCachSB.Text);
                    thongTinCanBan.SAO = int.Parse(cbb_DanhGiaSao.Text);
                    Dao.Update(thongTinCanBan, "ThongTinCanBan");
                    MessageBox.Show("Chỉnh sửa thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                    string query = "Select * from ThongTinCanBan where TK = '" + tentk + "' and MAKS = '" + txt_MaKhachSan.Text + "' ";
                    ThongTinCanBanDAO Dao = new ThongTinCanBanDAO();
                    List<ThongTinCanBan> thongTinCanBans = modify.ThongTinCanBan(query);
                    if (thongTinCanBans.Count() != 0)
                    {
                        ThongTinCanBan ThongTin = thongTinCanBans[0];
                        txt_TenKS.Text = ThongTin.TENKH;
                        txt_MoTa.Text = ThongTin.MOTA;
                        txt_KhoangCachSB.Text = ThongTin.KCSANBAY?.ToString();
                        txt_KhoangCachTP.Text = ThongTin.KCTHANHPHO?.ToString();
                        cbb_DanhGiaSao.Text = ThongTin.SAO.ToString();
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

        private void UThongTinKhachSan_Load(object sender, EventArgs e)
        {

        }
    }
}
