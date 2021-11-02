
namespace QuanLyDangKyHocPhan.CustomControl
{
    partial class ControlStudentManagerment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvDSSV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTen = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txtDiaChi = new Guna.UI.WinForms.GunaTextBox();
            this.dtpNS = new Guna.UI.WinForms.GunaDateTimePicker();
            this.txtHo = new Guna.UI.WinForms.GunaTextBox();
            this.cbbLop = new Guna.UI.WinForms.GunaComboBox();
            this.txtMSSV = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btnDelete = new Guna.UI.WinForms.GunaButton();
            this.btnUpdate = new Guna.UI.WinForms.GunaButton();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lvDSSV);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(452, 220);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(949, 615);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // lvDSSV
            // 
            this.lvDSSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDSSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7});
            this.lvDSSV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDSSV.FullRowSelect = true;
            this.lvDSSV.GridLines = true;
            this.lvDSSV.HideSelection = false;
            this.lvDSSV.Location = new System.Drawing.Point(4, 26);
            this.lvDSSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvDSSV.Name = "lvDSSV";
            this.lvDSSV.Size = new System.Drawing.Size(940, 585);
            this.lvDSSV.TabIndex = 0;
            this.lvDSSV.UseCompatibleStateImageBehavior = false;
            this.lvDSSV.View = System.Windows.Forms.View.Details;
            this.lvDSSV.SelectedIndexChanged += new System.EventHandler(this.lvDSSV_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MSSV";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ";
            this.columnHeader2.Width = 94;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên";
            this.columnHeader3.Width = 65;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày sinh";
            this.columnHeader4.Width = 115;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Địa chỉ";
            this.columnHeader5.Width = 248;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Lớp";
            this.columnHeader7.Width = 119;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.txtTen);
            this.groupBox2.Controls.Add(this.gunaLabel7);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.dtpNS);
            this.groupBox2.Controls.Add(this.txtHo);
            this.groupBox2.Controls.Add(this.cbbLop);
            this.groupBox2.Controls.Add(this.txtMSSV);
            this.groupBox2.Controls.Add(this.gunaLabel8);
            this.groupBox2.Controls.Add(this.gunaLabel6);
            this.groupBox2.Controls.Add(this.gunaLabel5);
            this.groupBox2.Controls.Add(this.gunaLabel4);
            this.groupBox2.Controls.Add(this.gunaLabel3);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 220);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(425, 615);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.Color.Transparent;
            this.txtTen.BaseColor = System.Drawing.Color.White;
            this.txtTen.BorderColor = System.Drawing.Color.Silver;
            this.txtTen.BorderSize = 1;
            this.txtTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTen.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTen.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTen.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTen.Location = new System.Drawing.Point(135, 261);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTen.Name = "txtTen";
            this.txtTen.PasswordChar = '\0';
            this.txtTen.Radius = 3;
            this.txtTen.SelectedText = "";
            this.txtTen.Size = new System.Drawing.Size(283, 37);
            this.txtTen.TabIndex = 12;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(9, 270);
            this.gunaLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(41, 25);
            this.gunaLabel7.TabIndex = 11;
            this.gunaLabel7.Text = "Tên";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.Transparent;
            this.txtDiaChi.BaseColor = System.Drawing.Color.White;
            this.txtDiaChi.BorderColor = System.Drawing.Color.Silver;
            this.txtDiaChi.BorderSize = 1;
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDiaChi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDiaChi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiaChi.Location = new System.Drawing.Point(135, 319);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.Radius = 3;
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(283, 37);
            this.txtDiaChi.TabIndex = 10;
            // 
            // dtpNS
            // 
            this.dtpNS.BackColor = System.Drawing.Color.Transparent;
            this.dtpNS.BaseColor = System.Drawing.Color.White;
            this.dtpNS.BorderColor = System.Drawing.Color.Silver;
            this.dtpNS.BorderSize = 1;
            this.dtpNS.CustomFormat = null;
            this.dtpNS.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpNS.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpNS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNS.ForeColor = System.Drawing.Color.Black;
            this.dtpNS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNS.Location = new System.Drawing.Point(135, 148);
            this.dtpNS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNS.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNS.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNS.Name = "dtpNS";
            this.dtpNS.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpNS.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpNS.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpNS.OnPressedColor = System.Drawing.Color.Black;
            this.dtpNS.Radius = 3;
            this.dtpNS.Size = new System.Drawing.Size(213, 37);
            this.dtpNS.TabIndex = 9;
            this.dtpNS.Text = "9/15/2021";
            this.dtpNS.Value = new System.DateTime(2021, 9, 15, 19, 22, 32, 410);
            // 
            // txtHo
            // 
            this.txtHo.BackColor = System.Drawing.Color.Transparent;
            this.txtHo.BaseColor = System.Drawing.Color.White;
            this.txtHo.BorderColor = System.Drawing.Color.Silver;
            this.txtHo.BorderSize = 1;
            this.txtHo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHo.FocusedBaseColor = System.Drawing.Color.White;
            this.txtHo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtHo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtHo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHo.Location = new System.Drawing.Point(135, 203);
            this.txtHo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHo.Name = "txtHo";
            this.txtHo.PasswordChar = '\0';
            this.txtHo.Radius = 3;
            this.txtHo.SelectedText = "";
            this.txtHo.Size = new System.Drawing.Size(283, 37);
            this.txtHo.TabIndex = 8;
            // 
            // cbbLop
            // 
            this.cbbLop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.cbbLop.Items.AddRange(new object[] {
            "CTK42",
            "CTK43",
            "CTK44",
            "CTK45"});
            this.cbbLop.Location = new System.Drawing.Point(135, 100);
            this.cbbLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.OnHoverItemBaseColor = System.Drawing.Color.Turquoise;
            this.cbbLop.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbLop.Radius = 3;
            this.cbbLop.Size = new System.Drawing.Size(212, 31);
            this.cbbLop.TabIndex = 7;
            // 
            // txtMSSV
            // 
            this.txtMSSV.BackColor = System.Drawing.Color.Transparent;
            this.txtMSSV.BaseColor = System.Drawing.Color.White;
            this.txtMSSV.BorderColor = System.Drawing.Color.Silver;
            this.txtMSSV.BorderSize = 1;
            this.txtMSSV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMSSV.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMSSV.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMSSV.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMSSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMSSV.Location = new System.Drawing.Point(135, 50);
            this.txtMSSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.PasswordChar = '\0';
            this.txtMSSV.Radius = 3;
            this.txtMSSV.SelectedText = "";
            this.txtMSSV.Size = new System.Drawing.Size(213, 37);
            this.txtMSSV.TabIndex = 6;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.Location = new System.Drawing.Point(8, 100);
            this.gunaLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(44, 25);
            this.gunaLabel8.TabIndex = 5;
            this.gunaLabel8.Text = "Lớp";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(9, 324);
            this.gunaLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(71, 25);
            this.gunaLabel6.TabIndex = 3;
            this.gunaLabel6.Text = "Địa chỉ";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(8, 148);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(98, 25);
            this.gunaLabel5.TabIndex = 2;
            this.gunaLabel5.Text = "Ngày sinh";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(8, 210);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(42, 25);
            this.gunaLabel4.TabIndex = 1;
            this.gunaLabel4.Text = "Họ ";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(8, 50);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(67, 25);
            this.gunaLabel3.TabIndex = 0;
            this.gunaLabel3.Text = "Mã SV";
            // 
            // gunaComboBox1
            // 
            this.gunaComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox1.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox1.BorderSize = 1;
            this.gunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox1.FormattingEnabled = true;
            this.gunaComboBox1.Items.AddRange(new object[] {
            "Mã SV",
            "Lớp ",
            "Tên",
            "Địa Chỉ"});
            this.gunaComboBox1.Location = new System.Drawing.Point(516, 52);
            this.gunaComboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.Turquoise;
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Radius = 3;
            this.gunaComboBox1.Size = new System.Drawing.Size(143, 31);
            this.gunaComboBox1.TabIndex = 5;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(412, 53);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(90, 25);
            this.gunaLabel2.TabIndex = 6;
            this.gunaLabel2.Text = "Tìm theo";
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(47, 92);
            this.gunaSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(1333, 12);
            this.gunaSeparator1.TabIndex = 10;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.AnimationHoverSpeed = 0.07F;
            this.btnDelete.AnimationSpeed = 0.03F;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BaseColor = System.Drawing.Color.Teal;
            this.btnDelete.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::QuanLyDangKyHocPhan.Properties.Resources.icons8_remove_16px;
            this.btnDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelete.Location = new System.Drawing.Point(840, 148);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.DarkCyan;
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Radius = 15;
            this.btnDelete.Size = new System.Drawing.Size(148, 46);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Animated = true;
            this.btnUpdate.AnimationHoverSpeed = 0.07F;
            this.btnUpdate.AnimationSpeed = 0.03F;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BaseColor = System.Drawing.Color.Teal;
            this.btnUpdate.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::QuanLyDangKyHocPhan.Properties.Resources.icons8_support_50px;
            this.btnUpdate.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdate.Location = new System.Drawing.Point(632, 148);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.DarkCyan;
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Radius = 15;
            this.btnUpdate.Size = new System.Drawing.Size(185, 46);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Animated = true;
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.Teal;
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::QuanLyDangKyHocPhan.Properties.Resources.icons8_add_bookmark_24px;
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.Location = new System.Drawing.Point(456, 148);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.DarkCyan;
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 15;
            this.btnAdd.Size = new System.Drawing.Size(155, 46);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.Animated = true;
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.Teal;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = global::QuanLyDangKyHocPhan.Properties.Resources.icons8_search_32px_2;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(47, 32);
            this.gunaButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.DarkCyan;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 15;
            this.gunaButton1.Size = new System.Drawing.Size(177, 46);
            this.gunaButton1.TabIndex = 18;
            this.gunaButton1.Text = "Tìm kiếm";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.BorderSize = 1;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.Location = new System.Drawing.Point(668, 52);
            this.gunaTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 3;
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(320, 37);
            this.gunaTextBox1.TabIndex = 22;
            // 
            // ControlStudentManagerment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.gunaTextBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaComboBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ControlStudentManagerment";
            this.Size = new System.Drawing.Size(1420, 875);
            this.Load += new System.EventHandler(this.ControlStudentManagerment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvDSSV;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private Guna.UI.WinForms.GunaTextBox txtMSSV;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaTextBox txtHo;
        private Guna.UI.WinForms.GunaComboBox cbbLop;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaTextBox txtDiaChi;
        private Guna.UI.WinForms.GunaDateTimePicker dtpNS;
        private Guna.UI.WinForms.GunaButton btnDelete;
        private Guna.UI.WinForms.GunaButton btnUpdate;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaTextBox txtTen;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
    }
}
