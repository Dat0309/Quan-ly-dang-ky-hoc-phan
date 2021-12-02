namespace QuanLyDangKyHocPhan
{
    partial class HocPhiForm
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
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lvHP = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtHocPhi = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtSoTienBangChu = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1222, 51);
            this.gunaPanel1.TabIndex = 13;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(22, 13);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(78, 22);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Học phí";
            // 
            // lvHP
            // 
            this.lvHP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvHP.FullRowSelect = true;
            this.lvHP.GridLines = true;
            this.lvHP.HideSelection = false;
            this.lvHP.Location = new System.Drawing.Point(12, 82);
            this.lvHP.Name = "lvHP";
            this.lvHP.Size = new System.Drawing.Size(1198, 580);
            this.lvHP.TabIndex = 14;
            this.lvHP.UseCompatibleStateImageBehavior = false;
            this.lvHP.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã phí";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên phí";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Còn nợ";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày cập nhật";
            this.columnHeader4.Width = 300;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(12, 674);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(179, 22);
            this.gunaLabel2.TabIndex = 15;
            this.gunaLabel2.Text = "Tổng học phí còn nợ:";
            // 
            // txtHocPhi
            // 
            this.txtHocPhi.BaseColor = System.Drawing.Color.White;
            this.txtHocPhi.BorderColor = System.Drawing.Color.Silver;
            this.txtHocPhi.BorderSize = 1;
            this.txtHocPhi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHocPhi.Enabled = false;
            this.txtHocPhi.FocusedBaseColor = System.Drawing.Color.White;
            this.txtHocPhi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtHocPhi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtHocPhi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHocPhi.Location = new System.Drawing.Point(286, 672);
            this.txtHocPhi.Name = "txtHocPhi";
            this.txtHocPhi.PasswordChar = '\0';
            this.txtHocPhi.ReadOnly = true;
            this.txtHocPhi.SelectedText = "";
            this.txtHocPhi.Size = new System.Drawing.Size(116, 32);
            this.txtHocPhi.TabIndex = 16;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(197, 676);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(62, 20);
            this.gunaLabel3.TabIndex = 17;
            this.gunaLabel3.Text = "Bằng số";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(197, 715);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(71, 20);
            this.gunaLabel4.TabIndex = 18;
            this.gunaLabel4.Text = "Bằng chữ";
            // 
            // txtSoTienBangChu
            // 
            this.txtSoTienBangChu.AutoSize = true;
            this.txtSoTienBangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTienBangChu.Location = new System.Drawing.Point(282, 713);
            this.txtSoTienBangChu.Name = "txtSoTienBangChu";
            this.txtSoTienBangChu.Size = new System.Drawing.Size(0, 22);
            this.txtSoTienBangChu.TabIndex = 19;
            // 
            // HocPhiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 753);
            this.Controls.Add(this.txtSoTienBangChu);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.txtHocPhi);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.lvHP);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HocPhiForm";
            this.Text = "HocPhiForm";
            this.Load += new System.EventHandler(this.HocPhiForm_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.ListView lvHP;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtHocPhi;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel txtSoTienBangChu;
    }
}