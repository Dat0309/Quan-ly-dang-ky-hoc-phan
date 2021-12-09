namespace QuanLyDangKyHocPhan
{
    partial class ThemLichThiForm
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
            this.lvLichThi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmLịchThiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.xemDanhSáchSinhViênĐăngKýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.txtNamHoc = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.cbbHocKy = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.btnFilter = new Guna.UI.WinForms.GunaButton();
            this.contextMenuStrip1.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvLichThi
            // 
            this.lvLichThi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvLichThi.ContextMenuStrip = this.contextMenuStrip1;
            this.lvLichThi.FullRowSelect = true;
            this.lvLichThi.GridLines = true;
            this.lvLichThi.HideSelection = false;
            this.lvLichThi.Location = new System.Drawing.Point(12, 107);
            this.lvLichThi.Name = "lvLichThi";
            this.lvLichThi.Size = new System.Drawing.Size(1198, 640);
            this.lvLichThi.TabIndex = 24;
            this.lvLichThi.UseCompatibleStateImageBehavior = false;
            this.lvLichThi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã HP";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Tên HP";
            this.columnHeader10.Width = 150;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Khoa";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "STC";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Số lượng SV";
            this.columnHeader13.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ngày thi";
            this.columnHeader2.Width = 124;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giờ thi";
            this.columnHeader3.Width = 121;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Phòng thi";
            this.columnHeader4.Width = 101;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Thời gian";
            this.columnHeader5.Width = 111;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Địa điểm";
            this.columnHeader6.Width = 142;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ghi chú";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmLịchThiToolStripMenuItem,
            this.toolStripSeparator1,
            this.xemDanhSáchSinhViênĐăngKýToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(296, 86);
            // 
            // thêmLịchThiToolStripMenuItem
            // 
            this.thêmLịchThiToolStripMenuItem.Name = "thêmLịchThiToolStripMenuItem";
            this.thêmLịchThiToolStripMenuItem.Size = new System.Drawing.Size(295, 24);
            this.thêmLịchThiToolStripMenuItem.Text = "Thêm lịch thi";
            this.thêmLịchThiToolStripMenuItem.Click += new System.EventHandler(this.thêmLịchThiToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(292, 6);
            // 
            // xemDanhSáchSinhViênĐăngKýToolStripMenuItem
            // 
            this.xemDanhSáchSinhViênĐăngKýToolStripMenuItem.Name = "xemDanhSáchSinhViênĐăngKýToolStripMenuItem";
            this.xemDanhSáchSinhViênĐăngKýToolStripMenuItem.Size = new System.Drawing.Size(295, 24);
            this.xemDanhSáchSinhViênĐăngKýToolStripMenuItem.Text = "Xem danh sách sinh viên đăng ký";
            this.xemDanhSáchSinhViênĐăngKýToolStripMenuItem.Click += new System.EventHandler(this.xemDanhSáchSinhViênĐăngKýToolStripMenuItem_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaPanel1.Controls.Add(this.txtNamHoc);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1222, 64);
            this.gunaPanel1.TabIndex = 19;
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.AutoSize = true;
            this.txtNamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamHoc.ForeColor = System.Drawing.Color.White;
            this.txtNamHoc.Location = new System.Drawing.Point(540, 13);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(28, 22);
            this.txtNamHoc.TabIndex = 0;
            this.txtNamHoc.Text = "...";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(12, 22);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(457, 22);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Danh sách học phần được đăng ký trong năm học:";
            // 
            // cbbHocKy
            // 
            this.cbbHocKy.BackColor = System.Drawing.Color.Transparent;
            this.cbbHocKy.BaseColor = System.Drawing.Color.White;
            this.cbbHocKy.BorderColor = System.Drawing.Color.Silver;
            this.cbbHocKy.BorderSize = 1;
            this.cbbHocKy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHocKy.FocusedColor = System.Drawing.Color.Empty;
            this.cbbHocKy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbHocKy.ForeColor = System.Drawing.Color.Black;
            this.cbbHocKy.FormattingEnabled = true;
            this.cbbHocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbbHocKy.Location = new System.Drawing.Point(77, 70);
            this.cbbHocKy.Name = "cbbHocKy";
            this.cbbHocKy.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbHocKy.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbHocKy.Radius = 10;
            this.cbbHocKy.Size = new System.Drawing.Size(121, 31);
            this.cbbHocKy.TabIndex = 23;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(12, 75);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(54, 20);
            this.gunaLabel3.TabIndex = 22;
            this.gunaLabel3.Text = "Học kỳ";
            // 
            // btnFilter
            // 
            this.btnFilter.AnimationHoverSpeed = 0.07F;
            this.btnFilter.AnimationSpeed = 0.03F;
            this.btnFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnFilter.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnFilter.BorderColor = System.Drawing.Color.Black;
            this.btnFilter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFilter.FocusedColor = System.Drawing.Color.Empty;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Image = null;
            this.btnFilter.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFilter.Location = new System.Drawing.Point(204, 70);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnFilter.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFilter.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFilter.OnHoverImage = null;
            this.btnFilter.OnPressedColor = System.Drawing.Color.Black;
            this.btnFilter.Radius = 10;
            this.btnFilter.Size = new System.Drawing.Size(98, 31);
            this.btnFilter.TabIndex = 25;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // ThemLichThiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 753);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.lvLichThi);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.cbbHocKy);
            this.Controls.Add(this.gunaLabel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThemLichThiForm";
            this.Text = "frmThemLichThi";
            this.Load += new System.EventHandler(this.ThemLichThiForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvLichThi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox cbbHocKy;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmLịchThiToolStripMenuItem;
        private Guna.UI.WinForms.GunaButton btnFilter;
        private Guna.UI.WinForms.GunaLabel txtNamHoc;
        private System.Windows.Forms.ToolStripMenuItem xemDanhSáchSinhViênĐăngKýToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}