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
    public partial class Admin_ThuQuyen_RoleUser : Form
    {
        public static OracleConnection conn = DangNhap.OracleConnect();
        public Admin_ThuQuyen_RoleUser()
        {
            InitializeComponent();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        private void Admin_ThuQuyen_RoleUser_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "select granted_role  from dba_role_privs connect by prior granted_role = grantee start with grantee = '" + comboBoxUser.SelectedValue+"'";
            cmd.Connection = conn;
            try
            {
               
                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridRole.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridRole.CurrentRow != null && dataGridRole.CurrentRow.Index > -1)
            {
                string value1 = dataGridRole.CurrentRow.Cells[0].Value != null ? dataGridRole.CurrentRow.Cells[0].Value.ToString() : "";
               
                textBoxRole.Text = value1;
                
            }
        }

        private void btnRevoke_Click(object sender, EventArgs e)
        {
            if (textBoxRole.Text == " ")
            {
                MessageBox.Show("Chọn quyền muốn revoke trước ");
            }


           
            OracleCommand cmd = new OracleCommand();

           string  Revoke ="Revoke " + textBoxRole.Text +  " from  " + comboBoxUser.SelectedValue ;


          
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            
           


            cmd.CommandText = Revoke;
            MessageBox.Show(cmd.CommandText);
            try
            {

                cmd.ExecuteNonQuery();
                MessageBox.Show("Revoke thành công!");
                textBoxRole.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
