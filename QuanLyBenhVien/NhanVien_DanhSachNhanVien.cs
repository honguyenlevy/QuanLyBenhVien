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
    public partial class NhanVien_DanhSachNhanVien : Form
    {
        private Form activeForm;
        public NhanVien_DanhSachNhanVien()
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
            this.tableLayoutPanelDSNV.Controls.Add(childForm);
            this.tableLayoutPanelDSNV.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonXemCTTT_Click(object sender, EventArgs e)
        {
            OpenFormAdmin(new NhanVien_XemThongTinCaNhan(), sender);
        }
    }
}
