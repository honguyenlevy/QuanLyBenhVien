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
    public partial class DangNhap : Form
    {
        private Form activeForm;

        public static string Username, Password;

        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void OpenForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }
        public static string OracleConnectionString(string Username, string Password)
        {
           
           return "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE)));Password=" + Password + ";User ID=" + Username;
            
        }
        public static OracleConnection OracleConnect()
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = OracleConnectionString(Username, Password);
            return conn;
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            Username = textUsername.Text;
            Password = textPassword.Text;
            OracleConnection conn = OracleConnect();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
               
                OpenForm(new Admin_Menu(), sender);
            }
            catch
            {
                MessageBox.Show("Sai mật khẩu hoặc password !", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}
