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
		public string getTenDangNhap()
		{
			return TenDangNhap;
		}

		public void setTenDangNhap(string tenDangNhap)
		{
			TenDangNhap = tenDangNhap;
		}
        public string getHoTen()
        {
            return TenDangNhap;
        }

        public void setHoTen(string hoTen)
        {
            HoTen = hoTen;
        }
        public string getGioiTinh()
        {
            return GioiTinh;
        }

        public void setGioiTinh(string gioiTinh)
        {
            GioiTinh = gioiTinh;
        }
        public string getDiaChi()
        {
            return DiaChi;
        }

        public void setDiaChi(string diaChi)
        {
            DiaChi = diaChi;
        }
        public DateTime getNgayThangNamSinh()
        {
            return NgayThangNamSinh;
        }

        public void setNgayThangNamSinh(DateTime ngayThangNamSinh)
        {
            NgayThangNamSinh = ngayThangNamSinh;
        }
        public string getEmail()
        {
            return Email;
        }

        public void setEmail(string email)
        {
            Email = email;
        }
        public string getSoDienThoai()
        {
            return SoDienThoai;
        }

        public void setSoDienThoai(string soDienThoai)
        {
            SoDienThoai = soDienThoai;
        }
        public string getMatKhau()
        {
            return MatKhau;
        }

        public void setMatKhau(string matKhau)
        {
            MatKhau = matKhau;
        }
        public void AddAccount(string TenDangNhap, string HoTen, string GioiTinh, string DiaChi, DateTime NgayThangNamSinh, string Email, string SoDienThoai, string MatKhau)
        {
            try
            {
                // Ket noi
                conn.Open();
                Account account = new Account(TenDangNhap, HoTen, GioiTinh, DiaChi, NgayThangNamSinh, Email, SoDienThoai, MatKhau);
                string sqlStr = string.Format("INSERT INTO TaiKhoan(TenDangNhap, HoTen, GioiTinh, DiaChi, NgayThangNamSinh, Email, SoDienThoai, MatKhau) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", account.TenDangNhap, account.HoTen, account.GioiTinh, account.DiaChi, account.NgayThangNamSinh, account.Email, account.SoDienThoai, account.MatKhau);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}