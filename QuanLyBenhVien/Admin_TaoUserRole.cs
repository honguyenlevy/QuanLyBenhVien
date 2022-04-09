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
    public partial class Admin_TaoUserRole : Form
    {
        private Form activeForm;
        public Admin_TaoUserRole()
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
            this.panelTaoUserRole.Controls.Add(childForm);
            this.panelTaoUserRole.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            OpenFormAdmin(new Admin_TaoUserRole_Tao(), sender);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            OpenFormAdmin(new Admin_TaoUserRole_Xoa(), sender);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            OpenFormAdmin(new Admin_TaoUserRole_Sua(), sender);
        }

        private void Admin_TaoUserRole_Load(object sender, EventArgs e)
        {

        }
    }
}
