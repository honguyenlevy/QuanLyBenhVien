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
    public partial class BacSi_XemThongTinBenhNhan : Form
    {
        public static OracleConnection conn = DangNhap.OracleConnect();
        public BacSi_XemThongTinBenhNhan()
        {

            InitializeComponent();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            
            //cmd.CommandText = "select username, account_status,default_tablespace,created,authentication_type from dba_users ";
             cmd.CommandText = "select * from hsba where mabn = " + textBoxMaBenhNhan.Text;
            cmd.Connection = conn;

            try
            {

                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewDAHSBA.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridViewDAHSBA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
