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
    public partial class Admin_ThuQuyen : Form
    {
        public Admin_ThuQuyen()
        {
            InitializeComponent();
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
            this.panelThuQuyen.Controls.Add(childForm);
            this.panelThuQuyen.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            OpenFormAdmin(new Admin_ThuQuyen_User(), sender);
        }

        private void btnRole_Click(object sender, EventArgs e)
        {
            OpenFormAdmin(new Admin_ThuQuyen_Role(), sender);
        }

        private void btnRoleUser_Click(object sender, EventArgs e)
        {
            OpenFormAdmin(new Admin_ThuQuyen_RoleUser(), sender);
        }

        private void Admin_ThuQuyen_Load(object sender, EventArgs e)
        {

        }
    }
}
