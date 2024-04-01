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
        public void SetTenTK(string tenTK)
        {
            tentk = tenTK;
            // Gọi lại phương thức load dữ liệu
            UHoSo_Load(this, EventArgs.Empty);
        }

        private void lbl_Email_Click(object sender, EventArgs e)
        {

        }

        private void UHoSo_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Connection_to_SQL.getConnnection()))
            {
                connection.Open();
                string sql = "SELECT * FROM HOSO WHERE TK = '" + tentk + "'";
                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataReader reader = command.ExecuteReader();

                // Clear existing columns in the DataGridView
                dataGridView1.Columns.Clear();

                // Add columns to the DataGridView
                dataGridView1.Columns.Add("MAKS", "MAKS");
                dataGridView1.Columns.Add("TK", "TK");
                dataGridView1.Columns.Add("TENCHUKS", "Tên chủ KS");
                dataGridView1.Columns.Add("SODIENTHOAI", "Số điện thoại");
                dataGridView1.Columns.Add("EMAIL", "Email");
                dataGridView1.Columns.Add("DIACHI", "Địa chỉ");
                dataGridView1.Columns.Add("TENTHANHPHO", "Tên thành phố");
                dataGridView1.Columns.Add("TINH", "Tỉnh");
                dataGridView1.Columns.Add("THEDIENTU", "Thẻ điện tử");
                dataGridView1.Columns.Add("NGANHANG", "Ngân hàng");

                while (reader.Read())
                {
                    int maks = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    string tk = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                    string tenChuKS = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                    string soDienThoai = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                    string email = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                    string diaChi = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                    string tenThanhPho = reader.IsDBNull(6) ? string.Empty : reader.GetString(6);
                    string tinh = reader.IsDBNull(7) ? string.Empty : reader.GetString(7);
                    bool theDienTu = !reader.IsDBNull(8) && reader.GetBoolean(8);
                    bool nganHang = !reader.IsDBNull(9) && reader.GetBoolean(9);

                    // Add rows to the DataGridView
                    dataGridView1.Rows.Add(maks, tk, tenChuKS, soDienThoai, email, diaChi, tenThanhPho, tinh, theDienTu, nganHang);
                }
                reader.Close();
            }
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
