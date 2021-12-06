namespace QuanLyDangKyHocPhan
{
    partial class TaiKhoanInfo
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
            this.btnCapNhat = new Guna.UI2.WinForms.Guna2Button();
            this.cbbIDQuyen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayLapTK = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaikhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHoTenNguoiLap = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDTaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.rdbtnFalse = new System.Windows.Forms.RadioButton();
            this.rdbtnTrue = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BorderColor = System.Drawing.Color.White;
            this.btnCapNhat.BorderRadius = 18;
            this.btnCapNhat.CheckedState.Parent = this.btnCapNhat;
            this.btnCapNhat.CustomImages.Parent = this.btnCapNhat;
            this.btnCapNhat.FillColor = System.Drawing.Color.Teal;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.HoverState.Parent = this.btnCapNhat;
            this.btnCapNhat.Location = new System.Drawing.Point(471, 208);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.ShadowDecoration.Parent = this.btnCapNhat;
            this.btnCapNhat.Size = new System.Drawing.Size(119, 45);
            this.btnCapNhat.TabIndex = 31;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // cbbIDQuyen
            // 
            this.cbbIDQuyen.BackColor = System.Drawing.Color.Transparent;
            this.cbbIDQuyen.BorderColor = System.Drawing.Color.Teal;
            this.cbbIDQuyen.BorderRadius = 5;
            this.cbbIDQuyen.BorderThickness = 2;
            this.cbbIDQuyen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbIDQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbIDQuyen.FocusedColor = System.Drawing.Color.Empty;
            this.cbbIDQuyen.FocusedState.Parent = this.cbbIDQuyen;
            this.cbbIDQuyen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbIDQuyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbIDQuyen.FormattingEnabled = true;
            this.cbbIDQuyen.HoverState.Parent = this.cbbIDQuyen;
            this.cbbIDQuyen.ItemHeight = 30;
            this.cbbIDQuyen.ItemsAppearance.Parent = this.cbbIDQuyen;
            this.cbbIDQuyen.Location = new System.Drawing.Point(501, 125);
            this.cbbIDQuyen.Name = "cbbIDQuyen";
            this.cbbIDQuyen.ShadowDecoration.Parent = this.cbbIDQuyen;
            this.cbbIDQuyen.Size = new System.Drawing.Size(225, 36);
            this.cbbIDQuyen.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Họ Tên Người Lập:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tài Khoản:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Mật Khẩu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "ID Quyền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "ID Tài Khoản:";
            // 
            // dtpNgayLapTK
            // 
            this.dtpNgayLapTK.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLapTK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLapTK.Location = new System.Drawing.Point(137, 175);
            this.dtpNgayLapTK.Name = "dtpNgayLapTK";
            this.dtpNgayLapTK.Size = new System.Drawing.Size(158, 22);
            this.dtpNgayLapTK.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ngày Lập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 19;
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.BorderColor = System.Drawing.Color.Teal;
            this.txtTaikhoan.BorderRadius = 5;
            this.txtTaikhoan.BorderThickness = 2;
            this.txtTaikhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaikhoan.DefaultText = "";
            this.txtTaikhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTaikhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTaikhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaikhoan.DisabledState.Parent = this.txtTaikhoan;
            this.txtTaikhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaikhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaikhoan.FocusedState.Parent = this.txtTaikhoan;
            this.txtTaikhoan.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtTaikhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaikhoan.HoverState.Parent = this.txtTaikhoan;
            this.txtTaikhoan.Location = new System.Drawing.Point(137, 63);
            this.txtTaikhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.PasswordChar = '\0';
            this.txtTaikhoan.PlaceholderForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtTaikhoan.PlaceholderText = "Tài Khoản...";
            this.txtTaikhoan.SelectedText = "";
            this.txtTaikhoan.ShadowDecoration.Parent = this.txtTaikhoan;
            this.txtTaikhoan.Size = new System.Drawing.Size(158, 36);
            this.txtTaikhoan.TabIndex = 14;
            // 
            // txtHoTenNguoiLap
            // 
            this.txtHoTenNguoiLap.BorderColor = System.Drawing.Color.Teal;
            this.txtHoTenNguoiLap.BorderRadius = 5;
            this.txtHoTenNguoiLap.BorderThickness = 2;
            this.txtHoTenNguoiLap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTenNguoiLap.DefaultText = "";
            this.txtHoTenNguoiLap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoTenNguoiLap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoTenNguoiLap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTenNguoiLap.DisabledState.Parent = this.txtHoTenNguoiLap;
            this.txtHoTenNguoiLap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTenNguoiLap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTenNguoiLap.FocusedState.Parent = this.txtHoTenNguoiLap;
            this.txtHoTenNguoiLap.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtHoTenNguoiLap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTenNguoiLap.HoverState.Parent = this.txtHoTenNguoiLap;
            this.txtHoTenNguoiLap.Location = new System.Drawing.Point(501, 63);
            this.txtHoTenNguoiLap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoTenNguoiLap.Name = "txtHoTenNguoiLap";
            this.txtHoTenNguoiLap.PasswordChar = '\0';
            this.txtHoTenNguoiLap.PlaceholderForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtHoTenNguoiLap.PlaceholderText = "Họ Tên Người Lập...";
            this.txtHoTenNguoiLap.SelectedText = "";
            this.txtHoTenNguoiLap.ShadowDecoration.Parent = this.txtHoTenNguoiLap;
            this.txtHoTenNguoiLap.Size = new System.Drawing.Size(225, 36);
            this.txtHoTenNguoiLap.TabIndex = 13;
            // 
            // txtIDTaiKhoan
            // 
            this.txtIDTaiKhoan.BorderColor = System.Drawing.Color.Teal;
            this.txtIDTaiKhoan.BorderRadius = 5;
            this.txtIDTaiKhoan.BorderThickness = 2;
            this.txtIDTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDTaiKhoan.DefaultText = "";
            this.txtIDTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDTaiKhoan.DisabledState.Parent = this.txtIDTaiKhoan;
            this.txtIDTaiKhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDTaiKhoan.Enabled = false;
            this.txtIDTaiKhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDTaiKhoan.FocusedState.Parent = this.txtIDTaiKhoan;
            this.txtIDTaiKhoan.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtIDTaiKhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDTaiKhoan.HoverState.Parent = this.txtIDTaiKhoan;
            this.txtIDTaiKhoan.Location = new System.Drawing.Point(137, 9);
            this.txtIDTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDTaiKhoan.Name = "txtIDTaiKhoan";
            this.txtIDTaiKhoan.PasswordChar = '\0';
            this.txtIDTaiKhoan.PlaceholderForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtIDTaiKhoan.PlaceholderText = "TD Tài Khoản...";
            this.txtIDTaiKhoan.ReadOnly = true;
            this.txtIDTaiKhoan.SelectedText = "";
            this.txtIDTaiKhoan.ShadowDecoration.Parent = this.txtIDTaiKhoan;
            this.txtIDTaiKhoan.Size = new System.Drawing.Size(158, 36);
            this.txtIDTaiKhoan.TabIndex = 15;
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 18;
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.FillColor = System.Drawing.Color.Teal;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Location = new System.Drawing.Point(607, 208);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(119, 45);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // rdbtnFalse
            // 
            this.rdbtnFalse.AutoSize = true;
            this.rdbtnFalse.Location = new System.Drawing.Point(632, 17);
            this.rdbtnFalse.Name = "rdbtnFalse";
            this.rdbtnFalse.Size = new System.Drawing.Size(62, 20);
            this.rdbtnFalse.TabIndex = 17;
            this.rdbtnFalse.TabStop = true;
            this.rdbtnFalse.Text = "False";
            this.rdbtnFalse.UseVisualStyleBackColor = true;
            // 
            // rdbtnTrue
            // 
            this.rdbtnTrue.AutoSize = true;
            this.rdbtnTrue.Location = new System.Drawing.Point(534, 17);
            this.rdbtnTrue.Name = "rdbtnTrue";
            this.rdbtnTrue.Size = new System.Drawing.Size(56, 20);
            this.rdbtnTrue.TabIndex = 16;
            this.rdbtnTrue.TabStop = true;
            this.rdbtnTrue.Text = "True";
            this.rdbtnTrue.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Trạng Thái:";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderColor = System.Drawing.Color.Teal;
            this.txtMatKhau.BorderRadius = 5;
            this.txtMatKhau.BorderThickness = 2;
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.DefaultText = "123456";
            this.txtMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.DisabledState.Parent = this.txtMatKhau;
            this.txtMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.Enabled = false;
            this.txtMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.FocusedState.Parent = this.txtMatKhau;
            this.txtMatKhau.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.HoverState.Parent = this.txtMatKhau;
            this.txtMatKhau.Location = new System.Drawing.Point(137, 119);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '\0';
            this.txtMatKhau.PlaceholderForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtMatKhau.PlaceholderText = "";
            this.txtMatKhau.ReadOnly = true;
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.SelectionStart = 6;
            this.txtMatKhau.ShadowDecoration.Parent = this.txtMatKhau;
            this.txtMatKhau.Size = new System.Drawing.Size(158, 36);
            this.txtMatKhau.TabIndex = 14;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // btnReset
            // 
            this.btnReset.BorderColor = System.Drawing.Color.White;
            this.btnReset.BorderRadius = 18;
            this.btnReset.CheckedState.Parent = this.btnReset;
            this.btnReset.CustomImages.Parent = this.btnReset;
            this.btnReset.Enabled = false;
            this.btnReset.FillColor = System.Drawing.Color.Maroon;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.HoverState.Parent = this.btnReset;
            this.btnReset.Location = new System.Drawing.Point(324, 208);
            this.btnReset.Name = "btnReset";
            this.btnReset.ShadowDecoration.Parent = this.btnReset;
            this.btnReset.Size = new System.Drawing.Size(131, 45);
            this.btnReset.TabIndex = 32;
            this.btnReset.Text = "Reset mật khẩu";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // TaiKhoanInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 265);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.cbbIDQuyen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpNgayLapTK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbtnFalse);
            this.Controls.Add(this.rdbtnTrue);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaikhoan);
            this.Controls.Add(this.txtHoTenNguoiLap);
            this.Controls.Add(this.txtIDTaiKhoan);
            this.Controls.Add(this.btnThem);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "TaiKhoanInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaiKhoanInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCapNhat;
        private Guna.UI2.WinForms.Guna2ComboBox cbbIDQuyen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayLapTK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtTaikhoan;
        private Guna.UI2.WinForms.Guna2TextBox txtHoTenNguoiLap;
        private Guna.UI2.WinForms.Guna2TextBox txtIDTaiKhoan;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private System.Windows.Forms.RadioButton rdbtnFalse;
        private System.Windows.Forms.RadioButton rdbtnTrue;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhau;
        private Guna.UI2.WinForms.Guna2Button btnReset;
    }
}