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

  
    public partial class Admin_CapQuyen : Form
    {
        public static OracleConnection conn = DangNhap.OracleConnect();
        public Admin_CapQuyen()
        {
            InitializeComponent();
        }

        private Form activeForm;
        private void OpenFormAdmin(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelCapQuyen.Controls.Add(childForm);
            this.panelCapQuyen.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //OracleConnection conn = new OracleConnection();
            //conn.ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE)));Password=334957777Lh;User ID=system";
            //OracleCommand cmd = new OracleCommand();
            //cmd.CommandText = "SELECT username FROM Dba_users order by created desc";

            //cmd.Connection = conn;

            //try
            //{
            //    conn.Open();
            //    cmd.ExecuteNonQuery();
            //    OracleDataAdapter da = new OracleDataAdapter(cmd);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    comboBoxUser.DataSource = dt;
            //    comboBoxUser.DisplayMember = dt.Columns[0].ColumnName;
            //    comboBoxUser.ValueMember = dt.Columns[0].ColumnName;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void Admin_CapQuyen_Load(object sender, EventArgs e)
        {
            //OracleConnection conn = new OracleConnection();
            //conn.ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE)));Password=334957777Lh;User ID=system";
            //OracleCommand cmd = new OracleCommand();
            //cmd.CommandText = "SELECT username FROM Dba_users order by created desc";

            //cmd.Connection = conn;

            //try
            //{
            //    conn.Open();
            //    cmd.ExecuteNonQuery();
            //    OracleDataAdapter da = new OracleDataAdapter(cmd);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    comboBoxUser.DataSource = dt;
            //    comboBoxUser.DisplayMember = dt.Columns[0].ColumnName;
            //    comboBoxUser.ValueMember = dt.Columns[0].ColumnName;
            //    comboBoxUser.SelectedIndex = -1;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}



            //cmd.CommandText = "select table_name from Dba_tables where owner = 'QTV'";
            //cmd.Connection = conn;

            //try
            //{

            //    cmd.ExecuteNonQuery();
            //    OracleDataAdapter da = new OracleDataAdapter(cmd);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    comboBoxTable.DisplayMember = dt.Columns[0].ColumnName;
            //    comboBoxTable.ValueMember = dt.Columns[0].ColumnName;
            //    comboBoxTable.DataSource = dt;
            //    comboBoxTable.SelectedIndex = -1;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}


            //if (comboBoxTable.Text == "")
            //{
            //    comboBoxColumn.SelectedIndex = -1;
            //}



            //cmd.CommandText = "SELECT COLUMN_NAME FROM ALL_TAB_COLUMNS WHERE TABLE_NAME = 'HSBA'";
            //cmd.Connection = conn;

            //try
            //{


            //    cmd.ExecuteNonQuery();
            //    OracleDataAdapter da = new OracleDataAdapter(cmd);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    comboBoxColumn.DataSource = dt;
            //    comboBoxColumn.DisplayMember = dt.Columns[0].ColumnName;
            //    comboBoxColumn.ValueMember = dt.Columns[0].ColumnName;
            //    comboBoxColumn.SelectedIndex = -1;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}


        }

        private void comboBoxTable_SelectedIndexChanged(object sender, EventArgs e)
        {


            //OracleConnection conn = new OracleConnection();
            //conn.ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE)));Password=334957777Lh;User ID=system";
            //OracleCommand cmd = new OracleCommand();


            //cmd.CommandText = "SELECT COLUMN_NAME FROM ALL_TAB_COLUMNS WHERE TABLE_NAME = 'HSBA'";
            //cmd.Connection = conn;

            //try
            //{


            //    cmd.ExecuteNonQuery();
            //    OracleDataAdapter da = new OracleDataAdapter(cmd);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    comboBoxColumn.DataSource = dt;
            //    comboBoxColumn.DisplayMember = dt.Columns[0].ColumnName;
            //    comboBoxColumn.ValueMember = dt.Columns[0].ColumnName;
            //    comboBoxColumn.SelectedIndex = -1;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        //private void btnUser_Click(object sender, EventArgs e)
        //{

        //    btnUser.BackColor = Color.FromArgb(107, 155, 55);

        //    btnRole.BackColor = Color.FromArgb(179, 229, 252);

        //    btnRoleUser.BackColor = Color.FromArgb(179, 229, 252);

        //    OpenFormAdmin(new Admin_CapQuyen_User(), sender);
        //}

        private void btnRole_Click(object sender, EventArgs e)
        {
            btnUser1.BackColor = Color.FromArgb(179, 229, 252);

            btnRole.BackColor = Color.FromArgb(107, 155, 55);

            btnRoleUser.BackColor = Color.FromArgb(179, 229, 252);

            OpenFormAdmin(new Admin_CapQuyen_Role(), sender);
        }

        private void btnRoleUser_Click(object sender, EventArgs e)
        {
            btnUser1.BackColor = Color.FromArgb(179, 229, 252);

            btnRole.BackColor = Color.FromArgb(179, 229, 252);

            btnRoleUser.BackColor = Color.FromArgb(107, 155, 55);

            OpenFormAdmin(new Admin_CapQuyen_RoleUser(), sender);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            btnUser1.BackColor = Color.FromArgb(107, 155, 55);

            btnRole.BackColor = Color.FromArgb(179, 229, 252);

            btnRoleUser.BackColor = Color.FromArgb(179, 229, 252);

            OpenFormAdmin(new Admin_CapQuyen_User(), sender);

        }
    } 
    
}
