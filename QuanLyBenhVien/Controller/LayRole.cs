using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Data.SqlClient;

namespace QuanLyBenhVien.Controller
{
    class LayRole
    {
        public static OracleConnection conn = DangNhap.OracleConnect();
         public static string LayThongTinRole(string username)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            string role ="";

            OracleCommand cmd = new OracleCommand();

            cmd.CommandText = " select vaitro from qtv.nhanvien where lower(manv)  = lower('"+username +"') ";

            cmd.Connection = conn;

            try
            {

                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                 role = dt.Rows[0][0].ToString();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return role;
        }
    }
}
