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
    public partial class UThongtin : UserControl
    {
        public string tentk;
        public string mk;
        public UThongtin()
        {
            InitializeComponent();
        }

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            Account account = new Account(tentk, null, null, null, DateTime.MinValue, null, null, mk);
            string ten = txt_HoTen.Text;
            string gioitinh = txt_GioiTinh.Text;
            string diachi = txt_DiaChi.Text;
            DateTime ngaythangnamsinh = dtp_ngaythangnamsinh.Value;
            string email = txt_Email.Text;
            string sdt = txt_SoDienThoai.Text;
            Modify modify = new Modify();
            if (ten.Trim() == "")
                MessageBox.Show("Vui lòng nhập tên");
            else if (gioitinh.Trim() == "")
                MessageBox.Show("Vui lòng nhập giới tính");
            else if (diachi.Trim() == "")
                MessageBox.Show("Vui lòng nhập địa chỉ");
            else if (email.Trim() == "")
                MessageBox.Show("Vui lòng nhập email");
            else if (!account.CheckEmail(email))
                MessageBox.Show("Email không hợp lệ");
            else if (sdt.Trim() == "")
                MessageBox.Show("Vui lòng nhập số điện thoại");
            else if (!account.CheckPhone(sdt))
                MessageBox.Show("SDT không hợp lệ");
            else
            {
                string query = "Select * from TaiKhoan1 where TenDangNhap = '" + tentk + "'";
                Account_DAO Dao = new Account_DAO();
                List<Account> list_accounts = modify.accounts(query);
                if (list_accounts.Count() != 0)
                {
                    account.setHoTen(ten);
                    account.setGioiTinh(gioitinh);
                    account.setDiaChi(diachi);
                    account.setEmail(email);
                    account.setSoDienThoai(sdt);
                    account.setNgayThangNamSinh(ngaythangnamsinh);
                    Dao.UpdateAccount(account, "TaiKhoan1");
                }
            }
        }

        private void UThongtin_Load(object sender, EventArgs e)
        {

        }

        private void txt_GioiTinh_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
