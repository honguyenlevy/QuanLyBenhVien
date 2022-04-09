namespace QuanLyBenhVien
{
    partial class Admin_TaoUserRole_Tao
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textConfirmPassword = new System.Windows.Forms.TextBox();
            this.checkBoxRole = new System.Windows.Forms.CheckBox();
            this.btn_Tao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textUsername
            // 
            this.textUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsername.Location = new System.Drawing.Point(368, 52);
            this.textUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(324, 30);
            this.textUsername.TabIndex = 3;
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(368, 147);
            this.textPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(324, 30);
            this.textPassword.TabIndex = 4;
            // 
            // textConfirmPassword
            // 
            this.textConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textConfirmPassword.Location = new System.Drawing.Point(368, 233);
            this.textConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textConfirmPassword.Name = "textConfirmPassword";
            this.textConfirmPassword.PasswordChar = '*';
            this.textConfirmPassword.Size = new System.Drawing.Size(324, 30);
            this.textConfirmPassword.TabIndex = 5;
            // 
            // checkBoxRole
            // 
            this.checkBoxRole.AutoSize = true;
            this.checkBoxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRole.Location = new System.Drawing.Point(848, 78);
            this.checkBoxRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxRole.Name = "checkBoxRole";
            this.checkBoxRole.Size = new System.Drawing.Size(73, 29);
            this.checkBoxRole.TabIndex = 6;
            this.checkBoxRole.Text = "Role";
            this.checkBoxRole.UseVisualStyleBackColor = true;
            this.checkBoxRole.CheckedChanged += new System.EventHandler(this.checkBoxRole_CheckedChanged);
            // 
            // btn_Tao
            // 
            this.btn_Tao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.btn_Tao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Tao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tao.Location = new System.Drawing.Point(392, 327);
            this.btn_Tao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Tao.Name = "btn_Tao";
            this.btn_Tao.Size = new System.Drawing.Size(276, 62);
            this.btn_Tao.TabIndex = 7;
            this.btn_Tao.Text = "Tạo ";
            this.btn_Tao.UseVisualStyleBackColor = false;
            this.btn_Tao.Click += new System.EventHandler(this.btn_Tao_Click);
            // 
            // Admin_TaoUserRole_Tao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1016, 691);
            this.Controls.Add(this.btn_Tao);
            this.Controls.Add(this.checkBoxRole);
            this.Controls.Add(this.textConfirmPassword);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Admin_TaoUserRole_Tao";
            this.Text = "Admin_TaoUserRole_Tao";
            this.Load += new System.EventHandler(this.Admin_TaoUserRole_Tao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textConfirmPassword;
        private System.Windows.Forms.CheckBox checkBoxRole;
        private System.Windows.Forms.Button btn_Tao;
    }
}