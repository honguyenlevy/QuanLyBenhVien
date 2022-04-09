using System;
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
    public partial class Admin_CapQuyen_Role : Form
    {
        public static OracleConnection conn = DangNhap.OracleConnect();
       
        public Admin_CapQuyen_Role()
        {
            InitializeComponent();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        private void Admin_CapQuyen_Role_Load(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "SELECT ROLE FROM DBA_ROLES ORDER BY ROLE_ID DESC";

            cmd.Connection = conn;

            try
            {
               
                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBoxRole.DataSource = dt;
                comboBoxRole.DisplayMember = dt.Columns[0].ColumnName;
                comboBoxRole.ValueMember = dt.Columns[0].ColumnName;
                comboBoxRole.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            cmd.CommandText = "select table_name from Dba_tables where owner = 'QTV'";
            cmd.Connection = conn;

            try
            {

                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBoxTable.DisplayMember = dt.Columns[0].ColumnName;
                comboBoxTable.ValueMember = dt.Columns[0].ColumnName;
                comboBoxTable.DataSource = dt;
                comboBoxTable.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxColumn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "SELECT COLUMN_NAME FROM ALL_TAB_COLUMNS WHERE TABLE_NAME = '" + comboBoxTable.SelectedValue + "'";

            cmd.Connection = conn;

            try
            {
                
                cmd.ExecuteNonQuery();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBoxColumn.DataSource = dt;
                comboBoxColumn.DisplayMember = dt.Columns[0].ColumnName;
                comboBoxColumn.ValueMember = dt.Columns[0].ColumnName;
                comboBoxColumn.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string select = "";
            string update = "";
            string insert = "";
            string delete = "";

            string column = "";
            column += comboBoxColumn.SelectedValue;

            switch (checkBoxSelect.CheckState)
            {
                case CheckState.Unchecked:
                    select = "";
                    break;
                case CheckState.Checked:
                    select += " grant select on QTV." + comboBoxTable.SelectedValue + " to " + comboBoxRole.SelectedValue ;
                    break;
                case CheckState.Indeterminate:
                    select = "";
                    break;
            }

            switch (checkBoxUpdate.CheckState)
            {
                case CheckState.Unchecked:
                    update = "";
                    break;
                case CheckState.Checked:
                    if (column != "")
                    {
                        update += " grant Update on QTV." + comboBoxTable.SelectedValue + " to " + comboBoxRole.SelectedValue ;
                    }
                    else
                    {
                        update += " grant Update (" + column + ") on QTV." + comboBoxTable.SelectedValue + " to " + comboBoxRole.SelectedValue ;
                    }
                    break;
                    
                case CheckState.Indeterminate:
                    update = "";
                    break;
            }

            switch (checkBoxInsert.CheckState)
            {
                case CheckState.Unchecked:

                    insert = "";
                    break;
                case CheckState.Checked:
                    if (column == "")
                    {
                        insert += " grant insert on QTV." + comboBoxTable.SelectedValue + " to " + comboBoxRole.SelectedValue ;
                    }
                    else
                    {
                        insert += " grant insert (" + column + ") on QTV." + comboBoxTable.SelectedValue + " to " + comboBoxRole.SelectedValue ;
                    }
                    break;
                case CheckState.Indeterminate:
                    insert = "";
                    break;
            }

            switch (checkBoxDelete.CheckState)
            {
                case CheckState.Unchecked:

                    delete = "";
                    break;
                case CheckState.Checked:
                    delete += "  grant delete on QTV." + comboBoxTable.SelectedValue + " to " + comboBoxRole.SelectedValue ;
                    break;
                case CheckState.Indeterminate:
                    delete = "";
                    break;
            }

            if (select == "" && insert == "" && update == "" && delete == "")
            {
                MessageBox.Show("YOU HAVE NOT SELECTED PRIVELEGE !");
            }

            OracleCommand cmd = new OracleCommand();

            cmd.CommandText = select;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            

            if (select != "")
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("GRANT SELECT SUCCESSFULLY!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            cmd.CommandText = insert;

            if (insert != "")
            {
                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("GRANT INSERT SUCCESFULLY !");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            cmd.CommandText = update;


            if (update != "")
            {
                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("GRANT UPDATE SUCCESFULLY");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            cmd.CommandText = delete;


            if (delete != "")
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("GRANT DELETE SUCCESFULLY");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void checkBoxUpdate_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
 }
