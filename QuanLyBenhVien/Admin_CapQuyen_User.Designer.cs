namespace QuanLyBenhVien
{
    partial class Admin_CapQuyen_User
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox_WithGrantOption = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTable = new System.Windows.Forms.ComboBox();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxColumn = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxSelect = new System.Windows.Forms.CheckBox();
            this.checkBoxInsert = new System.Windows.Forms.CheckBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.checkBoxDelete = new System.Windows.Forms.CheckBox();
            this.checkBoxUpdate = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.checkBox_WithGrantOption);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxTable);
            this.panel1.Controls.Add(this.comboBoxUser);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxColumn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 686);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(281, 255);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 62);
            this.button1.TabIndex = 15;
            this.button1.Text = "Load Column";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox_WithGrantOption
            // 
            this.checkBox_WithGrantOption.AutoSize = true;
            this.checkBox_WithGrantOption.Location = new System.Drawing.Point(308, 426);
            this.checkBox_WithGrantOption.Margin = new System.Windows.Forms.Padding(6);
            this.checkBox_WithGrantOption.Name = "checkBox_WithGrantOption";
            this.checkBox_WithGrantOption.Size = new System.Drawing.Size(190, 29);
            this.checkBox_WithGrantOption.TabIndex = 8;
            this.checkBox_WithGrantOption.Text = "With Grant Option";
            this.checkBox_WithGrantOption.UseVisualStyleBackColor = true;
            this.checkBox_WithGrantOption.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "User";
            // 
            // comboBoxTable
            // 
            this.comboBoxTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTable.FormattingEnabled = true;
            this.comboBoxTable.Location = new System.Drawing.Point(159, 128);
            this.comboBoxTable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxTable.Name = "comboBoxTable";
            this.comboBoxTable.Size = new System.Drawing.Size(560, 33);
            this.comboBoxTable.TabIndex = 7;
            this.comboBoxTable.SelectedIndexChanged += new System.EventHandler(this.comboBoxTable_SelectedIndexChanged);
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(159, 33);
            this.comboBoxUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(560, 33);
            this.comboBoxUser.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 349);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Column";
            // 
            // comboBoxColumn
            // 
            this.comboBoxColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColumn.FormattingEnabled = true;
            this.comboBoxColumn.Location = new System.Drawing.Point(159, 341);
            this.comboBoxColumn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxColumn.Name = "comboBoxColumn";
            this.comboBoxColumn.Size = new System.Drawing.Size(548, 33);
            this.comboBoxColumn.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Table";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxSelect);
            this.groupBox1.Controls.Add(this.checkBoxInsert);
            this.groupBox1.Controls.Add(this.btnApply);
            this.groupBox1.Controls.Add(this.checkBoxDelete);
            this.groupBox1.Controls.Add(this.checkBoxUpdate);
            this.groupBox1.Location = new System.Drawing.Point(773, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(237, 653);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Privilege";
            // 
            // checkBoxSelect
            // 
            this.checkBoxSelect.AutoSize = true;
            this.checkBoxSelect.Location = new System.Drawing.Point(64, 56);
            this.checkBoxSelect.Margin = new System.Windows.Forms.Padding(6);
            this.checkBoxSelect.Name = "checkBoxSelect";
            this.checkBoxSelect.Size = new System.Drawing.Size(89, 29);
            this.checkBoxSelect.TabIndex = 11;
            this.checkBoxSelect.Text = "Select";
            this.checkBoxSelect.UseVisualStyleBackColor = true;
            this.checkBoxSelect.CheckedChanged += new System.EventHandler(this.checkBoxSelect_CheckedChanged);
            // 
            // checkBoxInsert
            // 
            this.checkBoxInsert.AutoSize = true;
            this.checkBoxInsert.Location = new System.Drawing.Point(64, 134);
            this.checkBoxInsert.Margin = new System.Windows.Forms.Padding(6);
            this.checkBoxInsert.Name = "checkBoxInsert";
            this.checkBoxInsert.Size = new System.Drawing.Size(82, 29);
            this.checkBoxInsert.TabIndex = 9;
            this.checkBoxInsert.Text = "Insert";
            this.checkBoxInsert.UseVisualStyleBackColor = true;
            this.checkBoxInsert.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApply.Location = new System.Drawing.Point(37, 376);
            this.btnApply.Margin = new System.Windows.Forms.Padding(6);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(159, 62);
            this.btnApply.TabIndex = 13;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // checkBoxDelete
            // 
            this.checkBoxDelete.AutoSize = true;
            this.checkBoxDelete.Location = new System.Drawing.Point(64, 300);
            this.checkBoxDelete.Margin = new System.Windows.Forms.Padding(6);
            this.checkBoxDelete.Name = "checkBoxDelete";
            this.checkBoxDelete.Size = new System.Drawing.Size(90, 29);
            this.checkBoxDelete.TabIndex = 12;
            this.checkBoxDelete.Text = "Delete";
            this.checkBoxDelete.UseVisualStyleBackColor = true;
            // 
            // checkBoxUpdate
            // 
            this.checkBoxUpdate.AutoSize = true;
            this.checkBoxUpdate.Location = new System.Drawing.Point(64, 217);
            this.checkBoxUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.checkBoxUpdate.Name = "checkBoxUpdate";
            this.checkBoxUpdate.Size = new System.Drawing.Size(97, 29);
            this.checkBoxUpdate.TabIndex = 10;
            this.checkBoxUpdate.Text = "Update";
            this.checkBoxUpdate.UseVisualStyleBackColor = true;
            this.checkBoxUpdate.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Admin_CapQuyen_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1010, 686);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Admin_CapQuyen_User";
            this.Text = "Admin_CapQuyen_User";
            this.Load += new System.EventHandler(this.Admin_CapQuyen_User_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxTable;
        private System.Windows.Forms.ComboBox comboBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.CheckBox checkBox_WithGrantOption;
        private System.Windows.Forms.CheckBox checkBoxInsert;
        private System.Windows.Forms.CheckBox checkBoxSelect;
        private System.Windows.Forms.CheckBox checkBoxUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxDelete;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button button1;
    }
}