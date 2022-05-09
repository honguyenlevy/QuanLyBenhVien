using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien
{
    public partial class Admin_Menu : Form
    {
        private Form activeForm;
        public Admin_Menu()
        {
            InitializeComponent();
        }

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
            this.panelDesktopAdmin.Controls.Add(childForm);
            this.panelDesktopAdmin.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
           
            btnDanhSach.BackColor = Color.FromArgb(107, 155, 55);

            btnThongTinQuyen.BackColor = Color.FromArgb(179, 229, 252);

            btnTaoUserRole.BackColor = Color.FromArgb(179, 229, 252);

            btnCapQuyen.BackColor = Color.FromArgb(179, 229, 252);

            btnThuQuyen.BackColor = Color.FromArgb(179, 229, 252);

            buttonTaoNV.BackColor = Color.FromArgb(179, 229, 252);

            buttonTaoCSYT.BackColor = Color.FromArgb(179, 229, 252);

            buttonTaoBN.BackColor = Color.FromArgb(179, 229, 252);

            OpenFormAdmin(new Admin_DanhSach(), sender);
        }

        private void btnThongTinQuyen_Click(object sender, EventArgs e)
        {
            btnDanhSach.BackColor = Color.FromArgb(179, 229, 252);

            btnThongTinQuyen.BackColor = Color.FromArgb(107, 155, 55);

            btnTaoUserRole.BackColor = Color.FromArgb(179, 229, 252);

            btnCapQuyen.BackColor = Color.FromArgb(179, 229, 252);

            btnThuQuyen.BackColor = Color.FromArgb(179, 229, 252);

            buttonTaoNV.BackColor = Color.FromArgb(179, 229, 252);

            buttonTaoCSYT.BackColor = Color.FromArgb(179, 229, 252);

            buttonTaoBN.BackColor = Color.FromArgb(179, 229, 252);


            OpenFormAdmin(new Admin_ThongTinQuyen(), sender);
        }

        private void btnTaoUserRole_Click(object sender, EventArgs e)
        {
            btnDanhSach.BackColor = Color.FromArgb(179, 229, 252);

            btnThongTinQuyen.BackColor = Color.FromArgb(179, 229, 252);

            btnTaoUserRole.BackColor = Color.FromArgb(107, 155, 55);

            btnCapQuyen.BackColor = Color.FromArgb(179, 229, 252);

            btnThuQuyen.BackColor = Color.FromArgb(179, 229, 252);

            buttonTaoNV.BackColor = Color.FromArgb(179, 229, 252);

            buttonTaoCSYT.BackColor = Color.FromArgb(179, 229, 252);

            buttonTaoBN.BackColor = Color.FromArgb(179, 229, 252);


            OpenFormAdmin(new Admin_TaoUserRole(), sender);
        }

       

        private void btnCapQuyen_Click(object sender, EventArgs e)
        {
            btnDanhSach.BackColor = Color.FromArgb(179, 229, 252);

            btnThongTinQuyen.BackColor = Color.FromArgb(179, 229, 252);

            btnTaoUserRole.BackColor = Color.FromArgb(179, 229, 252);

            btnCapQuyen.BackColor = Color.FromArgb(107, 155, 55);

            btnThuQuyen.BackColor = Color.FromArgb(179, 229, 252);

            buttonTaoNV.BackColor = Color.FromArgb(179, 229, 252);

            buttonTaoCSYT.BackColor = Color.FromArgb(179, 229, 252);

            buttonTaoBN.BackColor = Color.FromArgb(179, 229, 252);

            OpenFormAdmin(new Admin_CapQuyen(), sender);
        }

        private void btnThuQuyen_Click(object sender, EventArgs e)
        {

            btnDanhSach.BackColor = Color.FromArgb(179, 229, 252);

            btnThongTinQuyen.BackColor = Color.FromArgb(179, 229, 252);

            btnTaoUserRole.BackColor = Color.FromArgb(179, 229, 252);

            btnCapQuyen.BackColor = Color.FromArgb(179, 229, 252);

            btnThuQuyen.BackColor = Color.FromArgb(107, 155, 55);

            buttonTaoNV.BackColor = Color.FromArgb(179, 229, 252);

            buttonTaoCSYT.BackColor = Color.FromArgb(179, 229, 252);

            buttonTaoBN.BackColor = Color.FromArgb(179, 229, 252);

            OpenFormAdmin(new Admin_ThuQuyen(), sender);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            btnDangXuat.BackColor = Color.FromArgb(107, 155, 55);

            btnDanhSach.BackColor = Color.FromArgb(179, 229, 252);

            btnThongTinQuyen.BackColor = Color.FromArgb(179, 229, 252);

            btnTaoUserRole.BackColor = Color.FromArgb(179, 229, 252);

            btnCapQuyen.BackColor = Color.FromArgb(179, 229, 252);

            btnThuQuyen.BackColor = Color.FromArgb(179, 229, 252);

            buttonTaoNV.BackColor = Color.FromArgb(179, 229, 252);

            buttonTaoCSYT.BackColor = Color.FromArgb(179, 229, 252);

            buttonTaoBN.BackColor = Color.FromArgb(179, 229, 252);

            DialogResult dialogResult = MessageBox.Show("Choose yes to log out", "Do you want to log out  ?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                OpenFormAdmin(new DangNhap(), sender);
            }
        }

        private void Admin_Menu_Load(object sender, EventArgs e)
        {

        }

        private void buttonTaoBN_Click(object sender, EventArgs e)
        {
            btnDangXuat.BackColor = Color.FromArgb(179, 229, 252);

            btnDanhSach.BackColor = Color.FromArgb(179, 229, 252);

            btnThongTinQuyen.BackColor = Color.FromArgb(179, 229, 252);

            btnTaoUserRole.BackColor = Color.FromArgb(179, 229, 252);

            btnCapQuyen.BackColor = Color.FromArgb(179, 229, 252);

            btnThuQuyen.BackColor = Color.FromArgb(179, 229, 252);

            buttonTaoNV.BackColor = Color.FromArgb(179, 229, 252);

            buttonTaoCSYT.BackColor = Color.FromArgb(179, 229, 252);

            buttonTaoBN.BackColor = Color.FromArgb(107, 155, 55);

            OpenFormAdmin(new Admin_TaoBenhNhan(), sender);
        }

        private void buttonTaoCSYT_Click(object sender, EventArgs e)
        {
            btnDangXuat.BackColor = Color.FromArgb(179, 229, 252);

            btnDanhSach.BackColor = Color.FromArgb(179, 229, 252);

            btnThongTinQuyen.BackColor = Color.FromArgb(179, 229, 252);

            btnTaoUserRole.BackColor = Color.FromArgb(179, 229, 252);

            btnCapQuyen.BackColor = Color.FromArgb(179, 229, 252);

            btnThuQuyen.BackColor = Color.FromArgb(179, 229, 252);

            buttonTaoNV.BackColor = Color.FromArgb(179, 229, 252);

            buttonTaoCSYT.BackColor = Color.FromArgb(107, 155, 55);

            buttonTaoBN.BackColor = Color.FromArgb(179, 229, 252);

            OpenFormAdmin(new Admin_TaoCSYT(), sender);
        }

        private void buttonTaoNV_Click(object sender, EventArgs e)
        {
            btnDangXuat.BackColor = Color.FromArgb(179, 229, 252);

            btnDanhSach.BackColor = Color.FromArgb(179, 229, 252);

            btnThongTinQuyen.BackColor = Color.FromArgb(179, 229, 252);

            btnTaoUserRole.BackColor = Color.FromArgb(179, 229, 252);

            btnCapQuyen.BackColor = Color.FromArgb(179, 229, 252);

            btnThuQuyen.BackColor = Color.FromArgb(179, 229, 252);

            buttonTaoNV.BackColor = Color.FromArgb(107, 155, 55);

            buttonTaoCSYT.BackColor = Color.FromArgb(179, 229, 252);

            buttonTaoBN.BackColor = Color.FromArgb(179, 229, 252);

            OpenFormAdmin(new Admin_TaoNhanVien(), sender);
        }

        private void buttonAudit_Click(object sender, EventArgs e)
        {

            btnDangXuat.BackColor = Color.FromArgb(179, 229, 252);

            btnDanhSach.BackColor = Color.FromArgb(179, 229, 252);

            btnThongTinQuyen.BackColor = Color.FromArgb(179, 229, 252);

            btnTaoUserRole.BackColor = Color.FromArgb(179, 229, 252);

            btnCapQuyen.BackColor = Color.FromArgb(179, 229, 252);

            btnThuQuyen.BackColor = Color.FromArgb(179, 229, 252);

            buttonTaoNV.BackColor = Color.FromArgb(179, 229, 252);

            buttonTaoCSYT.BackColor = Color.FromArgb(179, 229, 252);

            buttonTaoBN.BackColor = Color.FromArgb(179, 229, 252);

            buttonAudit.BackColor = Color.FromArgb(107, 155, 55);

            OpenFormAdmin(new Admin_Audit(), sender);

        }
    }
}