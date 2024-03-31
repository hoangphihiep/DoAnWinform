using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        public void SetTenTK(string tenTK)
        {
            tentk = tenTK;
            // Gọi lại phương thức load dữ liệu
            UTienNghi_Load(this, EventArgs.Empty);
        }
        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_MaKhachSan.Text == "")
                {
                    MessageBox.Show("Hãy nhập mã khách sạn");
                }
                else
                {
                    Modify modify = new Modify();
                    TienNghi tienNghi = new TienNghi(
                        int.Parse(txt_MaKhachSan.Text),
                        tentk,
                        clb_TienNghiChinh.GetItemChecked(0) ? 1 : 0,
                        clb_TienNghiChinh.GetItemChecked(1) ? 1 : 0,
                        clb_TienNghiChinh.GetItemChecked(2) ? 1 : 0,
                        clb_TienNghiChinh.GetItemChecked(3) ? 1 : 0,
                        clb_TienNghiChinh.GetItemChecked(4) ? 1 : 0,
                        clb_DichVuKhachSan.GetItemChecked(0) ? 1 : 0,
                        clb_DichVuKhachSan.GetItemChecked(1) ? 1 : 0,
                        clb_DichVuKhachSan.GetItemChecked(2) ? 1 : 0,
                        clb_DichVuKhachSan.GetItemChecked(3) ? 1 : 0,
                        clb_DichVuKhachSan.GetItemChecked(4) ? 1 : 0,
                        clb_TienNghiCongCong.GetItemChecked(0) ? 1 : 0,
                        clb_TienNghiCongCong.GetItemChecked(1) ? 1 : 0,
                        clb_TienNghiCongCong.GetItemChecked(2) ? 1 : 0,
                        clb_AmThuc.GetItemChecked(0) ? 1 : 0,
                        clb_AmThuc.GetItemChecked(1) ? 1 : 0,
                        clb_AmThuc.GetItemChecked(2) ? 1 : 0
                    );

                    string query = "Select * from TIENNGHI where MAKS = '" + int.Parse(txt_MaKhachSan.Text) + "' and TK = '" + tentk + "' ";
                    TienNghiDAO Dao = new TienNghiDAO();
                    List<TienNghi> list_TienNghi = modify.TienNghi(query);

                    if (list_TienNghi.Count() != 0)
                    {
                        Dao.Update(tienNghi, "TIENNGHI");
                        MessageBox.Show("Chỉnh sửa thành công");
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

        private void UTienNghi_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Connection_to_SQL.getConnnection()))
            {
                connection.Open();
                string sql = "SELECT * FROM TIENNGHI WHERE TK = '" + tentk + "'";
                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataReader reader = command.ExecuteReader();

                // Clear existing columns in the DataGridView
                dataGridView1.Columns.Clear();

                // Add columns to the DataGridView
                dataGridView1.Columns.Add("MAKS", "MAKS");
                dataGridView1.Columns.Add("TK", "TK");
                dataGridView1.Columns.Add("MAYLANH", "Máy lạnh");
                dataGridView1.Columns.Add("NHAHANG", "Nhà hàng");
                dataGridView1.Columns.Add("HOBOI", "Hồ bơi");
                dataGridView1.Columns.Add("LETAN24H", "Lễ tân 24h");
                dataGridView1.Columns.Add("WIFI", "Wifi");
                dataGridView1.Columns.Add("QUAYLETAN", "Quầy lễ tân");
                dataGridView1.Columns.Add("DICHVUTHUDOINGOAITE", "Dịch vụ thực đơn ngoại tệ");
                dataGridView1.Columns.Add("DICHVUTIECCUOI", "Dịch vụ tiệc cưới");
                dataGridView1.Columns.Add("DICHVUHOTRODATTOUR", "Dịch vụ hỗ trợ đặt tour");
                dataGridView1.Columns.Add("NHANVIENDANGONNGU", "Nhân viên đa ngôn ngữ");
                dataGridView1.Columns.Add("BAIDAUXE", "Bãi đậu xe");
                dataGridView1.Columns.Add("TIEMCAFE", "Tiệm cafe");
                dataGridView1.Columns.Add("THANGMAY", "Thang máy");
                dataGridView1.Columns.Add("QUAYBAR", "Quầy bar");
                dataGridView1.Columns.Add("BUASANG", "Bữa sáng");
                dataGridView1.Columns.Add("QUAYBARBENHOBOI", "Quầy bar bên hồ bơi");

                while (reader.Read())
                {
                    int maks = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    string tk = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                    bool mayLanh = !reader.IsDBNull(2) && reader.GetBoolean(2);
                    bool nhaHang = !reader.IsDBNull(3) && reader.GetBoolean(3);
                    bool hoBoi = !reader.IsDBNull(4) && reader.GetBoolean(4);
                    bool leTan24h = !reader.IsDBNull(5) && reader.GetBoolean(5);
                    bool wifi = !reader.IsDBNull(6) && reader.GetBoolean(6);
                    bool quayLeTan = !reader.IsDBNull(7) && reader.GetBoolean(7);
                    bool dichVuThuDoiNgoaiTe = !reader.IsDBNull(8) && reader.GetBoolean(8);
                    bool dichVuTiecCuoi = !reader.IsDBNull(9) && reader.GetBoolean(9);
                    bool dichVuHoTroDatTour = !reader.IsDBNull(10) && reader.GetBoolean(10);
                    bool nhanVienDaNgonNgu = !reader.IsDBNull(11) && reader.GetBoolean(11);
                    bool baiDauXe = !reader.IsDBNull(12) && reader.GetBoolean(12);
                    bool tiemCafe = !reader.IsDBNull(13) && reader.GetBoolean(13);
                    bool thangMay = !reader.IsDBNull(14) && reader.GetBoolean(14);
                    bool quayBar = !reader.IsDBNull(15) && reader.GetBoolean(15);
                    bool buaSang = !reader.IsDBNull(16) && reader.GetBoolean(16);
                    bool quayBarBenHoBoi = !reader.IsDBNull(17) && reader.GetBoolean(17);

                    // Add rows to the DataGridView
                    dataGridView1.Rows.Add(maks, tk, mayLanh, nhaHang, hoBoi, leTan24h, wifi, quayLeTan, dichVuThuDoiNgoaiTe, dichVuTiecCuoi,
                        dichVuHoTroDatTour, nhanVienDaNgonNgu, baiDauXe, tiemCafe, thangMay, quayBar, buaSang, quayBarBenHoBoi);
                }
                reader.Close();
            }

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {

            Modify modify = new Modify();
            if (txt_MaKhachSan.Text == "")
                MessageBox.Show("Hãy nhập mã khách sạn");
            else
            {
                string query = "Select * from TIENNGHI where TK = '" + tentk + "' and MAKS = '" + txt_MaKhachSan.Text + "' ";
                TienNghiDAO Dao = new TienNghiDAO();
                List<TienNghi> list_TienNghi = modify.TienNghi(query);
                if (list_TienNghi.Count() != 0)
                {
                    TienNghi TienNghi1 = list_TienNghi[0];
                    bool check0 = TienNghi1.MAYLANH != 0;
                    bool check1 = TienNghi1.NHAHANG != 0;
                    bool check2 = TienNghi1.HOBOI != 0;
                    bool check3 = TienNghi1.LETAN24H != 0;
                    bool check4 = TienNghi1.WIFI != 0;
                    bool check5 = TienNghi1.QUAYLETAN != 0;
                    bool check6 = TienNghi1.DICHVUTHUDOINGOAITE != 0;
                    bool check7 = TienNghi1.DICHVUTIECCUOI != 0;
                    bool check8 = TienNghi1.DICHVUHOTRODATTOUR != 0;
                    bool check9 = TienNghi1.NHANVIENDANGONNGU != 0;
                    bool check10 = TienNghi1.BAIDAUXE != 0;
                    bool check11 = TienNghi1.TIEMCAFE != 0;
                    bool check12 = TienNghi1.THANGMAY != 0;
                    bool check13 = TienNghi1.QUAYBAR != 0;
                    bool check14 = TienNghi1.BUASANG != 0;
                    bool check15 = TienNghi1.QUAYBARBENHOBOI != 0;

                    clb_TienNghiChinh.SetItemChecked(0, check0);
                    clb_TienNghiChinh.SetItemChecked(1, check1);
                    clb_TienNghiChinh.SetItemChecked(2, check2);
                    clb_TienNghiChinh.SetItemChecked(3, check3);
                    clb_TienNghiChinh.SetItemChecked(4, check4);

                    clb_DichVuKhachSan.SetItemChecked(0, check5);
                    clb_DichVuKhachSan.SetItemChecked(1, check6);
                    clb_DichVuKhachSan.SetItemChecked(2, check7);
                    clb_DichVuKhachSan.SetItemChecked(3, check8);
                    clb_DichVuKhachSan.SetItemChecked(4, check9);

                    clb_TienNghiCongCong.SetItemChecked(0, check10);
                    clb_TienNghiCongCong.SetItemChecked(1, check11);
                    clb_TienNghiCongCong.SetItemChecked(2, check12);

                    clb_AmThuc.SetItemChecked(0, check13);
                    clb_AmThuc.SetItemChecked(1, check14);
                    clb_AmThuc.SetItemChecked(2, check15);
                }
                else
                {
                    MessageBox.Show("Không tồn tại mã khách sạn này");
                }
            }
        }

    }
    
}
    
