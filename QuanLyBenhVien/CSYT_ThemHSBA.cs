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
    public partial class CSYT_ThemHSBA : Form
    {
        public static OracleConnection conn = DangNhap.OracleConnect();
        public CSYT_ThemHSBA()
        {
            InitializeComponent();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        private void CSYT_ThemHSBA_Load(object sender, EventArgs e)
        {

            comboBoxMaKhoa.DisplayMember = "Text";
            comboBoxMaKhoa.ValueMember = "Value";

            comboBoxMaKhoa.Items.Add(new { Text = "NOI", Value = "NOI" });
            comboBoxMaKhoa.Items.Add(new { Text = "NHI", Value = "NHI" });
            comboBoxMaKhoa.Items.Add(new { Text = "SAN", Value = "SAN" });
            comboBoxMaKhoa.Items.Add(new { Text = "TIM MACH", Value = "TIM MACH" });
            comboBoxMaKhoa.Items.Add(new { Text = "NGOAI", Value = "NGOAI" });
            comboBoxMaKhoa.Items.Add(new { Text = "DINH DUONG", Value = "DINH DUONG" });
            comboBoxMaKhoa.Items.Add(new { Text = "HOI SUC", Value = "HOI SUC" });

            OracleCommand cmd = new OracleCommand();


            cmd.CommandText = " SELECT SYS_CONTEXT('USERENV', 'SESSION_USER')  FROM DUAL";


            cmd.Connection = conn;

            try
            {

                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                textBoxMaCSYT.Text = dt.Rows[0][0].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void buttonTao_Click(object sender, EventArgs e)
        {
            string sql;
            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;
            string ngay = "TO_DATE('" + dateTimePickerNgay.Text + "', 'mm/dd/yyyy')";

            sql = "INSERT INTO qtv.HSBA(MAHSBA,MABN,NGAY,CHUANDOAN,MABS,MAKHOA,MACSYT,KETLUAN) VALUES ( '" + textBoxMaHSBA.Text + "','" + textBoxMaBenhNhan.Text + "'," + ngay + ",'" + richTextBoxChuanDoan.Text + "','" + textBoxMaBacSi.Text +"','" + comboBoxMaKhoa.Text+ "','" + textBoxMaCSYT.Text+"','" + richTextBoxKetLuan.Text+"')";

            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
          

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("THÊM HỒ SƠ BỆNH ÁN THÀNH CÔNG");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
