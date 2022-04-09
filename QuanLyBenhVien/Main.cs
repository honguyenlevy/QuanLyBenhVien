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
    public partial class Main : Form
    {
        private Form activeForm;
        public Main()
        {
            InitializeComponent();
        }

        private void OpenChilForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //
            WindowState = FormWindowState.Maximized;
            OpenChilForm(new DangNhap(), sender);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
