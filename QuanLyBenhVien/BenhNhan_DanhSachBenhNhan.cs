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
    public partial class BenhNhan_DanhSachBenhNhan : Form
    {
        private Form activeForm;
        public BenhNhan_DanhSachBenhNhan()
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
            this.tableLayoutPanelDSBN.Controls.Add(childForm);
            this.tableLayoutPanelDSBN.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonXemCTTT_Click(object sender, EventArgs e)
        {
            OpenFormAdmin(new BenhNhan_XemThongTinCaNhan(), sender);
        }
    }
}
