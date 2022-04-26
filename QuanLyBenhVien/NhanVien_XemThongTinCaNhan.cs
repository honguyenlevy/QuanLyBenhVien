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
    public partial class NhanVien_XemThongTinCaNhan : Form
    {
        public static OracleConnection conn = DangNhap.OracleConnect();
        public NhanVien_XemThongTinCaNhan()
        {
            InitializeComponent();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        private void NhanVien_XemThongTinCaNhan_Load(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();


            cmd.CommandText = "select * from nhanvien";
            cmd.Connection = conn;

            try
            {

                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewTTCaNhan.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewTTCaNhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewTTCaNhan.CurrentRow != null && dataGridViewTTCaNhan.CurrentRow.Index > -1)
            {
                textBoxMaNV.Text = dataGridViewTTCaNhan.CurrentRow.Cells[0].Value != null ? dataGridViewTTCaNhan.CurrentRow.Cells[0].Value.ToString() : "";
                textBoxHoTen.Text = dataGridViewTTCaNhan.CurrentRow.Cells[1].Value != null ? dataGridViewTTCaNhan.CurrentRow.Cells[1].Value.ToString() : "";
                string Phai = dataGridViewTTCaNhan.CurrentRow.Cells[2].Value != null ? dataGridViewTTCaNhan.CurrentRow.Cells[2].Value.ToString() : "";
                dateTimePicker1.Text = dataGridViewTTCaNhan.CurrentRow.Cells[3].Value != null ? dataGridViewTTCaNhan.CurrentRow.Cells[3].Value.ToString() : "";
                textBoxCMND.Text = dataGridViewTTCaNhan.CurrentRow.Cells[4].Value != null ? dataGridViewTTCaNhan.CurrentRow.Cells[4].Value.ToString() : "";
                textBoxQueQuan.Text = dataGridViewTTCaNhan.CurrentRow.Cells[5].Value != null ? dataGridViewTTCaNhan.CurrentRow.Cells[5].Value.ToString() : "";
                textBoxSDT.Text = dataGridViewTTCaNhan.CurrentRow.Cells[6].Value != null ? dataGridViewTTCaNhan.CurrentRow.Cells[6].Value.ToString() : "";
                comboBoxCSYT.Text = dataGridViewTTCaNhan.CurrentRow.Cells[7].Value != null ? dataGridViewTTCaNhan.CurrentRow.Cells[7].Value.ToString() : "";
                comboBoxVaiTro.Text = dataGridViewTTCaNhan.CurrentRow.Cells[8].Value != null ? dataGridViewTTCaNhan.CurrentRow.Cells[8].Value.ToString() : "";
                comboBoxChuyenKhoa.Text = dataGridViewTTCaNhan.CurrentRow.Cells[9].Value != null ? dataGridViewTTCaNhan.CurrentRow.Cells[9].Value.ToString() : "";
                if (Phai == "Nam")
                    radioButtonNam.Checked = true;
                else radioButtonNu.Checked = true;
            }
        }
    }
}
