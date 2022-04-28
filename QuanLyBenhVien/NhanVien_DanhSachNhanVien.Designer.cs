
namespace QuanLyBenhVien
{
    partial class NhanVien_DanhSachNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelDSNV = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.buttonXemCTTT = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.panelDanhSachNhanVien = new System.Windows.Forms.Panel();
            this.tableLayoutPanelDSNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            this.panelDanhSachNhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelDSNV
            // 
            this.tableLayoutPanelDSNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanelDSNV.ColumnCount = 3;
            this.tableLayoutPanelDSNV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelDSNV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanelDSNV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelDSNV.Controls.Add(this.dataGridViewList, 1, 2);
            this.tableLayoutPanelDSNV.Controls.Add(this.buttonXemCTTT, 1, 1);
            this.tableLayoutPanelDSNV.Controls.Add(this.label12, 1, 0);
            this.tableLayoutPanelDSNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDSNV.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelDSNV.Name = "tableLayoutPanelDSNV";
            this.tableLayoutPanelDSNV.RowCount = 4;
            this.tableLayoutPanelDSNV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelDSNV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelDSNV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanelDSNV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelDSNV.Size = new System.Drawing.Size(1200, 703);
            this.tableLayoutPanelDSNV.TabIndex = 0;
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewList.Location = new System.Drawing.Point(63, 143);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.RowHeadersWidth = 51;
            this.dataGridViewList.RowTemplate.Height = 24;
            this.dataGridViewList.Size = new System.Drawing.Size(1074, 521);
            this.dataGridViewList.TabIndex = 0;
            // 
            // buttonXemCTTT
            // 
            this.buttonXemCTTT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonXemCTTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.buttonXemCTTT.Location = new System.Drawing.Point(823, 73);
            this.buttonXemCTTT.Name = "buttonXemCTTT";
            this.buttonXemCTTT.Size = new System.Drawing.Size(314, 57);
            this.buttonXemCTTT.TabIndex = 1;
            this.buttonXemCTTT.Text = "Xem chi tiết thông tin";
            this.buttonXemCTTT.UseVisualStyleBackColor = false;
            this.buttonXemCTTT.Click += new System.EventHandler(this.buttonXemCTTT_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(63, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1074, 70);
            this.label12.TabIndex = 2;
            this.label12.Text = "Danh sách nhân viên";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDanhSachNhanVien
            // 
            this.panelDanhSachNhanVien.Controls.Add(this.tableLayoutPanelDSNV);
            this.panelDanhSachNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDanhSachNhanVien.Location = new System.Drawing.Point(0, 0);
            this.panelDanhSachNhanVien.Name = "panelDanhSachNhanVien";
            this.panelDanhSachNhanVien.Size = new System.Drawing.Size(1200, 703);
            this.panelDanhSachNhanVien.TabIndex = 1;
            // 
            // NhanVien_DanhSachNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.panelDanhSachNhanVien);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NhanVien_DanhSachNhanVien";
            this.Text = "DanhSachNhanVien";
            this.Load += new System.EventHandler(this.NhanVien_DanhSachNhanVien_Load);
            this.tableLayoutPanelDSNV.ResumeLayout(false);
            this.tableLayoutPanelDSNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.panelDanhSachNhanVien.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDSNV;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.Button buttonXemCTTT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panelDanhSachNhanVien;
    }
}