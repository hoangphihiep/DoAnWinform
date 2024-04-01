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
    public partial class UThongTinKhachSan : UserControl
    {
        public string tentk;
        public UThongTinKhachSan()
        {
            InitializeComponent();
        }
        public void SetTenTK(string tenTK)
        {
            tentk = tenTK;
            // Gọi lại phương thức load dữ liệu
            UThongTinKhachSan_Load(this, EventArgs.Empty);
        }
        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_MaKhachSan.Text == "")
                    MessageBox.Show("Hãy nhập mã khách sạn");
                else
                {
                    ThongTinCanBan thongTinCanBan = new ThongTinCanBan(int.Parse(txt_MaKhachSan.Text), tentk, null, null, null, null, 0, null);
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
                        /*KHACHSAN khachsan = new KHACHSAN(thongTinCanBan.TENKH, null, null, thongTinCanBan.SAO, thongTinCanBan.SAO, thongTinCanBan.SAO, null, thongTinCanBan.MAKS);
                        KHACHSAN_DAO ksDAO = new KHACHSAN_DAO();
                        ksDAO.UpdateFromThongTinCanBan(khachsan, "KHACHSAN");*/
                        MessageBox.Show("Chỉnh sửa thành công");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Modify modify = new Modify();
            if (txt_MaKhachSan.Text == "")
                MessageBox.Show("Hãy nhập mã khách sạn");
            else
            {
                string query = "Select * from ThongTinCanBan where TK = '" + tentk + "' and MAKS = '" + int.Parse(txt_MaKhachSan.Text) + "' ";
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

        private void UThongTinKhachSan_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Connection_to_SQL.getConnnection()))
            {
                connection.Open();
                string sql = "SELECT * FROM ThongTinCanBan WHERE TK = '" + tentk + "'";
                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataReader reader = command.ExecuteReader();

                // Clear existing columns in the DataGridView
                dataGridView1.Columns.Clear();

                // Add columns to the DataGridView
                dataGridView1.Columns.Add("MAKS", "MAKS");
                dataGridView1.Columns.Add("TK", "TK");
                dataGridView1.Columns.Add("TENKH", "Tên KS");
                dataGridView1.Columns.Add("MOTA", "Mô tả");
                dataGridView1.Columns.Add("KCTHANHPHO", "Khoảng cách thành phố");
                dataGridView1.Columns.Add("KCSANBAY", "Khoảng cách sân bay");
                dataGridView1.Columns.Add("SAO", "Sao");
                dataGridView1.Columns.Add("GIA", "Giá");
                dataGridView1.Columns.Add("AnhBia", "Ảnh bìa");

                while (reader.Read())
                {
                    int maks = reader.GetInt32(reader.GetOrdinal("MAKS"));
                    string tk = reader.GetString(reader.GetOrdinal("TK"));
                    string tenKH = reader.GetString(reader.GetOrdinal("TENKH"));
                    string moTa = reader.IsDBNull(reader.GetOrdinal("MOTA")) ? string.Empty : reader.GetString(reader.GetOrdinal("MOTA"));
                    int khoangCachTP = reader.IsDBNull(reader.GetOrdinal("KCTHANHPHO")) ? 0 : reader.GetInt32(reader.GetOrdinal("KCTHANHPHO"));
                    int khoangCachSB = reader.IsDBNull(reader.GetOrdinal("KCSANBAY")) ? 0 : reader.GetInt32(reader.GetOrdinal("KCSANBAY"));
                    int sao = reader.IsDBNull(reader.GetOrdinal("SAO")) ? 0 : reader.GetInt32(reader.GetOrdinal("SAO"));
                    int gia = reader.IsDBNull(reader.GetOrdinal("GIA")) ? 0 : reader.GetInt32(reader.GetOrdinal("GIA"));
                    string anhBia = reader.IsDBNull(reader.GetOrdinal("AnhBia")) ? string.Empty : reader.GetString(reader.GetOrdinal("AnhBia"));

                    // Add rows to the DataGridView
                    dataGridView1.Rows.Add(maks, tk, tenKH, moTa, khoangCachTP, khoangCachSB, sao, gia, anhBia);
                }
                reader.Close();
            }
        }
    }
}

