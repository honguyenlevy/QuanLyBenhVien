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
    public partial class Admin_ThuQuyen_User : Form
    {
        public static OracleConnection conn = DangNhap.OracleConnect();
        public Admin_ThuQuyen_User()
        {
            InitializeComponent();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        private void Admin_ThuQuyen_User_Load(object sender, EventArgs e)
        {
            
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "SELECT username FROM Dba_users order by created desc";

            cmd.Connection = conn;

            try
            {
                
                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBoxUser.DataSource = dt;
                comboBoxUser.DisplayMember = dt.Columns[0].ColumnName;
                comboBoxUser.ValueMember = dt.Columns[0].ColumnName;
                comboBoxUser.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            // select * from dba_tab_privs  where grantee = '&USER' or grantee in (select granted_role from dba_role_privs connect by prior granted_role = grantee start with grantee = '&USER')
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxUser.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn user trước ");
                comboBoxUser.Focus();
            }
            else
            {
               
                OracleCommand cmd = new OracleCommand();


                //cmd.CommandText = "select grantee,table_name,privilege,grantable,type from dba_tab_privs  where grantee = '" + comboBoxUser.SelectedValue + "'";
                cmd.CommandText = "select grantee,table_name,privilege,grantor,grantable,type from dba_tab_privs  where grantee = '" + comboBoxUser.SelectedValue + "' or grantee in (select granted_role from dba_role_privs connect by prior granted_role = grantee start with grantee = '" + comboBoxUser.SelectedValue + "')";
                cmd.Connection = conn;
                try
                {
                    
                    cmd.ExecuteNonQuery();
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridPriv.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridPriv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridPriv.CurrentRow != null && dataGridPriv.CurrentRow.Index > -1)
            {
                string value1 = dataGridPriv.CurrentRow.Cells[2].Value != null ? dataGridPriv.CurrentRow.Cells[2].Value.ToString() : "";
                string value2= dataGridPriv.CurrentRow.Cells[1].Value != null ? dataGridPriv.CurrentRow.Cells[1].Value.ToString() : "";
                textPriv.Text = value1;
                textBoxObject.Text = value2;
            }
        }

        private void textObject_Click(object sender, EventArgs e)
        {

        }

        private void btnRevoke_Click(object sender, EventArgs e)
        {

            if(textPriv.Text==" ")
            {
                MessageBox.Show("Chọn quyền muốn revoke trước ");
            }
            

            string Revoke = "Revoke ";
            
            OracleCommand cmd = new OracleCommand();

            Revoke += textPriv.Text + " on QTV." + textBoxObject.Text + " from  " + comboBoxUser.SelectedValue;


            cmd.CommandText = "alter session set \"_ORACLE_SCRIPT\"=true";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();

            
            cmd.CommandText = Revoke;
            try
            {

                cmd.ExecuteNonQuery();
                MessageBox.Show("Revoke thành công!");
                textPriv.Text = "";
                textBoxObject.Text = "";
                cmd.CommandText = "select grantee,table_name,privilege,grantable,type from dba_tab_privs  where grantee = '" + comboBoxUser.SelectedValue + "' or grantee in (select granted_role from dba_role_privs connect by prior granted_role = grantee start with grantee = '" + comboBoxUser.SelectedValue + "')";
                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridPriv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
