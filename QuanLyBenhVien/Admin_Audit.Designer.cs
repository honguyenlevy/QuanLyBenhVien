
namespace QuanLyBenhVien
{
    partial class Admin_Audit
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewAudit = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonStandard = new System.Windows.Forms.RadioButton();
            this.radioButtonFineGrained = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAudit)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewAudit, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1200, 703);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridViewAudit
            // 
            this.dataGridViewAudit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewAudit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAudit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAudit.Location = new System.Drawing.Point(63, 73);
            this.dataGridViewAudit.Name = "dataGridViewAudit";
            this.dataGridViewAudit.RowHeadersWidth = 51;
            this.dataGridViewAudit.RowTemplate.Height = 24;
            this.dataGridViewAudit.Size = new System.Drawing.Size(1074, 591);
            this.dataGridViewAudit.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.5F));
            this.tableLayoutPanel2.Controls.Add(this.radioButtonStandard, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioButtonFineGrained, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(63, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1074, 64);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // radioButtonStandard
            // 
            this.radioButtonStandard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonStandard.AutoSize = true;
            this.radioButtonStandard.Location = new System.Drawing.Point(347, 3);
            this.radioButtonStandard.Name = "radioButtonStandard";
            this.radioButtonStandard.Size = new System.Drawing.Size(160, 58);
            this.radioButtonStandard.TabIndex = 0;
            this.radioButtonStandard.TabStop = true;
            this.radioButtonStandard.Text = "Standard audit";
            this.radioButtonStandard.UseVisualStyleBackColor = true;
            // 
            // radioButtonFineGrained
            // 
            this.radioButtonFineGrained.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonFineGrained.AutoSize = true;
            this.radioButtonFineGrained.Location = new System.Drawing.Point(566, 3);
            this.radioButtonFineGrained.Name = "radioButtonFineGrained";
            this.radioButtonFineGrained.Size = new System.Drawing.Size(199, 58);
            this.radioButtonFineGrained.TabIndex = 1;
            this.radioButtonFineGrained.TabStop = true;
            this.radioButtonFineGrained.Text = "Fine – grained audit";
            this.radioButtonFineGrained.UseVisualStyleBackColor = true;
            // 
            // Admin_Audit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Admin_Audit";
            this.Text = "Admin_Audit";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAudit)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewAudit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton radioButtonStandard;
        private System.Windows.Forms.RadioButton radioButtonFineGrained;
    }
}