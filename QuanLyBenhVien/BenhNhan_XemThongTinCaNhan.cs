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


            //cmd.CommandText = "select MANV,HOTEN,PHAI,NGAYSINH,CMND,QUEQUAN,SODT,CSYT,VAITRO,CHUYENKHOA from qtv.benhnhan where mabn= 'BN14775'";
            //cmd.CommandText = "select * from qtv.benhnhan where mabn= 'BN14775'";
            //cmd.CommandText = "select MABN, MACSYT, TENBN, CMND, NGAYSINH, SONHA, TENDUONG, QUANHUYEN, TINHTP, TIENSUBENH, TIENSUBENHGD, DIUNGTHUOC from qtv.benhnhan where mabn= 'BN14775'";
            cmd.CommandText = "select MABN, MACSYT, TENBN, CMND, NGAYSINH, SONHA, TENDUONG, QUANHUYEN, TINHTP, TIENSUBENH, TIENSUBENHGD, DIUNGTHUOC from qtv.benhnhan ";
            cmd.Connection = conn;
            
            try
            {

                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                textBoxMaBN.Text = dt.Rows[0][0].ToString();

                textBoxMaCSYT.Text = dt.Rows[0][1].ToString();

                textBoxTenBN.Text = dt.Rows[0][2].ToString();

                textBoxCMND.Text = dt.Rows[0][3].ToString();

                dateTimePicker1.Text = dt.Rows[0][4].ToString();

                textBoxSoNha.Text = dt.Rows[0][5].ToString();

                textBoxTenDuong.Text = dt.Rows[0][6].ToString();

                textBoxQuanHuyen.Text = dt.Rows[0][7].ToString();

                textBoxTinh.Text = dt.Rows[0][8].ToString();

                richTextBoxTSB.Text = dt.Rows[0][9].ToString();

                richTextBoxTSBGD.Text = dt.Rows[0][10].ToString();

                richTextBoxDiUngThuoc.Text = dt.Rows[0][11].ToString();

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
            
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            string sql;
            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;
            string ngay = "TO_DATE('" + dateTimePicker1.Text + "', 'mm/dd/yyyy')";



            sql = "UPDATE qtv.BENHNHAN  SET  MACSYT = TRIM('" + textBoxMaCSYT.Text + "') , TENBN = '" + textBoxTenBN.Text + "' , NGAYSINH = " + ngay + " , "
                + " CMND = TRIM('" + textBoxCMND.Text + "'), SONHA =  " + textBoxSoNha.Text + "  , TENDUONG = '" + textBoxTenDuong.Text + "' , QUANHUYEN = ' "
                + textBoxQuanHuyen.Text + "', TINHTP = '" + textBoxTinh.Text + "' , TIENSUBENH = ' " + richTextBoxTSB.Text + "',TIENSUBENHGD  = '" + richTextBoxTSBGD.Text + "',DIUNGTHUOC = '" + richTextBoxDiUngThuoc.Text + "' WHERE MABN = '" + textBoxMaBN.Text +"'";
            

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

        private Form activeForm;

        private void OpenFormAdmin(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDangXuat.Controls.Add(childForm);
            this.panelDangXuat.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Choose yes to log out", "Do you want to log out  ?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                OpenFormAdmin(new DangNhap(), sender);
            }
        }
    }
}
