namespace QuanLyBenhVien
{
    partial class Admin_CapQuyen
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
            System.Windows.Forms.Button btnUser;
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRoleUser = new System.Windows.Forms.Button();
            this.btnRole = new System.Windows.Forms.Button();
            this.panelCapQuyen = new System.Windows.Forms.Panel();
            btnUser = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUser
            // 
            btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnUser.Location = new System.Drawing.Point(0, 0);
            btnUser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            btnUser.Name = "btnUser";
            btnUser.Size = new System.Drawing.Size(345, 94);
            btnUser.TabIndex = 0;
            btnUser.Text = "Cấp quyền User";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(btnUser);
            this.panel1.Controls.Add(this.btnRoleUser);
            this.panel1.Controls.Add(this.btnRole);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 94);
            this.panel1.TabIndex = 1;
            // 
            // btnRoleUser
            // 
            this.btnRoleUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRoleUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoleUser.Location = new System.Drawing.Point(678, 0);
            this.btnRoleUser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRoleUser.Name = "btnRoleUser";
            this.btnRoleUser.Size = new System.Drawing.Size(345, 94);
            this.btnRoleUser.TabIndex = 2;
            this.btnRoleUser.Text = "Cấp Role cho User";
            this.btnRoleUser.UseVisualStyleBackColor = true;
            this.btnRoleUser.Click += new System.EventHandler(this.btnRoleUser_Click);
            // 
            // btnRole
            // 
            this.btnRole.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRole.Location = new System.Drawing.Point(339, 0);
            this.btnRole.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRole.Name = "btnRole";
            this.btnRole.Size = new System.Drawing.Size(345, 94);
            this.btnRole.TabIndex = 1;
            this.btnRole.Text = "Cấp quyền Role";
            this.btnRole.UseVisualStyleBackColor = true;
            this.btnRole.Click += new System.EventHandler(this.btnRole_Click);
            // 
            // panelCapQuyen
            // 
            this.panelCapQuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelCapQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCapQuyen.Location = new System.Drawing.Point(0, 94);
            this.panelCapQuyen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panelCapQuyen.Name = "panelCapQuyen";
            this.panelCapQuyen.Size = new System.Drawing.Size(1042, 764);
            this.panelCapQuyen.TabIndex = 2;
            // 
            // Admin_CapQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 858);
            this.Controls.Add(this.panelCapQuyen);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Admin_CapQuyen";
            this.Text = "Admin_CapQuyen";
            this.Load += new System.EventHandler(this.Admin_CapQuyen_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRoleUser;
        private System.Windows.Forms.Button btnRole;
        private System.Windows.Forms.Panel panelCapQuyen;
    }
}