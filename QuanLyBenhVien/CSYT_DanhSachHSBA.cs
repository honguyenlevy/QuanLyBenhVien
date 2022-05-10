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
    public partial class CSYT_DanhSachHSBA : Form
    {
        public static OracleConnection conn = DangNhap.OracleConnect();
        public CSYT_DanhSachHSBA()
        {
            InitializeComponent();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

        }

        private void CSYT_DanhSachHSBA_Load(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();

            //cmd.CommandText = "select * from HSBA";
            cmd.CommandText = "select MAHSBA, MABN, NGAY, CHUANDOAN, MABS, MAKHOA, MACSYT, KETLUAN from QTV.HSBA";

            cmd.Connection = conn;

            try
            {

                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
