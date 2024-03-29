﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class Modify
    {
        public Modify() { }
        SqlCommand cmd;
        SqlDataReader data;
        public List<Account> accounts(string table)
        {
            List<Account> accounts = new List<Account>();
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                cmd = new SqlCommand(table, conn);
                data = cmd.ExecuteReader();
                while(data.Read())
                {
                    accounts.Add(new Account(data.GetString(0), data.GetString(1), data.GetString(2), data.GetString(3), data.GetDateTime(4), data.GetString(5), data.GetString(6), data.GetString(7)));
                }
                conn.Close();
            }
            return accounts;
        }
        public List<KhachSanThuocTaiKhoan> KHACHSAN_THUOC_TAIKHOAN(string table)
        {
            List<KhachSanThuocTaiKhoan> accounts = new List<KhachSanThuocTaiKhoan>();
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                cmd = new SqlCommand(table, conn);
                data = cmd.ExecuteReader();
                while (data.Read())
                {
                    accounts.Add(new KhachSanThuocTaiKhoan(data.GetString(0), data.GetInt32(1)));
                }
                conn.Close();
            }
            return accounts;
        }
        public List<HoSo> HoSo(string table)
        {
            List<HoSo> accounts = new List<HoSo>();
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                cmd = new SqlCommand(table, conn);
                data = cmd.ExecuteReader();
                while (data.Read())
                {
                    // Đọc giá trị từ cột 8 và 9 dưới dạng kiểu boolean
                    bool theDienTu = data.GetBoolean(8);
                    bool nganHang = data.GetBoolean(9);

                    // Chuyển đổi giá trị boolean sang số nguyên 0 hoặc 1
                    int theDienTuInt = theDienTu ? 1 : 0;
                    int nganHangInt = nganHang ? 1 : 0;

                    // Thêm đối tượng HoSo vào danh sách
                    accounts.Add(new HoSo(data.GetInt32(0), data.GetString(1), data.GetString(2), data.GetString(3), data.GetString(4), data.GetString(5), data.GetString(6), data.GetString(7), theDienTuInt, nganHangInt));
                }
                conn.Close();
            }
            return accounts;
        }

        public List<ThongTinCanBan> ThongTinCanBan(string table)
        {
            List<ThongTinCanBan> accounts = new List<ThongTinCanBan>();
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                cmd = new SqlCommand(table, conn);
                data = cmd.ExecuteReader();
                while (data.Read())
                {
                    accounts.Add(new ThongTinCanBan(data.GetInt32(0), data.GetString(1), data.GetString(2), data.GetString(3), data.GetInt32(4), data.GetInt32(5), data.GetInt32(6), data.GetInt32(7).ToString()));
                }
                conn.Close();
            }
            return accounts;
        }

        public List<TienNghi> TienNghi(string table)
        {
            List<TienNghi> accounts = new List<TienNghi>();
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                cmd = new SqlCommand(table, conn);
                data = cmd.ExecuteReader();
                while (data.Read())
                {
                    accounts.Add(new TienNghi(data.GetInt32(0), data.GetString(1), data.GetInt32(2), data.GetInt32(3), data.GetInt32(4), data.GetInt32(5), data.GetInt32(6), data.GetInt32(7), data.GetInt32(8), data.GetInt32(9), data.GetInt32(10), data.GetInt32(11), data.GetInt32(12), data.GetInt32(13), data.GetInt32(14), data.GetInt32(15), data.GetInt32(16), data.GetInt32(17)));
                }
                conn.Close();
            }
            return accounts;
        }
        public List<ViTri> ViTri(string table)
        {
            List<ViTri> accounts = new List<ViTri>();
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                cmd = new SqlCommand(table, conn);
                data = cmd.ExecuteReader();
                while (data.Read())
                {
                    accounts.Add(new ViTri(data.GetInt32(0), data.GetString(1), data.GetString(2), data.GetString(3), data.GetString(4)));
                }
                conn.Close();
            }
            return accounts;
        }
        public List<KhachSanThuocTaiKhoan> KhachSanThuocTaiKhoan(string table)
        {
            List<KhachSanThuocTaiKhoan> accounts = new List<KhachSanThuocTaiKhoan>();
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                cmd = new SqlCommand(table, conn);
                data = cmd.ExecuteReader();
                while (data.Read())
                {
                    accounts.Add(new KhachSanThuocTaiKhoan(data.GetString(0), data.GetInt32(1)));
                }
                conn.Close();
            }
            return accounts;
        }
        public List<UuDai> UuDai(string table)
        {
            List<UuDai> accounts = new List<UuDai>();
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                cmd = new SqlCommand(table, conn);
                data = cmd.ExecuteReader();
                while (data.Read())
                {
                    accounts.Add(new UuDai(data.GetInt32(0), data.GetInt32(1),data.GetString(2),data.GetInt32(3),data.GetString(4)));
                }
                conn.Close();
            }
            return accounts;
        }
        public List<HinhAnh> HinhAnh(string table)
        {
            List<HinhAnh> accounts = new List<HinhAnh>();
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                cmd = new SqlCommand(table, conn);
                data = cmd.ExecuteReader();
                while (data.Read())
                {
                    accounts.Add(new HinhAnh(data.GetString(0),data.GetInt32(1), data.GetString(2), data.GetString(3), data.GetString(4),data.GetString(5),data.GetString(6),data.GetString(7),data.GetInt32(8)));
                }
                conn.Close();
            }
            return accounts;
        }
        public List<Phong> Phong(string table)
        {
            List<Phong> accounts = new List<Phong>();
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                cmd = new SqlCommand(table, conn);
                data = cmd.ExecuteReader();
                while (data.Read())
                {
                    accounts.Add(new Phong(data.GetInt32(0), data.GetInt32(1), data.GetInt32(2), data.GetInt32(3), data.GetInt32(4), data.GetString(5), data.GetInt32(6),data.GetInt32(7)));
                }
                conn.Close();
            }
            return accounts;
        }
    }
}
