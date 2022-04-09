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
    public partial class Admin_TaoUserRole_Xoa : Form
    {
        public static OracleConnection conn = DangNhap.OracleConnect();
        public Admin_TaoUserRole_Xoa()
        {
            InitializeComponent();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        private void Admin_TaoUserRole_Xoa_Load(object sender, EventArgs e)
        {
           
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "select username, account_status,default_tablespace,created,authentication_type,last_login from dba_users where created > TO_DATE('20220320', 'yyyymmdd')";

            cmd.Connection = conn;

            try
            {
               
                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewXoaUserRole.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void Role_CheckedChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            switch (checkBoxRole.CheckState)
            {
                case CheckState.Checked:
                    
                  
                    cmd.CommandText = "SELECT role,role_id,password_required,authentication_type FROM Dba_roles order by role_id desc";

                    cmd.Connection = conn;

                    try
                    {
                       
                        cmd.ExecuteNonQuery();
                        OracleDataAdapter da = new OracleDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridViewXoaUserRole.DataSource = dt;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case CheckState.Unchecked:
                    
                    OracleCommand cmd1 = new OracleCommand();
                    cmd1.CommandText = "select username, account_status,default_tablespace,created,authentication_type,last_login from dba_users where created > TO_DATE('20220320', 'yyyymmdd')";

                    cmd1.Connection = conn;

                    try
                    {
                        
                        cmd1.ExecuteNonQuery();
                        OracleDataAdapter da = new OracleDataAdapter(cmd1);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridViewXoaUserRole.DataSource = dt;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case CheckState.Indeterminate:
                  
                    OracleCommand cmd2 = new OracleCommand();
                    cmd2.CommandText = "select username, account_status,default_tablespace,created,authentication_type,last_login from dba_users where created > TO_DATE('20220320', 'yyyymmdd')";

                    cmd2.Connection = conn;

                    try
                    {
                        
                        cmd2.ExecuteNonQuery();
                        OracleDataAdapter da = new OracleDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridViewXoaUserRole.DataSource = dt;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("User/Role WILL BE REMOVED", "DO YOU WANT TO DROP ?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string dropUserRole = "drop ";

                OracleCommand cmd = new OracleCommand();
                switch (checkBoxRole.CheckState)
                {
                    case CheckState.Unchecked:
                        dropUserRole += " user ";
                        break;
                    case CheckState.Checked:
                        dropUserRole += " role ";
                        break;

                }
                dropUserRole += textSelectedUserRole.Text  ;
                cmd.CommandText = "alter session set \"_ORACLE_SCRIPT\"=true";
                cmd.CommandType = CommandType.Text;

                cmd.Connection = conn;
                cmd.ExecuteNonQuery();


                cmd.CommandText = dropUserRole;
                try
                {

                    cmd.ExecuteNonQuery();
                    if (checkBoxRole.CheckState == CheckState.Unchecked)
                        MessageBox.Show("DROP USER SUCCESFULLY!");
                    else
                        MessageBox.Show("DROP ROLE SUCCESFULLY!");


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (checkBoxRole.CheckState == CheckState.Unchecked)
                {
                    cmd.CommandText = "select username, account_status,default_tablespace,created,authentication_type,last_login from dba_users where created > TO_DATE('20220320', 'yyyymmdd')";
                }
                else
                    cmd.CommandText = "SELECT role,role_id,password_required,authentication_type FROM Dba_roles order by role_id desc";
                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewXoaUserRole.DataSource = dt;
            }
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewXoaUserRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewXoaUserRole.CurrentRow != null && dataGridViewXoaUserRole.CurrentRow.Index > -1)
            {
                string value1 = dataGridViewXoaUserRole.CurrentRow.Cells[0].Value != null ? dataGridViewXoaUserRole.CurrentRow.Cells[0].Value.ToString() : "";
                textSelectedUserRole.Text = value1;
            }
        }
    }
}
