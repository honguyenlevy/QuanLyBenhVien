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
    public partial class NghienCuu_XemDanhSach : Form
    {
        public static OracleConnection conn = DangNhap.OracleConnect();
        public NghienCuu_XemDanhSach()
        {
            InitializeComponent();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        private void dataGridViewList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NghienCuu_XemDanhSach_Load(object sender, EventArgs e)
        {
            radioButtonHSBA.Checked = true;
        }

        private void radioButtonHSBADV_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHSBADV.Checked == true)
            {
                OracleCommand cmd = new OracleCommand();


                //cmd.CommandText = "select * from HSBA_DV ";
                cmd.CommandText = "select MAHSBA, MADV, NGAY, MAKTV, KETQUA from HSBA_DV ";

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

        private void radioButtonHSBA_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButtonHSBA.Checked == true)
            {
                OracleCommand cmd = new OracleCommand();


                //cmd.CommandText = "select * from HSBA ";
                cmd.CommandText = "select MAHSBA, MABN, NGAY, CHUANDOAN, MABS, MAKHOA, MACSYT, KETLUAN from HSBA ";

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
}
