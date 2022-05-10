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

            radioButtonStandard.Checked = true;
        }

        private void radioButtonFineGrained_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFineGrained.Checked == true)
            {
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "SELECT DB_USER,OBJECT_NAME,SQL_TEXT,EXTENDED_TIMESTAMP FROM dba_fga_audit_trail order by extended_timestamp desc ";

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

        private void radioButtonStandard_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonStandard.Checked == true)
            {
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = " select USERNAME,OBJ_NAME,SQL_TEXT ,EXTENDED_TIMESTAMP from dba_audit_trail order by extended_timestamp desc ";

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
}
