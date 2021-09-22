
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnShow = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnClose = new Guna.UI.WinForms.GunaButton();
            this.btnUser = new Guna.UI.WinForms.GunaButton();
            this.btnDKHP = new Guna.UI.WinForms.GunaButton();
            this.btnHocPhi = new Guna.UI.WinForms.GunaButton();
            this.btnThongKe = new Guna.UI.WinForms.GunaButton();
            this.btnHocVu = new Guna.UI.WinForms.GunaButton();
            this.btnQL = new Guna.UI.WinForms.GunaButton();
            this.btnHome = new Guna.UI.WinForms.GunaButton();
            this.ucHocPhi1 = new QuanLyDangKyHocPhan.CustomControl.UCHocPhi();
            this.ucLichThi1 = new QuanLyDangKyHocPhan.CustomControl.UCLichThi();
            this.uC_LKDSHP1 = new QuanLyDangKyHocPhan.CustomControl.UC_LKDSHP();
            this.uC_LKDSSVDangKy1 = new QuanLyDangKyHocPhan.CustomControl.UC_LKDSSVDangKy();
            this.uddkhp1 = new QuanLyDangKyHocPhan.CustomControl.UDDKHP();
            this.ucqlhp1 = new QuanLyDangKyHocPhan.CustomControl.UCQLHP();
            this.controlStudentManagerment1 = new QuanLyDangKyHocPhan.CustomControl.ControlStudentManagerment();
            this.startUpControl1 = new QuanLyDangKyHocPhan.StartUpControl();
            this.ddmQuanLy = new QuanLyDangKyHocPhan.CustomControl.DropDownMenu(this.components);
            this.tsmiQLSV = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQLHP = new System.Windows.Forms.ToolStripMenuItem();
            this.ddmHocVu = new QuanLyDangKyHocPhan.CustomControl.DropDownMenu(this.components);
            this.tsmiLichThi = new System.Windows.Forms.ToolStripMenuItem();
            this.ddmThongKe = new QuanLyDangKyHocPhan.CustomControl.DropDownMenu(this.components);
            this.tsmiLKDSSV = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLKDSHP = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLapDSThi = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.pnShow.SuspendLayout();
            this.ddmQuanLy.SuspendLayout();
            this.ddmHocVu.SuspendLayout();
            this.ddmThongKe.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.slidePanel);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.btnDKHP);
            this.panel1.Controls.Add(this.btnHocPhi);
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Controls.Add(this.btnHocVu);
            this.panel1.Controls.Add(this.btnQL);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(0, 11);
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
            this.slidePanel.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1290, 10);
            this.panel2.TabIndex = 1;
            // 
            // pnShow
            // 
            this.pnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnShow.Controls.Add(this.ucHocPhi1);
            this.pnShow.Controls.Add(this.ucLichThi1);
            this.pnShow.Controls.Add(this.uC_LKDSHP1);
            this.pnShow.Controls.Add(this.uC_LKDSSVDangKy1);
            this.pnShow.Controls.Add(this.uddkhp1);
            this.pnShow.Controls.Add(this.ucqlhp1);
            this.pnShow.Controls.Add(this.controlStudentManagerment1);
            this.pnShow.Controls.Add(this.startUpControl1);
            this.pnShow.Location = new System.Drawing.Point(225, 12);
            this.pnShow.Name = "pnShow";
            this.pnShow.Size = new System.Drawing.Size(1065, 711);
            this.pnShow.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Animated = true;
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BaseColor = System.Drawing.Color.Teal;
            this.btnClose.BorderColor = System.Drawing.Color.Black;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.FocusedColor = System.Drawing.Color.Empty;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::QuanLyDangKyHocPhan.Properties.Resources.icons8_close_window_26px;
            this.btnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(12, 657);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.Teal;
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Radius = 20;
            this.btnClose.Size = new System.Drawing.Size(191, 43);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "Thoát";
            this.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnUser.Image = global::QuanLyDangKyHocPhan.Properties.Resources.icons8_male_user_64px;
            this.btnUser.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUser.Location = new System.Drawing.Point(0, 475);
            this.btnUser.Name = "btnUser";
            this.btnUser.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btnUser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUser.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUser.OnHoverImage = null;
            this.btnUser.OnPressedColor = System.Drawing.Color.Black;
            this.btnUser.Size = new System.Drawing.Size(225, 56);
            this.btnUser.TabIndex = 11;
            this.btnUser.Text = "Tài khoản";
            this.btnUser.TextOffsetX = 10;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnDKHP
            // 
            this.btnDKHP.AnimationHoverSpeed = 0.07F;
            this.btnDKHP.AnimationSpeed = 0.03F;
            this.btnDKHP.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnDKHP.BorderColor = System.Drawing.Color.Black;
            this.btnDKHP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDKHP.FocusedColor = System.Drawing.Color.Empty;
            this.btnDKHP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDKHP.ForeColor = System.Drawing.Color.White;
            this.btnDKHP.Image = global::QuanLyDangKyHocPhan.Properties.Resources.icons8_student_registration_64px;
            this.btnDKHP.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDKHP.Location = new System.Drawing.Point(0, 413);
            this.btnDKHP.Name = "btnDKHP";
            this.btnDKHP.OnHoverBaseColor = System.Drawing.Color.DimGray;
            this.btnDKHP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDKHP.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDKHP.OnHoverImage = null;
            this.btnDKHP.OnPressedColor = System.Drawing.Color.Black;
            this.btnDKHP.Size = new System.Drawing.Size(225, 56);
            this.btnDKHP.TabIndex = 9;
            this.btnDKHP.Text = "Đăng ký học phần";
            this.btnDKHP.TextOffsetX = 10;
            this.btnDKHP.Click += new System.EventHandler(this.btnDKHP_Click);
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
            this.btnHocPhi.Image = global::QuanLyDangKyHocPhan.Properties.Resources.icons8_money_bag_64px;
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
            this.btnThongKe.Image = global::QuanLyDangKyHocPhan.Properties.Resources.icons8_statistics_64px;
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
            this.btnHocVu.Image = global::QuanLyDangKyHocPhan.Properties.Resources.icons8_study_64px;
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
            this.btnQL.Image = global::QuanLyDangKyHocPhan.Properties.Resources.icons8_product_management_64px;
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
            this.btnHome.Image = global::QuanLyDangKyHocPhan.Properties.Resources.icons8_home_64px;
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
            // ucHocPhi1
            // 
            this.ucHocPhi1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucHocPhi1.Location = new System.Drawing.Point(0, 0);
            this.ucHocPhi1.Name = "ucHocPhi1";
            this.ucHocPhi1.Size = new System.Drawing.Size(1065, 711);
            this.ucHocPhi1.TabIndex = 7;
            // 
            // ucLichThi1
            // 
            this.ucLichThi1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLichThi1.Location = new System.Drawing.Point(0, 0);
            this.ucLichThi1.Name = "ucLichThi1";
            this.ucLichThi1.Size = new System.Drawing.Size(1065, 711);
            this.ucLichThi1.TabIndex = 6;
            // 
            // uC_LKDSHP1
            // 
            this.uC_LKDSHP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_LKDSHP1.Location = new System.Drawing.Point(0, 0);
            this.uC_LKDSHP1.Name = "uC_LKDSHP1";
            this.uC_LKDSHP1.Size = new System.Drawing.Size(1065, 711);
            this.uC_LKDSHP1.TabIndex = 5;
            // 
            // uC_LKDSSVDangKy1
            // 
            this.uC_LKDSSVDangKy1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_LKDSSVDangKy1.Location = new System.Drawing.Point(0, 0);
            this.uC_LKDSSVDangKy1.Name = "uC_LKDSSVDangKy1";
            this.uC_LKDSSVDangKy1.Size = new System.Drawing.Size(1065, 711);
            this.uC_LKDSSVDangKy1.TabIndex = 4;
            // 
            // uddkhp1
            // 
            this.uddkhp1.AutoScroll = true;
            this.uddkhp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uddkhp1.Location = new System.Drawing.Point(0, 0);
            this.uddkhp1.Name = "uddkhp1";
            this.uddkhp1.Size = new System.Drawing.Size(1065, 711);
            this.uddkhp1.TabIndex = 3;
            // 
            // ucqlhp1
            // 
            this.ucqlhp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucqlhp1.Location = new System.Drawing.Point(0, 0);
            this.ucqlhp1.Name = "ucqlhp1";
            this.ucqlhp1.Size = new System.Drawing.Size(1065, 711);
            this.ucqlhp1.TabIndex = 2;
            // 
            // controlStudentManagerment1
            // 
            this.controlStudentManagerment1.AutoScroll = true;
            this.controlStudentManagerment1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlStudentManagerment1.Location = new System.Drawing.Point(0, 0);
            this.controlStudentManagerment1.Name = "controlStudentManagerment1";
            this.controlStudentManagerment1.Size = new System.Drawing.Size(1065, 711);
            this.controlStudentManagerment1.TabIndex = 1;
            // 
            // startUpControl1
            // 
            this.startUpControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startUpControl1.Location = new System.Drawing.Point(3, 0);
            this.startUpControl1.Name = "startUpControl1";
            this.startUpControl1.Size = new System.Drawing.Size(1049, 672);
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
            this.tsmiQLSV.Click += new System.EventHandler(this.tsmiQLSV_Click);
            // 
            // tsmiQLHP
            // 
            this.tsmiQLHP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiQLHP.ForeColor = System.Drawing.Color.White;
            this.tsmiQLHP.Name = "tsmiQLHP";
            this.tsmiQLHP.Size = new System.Drawing.Size(197, 24);
            this.tsmiQLHP.Text = "Quản lý học phần";
            this.tsmiQLHP.Click += new System.EventHandler(this.tsmiQLHP_Click);
            // 
            // ddmHocVu
            // 
            this.ddmHocVu.IsMainMenu = false;
            this.ddmHocVu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLichThi});
            this.ddmHocVu.MenuItemHeight = 25;
            this.ddmHocVu.MenuItemTextColor = System.Drawing.Color.Empty;
            this.ddmHocVu.Name = "ddmHocVu";
            this.ddmHocVu.PrimaryColor = System.Drawing.Color.Empty;
            this.ddmHocVu.Size = new System.Drawing.Size(128, 28);
            // 
            // tsmiLichThi
            // 
            this.tsmiLichThi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiLichThi.ForeColor = System.Drawing.Color.White;
            this.tsmiLichThi.Name = "tsmiLichThi";
            this.tsmiLichThi.Size = new System.Drawing.Size(127, 24);
            this.tsmiLichThi.Text = "Lịch thi";
            this.tsmiLichThi.Click += new System.EventHandler(this.tsmiLichThi_Click);
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
            this.ddmThongKe.Size = new System.Drawing.Size(166, 76);
            // 
            // tsmiLKDSSV
            // 
            this.tsmiLKDSSV.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiLKDSSV.ForeColor = System.Drawing.Color.White;
            this.tsmiLKDSSV.Name = "tsmiLKDSSV";
            this.tsmiLKDSSV.Size = new System.Drawing.Size(165, 24);
            this.tsmiLKDSSV.Text = "Liệt kê DSSV";
            this.tsmiLKDSSV.Click += new System.EventHandler(this.tsmiLKDSSV_Click);
            // 
            // tsmiLKDSHP
            // 
            this.tsmiLKDSHP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiLKDSHP.ForeColor = System.Drawing.Color.White;
            this.tsmiLKDSHP.Name = "tsmiLKDSHP";
            this.tsmiLKDSHP.Size = new System.Drawing.Size(165, 24);
            this.tsmiLKDSHP.Text = "Liệt kê DSHP";
            this.tsmiLKDSHP.Click += new System.EventHandler(this.tsmiLKDSHP_Click);
            // 
            // tsmiLapDSThi
            // 
            this.tsmiLapDSThi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiLapDSThi.ForeColor = System.Drawing.Color.White;
            this.tsmiLapDSThi.Name = "tsmiLapDSThi";
            this.tsmiLapDSThi.Size = new System.Drawing.Size(165, 24);
            this.tsmiLapDSThi.Text = "Lập DS Thi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 723);
            this.Controls.Add(this.pnShow);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.pnShow.ResumeLayout(false);
            this.ddmQuanLy.ResumeLayout(false);
            this.ddmHocVu.ResumeLayout(false);
            this.ddmThongKe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnShow;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Guna.UI.WinForms.GunaButton btnHome;
        private Guna.UI.WinForms.GunaButton btnDKHP;
        private Guna.UI.WinForms.GunaButton btnHocPhi;
        private Guna.UI.WinForms.GunaButton btnThongKe;
        private Guna.UI.WinForms.GunaButton btnHocVu;
        private Guna.UI.WinForms.GunaButton btnQL;
        private CustomControl.DropDownMenu ddmQuanLy;
        private System.Windows.Forms.ToolStripMenuItem tsmiQLSV;
        private System.Windows.Forms.ToolStripMenuItem tsmiQLHP;
        private CustomControl.DropDownMenu ddmHocVu;
        private System.Windows.Forms.ToolStripMenuItem tsmiLichThi;
        private CustomControl.DropDownMenu ddmThongKe;
        private System.Windows.Forms.ToolStripMenuItem tsmiLKDSSV;
        private System.Windows.Forms.ToolStripMenuItem tsmiLKDSHP;
        private System.Windows.Forms.ToolStripMenuItem tsmiLapDSThi;
        private CustomControl.ControlStudentManagerment controlStudentManagerment1;
        private StartUpControl startUpControl1;
        private CustomControl.UCQLHP ucqlhp1;
        private Guna.UI.WinForms.GunaButton btnUser;
        private System.Windows.Forms.Panel slidePanel;
        private CustomControl.UDDKHP uddkhp1;
        private CustomControl.UC_LKDSSVDangKy uC_LKDSSVDangKy1;
        private CustomControl.UC_LKDSHP uC_LKDSHP1;
        private CustomControl.UCLichThi ucLichThi1;
        private CustomControl.UCHocPhi ucHocPhi1;
        private Guna.UI.WinForms.GunaButton btnClose;
    }
}

