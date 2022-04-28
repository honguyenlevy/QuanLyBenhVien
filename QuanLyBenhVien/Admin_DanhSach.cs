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
    public partial class Admin_DanhSach : Form
    {
        public static OracleConnection conn = DangNhap.OracleConnect();
        public Admin_DanhSach()
        {
            InitializeComponent();
            if (conn.State != ConnectionState.Open)
            {
               conn.Open();
            }

        }

        private void Admin_DanhSach_Load(object sender, EventArgs e)
        {
            


            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "select username, account_status,default_tablespace,created,authentication_type,last_login from dba_users where created > TO_DATE('20220320', 'yyyymmdd')";
            //cmd.CommandText = "select username, account_status,default_tablespace,created,authentication_type from dba_users ";
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

        private void dataGridViewDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
