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

namespace QuanLyBenhVien
{
    public partial class ThongBao : Form
    {
        public static OracleConnection conn = DangNhap.OracleConnect();
        public ThongBao()
        {
            InitializeComponent();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        private void ThongBao_Load(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();

            cmd.CommandText = "select * FROM THONGBAO ";
            
            cmd.Connection = conn;

            try
            {

                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewThongBao.DataSource = dt;
             

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
