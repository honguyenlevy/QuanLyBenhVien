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
    public partial class Admin_CapQuyen_RoleUser : Form
    {
        public static OracleConnection conn = DangNhap.OracleConnect();
        public Admin_CapQuyen_RoleUser()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string withgrantoption = "";

            switch (checkBoxWithGrantOption.CheckState)
            {
                case CheckState.Unchecked:

                    withgrantoption = "";
                    break;
                case CheckState.Checked:
                    withgrantoption += " with admin option  " + "\n";
                    break;
                case CheckState.Indeterminate:
                    withgrantoption = "";
                    break;
            }
            
            OracleCommand cmd = new OracleCommand();

            cmd.CommandText = "grant " + comboBoxRole.SelectedValue + " to " + comboBoxUser.SelectedValue + withgrantoption;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
           

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("GRANT ROLE SUCCESSFULLY");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxColumn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Admin_CapQuyen_RoleUser_Load(object sender, EventArgs e)
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
    }
}
