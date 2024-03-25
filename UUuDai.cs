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
    public partial class UUuDai : UserControl
    {
        public string tentk;
        public int index = 1;
        public UUuDai()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                UuDaiDAO Dao = new UuDaiDAO();
                UuDai UuDai = new UuDai(0, 0, null, 0, tentk);
                Modify modify = new Modify();
                if (txt_MaKhachSan.Text == "")
                    MessageBox.Show("Hãy nhập mã khách sạn");
                else if (txt_MaUuDai.Text == "")
                    MessageBox.Show("Hãy nhập mã ưu đãi");
                string query = "SELECT * FROM UuDai WHERE MAKS = '" + txt_MaKhachSan.Text + "' AND MAUUDAI = '" + txt_MaUuDai.Text + "' AND Tk = '" + tentk + "'";
                if (modify.UuDai(query).Count() == 0)
                {
                    UuDai.MaKS = int.Parse(txt_MaKhachSan.Text);
                    UuDai.MaUuDai = int.Parse(txt_MaUuDai.Text);
                    UuDai.TenUuDai = txt_TenUuDai.Text;
                    UuDai.GiaTriUuDai = int.Parse(txt_GiaTriUuDai.Text);
                    Dao.Add(UuDai, "UuDai");
                    MessageBox.Show("Thêm ưu đãi thành công");
                }
                else
                {
                    MessageBox.Show("Mã ưu đãi đã tồn tại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                UuDaiDAO Dao = new UuDaiDAO();
                UuDai UuDai = new UuDai(0, 0, null, 0, tentk);
                Modify modify = new Modify();
                if (txt_MaKhachSan.Text == "")
                    MessageBox.Show("Hãy nhập mã khách sạn");
                else if (txt_MaUuDai.Text == "")
                    MessageBox.Show("Hãy nhập mã ưu đãi");
                else
                {
                    string query = "SELECT * FROM UuDai WHERE MAKS = '" + txt_MaKhachSan.Text + "' AND MAUUDAI = '" + txt_MaUuDai.Text + "' AND Tk = '" + tentk + "'";
                    if (modify.UuDai(query).Count() == 1)
                    {
                        Dao.Delete(UuDai, "UuDai");
                        MessageBox.Show("Xóa ưu đãi thành công");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                UuDaiDAO Dao = new UuDaiDAO();
                UuDai UuDai = new UuDai(0, 0, null, 0, tentk);
                Modify modify = new Modify();
                if (txt_MaKhachSan.Text == "")
                    MessageBox.Show("Hãy nhập mã khách sạn");
                else if (txt_MaUuDai.Text == "")
                    MessageBox.Show("Hãy nhập mã ưu đãi");
                else
                {
                    string query = "SELECT * FROM UuDai WHERE MAKS = '" + txt_MaKhachSan.Text + "' AND MAUUDAI = '" + txt_MaUuDai.Text + "' AND Tk = '" + tentk + "'";

                    if (modify.UuDai(query).Count() == 0)
                    {
                        UuDai.MaKS = int.Parse(txt_MaKhachSan.Text);
                        UuDai.MaUuDai = int.Parse(txt_MaUuDai.Text);
                        UuDai.TenUuDai = txt_TenUuDai.Text;
                        UuDai.GiaTriUuDai = int.Parse(txt_GiaTriUuDai.Text);
                        Dao.Update(UuDai, "UuDai");
                        MessageBox.Show("Chỉnh sửa ưu đãi thành công");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void U_UuDai_Load(object sender, EventArgs e)
        {
            MessageBox.Show(tentk);
            using (SqlConnection connection = new SqlConnection(Connection_to_SQL.getConnnection()))
            {
                connection.Open();

                string sql = "SELECT * FROM UuDai";
                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataReader reader = command.ExecuteReader();

                // Xóa bỏ các cột cũ (nếu có)
                dataGridView1.Columns.Clear();

                // Thêm các cột vào DataGridView
                dataGridView1.Columns.Add("Tk", "Tk");
                dataGridView1.Columns.Add("MAKS", "MAKS");
                dataGridView1.Columns.Add("MAUUDAI", "MAUUDAI");
                dataGridView1.Columns.Add("TENUUDAI", "TENUUDAI");
                dataGridView1.Columns.Add("GIATRIUUDAI", "GIATRIUUDAI");
                while (reader.Read())
                {
                    int maks = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    int mauudai = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                    string tenuudai = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                    int giatriuudai = reader.IsDBNull(3) ? 0 : reader.GetInt32(3);
                    string tk = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);

                    // Tạo một mảng chứa giá trị của từng cột
                    string[] rowValues = { tk,maks.ToString(), mauudai.ToString(), tenuudai, giatriuudai.ToString() };

                    // Thêm hàng vào DataGridView
                    dataGridView1.Rows.Add(rowValues);
                }

                reader.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Modify modify = new Modify();
                if (txt_MaKhachSan.Text == "")
                    MessageBox.Show("Hãy nhập mã khách sạn");
                else if (txt_MaUuDai.Text == "")
                    MessageBox.Show("Hãy nhập mã ưu đãi");
                else
                {
                    string query = "SELECT * FROM UuDai WHERE MAKS = '" + txt_MaKhachSan.Text + "' AND MAUUDAI = '" + txt_MaUuDai.Text + "' AND Tk = '" + tentk + "'";
                    UuDaiDAO Dao = new UuDaiDAO();
                    List<UuDai> list_UuDai = modify.UuDai(query);
                    if (list_UuDai.Count() != 0)
                    {
                        UuDai uuDai = list_UuDai[0];
                        txt_TenUuDai.Text = uuDai.TenUuDai;
                        txt_GiaTriUuDai.Text = uuDai.GiaTriUuDai.ToString();
                        dataGridView1.Refresh();
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
