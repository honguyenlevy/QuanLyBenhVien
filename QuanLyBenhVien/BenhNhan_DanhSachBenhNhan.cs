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
    public partial class BenhNhan_DanhSachBenhNhan : Form
    {
        public static OracleConnection conn = DangNhap.OracleConnect();
        private Form activeForm;
        public BenhNhan_DanhSachBenhNhan()
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
            this.tableLayoutPanelDSBN.Controls.Add(childForm);
            this.tableLayoutPanelDSBN.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonXemCTTT_Click(object sender, EventArgs e)
        {
            OpenFormAdmin(new BenhNhan_XemThongTinCaNhan(), sender);
        }

        private void BenhNhan_DanhSachBenhNhan_Load(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();


            cmd.CommandText = "select * from qtv.benhnhan";
            cmd.Connection = conn;

            try
            {

                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewList.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
