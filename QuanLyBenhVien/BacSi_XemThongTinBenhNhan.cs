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
    public partial class BacSi_XemThongTinBenhNhan : Form
    {
        public static OracleConnection conn = DangNhap.OracleConnect();
        public BacSi_XemThongTinBenhNhan()
        {

            InitializeComponent();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();


            cmd.CommandText = "select MABN, MACSYT, TENBN, CMND, NGAYSINH, SONHA, TENDUONG, QUANHUYEN, TINHTP, TIENSUBENH, TIENSUBENHGD, DIUNGTHUOC from QTV.BENHNHAN where TRIM(UPPER(MABN)) = TRIM(UPPER('" + textBoxMaBenhNhan.Text +"')) OR TRIM(UPPER(CMND)) = " + "TRIM(UPPER('" + textBoxMaBenhNhan.Text +"'))";
            //cmd.CommandText = "select MAHSBA, MABN, NGAY, CHUANDOAN, MABS, MAKHOA, MACSYT, KETLUAN from HSBA where mabn = '" + textBoxMaBenhNhan.Text +"'";
            cmd.Connection = conn;

            try
            {

                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewDAHSBA.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridViewDAHSBA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxTenBN.Text = dataGridViewDAHSBA.CurrentRow.Cells[2].Value != null ? dataGridViewDAHSBA.CurrentRow.Cells[2].Value.ToString() : "";
           
            dateTimePicker1.Text = dataGridViewDAHSBA.CurrentRow.Cells[4].Value != null ? dataGridViewDAHSBA.CurrentRow.Cells[4].Value.ToString() : "";
            textBoxCMND.Text = dataGridViewDAHSBA.CurrentRow.Cells[3].Value != null ? dataGridViewDAHSBA.CurrentRow.Cells[3].Value.ToString() : "";
            textBoxTinhTP.Text = dataGridViewDAHSBA.CurrentRow.Cells[8].Value != null ? dataGridViewDAHSBA.CurrentRow.Cells[8].Value.ToString() : "";

            textBoxQuanHuyen.Text = dataGridViewDAHSBA.CurrentRow.Cells[7].Value != null ? dataGridViewDAHSBA.CurrentRow.Cells[7].Value.ToString() : "";

            textBoxTenDuong.Text = dataGridViewDAHSBA.CurrentRow.Cells[6].Value != null ? dataGridViewDAHSBA.CurrentRow.Cells[6].Value.ToString() : "";

            textBoxSoNha.Text = dataGridViewDAHSBA.CurrentRow.Cells[5].Value != null ? dataGridViewDAHSBA.CurrentRow.Cells[5].Value.ToString() : "";


            richTextBoxTSB.Text= dataGridViewDAHSBA.CurrentRow.Cells[8].Value != null ? dataGridViewDAHSBA.CurrentRow.Cells[8].Value.ToString() : "";


            richTextBoxTSBGD.Text= dataGridViewDAHSBA.CurrentRow.Cells[9].Value != null ? dataGridViewDAHSBA.CurrentRow.Cells[9].Value.ToString() : "";
        }

        private void BacSi_XemThongTinBenhNhan_Load(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();


            //cmd.CommandText = "select * from benhnhan";
            cmd.CommandText = "select MABN, MACSYT, TENBN, CMND, NGAYSINH, SONHA, TENDUONG, QUANHUYEN, TINHTP, TIENSUBENH, TIENSUBENHGD, DIUNGTHUOC from QTV.benhnhan";
            cmd.Connection = conn;

            try
            {

                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewDAHSBA.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void textBoxCMND_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonReLoad_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();


            //cmd.CommandText = "select * from benhnhan";
            cmd.CommandText = "select MABN, MACSYT, TENBN, CMND, NGAYSINH, SONHA, TENDUONG, QUANHUYEN, TINHTP, TIENSUBENH, TIENSUBENHGD, DIUNGTHUOC from QTV.benhnhan";
            cmd.Connection = conn;

            try
            {

                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewDAHSBA.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
