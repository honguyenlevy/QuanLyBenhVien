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
    public partial class BacSi : Form
    {
        private Form activeForm;
        public BacSi()
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
            this.panelBacSi.Controls.Add(childForm);
            this.panelBacSi.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonXemBenhNhan_Click(object sender, EventArgs e)
        {
            buttonXemBenhNhan.BackColor = Color.FromArgb(107, 155, 55);

            buttonXemCaNhan.BackColor = Color.FromArgb(179, 229, 252);

            OpenFormAdmin(new BacSi_XemThongTinBenhNhan(), sender);
        }

        private void buttonXemCaNhan_Click(object sender, EventArgs e)
        {
            buttonXemBenhNhan.BackColor = Color.FromArgb(179, 229, 252);

            buttonXemCaNhan.BackColor = Color.FromArgb(107, 155, 55);

            OpenFormAdmin(new NhanVien_DanhSachNhanVien(), sender);
        }

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            buttonXemBenhNhan.BackColor = Color.FromArgb(179, 229, 252);

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
