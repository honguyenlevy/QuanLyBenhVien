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
    public partial class Admin_ThongTinQuyen : Form
    {
        public static OracleConnection conn = DangNhap.OracleConnect();
        public Admin_ThongTinQuyen()
        {
            InitializeComponent();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        private void Admin_ThongTinQuyen_Load(object sender, EventArgs e)
        {

            OracleCommand cmd = new OracleCommand();
            //cmd.CommandText = "SELECT grantee,owner,table_name,privilege,grantable FROM Dba_tab_privs";
            cmd.CommandText = "select grantee,owner,table_name,privilege,grantable from Dba_tab_privs where owner='QTV'";

            //cmd.CommandText = "select grantee,table_name,column_name ,privilege,grantable from Dba_col_privs ";
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            switch (checkBox1.CheckState)
            {
                case CheckState.Checked:


                    cmd.CommandText ="select grantee, table_name, column_name, privilege, grantable from Dba_col_privs ";

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
                    break;
                case CheckState.Unchecked:

                    OracleCommand cmd1 = new OracleCommand();
                    cmd1.CommandText = "SELECT grantee,owner,table_name,privilege,grantable FROM Dba_tab_privs where owner='QTV'";

                    cmd1.Connection = conn;

                    try
                    {

                        cmd1.ExecuteNonQuery();
                        OracleDataAdapter da = new OracleDataAdapter(cmd1);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case CheckState.Indeterminate:

                    OracleCommand cmd2 = new OracleCommand();
                    cmd2.CommandText = "SELECT grantee,owner,table_name,privilege,grantable FROM Dba_tab_privs where owner ='QTV'";

                    cmd2.Connection = conn;

                    try
                    {

                        cmd2.ExecuteNonQuery();
                        OracleDataAdapter da = new OracleDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
   }

