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
                UuDai UuDai = new UuDai(0, 0, null, 0);
                Modify modify = new Modify();
                if (txt_MaKhachSan.Text == "")
                    MessageBox.Show("Hãy nhập mã khách sạn");
                else if (txt_MaUuDai.Text == "")
                    MessageBox.Show("Hãy nhập mã ưu đãi");
                string query = "Select * from UuDai where MAKS = '" + int.Parse(txt_MaKhachSan.Text) + "' and MAUUDAI = '" + int.Parse(txt_MaUuDai.Text) + "' ";
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
                UuDai UuDai = new UuDai(0, 0, null, 0);
                Modify modify = new Modify();
                if (txt_MaKhachSan.Text == "")
                    MessageBox.Show("Hãy nhập mã khách sạn");
                else if (txt_MaUuDai.Text == "")
                    MessageBox.Show("Hãy nhập mã ưu đãi");
                else
                {
                    string query = "Select * from UuDai where MAKS = '" + int.Parse(txt_MaKhachSan.Text) + "' and MAUUDAI = '" + int.Parse(txt_MaUuDai.Text) + "' ";
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
                UuDai UuDai = new UuDai(0, 0, null, 0);
                Modify modify = new Modify();
                if (txt_MaKhachSan.Text == "")
                    MessageBox.Show("Hãy nhập mã khách sạn");
                else if (txt_MaUuDai.Text == "")
                    MessageBox.Show("Hãy nhập mã ưu đãi");
                else
                {
                    string query = "Select * from UuDai where MAKS = '" + int.Parse(txt_MaKhachSan.Text) + "' and MAUUDAI = '" + int.Parse(txt_MaUuDai.Text) + "' ";
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
            using (SqlConnection connection = new SqlConnection(Connection_to_SQL.getConnnection()))
            {
                connection.Open();

                string sql = "SELECT * FROM UuDai";
                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int maks = reader.GetInt32(0);
                    int mauudai = reader.GetInt32(1);
                    string tenuudai = reader.GetString(2);
                    int giatriuudai = reader.GetInt32(3);

                    DataGridViewRow row = new DataGridViewRow();
                    row.Cells[0].Value = maks;
                    row.Cells[1].Value = mauudai;
                    row.Cells[2].Value = tenuudai;
                    row.Cells[3].Value = giatriuudai;

                    dataGridView1.Rows.Add(row);
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
                    string query = "Select * from UuDai where MAKS = '" + int.Parse(txt_MaKhachSan.Text) + "' and MAUUDAI = '" + int.Parse(txt_MaUuDai.Text) + "' ";
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
