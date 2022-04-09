using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace QuanLyBenhVien
{
    class ConnectData
    {
        public static OracleConnection conn = null;
        public static string stringConnection(string password, string username)
        {
            // 'Connection String' kết nối trực tiếp tới Oracle.
            string connString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE)))Password=" + password + ";User ID=" + username;

            return connString;
        }
        public static void Connect(string connect)
        {
            try
            {
                MessageBox.Show(connect);
                conn = new OracleConnection();
                conn.ConnectionString = connect;
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString());
            }
        }

        public static void DisConnect()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            else
            {
                conn.Dispose();
            }
        }

        public static int ExcuteQuery(string query)
        {
            int result = -1;
            try
            {
                OracleCommand cmd = new OracleCommand(query, conn);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString());
            }
            finally
            {
                DisConnect();
            }
            return result;
        }

        public static DataTable GetDataTable(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString());
            }
            finally
            {
                DisConnect();
            }
            return dt;
        }
    }
}
