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

  
    public partial class Admin_Audit : Form
    {
        public static OracleConnection conn = DangNhap.OracleConnect();
        public Admin_Audit()
        {
            InitializeComponent();

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        private void dataGridViewAudit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Admin_Audit_Load(object sender, EventArgs e)
        {

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText =" select username, owner, obj_name, action_name, extended_timestamp, sql_text from dba_audit_trail";


            cmd.Connection = conn;

            try
            {

                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewAudit.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
