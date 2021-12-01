namespace QuanLyDangKyHocPhan
{
    partial class DKTheoKeHoachForm
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnDangKy = new Guna.UI.WinForms.GunaButton();
            this.lvHP = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.btnXuat = new Guna.UI.WinForms.GunaButton();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.lvKQDK = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbbHK = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.cmsKQDK = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.gunaPanel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.cmsKQDK.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(22, 19);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(657, 22);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Danh sách học phần chưa tích luỹ được tổ chức giảng dạy theo kế hoạch";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangKy.AnimationHoverSpeed = 0.07F;
            this.btnDangKy.AnimationSpeed = 0.03F;
            this.btnDangKy.BackColor = System.Drawing.Color.Transparent;
            this.btnDangKy.BaseColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDangKy.BorderColor = System.Drawing.Color.Black;
            this.btnDangKy.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDangKy.FocusedColor = System.Drawing.Color.Empty;
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.Image = null;
            this.btnDangKy.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDangKy.Location = new System.Drawing.Point(1283, 456);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.OnHoverBaseColor = System.Drawing.Color.SeaGreen;
            this.btnDangKy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDangKy.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDangKy.OnHoverImage = null;
            this.btnDangKy.OnPressedColor = System.Drawing.Color.Black;
            this.btnDangKy.Radius = 10;
            this.btnDangKy.Size = new System.Drawing.Size(97, 42);
            this.btnDangKy.TabIndex = 10;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // lvHP
            // 
            this.lvHP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvHP.CheckBoxes = true;
            this.lvHP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvHP.FullRowSelect = true;
            this.lvHP.GridLines = true;
            this.lvHP.HideSelection = false;
            this.lvHP.Location = new System.Drawing.Point(12, 108);
            this.lvHP.Name = "lvHP";
            this.lvHP.Size = new System.Drawing.Size(1371, 342);
            this.lvHP.TabIndex = 7;
            this.lvHP.UseCompatibleStateImageBehavior = false;
            this.lvHP.View = System.Windows.Forms.View.Details;
            this.lvHP.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvHP_ItemChecked);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã HP";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên HP";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 450;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Loại HP";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "STC";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 200;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1395, 66);
            this.gunaPanel1.TabIndex = 6;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.btnXuat);
            this.gunaGroupBox1.Controls.Add(this.txtQuantity);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.lvKQDK);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.Red;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(12, 504);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 10;
            this.gunaGroupBox1.Size = new System.Drawing.Size(1371, 319);
            this.gunaGroupBox1.TabIndex = 11;
            this.gunaGroupBox1.Text = "Phiếu đăng ký học phần";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(841, 291);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(308, 20);
            this.gunaLabel3.TabIndex = 4;
            this.gunaLabel3.Text = "Sinh viên cần xuất phiếu đăng ký khi cần thiết";
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
            this.btnXuat.Location = new System.Drawing.Point(1168, 286);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnXuat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXuat.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXuat.OnHoverImage = null;
            this.btnXuat.OnPressedColor = System.Drawing.Color.Black;
            this.btnXuat.Radius = 10;
            this.btnXuat.Size = new System.Drawing.Size(200, 30);
            this.btnXuat.TabIndex = 3;
            this.btnXuat.Text = "Xuất phiếu đăng ký";
            this.btnXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(202, 33);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(51, 27);
            this.txtQuantity.TabIndex = 2;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(10, 35);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(183, 20);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Tổng số tín chỉ đã đăng ký";
            // 
            // lvKQDK
            // 
            this.lvKQDK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvKQDK.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvKQDK.ContextMenuStrip = this.cmsKQDK;
            this.lvKQDK.FullRowSelect = true;
            this.lvKQDK.GridLines = true;
            this.lvKQDK.HideSelection = false;
            this.lvKQDK.Location = new System.Drawing.Point(14, 61);
            this.lvKQDK.Name = "lvKQDK";
            this.lvKQDK.Size = new System.Drawing.Size(1354, 219);
            this.lvKQDK.TabIndex = 0;
            this.lvKQDK.UseCompatibleStateImageBehavior = false;
            this.lvKQDK.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã HP";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tên học phần";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 400;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Loại HP";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "STC";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 200;
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
            this.cbbHK.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbbHK.Location = new System.Drawing.Point(72, 72);
            this.cbbHK.Name = "cbbHK";
            this.cbbHK.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbHK.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbHK.Radius = 5;
            this.cbbHK.Size = new System.Drawing.Size(121, 31);
            this.cbbHK.TabIndex = 12;
            this.cbbHK.SelectedIndexChanged += new System.EventHandler(this.cbbHK_SelectedIndexChanged);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(12, 77);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(54, 20);
            this.gunaLabel4.TabIndex = 13;
            this.gunaLabel4.Text = "Học kỳ";
            // 
            // cmsKQDK
            // 
            this.cmsKQDK.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsKQDK.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDelete});
            this.cmsKQDK.Name = "cmsKQDK";
            this.cmsKQDK.Size = new System.Drawing.Size(211, 56);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(210, 24);
            this.tsmDelete.Text = "Xoá học phần";
            this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
            // 
            // DKTheoKeHoachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 898);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.cbbHK);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.lvHP);
            this.Controls.Add(this.gunaPanel1);
            this.Name = "DKTheoKeHoachForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DKTheoKeHoachForm";
            this.Load += new System.EventHandler(this.DKTheoKeHoachForm_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.cmsKQDK.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btnDangKy;
        private System.Windows.Forms.ListView lvHP;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaButton btnXuat;
        private System.Windows.Forms.TextBox txtQuantity;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.ListView lvKQDK;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private Guna.UI.WinForms.GunaComboBox cbbHK;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip cmsKQDK;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
    }
}