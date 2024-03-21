using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnDuLich;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DuLich
{
    public partial class fRegister : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        public fRegister()
        {
            InitializeComponent();
        }
        private void fRegister_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(50, 0, 0, 0);
            panel3.BackColor = Color.FromArgb(50, 0, 0, 0);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_TenDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_MatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Email_Click(object sender, EventArgs e)
        {

        }

        private void txt_TenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void lbl_NhapLaiMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                Account_DAO Dao = new Account_DAO();
                Account tk = new Account(txt_TenDangNhap.Text, txt_HoVaTen.Text, cbb_GioiTinh.Text, txt_DiaChi.Text, dtp_NgayThangNamSinh.Value, txt_Email.Text, txt_SoDienThoai.Text, txt_MatKhau.Text);
                if (!tk.checkInput(tk))
                {

                }
                else
                {
                    Modify modify = new Modify();
                    string query = "Select * from TaiKhoan1 where TenDangNhap = '" + tk.getTenDangNhap + "'";
                    if (modify.accounts(query).Count() == 0)
                    {
                        if (txt_MatKhau.Text != txt_NhapLaiMatKhau.Text)
                        {
                            MessageBox.Show("Mật khẩu nhập lại không trùng khớp");
                        }
                        else
                        {
                            if (cb_ToiDongY.Checked == true)
                            {
                                Dao.AddAccount(tk, "TaiKhoan1");
                                MessageBox.Show("Đăng kí thành công");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Hãy đọc kĩ điều khoản và điều kiện đăng ký");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản đã tồn tại");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fRegister_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
