namespace QuanLyDangKyHocPhan
{
    partial class DKNgoaiKHForm
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
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.btnXuat = new Guna.UI.WinForms.GunaButton();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.lvKQDK = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDangKy = new Guna.UI.WinForms.GunaButton();
            this.lvHP = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.cbbHK = new Guna.UI.WinForms.GunaComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtWanning = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox1.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "STC";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tên học phần";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 400;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã HP";
            this.columnHeader5.Width = 200;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(651, 231);
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
            this.btnXuat.Location = new System.Drawing.Point(977, 231);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnXuat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXuat.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXuat.OnHoverImage = null;
            this.btnXuat.OnPressedColor = System.Drawing.Color.Black;
            this.btnXuat.Radius = 10;
            this.btnXuat.Size = new System.Drawing.Size(200, 25);
            this.btnXuat.TabIndex = 3;
            this.btnXuat.Text = "Xuất ơhiếu đăng ký";
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
            this.columnHeader8,
            this.columnHeader11,
            this.columnHeader12});
            this.lvKQDK.FullRowSelect = true;
            this.lvKQDK.GridLines = true;
            this.lvKQDK.HideSelection = false;
            this.lvKQDK.Location = new System.Drawing.Point(14, 61);
            this.lvKQDK.Name = "lvKQDK";
            this.lvKQDK.Size = new System.Drawing.Size(1163, 162);
            this.lvKQDK.TabIndex = 0;
            this.lvKQDK.UseCompatibleStateImageBehavior = false;
            this.lvKQDK.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Loại HP";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 200;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "TCLT";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "TCTH";
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
            this.gunaGroupBox1.Location = new System.Drawing.Point(12, 475);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 10;
            this.gunaGroupBox1.Size = new System.Drawing.Size(1180, 264);
            this.gunaGroupBox1.TabIndex = 15;
            this.gunaGroupBox1.Text = "Phiếu đăng ký học phần";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1204, 51);
            this.gunaPanel1.TabIndex = 12;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(22, 13);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(313, 22);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Đăng ký học phần ngoài kế hoạch";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "STC";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Loại HP";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên HP";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 450;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã HP";
            this.columnHeader1.Width = 200;
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
            this.btnDangKy.Location = new System.Drawing.Point(1092, 427);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.OnHoverBaseColor = System.Drawing.Color.SeaGreen;
            this.btnDangKy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDangKy.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDangKy.OnHoverImage = null;
            this.btnDangKy.OnPressedColor = System.Drawing.Color.Black;
            this.btnDangKy.Radius = 10;
            this.btnDangKy.Size = new System.Drawing.Size(97, 42);
            this.btnDangKy.TabIndex = 14;
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
            this.columnHeader4,
            this.columnHeader9,
            this.columnHeader10});
            this.lvHP.FullRowSelect = true;
            this.lvHP.GridLines = true;
            this.lvHP.HideSelection = false;
            this.lvHP.Location = new System.Drawing.Point(9, 93);
            this.lvHP.Name = "lvHP";
            this.lvHP.Size = new System.Drawing.Size(1180, 328);
            this.lvHP.TabIndex = 13;
            this.lvHP.UseCompatibleStateImageBehavior = false;
            this.lvHP.View = System.Windows.Forms.View.Details;
            this.lvHP.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvHP_ItemChecked);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "TCLT";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "TCTH";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(7, 62);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(54, 20);
            this.gunaLabel4.TabIndex = 17;
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
            this.cbbHK.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbbHK.Location = new System.Drawing.Point(67, 57);
            this.cbbHK.Name = "cbbHK";
            this.cbbHK.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbHK.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbHK.Radius = 5;
            this.cbbHK.Size = new System.Drawing.Size(121, 31);
            this.cbbHK.TabIndex = 16;
            this.cbbHK.SelectedIndexChanged += new System.EventHandler(this.cbbHK_SelectedIndexChanged);
            // 
            // txtWanning
            // 
            this.txtWanning.AutoSize = true;
            this.txtWanning.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWanning.ForeColor = System.Drawing.Color.Red;
            this.txtWanning.Location = new System.Drawing.Point(22, 446);
            this.txtWanning.Name = "txtWanning";
            this.txtWanning.Size = new System.Drawing.Size(486, 23);
            this.txtWanning.TabIndex = 18;
            this.txtWanning.Text = "Lưu ý sinh viên không được đăng ký quá 25 tính chỉ/học kỳ";
            this.txtWanning.Visible = false;
            // 
            // DKNgoaiKHForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 751);
            this.Controls.Add(this.txtWanning);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.cbbHK);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.lvHP);
            this.Name = "DKNgoaiKHForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DKNgoaiKHForm";
            this.Load += new System.EventHandler(this.DKNgoaiKHForm_Load);
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaButton btnXuat;
        private System.Windows.Forms.TextBox txtQuantity;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.ListView lvKQDK;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private Guna.UI.WinForms.GunaButton btnDangKy;
        private System.Windows.Forms.ListView lvHP;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaComboBox cbbHK;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private Guna.UI.WinForms.GunaLabel txtWanning;
    }
}