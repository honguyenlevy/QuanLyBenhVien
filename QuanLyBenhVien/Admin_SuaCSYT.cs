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
    public partial class Admin_SuaCSYT : Form
    {

        public static OracleConnection conn = DangNhap.OracleConnect();
        public Admin_SuaCSYT()
        {
            InitializeComponent();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        private void Admin_SuaCSYT_Load(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "select macsyt,tencsyt,dccsyt,sdtcsyt from qtv.csyt ";
            
            cmd.Connection = conn;

            try
            {

                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewListCSYT.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewListCSYT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewListCSYT.CurrentRow != null && dataGridViewListCSYT.CurrentRow.Index > -1)
            {
                textBoxMa.Text = dataGridViewListCSYT.CurrentRow.Cells[0].Value != null ? dataGridViewListCSYT.CurrentRow.Cells[0].Value.ToString() : "";
                textBoxTen.Text = dataGridViewListCSYT.CurrentRow.Cells[1].Value != null ? dataGridViewListCSYT.CurrentRow.Cells[1].Value.ToString() : "";
                textBoxDiaChi.Text = dataGridViewListCSYT.CurrentRow.Cells[2].Value != null ? dataGridViewListCSYT.CurrentRow.Cells[2].Value.ToString() : "";
                textBoxSDT.Text = dataGridViewListCSYT.CurrentRow.Cells[3].Value != null ? dataGridViewListCSYT.CurrentRow.Cells[3].Value.ToString() : "";
            }

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            string sql;
            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;
           



            sql = "UPDATE qtv.CSYT  SET  TENCSYT = '" + textBoxTen.Text + "' , DCCSYT = '" + textBoxDiaChi.Text + "' ,SDTCSYT = " + textBoxSDT.Text + 
                 " WHERE MACSYT = '" + textBoxMa.Text + "'";


            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("CẬP NHẬT THÔNG TIN CƠ SỞ Y TẾ THÀNH CÔNG");


                cmd.CommandText = "select macsyt,tencsyt,dccsyt,sdtcsyt from qtv.csyt ";

                       
                    cmd.ExecuteNonQuery();
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewListCSYT.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
