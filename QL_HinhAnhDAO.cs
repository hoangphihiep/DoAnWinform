using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class QL_HinhAnhDAO
    {
        public void Add(QL_HinhAnh acc, string TenQuanHe)
        {
            string sqlStr = string.Format("INSERT INTO {0} (MAKS, TENANH, ADDRESS) VALUES (@MAKS, @TENANH, @ADDRESS)", TenQuanHe);
            //connection.ThucThi(acc, sqlStr);
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                {
                    cmd.Parameters.AddWithValue("@MAKS", acc.MAKS);
                    cmd.Parameters.AddWithValue("@TENANH", acc.TENANH);
                    string relativePath = ExtractRelativePath(acc.ADDRESS);
                    // Handle null value for ADDRESS
                    SqlParameter addressParam = new SqlParameter("@ADDRESS", relativePath ?? (object)DBNull.Value);
                    cmd.Parameters.Add(addressParam);

                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void Update(QL_HinhAnh acc, string TenQuanHe)
        {
            string SQL = string.Format("UPDATE {0} SET TENANH = '{1}', ADDRESS = '{2}'  WHERE MAKS = '{3}' and MAANH = '{4}'", TenQuanHe, acc.TENANH, acc.ADDRESS, acc.MAKS,acc.MAANH);
            //connection.ThucThi(acc, SQL);
            using (SqlConnection conn = Connection_to_SQL.getConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(SQL, conn))
                {
                    cmd.Parameters.AddWithValue("@MAKS", acc.MAKS);
                    cmd.Parameters.AddWithValue("@TENANH", acc.TENANH);
                    string relativePath = ExtractRelativePath(acc.ADDRESS);
                    cmd.Parameters.AddWithValue("@ADDRESS", relativePath);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public List<QL_HinhAnh> Get(int maks)
        {
            List < QL_HinhAnh > list= new List<QL_HinhAnh>();
            string sqlString = string.Format("SELECT * FROM QL_ANH WHERE MAKS='{0}'", maks.ToString());
            SqlConnection conn = Connection_to_SQL.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(sqlString, conn);
            command.CommandTimeout = 120;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string tenanh;
                string address;
                int maanh;
                tenanh = reader.GetString(reader.GetOrdinal("TENANH"));
                address = reader.GetString(reader.GetOrdinal("ADDRESS"));
                maanh = reader.GetInt32(reader.GetOrdinal("MAANH"));
                QL_HinhAnh ql = new QL_HinhAnh(maks,tenanh, address,maanh);
                list.Add(ql);
            }
            return list;
        }

        static string ExtractRelativePath(string fullPath)
        {
            if (fullPath.Contains("hinhanh"))
            {
                int index = fullPath.IndexOf(@"hinhanh\");
                return fullPath.Substring(index);
            }
            else if (fullPath.Contains("Image"))
            {
                int index = fullPath.IndexOf(@"Image\");
                return fullPath.Substring(index);
            }
            return "Không chứa chuỗi 'hinhanh' hoặc 'Image'.";

        }
    }
}
