﻿
namespace QuanLyDangKyHocPhan
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.slidePanel = new System.Windows.Forms.Panel();
            this.btnUser = new Guna.UI.WinForms.GunaButton();
            this.btnHocPhi = new Guna.UI.WinForms.GunaButton();
            this.btnThongKe = new Guna.UI.WinForms.GunaButton();
            this.btnHocVu = new Guna.UI.WinForms.GunaButton();
            this.btnQL = new Guna.UI.WinForms.GunaButton();
            this.btnHome = new Guna.UI.WinForms.GunaButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.startUpControl1 = new QuanLyDangKyHocPhan.StartUpControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.ddmQuanLy = new QuanLyDangKyHocPhan.CustomControl.DropDownMenu(this.components);
            this.tsmiQLSV = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQLHP = new System.Windows.Forms.ToolStripMenuItem();
            this.ddmHocVu = new QuanLyDangKyHocPhan.CustomControl.DropDownMenu(this.components);
            this.tsmiCTDT = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLichThi = new System.Windows.Forms.ToolStripMenuItem();
            this.ddmThongKe = new QuanLyDangKyHocPhan.CustomControl.DropDownMenu(this.components);
            this.tsmiLKDSSV = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLKDSHP = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLapDSThi = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.ddmQuanLy.SuspendLayout();
            this.ddmHocVu.SuspendLayout();
            this.ddmThongKe.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.slidePanel);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.btnHocPhi);
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Controls.Add(this.btnHocVu);
            this.panel1.Controls.Add(this.btnQL);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 723);
            this.panel1.TabIndex = 0;
            // 
            // slidePanel
            // 
            this.slidePanel.BackColor = System.Drawing.Color.Teal;
            this.slidePanel.Location = new System.Drawing.Point(0, 89);
            this.slidePanel.Name = "slidePanel";
            this.slidePanel.Size = new System.Drawing.Size(10, 56);
            this.slidePanel.TabIndex = 10;
            // 
            // btnUser
            // 
            this.btnUser.AnimationHoverSpeed = 0.07F;
            this.btnUser.AnimationSpeed = 0.03F;
            this.btnUser.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnUser.BorderColor = System.Drawing.Color.Black;
            this.btnUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUser.FocusedColor = System.Drawing.Color.Empty;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = null;
            this.btnUser.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUser.Location = new System.Drawing.Point(0, 413);
            this.btnUser.Name = "btnUser";
            this.btnUser.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btnUser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUser.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUser.OnHoverImage = null;
            this.btnUser.OnPressedColor = System.Drawing.Color.Black;
            this.btnUser.Size = new System.Drawing.Size(225, 56);
            this.btnUser.TabIndex = 9;
            this.btnUser.Text = "Tài khoản";
            this.btnUser.TextOffsetX = 10;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnHocPhi
            // 
            this.btnHocPhi.AnimationHoverSpeed = 0.07F;
            this.btnHocPhi.AnimationSpeed = 0.03F;
            this.btnHocPhi.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnHocPhi.BorderColor = System.Drawing.Color.Black;
            this.btnHocPhi.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHocPhi.FocusedColor = System.Drawing.Color.Empty;
            this.btnHocPhi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHocPhi.ForeColor = System.Drawing.Color.White;
            this.btnHocPhi.Image = null;
            this.btnHocPhi.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHocPhi.Location = new System.Drawing.Point(0, 346);
            this.btnHocPhi.Name = "btnHocPhi";
            this.btnHocPhi.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btnHocPhi.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHocPhi.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHocPhi.OnHoverImage = null;
            this.btnHocPhi.OnPressedColor = System.Drawing.Color.Black;
            this.btnHocPhi.Size = new System.Drawing.Size(225, 56);
            this.btnHocPhi.TabIndex = 8;
            this.btnHocPhi.Text = "Học phí";
            this.btnHocPhi.TextOffsetX = 10;
            this.btnHocPhi.Click += new System.EventHandler(this.btnHocPhi_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.AnimationHoverSpeed = 0.07F;
            this.btnThongKe.AnimationSpeed = 0.03F;
            this.btnThongKe.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnThongKe.BorderColor = System.Drawing.Color.Black;
            this.btnThongKe.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThongKe.FocusedColor = System.Drawing.Color.Empty;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Image = null;
            this.btnThongKe.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThongKe.Location = new System.Drawing.Point(0, 280);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btnThongKe.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThongKe.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThongKe.OnHoverImage = null;
            this.btnThongKe.OnPressedColor = System.Drawing.Color.Black;
            this.btnThongKe.Size = new System.Drawing.Size(225, 56);
            this.btnThongKe.TabIndex = 7;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextOffsetX = 10;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnHocVu
            // 
            this.btnHocVu.AnimationHoverSpeed = 0.07F;
            this.btnHocVu.AnimationSpeed = 0.03F;
            this.btnHocVu.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnHocVu.BorderColor = System.Drawing.Color.Black;
            this.btnHocVu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHocVu.FocusedColor = System.Drawing.Color.Empty;
            this.btnHocVu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHocVu.ForeColor = System.Drawing.Color.White;
            this.btnHocVu.Image = null;
            this.btnHocVu.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHocVu.Location = new System.Drawing.Point(0, 214);
            this.btnHocVu.Name = "btnHocVu";
            this.btnHocVu.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btnHocVu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHocVu.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHocVu.OnHoverImage = null;
            this.btnHocVu.OnPressedColor = System.Drawing.Color.Black;
            this.btnHocVu.Size = new System.Drawing.Size(225, 56);
            this.btnHocVu.TabIndex = 6;
            this.btnHocVu.Text = "Học vụ";
            this.btnHocVu.TextOffsetX = 10;
            this.btnHocVu.Click += new System.EventHandler(this.btnHocVu_Click);
            // 
            // btnQL
            // 
            this.btnQL.AnimationHoverSpeed = 0.07F;
            this.btnQL.AnimationSpeed = 0.03F;
            this.btnQL.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnQL.BorderColor = System.Drawing.Color.Black;
            this.btnQL.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnQL.FocusedColor = System.Drawing.Color.Empty;
            this.btnQL.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQL.ForeColor = System.Drawing.Color.White;
            this.btnQL.Image = null;
            this.btnQL.ImageSize = new System.Drawing.Size(20, 20);
            this.btnQL.Location = new System.Drawing.Point(0, 150);
            this.btnQL.Name = "btnQL";
            this.btnQL.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btnQL.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnQL.OnHoverForeColor = System.Drawing.Color.White;
            this.btnQL.OnHoverImage = null;
            this.btnQL.OnPressedColor = System.Drawing.Color.Black;
            this.btnQL.Size = new System.Drawing.Size(225, 56);
            this.btnQL.TabIndex = 4;
            this.btnQL.Text = "Quản lý";
            this.btnQL.TextOffsetX = 10;
            this.btnQL.Click += new System.EventHandler(this.btnQL_Click);
            // 
            // btnHome
            // 
            this.btnHome.AnimationHoverSpeed = 0.07F;
            this.btnHome.AnimationSpeed = 0.03F;
            this.btnHome.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnHome.BorderColor = System.Drawing.Color.Black;
            this.btnHome.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHome.FocusedColor = System.Drawing.Color.Empty;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = null;
            this.btnHome.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHome.Location = new System.Drawing.Point(0, 89);
            this.btnHome.Name = "btnHome";
            this.btnHome.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btnHome.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHome.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHome.OnHoverImage = null;
            this.btnHome.OnPressedColor = System.Drawing.Color.Black;
            this.btnHome.Size = new System.Drawing.Size(225, 56);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextOffsetX = 10;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(225, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1065, 18);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.startUpControl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(225, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1065, 711);
            this.panel4.TabIndex = 2;
            // 
            // startUpControl1
            // 
            this.startUpControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startUpControl1.Location = new System.Drawing.Point(0, 0);
            this.startUpControl1.Name = "startUpControl1";
            this.startUpControl1.Size = new System.Drawing.Size(1065, 684);
            this.startUpControl1.TabIndex = 0;
            // 
            // ddmQuanLy
            // 
            this.ddmQuanLy.IsMainMenu = false;
            this.ddmQuanLy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiQLSV,
            this.tsmiQLHP});
            this.ddmQuanLy.MenuItemHeight = 25;
            this.ddmQuanLy.MenuItemTextColor = System.Drawing.Color.Empty;
            this.ddmQuanLy.Name = "dropDownMenu1";
            this.ddmQuanLy.PrimaryColor = System.Drawing.Color.Empty;
            this.ddmQuanLy.Size = new System.Drawing.Size(198, 52);
            // 
            // tsmiQLSV
            // 
            this.tsmiQLSV.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiQLSV.ForeColor = System.Drawing.Color.White;
            this.tsmiQLSV.Name = "tsmiQLSV";
            this.tsmiQLSV.Size = new System.Drawing.Size(197, 24);
            this.tsmiQLSV.Text = "Quản lý sinh viên";
            // 
            // tsmiQLHP
            // 
            this.tsmiQLHP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiQLHP.ForeColor = System.Drawing.Color.White;
            this.tsmiQLHP.Name = "tsmiQLHP";
            this.tsmiQLHP.Size = new System.Drawing.Size(197, 24);
            this.tsmiQLHP.Text = "Quản lý học phần";
            // 
            // ddmHocVu
            // 
            this.ddmHocVu.IsMainMenu = false;
            this.ddmHocVu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCTDT,
            this.tsmiLichThi});
            this.ddmHocVu.MenuItemHeight = 25;
            this.ddmHocVu.MenuItemTextColor = System.Drawing.Color.Empty;
            this.ddmHocVu.Name = "ddmHocVu";
            this.ddmHocVu.PrimaryColor = System.Drawing.Color.Empty;
            this.ddmHocVu.Size = new System.Drawing.Size(154, 52);
            // 
            // tsmiCTDT
            // 
            this.tsmiCTDT.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiCTDT.ForeColor = System.Drawing.Color.White;
            this.tsmiCTDT.Name = "tsmiCTDT";
            this.tsmiCTDT.Size = new System.Drawing.Size(153, 24);
            this.tsmiCTDT.Text = "CT Đào tạo";
            // 
            // tsmiLichThi
            // 
            this.tsmiLichThi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiLichThi.ForeColor = System.Drawing.Color.White;
            this.tsmiLichThi.Name = "tsmiLichThi";
            this.tsmiLichThi.Size = new System.Drawing.Size(153, 24);
            this.tsmiLichThi.Text = "Lịch thi";
            // 
            // ddmThongKe
            // 
            this.ddmThongKe.IsMainMenu = false;
            this.ddmThongKe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLKDSSV,
            this.tsmiLKDSHP,
            this.tsmiLapDSThi});
            this.ddmThongKe.MenuItemHeight = 25;
            this.ddmThongKe.MenuItemTextColor = System.Drawing.Color.Empty;
            this.ddmThongKe.Name = "ddmThongKe";
            this.ddmThongKe.PrimaryColor = System.Drawing.Color.Empty;
            this.ddmThongKe.Size = new System.Drawing.Size(181, 98);
            // 
            // tsmiLKDSSV
            // 
            this.tsmiLKDSSV.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiLKDSSV.ForeColor = System.Drawing.Color.White;
            this.tsmiLKDSSV.Name = "tsmiLKDSSV";
            this.tsmiLKDSSV.Size = new System.Drawing.Size(180, 24);
            this.tsmiLKDSSV.Text = "Liệt kê DSSV";
            // 
            // tsmiLKDSHP
            // 
            this.tsmiLKDSHP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiLKDSHP.ForeColor = System.Drawing.Color.White;
            this.tsmiLKDSHP.Name = "tsmiLKDSHP";
            this.tsmiLKDSHP.Size = new System.Drawing.Size(180, 24);
            this.tsmiLKDSHP.Text = "Liệt kê DSHP";
            // 
            // tsmiLapDSThi
            // 
            this.tsmiLapDSThi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiLapDSThi.ForeColor = System.Drawing.Color.White;
            this.tsmiLapDSThi.Name = "tsmiLapDSThi";
            this.tsmiLapDSThi.Size = new System.Drawing.Size(180, 24);
            this.tsmiLapDSThi.Text = "Lập DS Thi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 723);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ddmQuanLy.ResumeLayout(false);
            this.ddmHocVu.ResumeLayout(false);
            this.ddmThongKe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private StartUpControl startUpControl1;
        private Guna.UI.WinForms.GunaButton btnHome;
        private Guna.UI.WinForms.GunaButton btnUser;
        private Guna.UI.WinForms.GunaButton btnHocPhi;
        private Guna.UI.WinForms.GunaButton btnThongKe;
        private Guna.UI.WinForms.GunaButton btnHocVu;
        private Guna.UI.WinForms.GunaButton btnQL;
        private CustomControl.DropDownMenu ddmQuanLy;
        private System.Windows.Forms.ToolStripMenuItem tsmiQLSV;
        private System.Windows.Forms.ToolStripMenuItem tsmiQLHP;
        private System.Windows.Forms.Panel slidePanel;
        private CustomControl.DropDownMenu ddmHocVu;
        private System.Windows.Forms.ToolStripMenuItem tsmiCTDT;
        private System.Windows.Forms.ToolStripMenuItem tsmiLichThi;
        private CustomControl.DropDownMenu ddmThongKe;
        private System.Windows.Forms.ToolStripMenuItem tsmiLKDSSV;
        private System.Windows.Forms.ToolStripMenuItem tsmiLKDSHP;
        private System.Windows.Forms.ToolStripMenuItem tsmiLapDSThi;
    }
}

