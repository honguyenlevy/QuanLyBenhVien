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

            comboBoxVaiTro.DisplayMember = "Text";
            comboBoxVaiTro.ValueMember = "Value";

            comboBoxVaiTro.Items.Add(new { Text = "THANH TRA", Value = "THANH TRA" });
            comboBoxVaiTro.Items.Add(new { Text = "CO SO Y TE", Value = "CO SO Y TE" });
            comboBoxVaiTro.Items.Add(new { Text = "Y/BAC SI", Value = "Y/BAC SI" });
            comboBoxVaiTro.Items.Add(new { Text = "NGHIEN CUU", Value = "NGHIEN CUU" });




            comboBoxChuyenKhoa.DisplayMember = "Text";
            comboBoxChuyenKhoa.ValueMember = "Value";

            comboBoxChuyenKhoa.Items.Add(new { Text = "NOI", Value = "NOI" });
            comboBoxChuyenKhoa.Items.Add(new { Text = "NHI", Value = "NHI" });
            comboBoxChuyenKhoa.Items.Add(new { Text = "SAN", Value = "SAN" });
            comboBoxChuyenKhoa.Items.Add(new { Text = "TIM MACH", Value = "TIM MACH" });
            comboBoxChuyenKhoa.Items.Add(new { Text = "NGOAI", Value = "NGOAI" });
            comboBoxChuyenKhoa.Items.Add(new { Text = "DINH DUONG", Value = "DINH DUONG" });
            comboBoxChuyenKhoa.Items.Add(new { Text = "HOI SUC", Value = "HOI SUC" });

            OracleCommand cmd = new OracleCommand();

 
            cmd.Connection = conn;

            cmd.CommandText = "SELECT MACSYT FROM qtv.MA_CSYT";
           
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

            //cmd.CommandText = "select * from qtv.nhanvien";
            cmd.CommandText = "select MANV, HOTEN, PHAI, NGAYSINH, CMND, QUEQUAN, SODT, CSYT, VAITRO, CHUYENKHOA from qtv.nhanvien";
            try
            {

                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                textBoxMaNV.Text = dt.Rows[0][0].ToString();
                textBoxHoTen.Text= dt.Rows[0][1].ToString();
                string Phai= dt.Rows[0][2].ToString();
                dateTimePicker1.Text= dt.Rows[0][3].ToString();
                textBoxCMND.Text= dt.Rows[0][4].ToString();
                textBoxQueQuan.Text= dt.Rows[0][5].ToString();
                textBoxSDT.Text= dt.Rows[0][6].ToString();
                comboBoxCSYT.Text= dt.Rows[0][7].ToString();
                comboBoxVaiTro.Text = dt.Rows[0][8].ToString();
                comboBoxChuyenKhoa.Text= dt.Rows[0][9].ToString();

                if (Phai == "Nam")
                    radioButtonNam.Checked = true;
                else radioButtonNu.Checked = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dataGridViewTTCaNhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //textBoxMaNV.Text = dataGridViewTTCaNhan.CurrentRow.Cells[0].Value != null ? dataGridViewTTCaNhan.CurrentRow.Cells[0].Value.ToString() : "";
            //textBoxHoTen.Text = dataGridViewTTCaNhan.CurrentRow.Cells[1].Value != null ? dataGridViewTTCaNhan.CurrentRow.Cells[1].Value.ToString() : "";
            //string Phai = dataGridViewTTCaNhan.CurrentRow.Cells[2].Value != null ? dataGridViewTTCaNhan.CurrentRow.Cells[2].Value.ToString() : "";
            //dateTimePicker1.Text = dataGridViewTTCaNhan.CurrentRow.Cells[3].Value != null ? dataGridViewTTCaNhan.CurrentRow.Cells[3].Value.ToString() : "";
            //textBoxCMND.Text = dataGridViewTTCaNhan.CurrentRow.Cells[4].Value != null ? dataGridViewTTCaNhan.CurrentRow.Cells[4].Value.ToString() : "";
            //textBoxQueQuan.Text = dataGridViewTTCaNhan.CurrentRow.Cells[5].Value != null ? dataGridViewTTCaNhan.CurrentRow.Cells[5].Value.ToString() : "";
            //textBoxSDT.Text = dataGridViewTTCaNhan.CurrentRow.Cells[6].Value != null ? dataGridViewTTCaNhan.CurrentRow.Cells[6].Value.ToString() : "";
            //comboBoxCSYT.Text = dataGridViewTTCaNhan.CurrentRow.Cells[7].Value != null ? dataGridViewTTCaNhan.CurrentRow.Cells[7].Value.ToString() : "";
            //comboBoxVaiTro.Text = dataGridViewTTCaNhan.CurrentRow.Cells[8].Value != null ? dataGridViewTTCaNhan.CurrentRow.Cells[8].Value.ToString() : "";
            //comboBoxChuyenKhoa.Text = dataGridViewTTCaNhan.CurrentRow.Cells[9].Value != null ? dataGridViewTTCaNhan.CurrentRow.Cells[9].Value.ToString() : "";
            //if (Phai == "Nam")
            //    radioButtonNam.Checked = true;
            //else radioButtonNu.Checked = true;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)

        {
            //Random _r = new Random();

            //int number = _r.Next()%10000;
            //int number = 1;
            //string value = "BN"+String.Format("{0:D5}", number);
            //MessageBox.Show(value);

            string sql;
            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;
            string ngay = "TO_DATE('" + dateTimePicker1.Text + "', 'mm/dd/yyyy')";
            string Phai = "Nam";
            if (radioButtonNu.Checked == true) Phai = "Nu";

            sql = "UPDATE qtv.NHANVIEN  SET  HOTEN = '" + textBoxHoTen.Text + "' , PHAI = '" + Phai + "' , NGAYSINH = " + ngay + " , "
                + " CMND = ' " + textBoxCMND.Text + "' , QUEQUAN = ' " + textBoxQueQuan.Text + " ' , SODT = '" + textBoxSDT.Text + "' , CSYT = TRIM('"
                + comboBoxCSYT.Text + "'), VAITRO = '" + comboBoxVaiTro.Text + "' , CHUYENKHOA = TRIM('" + comboBoxChuyenKhoa.Text + "') WHERE MANV = '" + textBoxMaNV.Text +"'";

            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
           

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("CẬP NHẬT THÔNG TIN CÁ NHÂN THÀNH CÔNG");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
  }

