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
using QuanLyBenhVien.Controller;
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
            textPassword.Text = "";
            textUsername.Text = "";
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
            string check = Username.Substring(0, 2);

            check=check.ToUpper();

            OracleConnection conn = OracleConnect();

           
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    textUsername.Text = "";
                    textPassword.Text = "";

                    if (check == "QT")
                    {
                        OpenForm(new Admin_Menu(), sender);

                        //OpenForm(new ThanhTra(), sender);


                    }
                    else if (check == "NV")
                    {          
                        string role = LayRole.LayThongTinRole(Username);
                        
                        if (role == "THANH TRA")
                        {
                            OpenForm(new ThanhTra(), sender);
                        }
                        else if (role == "CO SO Y TE")
                        {
                            OpenForm(new CoSoYTe(), sender);
                        }
                        else if (role == "Y/BAC SI")
                        {
                            OpenForm(new BacSi(), sender);
                        }
                        else if (role == "NGHIEN CUU")
                        {
                            OpenForm(new NghienCuu(), sender);
                        }
                    }
                    else if (check == "BN")
                    {
                        //OpenForm(new BenhNhan_DanhSachBenhNhan(), sender);

                        OpenForm(new BenhNhan_XemThongTinCaNhan(), sender);
                    }

                }


                
            }
            catch
            {
                MessageBox.Show("Sai mật khẩu hoặc password  !", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }

}
