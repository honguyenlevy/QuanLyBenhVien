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
    public partial class Admin_TaoNhanVien : Form
    {
        public static OracleConnection conn = DangNhap.OracleConnect();
        public Admin_TaoNhanVien()
        {
            InitializeComponent();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        private void buttonTao_Click(object sender, EventArgs e)
        {
            //bool check = true;

            //if (textBoxMaNV.Text.Trim().Length < 5)
            //{
            //    MessageBox.Show("MÃ NHÂN VIÊN ÍT NHẤT PHẢI CÓ 5 KÝ TỰ", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    this.ActiveControl = textBoxMaNV;
            //    check = false;

            //}


            //if (textBoxHoTen.Text.Trim().Length < 5)
            //{
            //    MessageBox.Show("HỌ TÊN KHÔNG ÍT HƠN 5 KÝ TỰ", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    this.ActiveControl = textBoxHoTen;
            //    check = false;

            //}

            //if (textBoxQueQuan.Text.Trim().Length < 5)
            //{
            //    MessageBox.Show("CHƯA NHẬP QUÊ QUÁN", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    this.ActiveControl = textBoxQueQuan;
            //    check = false;
            //}

            //if (comboBoxCSYT.Text == "")
            //{
            //    MessageBox.Show("CHƯA CHỌN CSYT", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    this.ActiveControl = comboBoxCSYT;
            //    //check = false;

            //}

            //if (radioButtonNu.Checked == false && radioButtonNam.Checked==false)
            //{
            //    MessageBox.Show("CHƯA CHỌN GIỚI TÍNH");
            //    //check = false;
            //}


            //if (textBoxCMND.Text.Trim().Length < 9)
            //{
            //    MessageBox.Show("SỐ CMND KHÔNG HỢP LỆ", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    this.ActiveControl = textBoxCMND;
            //    //check = false;
            //}

            //if (textBoxCMND.Text.Trim().Length < 9)
            //{
            //    MessageBox.Show("SỐ CMND KHÔNG HỢP LỆ", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    this.ActiveControl = textBoxCMND;
            //    //check = false;
            //}

           
            //    if (textBoxSDT.Text.Trim().Length < 10)
            //{
            //    MessageBox.Show("SỐ ĐIỆN THOẠI KHÔNG HỢP LỆ", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    this.ActiveControl = textBoxSDT;
            //    //check = false;
            //}
            //if (comboBoxVaiTro.Text == "")
            //{
            //    MessageBox.Show("CHƯA CHỌN VAI TRÒ", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    this.ActiveControl = comboBoxCSYT;
            //    //check = false;

            //}

            string Phai = "Nam";
            if (radioButtonNu.Checked == true) Phai = "Nu";
            string ngaysinh = "TO_DATE('" + dateTimePicker1.Text + "', 'mm/dd/yyyy')";
            string chuyenkhoa = comboBoxChuyenKhoa.Text;
            if (comboBoxVaiTro.Text == "") chuyenkhoa = "NULL";

            string sql;
            sql = "INSERT INTO NHANVIEN VALUES " + " ('" + textBoxMaNV.Text + "','" + textBoxHoTen.Text + "','" + Phai + "'," + ngaysinh +
            "," + textBoxCMND.Text + ",'" + textBoxQueQuan.Text + "','" + textBoxSDT.Text + "','" + comboBoxCSYT.Text + "','" + comboBoxVaiTro.Text + "','" + chuyenkhoa + "' )";
            MessageBox.Show(sql);


            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
           // MessageBox.Show(sql);

            System.Windows.Forms.Clipboard.SetDataObject(sql, true);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("THÊM NHÂN VIÊN THÀNH CÔNG");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButtonNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Admin_TaoNhanVien_Load(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "SELECT ROLE FROM DBA_ROLES ORDER BY ROLE_ID DESC";

            cmd.Connection = conn;

            try
            {

                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBoxVaiTro.DataSource = dt;
                comboBoxVaiTro.DisplayMember = dt.Columns[0].ColumnName;
                comboBoxVaiTro.ValueMember = dt.Columns[0].ColumnName;
                comboBoxVaiTro.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            cmd.CommandText = "SELECT ROLE FROM DBA_ROLES ORDER BY ROLE_ID DESC";
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


            cmd.CommandText = "SELECT ROLE FROM DBA_ROLES ORDER BY ROLE_ID DESC";
            try
            {

                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBoxChuyenKhoa.DataSource = dt;
                comboBoxChuyenKhoa.DisplayMember = dt.Columns[0].ColumnName;
                comboBoxChuyenKhoa.ValueMember = dt.Columns[0].ColumnName;
                comboBoxChuyenKhoa.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}