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
    public partial class ThanhTra_XemThongTin : Form
    {
        public static OracleConnection conn = DangNhap.OracleConnect();
        public ThanhTra_XemThongTin()
        {
            InitializeComponent();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

        }

        private void ThanhTra_XemThongTin_Load(object sender, EventArgs e)
        {
            radioButtonBenhNhan.Checked = true;
        }

        private void radioButtonBenhNhan_CheckedChanged(object sender, EventArgs e)
       {
               if (radioButtonBenhNhan.Checked == true)
                {
                  OracleCommand cmd = new OracleCommand();
                //cmd.CommandText = "select * from qtv.benhnhan ";
                cmd.CommandText = "select MABN, MACSYT, TENBN, CMND, NGAYSINH, SONHA, TENDUONG, QUANHUYEN, TINHTP, TIENSUBENH, TIENSUBENHGD, DIUNGTHUOC from qtv.benhnhan ";
                cmd.Connection = conn;

              try
              {

            cmd.ExecuteNonQuery();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        }
     }

        private void radioButtonNhanVien_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNhanVien.Checked == true)
            {
                OracleCommand cmd = new OracleCommand();
                //cmd.CommandText = "select* from qtv.nhanvien  ";
                //cmd.CommandText = "select MANV, HOTEN, PHAI, NGAYSINH, CMND, QUEQUAN, SODT, CSYT, VAITRO, CHUYENKHOA from qtv.nhanvien  ";
                cmd.CommandText = "select MANV, HOTEN, PHAI, NGAYSINH,  QUEQUAN, SODT, CSYT, VAITRO, CHUYENKHOA from qtv.nhanvien  ";
                cmd.Connection = conn;

                try
                {

                    cmd.ExecuteNonQuery();
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void radioButtonCSYT_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCSYT.Checked == true)
            {
                OracleCommand cmd = new OracleCommand();
                //cmd.CommandText = "select * from qtv.csyt ";
                cmd.CommandText = "select MACSYT, TENCSYT, DCCSYT, SDTCSYT from qtv.csyt ";
                cmd.Connection = conn;

                try
                {

                    cmd.ExecuteNonQuery();
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

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
                //cmd.CommandText = "select * from qtv.hsba ";
                cmd.CommandText = "select MAHSBA, MABN, NGAY, CHUANDOAN, MABS, MAKHOA, MACSYT, KETLUAN from qtv.hsba ";
                cmd.Connection = conn;

                try
                {

                    cmd.ExecuteNonQuery();
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void radioButtonHSBA_DV_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHSBA_DV.Checked == true)
            {
                OracleCommand cmd = new OracleCommand();
                //cmd.CommandText = "select * from qtv.hsba_dv ";
                cmd.CommandText = "select MAHSBA, MADV, NGAY, MAKTV, KETQUA from qtv.hsba_dv ";
                cmd.Connection = conn;

                try
                {

                    cmd.ExecuteNonQuery();
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
 }

