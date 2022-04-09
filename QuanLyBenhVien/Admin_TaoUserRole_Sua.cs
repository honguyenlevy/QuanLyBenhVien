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
    public partial class Admin_TaoUserRole_Sua : Form
    {
        public static OracleConnection conn = DangNhap.OracleConnect();
        public Admin_TaoUserRole_Sua()
        {
            InitializeComponent();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Admin_TaoUserRole_Sua_Load(object sender, EventArgs e)
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
                dataGridViewAlter.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewAlter.CurrentRow != null && dataGridViewAlter.CurrentRow.Index > -1)
            {
                string value1 = dataGridViewAlter.CurrentRow.Cells[0].Value != null ? dataGridViewAlter.CurrentRow.Cells[0].Value.ToString() : "";
                textUsername.Text = value1;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("YOUR USER'S PASSWORD WILL BE MODIFIED", "DO YOU WANT TO SAVE ?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
                OracleCommand cmd = new OracleCommand();
                if (textUsername.Text.Trim().Length < 2)
                {
                    MessageBox.Show("ROLE/USER MUST HAVE MORE THAN 1 CHARACTERS!", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.ActiveControl = textUsername;
                }

                if (textPassword.Text.Trim().Length < 4)
                {
                    MessageBox.Show("Password MUST HAVE MORE THAN 3 CHARACTERS", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.ActiveControl = textPassword;
                }

                if (textPassword.Text != textConfirmPassword.Text)
                {
                    MessageBox.Show("COMFIRMATION PASSWORD FAIL !", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.ActiveControl = textConfirmPassword;
                }

                string userCreate;
                cmd.CommandText = "alter session set \"_ORACLE_SCRIPT\"=true";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

                userCreate = "  alter user " + textUsername.Text + " identified by " + textPassword.Text;
                cmd.CommandText = userCreate;
               

                try
                {
                   
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ALTER SUCCESSFULLY");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //MessageBox.Show("Không thay đổi!");
            }
            
                    

            }
        }
    }

