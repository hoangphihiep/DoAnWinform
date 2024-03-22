using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
	public class Account
	{
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        private string TenDangNhap;
		private string HoTen;
		private string GioiTinh;
		private string DiaChi;
		private DateTime NgayThangNamSinh;
		private string Email;
		private string SoDienThoai;
		private string MatKhau;
		public Account(string TenDangNhap, string HoTen, string GioiTinh, string DiaChi, DateTime NgayThangNamSinh, string Email, string SoDienThoai, string MatKhau)
		{
			this.TenDangNhap = TenDangNhap;
			this.HoTen = HoTen;
			this.GioiTinh = GioiTinh;
			this.DiaChi = DiaChi;
			this.NgayThangNamSinh = NgayThangNamSinh;
			this.Email = Email;
			this.SoDienThoai = SoDienThoai;
			this.MatKhau = MatKhau;
		}
		public string getTenDangNhap
		{
            get { return TenDangNhap; }
		}

		public void setTenDangNhap(string tenDangNhap)
		{
			TenDangNhap = tenDangNhap;
		}
        public string getHoTen
        {
            get { return HoTen; }
        }

        public void setHoTen(string hoTen)
        {
            HoTen = hoTen;
        }
        public string getGioiTinh
        {
            get { return GioiTinh; }
        }

        public void setGioiTinh(string gioiTinh)
        {
            GioiTinh = gioiTinh;
        }
        public string getDiaChi
        {
            get { return DiaChi; }
        }

        public void setDiaChi(string diaChi)
        {
            DiaChi = diaChi;
        }
        public DateTime getNgayThangNamSinh
        {
            get { return NgayThangNamSinh; }
        }

        public void setNgayThangNamSinh(DateTime ngayThangNamSinh)
        {
            NgayThangNamSinh = ngayThangNamSinh;
        }
        public string getEmail
        {
            get { return Email; }
        }

        public void setEmail(string email)
        {
            Email = email;
        }
        public string getSoDienThoai
        {
            get { return SoDienThoai; }
        }

        public void setSoDienThoai(string soDienThoai)
        {
            SoDienThoai = soDienThoai;
        }
        public string getMatKhau
        {
            get { return MatKhau; }
        }

        public void setMatKhau(string matKhau)
        {
            MatKhau = matKhau;
        }
        public bool CheckPhone(string phone)
        {
            if (phone.Length != 10)
                return false;
            foreach (var i in phone)
            {
                if (!char.IsDigit(i))
                    return false;
            }
            return true;
        }
        public bool CheckEmail(string email)
        {
            int pos = email.IndexOf('@');
            int count = 0;
            foreach (var i in email)
            {
                if (i == '@')
                {
                    count++;
                }
            }
            if (pos >= 1 && pos < email.Length - 1 && count == 1)
                return true;
            else
                return false;
        }
        public bool checkInput(Account tk)
        {
            string email = tk.getEmail;
            string phone = tk.getSoDienThoai;
            //3. Kiểm tra tất cả các field không được rỗng khi thêm
            if (tk.getTenDangNhap == "")
                MessageBox.Show("Chưa nhập Ten Dang Nhap");
            //mk dai hon 6 ki tu
            else if (tk.getTenDangNhap.Length < 6)
                MessageBox.Show("Tk phải dài hơn 6 kí tự ");
            else if (tk.getHoTen == "")
                MessageBox.Show("Chưa nhập Ho va Ten ");
            else if (tk.getGioiTinh == "")
                MessageBox.Show("Chưa nhập Gioi Tinh ");
            else if (tk.getDiaChi == "")
                MessageBox.Show("Chưa nhập Dia Chi ");
            else if (tk.getNgayThangNamSinh == null)
                MessageBox.Show("Chưa nhập Ngay Thang Nam ");
            else if (tk.getEmail == "")
                MessageBox.Show("Chưa nhập Email ");
            else if (tk.getSoDienThoai == "")
                MessageBox.Show("Chưa nhập So Dien Thoai ");
            else if (tk.getMatKhau == "")
                MessageBox.Show("Chưa nhập Mat Khau ");
            //mk dai hon 6 ki tu
            else if(tk.getMatKhau.Length < 6)
                MessageBox.Show("Mật khẩu phải dài hơn 6 kí tự ");
            //4.Kiểm tra năm sinh >= 18 tuổi khi thêm
            else if ((DateTime.Now - tk.getNgayThangNamSinh).TotalDays < 18 * 365.25)
                MessageBox.Show("Vui Long nhap >= 17 tuoi ");
            //5.Kiểm tra email có hợp lệ không khi thêm
            else if (!CheckEmail(email))
                MessageBox.Show("Email khong hop le ");
            //6.Kiểm tra phone phải có định dạng : xxx - xxxx - xxx mới hợp lệ khi thêm
            else if (!CheckPhone(phone))
                MessageBox.Show("Phone khong hop le ");
            else
                return true;
            return false;
        }
    }
}