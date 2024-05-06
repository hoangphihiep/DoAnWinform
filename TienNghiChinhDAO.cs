using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuLich
{
    public class TienNghiChinhDAO
    {
        SqlConnection conn = Connection_to_SQL.getConnection();
        public List<TienNghiChinh> GetListTNC(int maks)
        {
            conn.Open();
            List<TienNghiChinh> list = new List<TienNghiChinh> ();
            string sqlString = string.Format("SELECT * FROM QL_TN INNER JOIN TNCHINH ON QL_TN.MATN = TNCHINH.MATN WHERE MAKS = {0}", maks);
            try
            {
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    string tenTN = reader.GetString(reader.GetOrdinal("TENTN"));
                    string hinhanh = reader.GetString(reader.GetOrdinal("ANH"));
                    TienNghiChinh tnc = new TienNghiChinh(tenTN, hinhanh);
                    list.Add(tnc);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return list;
        }
    }
}
