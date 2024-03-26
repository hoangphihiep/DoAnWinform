using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuLich
{
    public partial class UCTNChinh : UserControl
    {
        int matn;
        public UCTNChinh(int matn)
        {
            this.matn = matn;
            InitializeComponent();
        }

        private void UCTNChinh_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM TNChinh WHERE TNChinh.MATN = @matn";
            SqlConnection conn = Connection_to_SQL.getConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@matn", matn);
            command.CommandTimeout = 120;
            SqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                string address = reader.GetString(reader.GetOrdinal("Anh"));
                ptbTNC.Image = Image.FromFile(address);
                lblTNC.Text = reader.GetString(reader.GetOrdinal("TENTN"));
                i++;
            }
            conn.Close();
        }
    }
}
