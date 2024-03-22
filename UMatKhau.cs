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
    public partial class UMatKhau : UserControl
    {
        public UMatKhau()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            try
            {
                string tk = txt_TenDangNhap.Text;
                string mk = txt_MatKhau.Text;
                string mkMoi = txt_NhapMatKhauMoi.Text;
                string nhapLaimk = txt_NhapLaiMatKhau.Text;
                if (tk.Trim() == "")
                    MessageBox.Show("Vui lòng nhập tài khoản");
                else if (mk.Trim() == "")
                    MessageBox.Show("Vui lòng nhập mật khẩu");
                else if (mkMoi.Trim() == "")
                    MessageBox.Show("Vui lòng nhập mật khẩu mới");
                else if (mkMoi.Length < 6)
                    MessageBox.Show("Vui lòng nhập mật khẩu mới dài hơn 6 kí tự");
                else if (mkMoi == mk)
                    MessageBox.Show("Vui lòng nhập mật khẩu mới khác mật khẩu cũ");
                else
                {
                    string query = "Select * from TaiKhoan1 where TenDangNhap = '" + tk + "' and MatKhau = '" + mk + "' ";
                    Account_DAO Dao = new Account_DAO();
                    List<Account> list_accounts = modify.accounts(query);
                    if (list_accounts.Count() != 0)
                    {
                        Account account = new Account(null, null, null, null, DateTime.MinValue, null, null, null);
                        foreach (Account acc in list_accounts)
                        {
                            if (acc.getTenDangNhap == tk && acc.getMatKhau == mk)
                            {
                                account = acc;
                                break;
                            }
                        }
                        account.setMatKhau(txt_NhapMatKhauMoi.Text);
                        if (txt_NhapMatKhauMoi.Text == txt_NhapLaiMatKhau.Text)
                        {
                            Dao.UpdateAccount(account, "TaiKhoan1");
                            MessageBox.Show("Chỉnh sửa thành công");
                        }
                        else
                            MessageBox.Show("Mật khẩu nhập lại không chính xác");

                    }
                    else
                        MessageBox.Show("Mật khẩu hiện tại không chính xác");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}
