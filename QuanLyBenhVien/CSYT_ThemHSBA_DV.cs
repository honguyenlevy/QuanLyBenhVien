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
    public partial class CSYT_ThemHSBA_DV : Form
    {
        public static OracleConnection conn = DangNhap.OracleConnect();
        public CSYT_ThemHSBA_DV()
        {
            InitializeComponent();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        private void CSYT_ThemHSBA_DV_Load(object sender, EventArgs e)
        {
            comboBoxMaDV.DisplayMember = "Text";
            comboBoxMaDV.ValueMember = "Value";

            comboBoxMaDV.Items.Add(new { Text = "SIEU AM", Value = "SIEU AM" });
            comboBoxMaDV.Items.Add(new { Text = "DO HUYET AP", Value = "DO HUYET AP" });
            comboBoxMaDV.Items.Add(new { Text = "DO DIEN TIM", Value = "DO DIEN TIM" });
            comboBoxMaDV.Items.Add(new { Text = "THU MAU", Value = "THU MAU" });
        }

        private void buttonTao_Click(object sender, EventArgs e)
        {
            string sql;
            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;
            string ngay = "TO_DATE('" + dateTimePickerNgay.Text + "', 'mm/dd/yyyy')";

            sql = "INSERT INTO qtv.HSBA_DV(MAHSBA, MADV, NGAY, MAKTV, KETQUA) VALUES ( '" + textBoxMaHSBA.Text + "','" + comboBoxMaDV.Text + "'," + ngay + ",'" + textBoxMaKTV.Text + "','" + richTextBoxKetQua.Text + "')";

            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            MessageBox.Show(sql);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("THÊM HỒ SƠ BỆNH ÁN DỊCH VỤ THÀNH CÔNG");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
