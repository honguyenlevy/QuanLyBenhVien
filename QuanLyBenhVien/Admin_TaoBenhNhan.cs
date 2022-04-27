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
    public partial class Admin_TaoBenhNhan : Form
    {
        public static OracleConnection conn = DangNhap.OracleConnect();
        public Admin_TaoBenhNhan()
        {
            InitializeComponent();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

        }

        private void Admin_TaoBenhNhan_Load(object sender, EventArgs e)
        {
            Random _r = new Random();
            int number = _r.Next()%10000+10000;

            textBoxMaBN.Text = "BN" + String.Format("{0:D5}", number);

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            
            cmd.CommandText = "SELECT MACSYT FROM CSYT";
            try
            {

                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBoxCSYT.DataSource = dt;
                comboBoxCSYT.DisplayMember = dt.Columns[0].ColumnName;
                comboBoxCSYT.ValueMember = dt.Columns[0].ColumnName;
                comboBoxCSYT.SelectedIndex = -1;
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

           string ngay = "TO_DATE('" + dateTimePicker1.Text + "', 'mm/dd/yyyy')";
            sql = "INSERT INTO qtv.BENHNHAN VALUES ( '" + textBoxMaBN.Text + "','" + comboBoxCSYT.Text + "','" + textBoxTenBN.Text + "','" +textBoxCMND.Text + "'," + ngay + ", ' "+ textBoxSoNha.Text + "','" 
                + textBoxTenDuong.Text + "','"  + textBoxQuanHuyen.Text + "',' " + textBoxTinhTP.Text + "','" + richTextBoxTSB.Text + "','" + richTextBoxTSBGD.Text + "','" + richTextBoxDiUngThuoc .Text+ "')";

            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            MessageBox.Show(sql);


            //create user nua ne
            // gan role benhnhan cho benhnhan moi dc tao
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("THÊM BỆNH NHÂN THÀNH CÔNG");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
