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
    public partial class Admin_TaoCSYT : Form
    {
        private Form activeForm;
        public static OracleConnection conn = DangNhap.OracleConnect();
        public Admin_TaoCSYT()
        {
            InitializeComponent();
           
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

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
            this.tableLayoutPanelTaoCSYT.Controls.Add(childForm);
            this.tableLayoutPanelTaoCSYT.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonTao_Click(object sender, EventArgs e)
        {
            bool check = true;
            OracleCommand cmd = new OracleCommand();
            if (textBoxMa.Text.Trim().Length < 2)
            {
                MessageBox.Show("MÃ CƠ SỞ Y TẾ PHẢI CÓ IT NHẤT 5 KÍ TỰ", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = textBoxMa;
                check = false;

            }
            if (textBoxTen.Text.Trim().Length < 2)
            {
                MessageBox.Show("TÊN CƠ SỞ Y TẾ PHẢI CÓ ÍT NHẤT 2 KÍ TỰ ", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = textBoxTen;
                check = false;

            }

            if (textBoxDiaChi.Text.Trim().Length < 2)
            {
                MessageBox.Show("ĐỊA CHỈ CƠ SỞ Y TẾ PHẢI CÓ ÍT NHẤT 2 KÍ TỰ ", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = textBoxDiaChi;
                check = false;

            }

            if (textBoxSDT.Text.Trim().Length < 10)
            {
                MessageBox.Show("SỐ ĐIỆN THOẠI CƠ SỞ Y TẾ PHẢI CÓ ÍT NHẤT 10 SỐ ", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = textBoxSDT;
                check = false;

            }
            if (check)
            {
                        string sql;
                       
                        cmd.Connection = conn;


                sql = "INSERT INTO qtv.CSYT VALUES ( '" + textBoxMa.Text + "','" + textBoxTen.Text + "','" + textBoxDiaChi.Text + "','" + textBoxSDT.Text + "')";
               
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                MessageBox.Show(sql);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("THÊM CƠ SỞ Y TẾ THÀNH CÔNG");

                    // tạo tài khoản cho csyt
                    // gán role csyt cho tài khoản

                    string userCreate;

                    cmd.CommandText = "alter session set \"_ORACLE_SCRIPT\"=true";
                    cmd.CommandType = CommandType.Text;

                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();

                    userCreate = "  create user " + textBoxMa.Text + " identified by 1  ";
                    cmd.CommandText = userCreate;

                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "grant  ROLE_CSYT  to " + textBoxMa.Text;

                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



            }
            }

        private void buttonListCSYT_Click(object sender, EventArgs e)
        {
            OpenFormAdmin(new Admin_SuaCSYT(), sender);
        }

        private void Admin_TaoCSYT_Load(object sender, EventArgs e)
        {
            Random _r = new Random();
            int number = _r.Next() % 50 + 50;

            textBoxMa.Text = "CS" + String.Format("{0:D5}", number);
        }
    }
}
