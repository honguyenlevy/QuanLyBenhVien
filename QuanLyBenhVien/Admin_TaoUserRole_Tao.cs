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
    public partial class Admin_TaoUserRole_Tao : Form
    {
        public static OracleConnection conn = DangNhap.OracleConnect();
        public Admin_TaoUserRole_Tao()
        {
            InitializeComponent();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        
        private void Admin_TaoUserRole_Tao_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Tao_Click(object sender, EventArgs e)
        {
            bool check = true;
            OracleCommand cmd = new OracleCommand();
            if (textUsername.Text.Trim().Length < 2)
            {
                MessageBox.Show("USER/ROLE MUST HAVE MORE THAN 1 CHARACTERS", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = textUsername;
                check = false;

            }

            if (textPassword.Text.Trim().Length < 4)
            {
                MessageBox.Show("PASSWORD MUST HAVE MORE THAN 3 CHARACTERS", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = textPassword;
                check = false;

            }

            if (textPassword.Text != textConfirmPassword.Text)
            {
                MessageBox.Show("CONFIRMATION PASSWORD IS FAILED !", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = textConfirmPassword;
                check = false;

            }

            if (check)
            {

                string userCreate;


                switch (checkBoxRole.CheckState)
                {
                    case CheckState.Unchecked:

                        cmd.CommandText = "alter session set \"_ORACLE_SCRIPT\"=true";
                        cmd.CommandType = CommandType.Text;

                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();

                        userCreate = "  create user " + textUsername.Text + " identified by " + textPassword.Text;
                        cmd.CommandText = userCreate;

                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("CREATE USER SUCCESSFULLY!");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;
                    case CheckState.Checked:
                        cmd.CommandText = "alter session set \"_ORACLE_SCRIPT\"=true";
                        cmd.CommandType = CommandType.Text;

                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();

                        userCreate = "  create role " + textUsername.Text + " identified by " + textPassword.Text;

                        cmd.CommandText = userCreate;


                        try
                        {

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("CREATE ROLE SUCCESFULLY");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;

                }

            }
        }

        private void checkBoxRole_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    
}
