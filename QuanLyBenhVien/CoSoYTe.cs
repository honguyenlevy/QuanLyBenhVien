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
    public partial class CoSoYTe : Form
    {
        private Form activeForm;
        public CoSoYTe()
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
            this.panelCSYT.Controls.Add(childForm);
            this.panelCSYT.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonThemHSBA_Click(object sender, EventArgs e)
        {
            buttonThemHSBA.BackColor = Color.FromArgb(107, 155, 55);

            buttonDSHSBA.BackColor = Color.FromArgb(179, 229, 252);

            buttonThemHSBADV.BackColor = Color.FromArgb(179, 229, 252);

            buttonDSHSBADV.BackColor = Color.FromArgb(179, 229, 252);

            OpenFormAdmin(new CSYT_ThemHSBA(), sender);
        }

        private void buttonDSHSBA_Click(object sender, EventArgs e)
        {
            buttonThemHSBA.BackColor = Color.FromArgb(179, 229, 252);

            buttonDSHSBA.BackColor = Color.FromArgb(107, 155, 55);

            buttonThemHSBADV.BackColor = Color.FromArgb(179, 229, 252);

            buttonDSHSBADV.BackColor = Color.FromArgb(179, 229, 252);

            OpenFormAdmin(new CSYT_DanhSachHSBA(), sender);
        }

        private void buttonThemHSBADV_Click(object sender, EventArgs e)
        {
            buttonThemHSBA.BackColor = Color.FromArgb(179, 229, 252);

            buttonDSHSBA.BackColor = Color.FromArgb(179, 229, 252);

            buttonThemHSBADV.BackColor = Color.FromArgb(107, 155, 55);

            buttonDSHSBADV.BackColor = Color.FromArgb(179, 229, 252);

            OpenFormAdmin(new CSYT_ThemHSBA_DV(), sender);
        }

        private void buttonDSHSBADV_Click(object sender, EventArgs e)
        {
            buttonThemHSBA.BackColor = Color.FromArgb(179, 229, 252);

            buttonDSHSBA.BackColor = Color.FromArgb(179, 229, 252);

            buttonThemHSBADV.BackColor = Color.FromArgb(179, 229, 252);

            buttonDSHSBADV.BackColor = Color.FromArgb(107, 155, 55);

            OpenFormAdmin(new CSYT_DanhSachHSBA_DV(), sender);
        }

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            buttonThemHSBA.BackColor = Color.FromArgb(179, 229, 252);

            buttonDSHSBA.BackColor = Color.FromArgb(179, 229, 252);

            buttonThemHSBADV.BackColor = Color.FromArgb(179, 229, 252);

            buttonDSHSBADV.BackColor = Color.FromArgb(179, 229, 252);

            buttonDangXuat.BackColor = Color.FromArgb(107, 155, 55);

            DialogResult dialogResult = MessageBox.Show("Choose yes to log out", "Do you want to log out  ?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                OpenFormAdmin(new DangNhap(), sender);
            }
        }

        private void CoSoYTe_Load(object sender, EventArgs e)
        {

        }

        private void buttonThongBao_Click(object sender, EventArgs e)
        {
            buttonThemHSBA.BackColor = Color.FromArgb(179, 229, 252);

            buttonDSHSBA.BackColor = Color.FromArgb(179, 229, 252);

            buttonThemHSBADV.BackColor = Color.FromArgb(179, 229, 252);

            buttonDSHSBADV.BackColor = Color.FromArgb(179, 229, 252);

            buttonDangXuat.BackColor = Color.FromArgb(179, 229, 252);

            buttonThongBao.BackColor = Color.FromArgb(107, 155, 55);

            OpenFormAdmin(new ThongBao(), sender);
        }
    }
}
