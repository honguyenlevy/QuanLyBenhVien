namespace QuanLyBenhVien
{
    partial class Admin_TaoUserRole_Xoa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textSelectedUserRole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxRole = new System.Windows.Forms.CheckBox();
            this.btnXoaRole_User = new System.Windows.Forms.Button();
            this.dataGridViewXoaUserRole = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXoaUserRole)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textSelectedUserRole
            // 
            this.textSelectedUserRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textSelectedUserRole.Location = new System.Drawing.Point(282, 33);
            this.textSelectedUserRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSelectedUserRole.Name = "textSelectedUserRole";
            this.textSelectedUserRole.ReadOnly = true;
            this.textSelectedUserRole.Size = new System.Drawing.Size(393, 30);
            this.textSelectedUserRole.TabIndex = 3;
            this.textSelectedUserRole.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 97);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selected User/Role";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxRole
            // 
            this.checkBoxRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxRole.AutoSize = true;
            this.checkBoxRole.Location = new System.Drawing.Point(4, 5);
            this.checkBoxRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxRole.Name = "checkBoxRole";
            this.checkBoxRole.Size = new System.Drawing.Size(73, 87);
            this.checkBoxRole.TabIndex = 1;
            this.checkBoxRole.Text = "Role";
            this.checkBoxRole.UseVisualStyleBackColor = true;
            this.checkBoxRole.CheckedChanged += new System.EventHandler(this.Role_CheckedChanged);
            // 
            // btnXoaRole_User
            // 
            this.btnXoaRole_User.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaRole_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.btnXoaRole_User.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoaRole_User.Location = new System.Drawing.Point(728, 24);
            this.btnXoaRole_User.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaRole_User.Name = "btnXoaRole_User";
            this.btnXoaRole_User.Size = new System.Drawing.Size(176, 49);
            this.btnXoaRole_User.TabIndex = 0;
            this.btnXoaRole_User.Text = "DROP";
            this.btnXoaRole_User.UseVisualStyleBackColor = false;
            this.btnXoaRole_User.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dataGridViewXoaUserRole
            // 
            this.dataGridViewXoaUserRole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewXoaUserRole.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewXoaUserRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(164)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewXoaUserRole.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewXoaUserRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewXoaUserRole.Location = new System.Drawing.Point(54, 108);
            this.dataGridViewXoaUserRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewXoaUserRole.Name = "dataGridViewXoaUserRole";
            this.dataGridViewXoaUserRole.RowHeadersWidth = 51;
            this.dataGridViewXoaUserRole.RowTemplate.Height = 24;
            this.dataGridViewXoaUserRole.Size = new System.Drawing.Size(906, 542);
            this.dataGridViewXoaUserRole.TabIndex = 1;
            this.dataGridViewXoaUserRole.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewXoaUserRole_CellContentClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewXoaUserRole, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1016, 691);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.70485F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.16299F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textSelectedUserRole, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxRole, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnXoaRole_User, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(53, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(908, 97);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // Admin_TaoUserRole_Xoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 691);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Admin_TaoUserRole_Xoa";
            this.Text = "Admin_TaoUserRole_Xoa";
            this.Load += new System.EventHandler(this.Admin_TaoUserRole_Xoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXoaUserRole)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxRole;
        private System.Windows.Forms.Button btnXoaRole_User;
        private System.Windows.Forms.DataGridView dataGridViewXoaUserRole;
        private System.Windows.Forms.TextBox textSelectedUserRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}