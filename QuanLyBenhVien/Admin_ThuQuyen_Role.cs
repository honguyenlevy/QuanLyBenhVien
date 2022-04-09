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
    public partial class Admin_ThuQuyen_Role : Form
    {
        public static OracleConnection conn = DangNhap.OracleConnect();
        public Admin_ThuQuyen_Role()
        {
            InitializeComponent();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Admin_ThuQuyen_Role_Load(object sender, EventArgs e)
        {
           
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "SELECT ROLE FROM DBA_ROLES ORDER BY ROLE_ID DESC";

            cmd.Connection = conn;

            try
            {
                

                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBoxRole.DataSource = dt;
                comboBoxRole.DisplayMember = dt.Columns[0].ColumnName;
                comboBoxRole.ValueMember = dt.Columns[0].ColumnName;
                comboBoxRole.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            OracleCommand cmd = new OracleCommand();

            cmd.CommandText = "select grantee,table_name,privilege,grantable,type from dba_tab_privs  where grantee = '" + comboBoxRole.SelectedValue + "' or grantee in (select granted_role from dba_role_privs connect by prior granted_role = grantee start with grantee = '" + comboBoxRole.SelectedValue + "')";

            cmd.Connection = conn;
            try
            {
               
                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridRolePriv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridRolePriv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridRolePriv.CurrentRow != null && dataGridRolePriv.CurrentRow.Index > -1)
            {
                string value1 = dataGridRolePriv.CurrentRow.Cells[2].Value != null ? dataGridRolePriv.CurrentRow.Cells[2].Value.ToString() : "";
                string value2 = dataGridRolePriv.CurrentRow.Cells[1].Value != null ? dataGridRolePriv.CurrentRow.Cells[1].Value.ToString() : "";
                textPriv.Text = value1;
                textBoxObject.Text = value2;
            }
        }

        private void btnRevoke_Click(object sender, EventArgs e)
        {
            if (textPriv.Text == " ")
            {
                MessageBox.Show("Chọn quyền muốn revoke trước ");
            }


            string Revoke = "Revoke ";
           
            OracleCommand cmd = new OracleCommand();

            Revoke += textPriv.Text + " on QTV." + textBoxObject.Text + " from  " + comboBoxRole.SelectedValue;


            cmd.CommandText = "alter session set \"_ORACLE_SCRIPT\"=true";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
           
            cmd.ExecuteNonQuery();


            cmd.CommandText = Revoke;
            try
            {

                cmd.ExecuteNonQuery();
                MessageBox.Show("Revoke thành công!");
                textPriv.Text = "";
                textBoxObject.Text = "";
                cmd.CommandText = "select grantee,table_name,privilege,grantable,type from dba_tab_privs  where grantee = '" + comboBoxRole.SelectedValue + "' or grantee in (select granted_role from dba_role_privs connect by prior granted_role = grantee start with grantee = '" + comboBoxRole.SelectedValue + "')";
                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridRolePriv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
