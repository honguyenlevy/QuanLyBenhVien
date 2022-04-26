﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Data.SqlClient;

namespace QuanLyBenhVien
{
    public partial class Admin_TaoCSYT : Form
    {
        public static OracleConnection conn = DangNhap.OracleConnect();
        public Admin_TaoCSYT()
        {
            InitializeComponent();
           
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        private void buttonTao_Click(object sender, EventArgs e)
        {
            bool check = true;
            OracleCommand cmd = new OracleCommand();
            if (textBoxMa.Text.Trim().Length < 2)
            {
                MessageBox.Show("MÃ CƠ SỞ Y TẾ PHẢI CÓ IT NHẤT 5 KÍ TỰ", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = textBoxMa;
                check = false;

            }
            if (textBoxTen.Text.Trim().Length < 2)
            {
                MessageBox.Show("TÊN CƠ SỞ Y TẾ PHẢI CÓ ÍT NHẤT 2 KÍ TỰ ", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = textBoxTen;
                check = false;

            }

            if (textBoxDiaChi.Text.Trim().Length < 2)
            {
                MessageBox.Show("ĐỊA CHỈ CƠ SỞ Y TẾ PHẢI CÓ ÍT NHẤT 2 KÍ TỰ ", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = textBoxDiaChi;
                check = false;

            }

            if (textBoxSDT.Text.Trim().Length < 10)
            {
                MessageBox.Show("SỐ ĐIỆN THOẠI CƠ SỞ Y TẾ PHẢI CÓ ÍT NHẤT 10 SỐ ", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = textBoxSDT;
                check = false;

            }
            if (check)
            {
                        string sql;
                       
                        cmd.Connection = conn;


                sql = "INSERT INTO qtv.CSYT VALUES ( '" + textBoxMa.Text + "','" + textBoxTen.Text + "','" + textBoxDiaChi.Text + "','" + textBoxSDT.Text + "')";
               
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                MessageBox.Show(sql);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("THÊM CƠ SỞ Y TẾ THÀNH CÔNG");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



            }
            }
    }
}
