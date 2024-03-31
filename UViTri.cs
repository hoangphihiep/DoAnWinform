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

namespace DuLich
{
    public partial class UViTri : UserControl
    {
        public string tentk;
        public UViTri()
        {
            InitializeComponent();
        }
        public void SetTenTK(string tenTK)
        {
            tentk = tenTK;
            // Gọi lại phương thức load dữ liệu
            UViTri_Load(this, EventArgs.Empty);
        }

        private void UViTri_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Connection_to_SQL.getConnnection()))
            {
                connection.Open();
                string sql = "SELECT * FROM ViTri WHERE TK = '" + tentk + "'";
                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataReader reader = command.ExecuteReader();

                // Xóa bỏ các cột cũ (nếu có)
                dataGridView1.Columns.Clear();

                // Thêm các cột vào DataGridView
                dataGridView1.Columns.Add("MAKS", "MAKS");
                dataGridView1.Columns.Add("TK", "TK");
                dataGridView1.Columns.Add("DIACHI", "DIACHI");
                dataGridView1.Columns.Add("TENTHANHPHO", "TENTHANHPHO");
                dataGridView1.Columns.Add("TINH", "TINH");
                while (reader.Read())
                {
                    int maks = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    string tk = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                    string diachi = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                    string tenthanhpho = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                    string tinh = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);

                    // Tạo một mảng chứa giá trị của từng cột
                    string[] rowValues = { tk, maks.ToString(), diachi, tenthanhpho, tinh };

                    // Thêm hàng vào DataGridView
                    dataGridView1.Rows.Add(rowValues);
                }
                reader.Close();
            }
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
                    ViTri viTri = new ViTri(int.Parse(txt_MaKhachSan.Text), tentk, null, null, null);
                    string query = "Select * from ViTri where MAKS = '" + int.Parse(txt_MaKhachSan.Text) + "' and TK = '" + tentk + "' ";
                    ViTriDao Dao = new ViTriDao();
                    List<ViTri> list_HoSo = modify.ViTri(query);
                    if (list_HoSo.Count() != 0)
                    {
                        viTri.DIACHI = txt_DiaChi.Text;
                        viTri.TENTHANHPHO = cbb_ThanhPho.Text;
                        viTri.TINH = cbb_Tinh.Text;
                        Dao.Update(viTri, "ViTri");
                        /*KHACHSAN khachsan = new KHACHSAN(null, viTri.TINH, viTri.TENTHANHPHO, 0, 0, 0, viTri.DIACHI, viTri.MAKS);
                        KHACHSAN_DAO ksDAO = new KHACHSAN_DAO();
                        ksDAO.UpdateFromViTri(khachsan, "KHACHSAN");*/
                        MessageBox.Show("Chỉnh sửa thành công");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbl_MaKS_Click(object sender, EventArgs e)
        {

        }

        private void UViTri_VisibleChanged(object sender, EventArgs e)
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
                    string query = "Select * from ViTri where TK = '" + tentk + "' and MAKS = '" + txt_MaKhachSan.Text + "' ";
                    ViTriDao Dao = new ViTriDao();
                    List<ViTri> list_HoSo = modify.ViTri(query);
                    if (list_HoSo.Count() != 0)
                    {
                        ViTri viTri = list_HoSo[0];
                        txt_DiaChi.Text = viTri.DIACHI;
                        cbb_ThanhPho.Text = viTri.TENTHANHPHO;
                        cbb_Tinh.Text = viTri.TINH;
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
