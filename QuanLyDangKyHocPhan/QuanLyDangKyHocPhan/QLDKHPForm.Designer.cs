namespace QuanLyDangKyHocPhan
{
    partial class QLDKHPForm
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
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.btnSearch = new Guna.UI.WinForms.GunaButton();
            this.btnFilter = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.cbbNamHoc = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.cbbHK = new Guna.UI.WinForms.GunaComboBox();
            this.lvQL = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXuat = new Guna.UI.WinForms.GunaButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.cbbKhoa = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.cbbLop = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.cbbCourse = new Guna.UI.WinForms.GunaComboBox();
            this.btnThongKe = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaPanel1.Controls.Add(this.gunaLabel2);
            this.gunaPanel1.Controls.Add(this.txtSearch);
            this.gunaPanel1.Controls.Add(this.btnSearch);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1222, 64);
            this.gunaPanel1.TabIndex = 10;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(8, 16);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(243, 22);
            this.gunaLabel2.TabIndex = 16;
            this.gunaLabel2.Text = "Quản lý đăng ký học phần";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BaseColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.Silver;
            this.txtSearch.BorderSize = 1;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearch.FocusedBorderColor = System.Drawing.Color.Silver;
            this.txtSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(915, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Radius = 18;
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(295, 40);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextOffsetX = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.AnimationHoverSpeed = 0.07F;
            this.btnSearch.AnimationSpeed = 0.03F;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSearch.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.FocusedColor = System.Drawing.Color.Empty;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = null;
            this.btnSearch.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSearch.Location = new System.Drawing.Point(849, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSearch.OnHoverImage = null;
            this.btnSearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnSearch.Radius = 10;
            this.btnSearch.Size = new System.Drawing.Size(58, 34);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.btnFilter.Location = new System.Drawing.Point(1123, 70);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnFilter.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFilter.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFilter.OnHoverImage = null;
            this.btnFilter.OnPressedColor = System.Drawing.Color.Black;
            this.btnFilter.Radius = 10;
            this.btnFilter.Size = new System.Drawing.Size(87, 42);
            this.btnFilter.TabIndex = 24;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(12, 79);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(69, 20);
            this.gunaLabel1.TabIndex = 23;
            this.gunaLabel1.Text = "Năm học";
            // 
            // cbbNamHoc
            // 
            this.cbbNamHoc.BackColor = System.Drawing.Color.Transparent;
            this.cbbNamHoc.BaseColor = System.Drawing.Color.White;
            this.cbbNamHoc.BorderColor = System.Drawing.Color.Silver;
            this.cbbNamHoc.BorderSize = 1;
            this.cbbNamHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNamHoc.FocusedColor = System.Drawing.Color.Empty;
            this.cbbNamHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbNamHoc.ForeColor = System.Drawing.Color.Black;
            this.cbbNamHoc.FormattingEnabled = true;
            this.cbbNamHoc.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbbNamHoc.Location = new System.Drawing.Point(87, 73);
            this.cbbNamHoc.Name = "cbbNamHoc";
            this.cbbNamHoc.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbNamHoc.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbNamHoc.Radius = 5;
            this.cbbNamHoc.Size = new System.Drawing.Size(183, 31);
            this.cbbNamHoc.TabIndex = 22;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(12, 114);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(54, 20);
            this.gunaLabel4.TabIndex = 21;
            this.gunaLabel4.Text = "Học kỳ";
            // 
            // cbbHK
            // 
            this.cbbHK.BackColor = System.Drawing.Color.Transparent;
            this.cbbHK.BaseColor = System.Drawing.Color.White;
            this.cbbHK.BorderColor = System.Drawing.Color.Silver;
            this.cbbHK.BorderSize = 1;
            this.cbbHK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbHK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHK.FocusedColor = System.Drawing.Color.Empty;
            this.cbbHK.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbHK.ForeColor = System.Drawing.Color.Black;
            this.cbbHK.FormattingEnabled = true;
            this.cbbHK.Location = new System.Drawing.Point(87, 109);
            this.cbbHK.Name = "cbbHK";
            this.cbbHK.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbHK.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbHK.Radius = 5;
            this.cbbHK.Size = new System.Drawing.Size(183, 31);
            this.cbbHK.TabIndex = 20;
            // 
            // lvQL
            // 
            this.lvQL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvQL.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader13,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvQL.FullRowSelect = true;
            this.lvQL.GridLines = true;
            this.lvQL.HideSelection = false;
            this.lvQL.Location = new System.Drawing.Point(12, 155);
            this.lvQL.Name = "lvQL";
            this.lvQL.Size = new System.Drawing.Size(1198, 553);
            this.lvQL.TabIndex = 13;
            this.lvQL.UseCompatibleStateImageBehavior = false;
            this.lvQL.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MaSV";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "MaHP";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Họ lót";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên HP";
            this.columnHeader5.Width = 250;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Thuộc Lớp";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Loại HP";
            this.columnHeader13.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Thuộc Khoa";
            this.columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Số TC";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Sô SVDK";
            // 
            // btnXuat
            // 
            this.btnXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuat.AnimationHoverSpeed = 0.07F;
            this.btnXuat.AnimationSpeed = 0.03F;
            this.btnXuat.BackColor = System.Drawing.Color.Transparent;
            this.btnXuat.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnXuat.BorderColor = System.Drawing.Color.Black;
            this.btnXuat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXuat.FocusedColor = System.Drawing.Color.Empty;
            this.btnXuat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXuat.ForeColor = System.Drawing.Color.White;
            this.btnXuat.Image = null;
            this.btnXuat.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXuat.Location = new System.Drawing.Point(1010, 714);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnXuat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXuat.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXuat.OnHoverImage = null;
            this.btnXuat.OnPressedColor = System.Drawing.Color.Black;
            this.btnXuat.Radius = 10;
            this.btnXuat.Size = new System.Drawing.Size(200, 30);
            this.btnXuat.TabIndex = 14;
            this.btnXuat.Text = "Xuất chi tiết đăng ký";
            this.btnXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(295, 79);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(43, 20);
            this.gunaLabel3.TabIndex = 28;
            this.gunaLabel3.Text = "Khoa";
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.BackColor = System.Drawing.Color.Transparent;
            this.cbbKhoa.BaseColor = System.Drawing.Color.White;
            this.cbbKhoa.BorderColor = System.Drawing.Color.Silver;
            this.cbbKhoa.BorderSize = 1;
            this.cbbKhoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKhoa.FocusedColor = System.Drawing.Color.Empty;
            this.cbbKhoa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbKhoa.ForeColor = System.Drawing.Color.Black;
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbbKhoa.Location = new System.Drawing.Point(344, 73);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbKhoa.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbKhoa.Radius = 5;
            this.cbbKhoa.Size = new System.Drawing.Size(183, 31);
            this.cbbKhoa.TabIndex = 27;
            this.cbbKhoa.TextChanged += new System.EventHandler(this.cbbKhoa_TextChanged);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(295, 114);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(34, 20);
            this.gunaLabel5.TabIndex = 26;
            this.gunaLabel5.Text = "Lớp";
            // 
            // cbbLop
            // 
            this.cbbLop.BackColor = System.Drawing.Color.Transparent;
            this.cbbLop.BaseColor = System.Drawing.Color.White;
            this.cbbLop.BorderColor = System.Drawing.Color.Silver;
            this.cbbLop.BorderSize = 1;
            this.cbbLop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLop.FocusedColor = System.Drawing.Color.Empty;
            this.cbbLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbLop.ForeColor = System.Drawing.Color.Black;
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(344, 109);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbLop.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbLop.Radius = 5;
            this.cbbLop.Size = new System.Drawing.Size(183, 31);
            this.cbbLop.TabIndex = 25;
            this.cbbLop.TextChanged += new System.EventHandler(this.cbbLop_TextChanged);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(562, 79);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(43, 20);
            this.gunaLabel6.TabIndex = 30;
            this.gunaLabel6.Text = "Khoá";
            // 
            // cbbCourse
            // 
            this.cbbCourse.BackColor = System.Drawing.Color.Transparent;
            this.cbbCourse.BaseColor = System.Drawing.Color.White;
            this.cbbCourse.BorderColor = System.Drawing.Color.Silver;
            this.cbbCourse.BorderSize = 1;
            this.cbbCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCourse.FocusedColor = System.Drawing.Color.Empty;
            this.cbbCourse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbCourse.ForeColor = System.Drawing.Color.Black;
            this.cbbCourse.FormattingEnabled = true;
            this.cbbCourse.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbbCourse.Location = new System.Drawing.Point(611, 74);
            this.cbbCourse.Name = "cbbCourse";
            this.cbbCourse.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbCourse.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbCourse.Radius = 5;
            this.cbbCourse.Size = new System.Drawing.Size(183, 31);
            this.cbbCourse.TabIndex = 29;
            this.cbbCourse.TextChanged += new System.EventHandler(this.cbbCourse_TextChanged);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThongKe.AnimationHoverSpeed = 0.07F;
            this.btnThongKe.AnimationSpeed = 0.03F;
            this.btnThongKe.BackColor = System.Drawing.Color.Transparent;
            this.btnThongKe.BaseColor = System.Drawing.Color.Brown;
            this.btnThongKe.BorderColor = System.Drawing.Color.Black;
            this.btnThongKe.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThongKe.FocusedColor = System.Drawing.Color.Empty;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Image = null;
            this.btnThongKe.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThongKe.Location = new System.Drawing.Point(894, 714);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnThongKe.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThongKe.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThongKe.OnHoverImage = null;
            this.btnThongKe.OnPressedColor = System.Drawing.Color.Black;
            this.btnThongKe.Radius = 10;
            this.btnThongKe.Size = new System.Drawing.Size(98, 30);
            this.btnThongKe.TabIndex = 31;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // QLDKHPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 753);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.cbbCourse);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.cbbKhoa);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.cbbLop);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cbbNamHoc);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.cbbHK);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.lvQL);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QLDKHPForm";
            this.Text = "QLDKHPForm";
            this.Load += new System.EventHandler(this.QLDKHPForm_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private System.Windows.Forms.ListView lvQL;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private Guna.UI.WinForms.GunaButton btnXuat;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox cbbNamHoc;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaComboBox cbbHK;
        private Guna.UI.WinForms.GunaButton btnFilter;
        private Guna.UI.WinForms.GunaButton btnSearch;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaComboBox cbbKhoa;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaComboBox cbbLop;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaComboBox cbbCourse;
        private Guna.UI.WinForms.GunaButton btnThongKe;
    }
}