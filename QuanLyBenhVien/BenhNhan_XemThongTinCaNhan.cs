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
    public partial class BenhNhan_XemThongTinCaNhan : Form
    {
        public static OracleConnection conn = DangNhap.OracleConnect();

        public BenhNhan_XemThongTinCaNhan()
        {
            InitializeComponent();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        private void BenhNhan_XemThongTinCaNhan_Load(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();

           
            cmd.CommandText = "select * from benhnhan";
            cmd.Connection = conn;

            try
            {

                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewThongTinCaNha.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewThongTinCaNha_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewThongTinCaNha.CurrentRow != null && dataGridViewThongTinCaNha.CurrentRow.Index > -1)
            {
                textBoxMaBN.Text= dataGridViewThongTinCaNha.CurrentRow.Cells[0].Value != null ? dataGridViewThongTinCaNha.CurrentRow.Cells[0].Value.ToString() : "";
                textBoxMaCSYT.Text = dataGridViewThongTinCaNha.CurrentRow.Cells[1].Value != null ? dataGridViewThongTinCaNha.CurrentRow.Cells[1].Value.ToString() : "";
                textBoxTenBN .Text= dataGridViewThongTinCaNha.CurrentRow.Cells[2].Value != null ? dataGridViewThongTinCaNha.CurrentRow.Cells[2].Value.ToString() : "";
                textBoxCMND.Text= dataGridViewThongTinCaNha.CurrentRow.Cells[3].Value != null ? dataGridViewThongTinCaNha.CurrentRow.Cells[3].Value.ToString() : "";
                dateTimePicker1.Text= dataGridViewThongTinCaNha.CurrentRow.Cells[4].Value != null ? dataGridViewThongTinCaNha.CurrentRow.Cells[4].Value.ToString() : "";
                textBoxSoNha.Text= dataGridViewThongTinCaNha.CurrentRow.Cells[5].Value != null ? dataGridViewThongTinCaNha.CurrentRow.Cells[5].Value.ToString() : "";
                textBoxTenDuong.Text = dataGridViewThongTinCaNha.CurrentRow.Cells[6].Value != null ? dataGridViewThongTinCaNha.CurrentRow.Cells[6].Value.ToString() : "";
                textBoxQuanHuyen.Text = dataGridViewThongTinCaNha.CurrentRow.Cells[7].Value != null ? dataGridViewThongTinCaNha.CurrentRow.Cells[7].Value.ToString() : "";
                textBoxTinh.Text= dataGridViewThongTinCaNha.CurrentRow.Cells[8].Value != null ? dataGridViewThongTinCaNha.CurrentRow.Cells[8].Value.ToString() : "";
                richTextBoxTSB.Text= dataGridViewThongTinCaNha.CurrentRow.Cells[9].Value != null ? dataGridViewThongTinCaNha.CurrentRow.Cells[9].Value.ToString() : "";
                richTextBoxTSBGD.Text= dataGridViewThongTinCaNha.CurrentRow.Cells[10].Value != null ? dataGridViewThongTinCaNha.CurrentRow.Cells[10].Value.ToString() : "";
            }
        }
    }
}
