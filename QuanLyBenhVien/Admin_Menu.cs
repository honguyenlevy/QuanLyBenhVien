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
           // btnDanhSach.BackColor = Color.Green;

            OpenFormAdmin(new Admin_DanhSach(), sender);
        }

        private void btnThongTinQuyen_Click(object sender, EventArgs e)
        {
            OpenFormAdmin(new Admin_ThongTinQuyen(), sender);
        }

        private void btnTaoUserRole_Click(object sender, EventArgs e)
        {
            OpenFormAdmin(new Admin_TaoUserRole(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFormAdmin(new Admin_CapQuyen(), sender);
        }

        private void btnCapQuyen_Click(object sender, EventArgs e)
        {
            OpenFormAdmin(new Admin_CapQuyen(), sender);
        }

        private void btnThuQuyen_Click(object sender, EventArgs e)
        {
            OpenFormAdmin(new Admin_ThuQuyen(), sender);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            OpenFormAdmin(new DangNhap(), sender);
        }
    }
}