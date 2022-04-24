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
    public partial class ThanhTra : Form
    {
        private Form activeForm;
        public ThanhTra()
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
            this.panelThanhTra.Controls.Add(childForm);
            this.panelThanhTra.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ThanhTra_Load(object sender, EventArgs e)
        {

        }

        private void buttonXemThongTin_Click(object sender, EventArgs e)
        {
            buttonXemThongTin.BackColor = Color.FromArgb(107, 155, 55);

            buttonXemCaNhan.BackColor = Color.FromArgb(179, 229, 252);

            OpenFormAdmin(new ThanhTra_XemThongTin(), sender);
        }

        private void buttonXemCaNhan_Click(object sender, EventArgs e)
        {
            buttonXemThongTin.BackColor = Color.FromArgb(179, 229, 252);

            buttonXemCaNhan.BackColor = Color.FromArgb(107, 155, 55);

            OpenFormAdmin(new NhanVien_XemThongTinCaNhan(), sender);
        }

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            buttonXemThongTin.BackColor = Color.FromArgb(179, 229, 252);

            buttonXemCaNhan.BackColor = Color.FromArgb(179, 229, 252);

            buttonDangXuat.BackColor = Color.FromArgb(107, 155, 55);

            DialogResult dialogResult = MessageBox.Show("Choose yes to log out", "Do you want to log out  ?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                OpenFormAdmin(new DangNhap(), sender);
            }
        }
    }
}
