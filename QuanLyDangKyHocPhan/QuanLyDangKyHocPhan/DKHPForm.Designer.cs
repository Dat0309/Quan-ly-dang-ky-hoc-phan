namespace QuanLyDangKyHocPhan
{
    partial class DKHPForm
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.lvHP = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnKeHoach = new Guna.UI.WinForms.GunaButton();
            this.btnCaiThien = new Guna.UI.WinForms.GunaButton();
            this.btnKetQua = new Guna.UI.WinForms.GunaButton();
            this.btnDCHP = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(22, 19);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(312, 22);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Danh sách học phần chưa tích luỹ";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1222, 66);
            this.gunaPanel1.TabIndex = 1;
            // 
            // lvHP
            // 
            this.lvHP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvHP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvHP.GridLines = true;
            this.lvHP.HideSelection = false;
            this.lvHP.Location = new System.Drawing.Point(12, 132);
            this.lvHP.Name = "lvHP";
            this.lvHP.Size = new System.Drawing.Size(1198, 557);
            this.lvHP.TabIndex = 2;
            this.lvHP.UseCompatibleStateImageBehavior = false;
            this.lvHP.View = System.Windows.Forms.View.Details;
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
            this.columnHeader2.Width = 400;
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
            // btnKeHoach
            // 
            this.btnKeHoach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKeHoach.AnimationHoverSpeed = 0.07F;
            this.btnKeHoach.AnimationSpeed = 0.03F;
            this.btnKeHoach.BackColor = System.Drawing.Color.Transparent;
            this.btnKeHoach.BaseColor = System.Drawing.Color.MediumSeaGreen;
            this.btnKeHoach.BorderColor = System.Drawing.Color.Black;
            this.btnKeHoach.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnKeHoach.FocusedColor = System.Drawing.Color.Empty;
            this.btnKeHoach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKeHoach.ForeColor = System.Drawing.Color.White;
            this.btnKeHoach.Image = null;
            this.btnKeHoach.ImageSize = new System.Drawing.Size(20, 20);
            this.btnKeHoach.Location = new System.Drawing.Point(12, 699);
            this.btnKeHoach.Name = "btnKeHoach";
            this.btnKeHoach.OnHoverBaseColor = System.Drawing.Color.SeaGreen;
            this.btnKeHoach.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnKeHoach.OnHoverForeColor = System.Drawing.Color.White;
            this.btnKeHoach.OnHoverImage = null;
            this.btnKeHoach.OnPressedColor = System.Drawing.Color.Black;
            this.btnKeHoach.Radius = 10;
            this.btnKeHoach.Size = new System.Drawing.Size(209, 42);
            this.btnKeHoach.TabIndex = 3;
            this.btnKeHoach.Text = "Đăng ký theo kế hoạch";
            this.btnKeHoach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnKeHoach.Click += new System.EventHandler(this.btnKeHoach_Click);
            // 
            // btnCaiThien
            // 
            this.btnCaiThien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCaiThien.AnimationHoverSpeed = 0.07F;
            this.btnCaiThien.AnimationSpeed = 0.03F;
            this.btnCaiThien.BackColor = System.Drawing.Color.Transparent;
            this.btnCaiThien.BaseColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCaiThien.BorderColor = System.Drawing.Color.Black;
            this.btnCaiThien.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCaiThien.FocusedColor = System.Drawing.Color.Empty;
            this.btnCaiThien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCaiThien.ForeColor = System.Drawing.Color.White;
            this.btnCaiThien.Image = null;
            this.btnCaiThien.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCaiThien.Location = new System.Drawing.Point(227, 699);
            this.btnCaiThien.Name = "btnCaiThien";
            this.btnCaiThien.OnHoverBaseColor = System.Drawing.Color.SeaGreen;
            this.btnCaiThien.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCaiThien.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCaiThien.OnHoverImage = null;
            this.btnCaiThien.OnPressedColor = System.Drawing.Color.Black;
            this.btnCaiThien.Radius = 10;
            this.btnCaiThien.Size = new System.Drawing.Size(270, 42);
            this.btnCaiThien.TabIndex = 4;
            this.btnCaiThien.Text = "Đăng ký học bù, học lại, cải thiện";
            this.btnCaiThien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCaiThien.Click += new System.EventHandler(this.btnCaiThien_Click);
            // 
            // btnKetQua
            // 
            this.btnKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKetQua.AnimationHoverSpeed = 0.07F;
            this.btnKetQua.AnimationSpeed = 0.03F;
            this.btnKetQua.BackColor = System.Drawing.Color.Transparent;
            this.btnKetQua.BaseColor = System.Drawing.Color.MediumSeaGreen;
            this.btnKetQua.BorderColor = System.Drawing.Color.Black;
            this.btnKetQua.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnKetQua.FocusedColor = System.Drawing.Color.Empty;
            this.btnKetQua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKetQua.ForeColor = System.Drawing.Color.White;
            this.btnKetQua.Image = null;
            this.btnKetQua.ImageSize = new System.Drawing.Size(20, 20);
            this.btnKetQua.Location = new System.Drawing.Point(718, 699);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.OnHoverBaseColor = System.Drawing.Color.SeaGreen;
            this.btnKetQua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnKetQua.OnHoverForeColor = System.Drawing.Color.White;
            this.btnKetQua.OnHoverImage = null;
            this.btnKetQua.OnPressedColor = System.Drawing.Color.Black;
            this.btnKetQua.Radius = 10;
            this.btnKetQua.Size = new System.Drawing.Size(209, 42);
            this.btnKetQua.TabIndex = 5;
            this.btnKetQua.Text = "Kết quả đăng ký";
            this.btnKetQua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // btnDCHP
            // 
            this.btnDCHP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDCHP.AnimationHoverSpeed = 0.07F;
            this.btnDCHP.AnimationSpeed = 0.03F;
            this.btnDCHP.BackColor = System.Drawing.Color.Transparent;
            this.btnDCHP.BaseColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDCHP.BorderColor = System.Drawing.Color.Black;
            this.btnDCHP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDCHP.FocusedColor = System.Drawing.Color.Empty;
            this.btnDCHP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDCHP.ForeColor = System.Drawing.Color.White;
            this.btnDCHP.Image = null;
            this.btnDCHP.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDCHP.Location = new System.Drawing.Point(503, 699);
            this.btnDCHP.Name = "btnDCHP";
            this.btnDCHP.OnHoverBaseColor = System.Drawing.Color.SeaGreen;
            this.btnDCHP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDCHP.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDCHP.OnHoverImage = null;
            this.btnDCHP.OnPressedColor = System.Drawing.Color.Black;
            this.btnDCHP.Radius = 10;
            this.btnDCHP.Size = new System.Drawing.Size(209, 42);
            this.btnDCHP.TabIndex = 6;
            this.btnDCHP.Text = "Điều chỉnh KQDK";
            this.btnDCHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDCHP.Click += new System.EventHandler(this.btnDCHP_Click);
            // 
            // DKHPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 753);
            this.Controls.Add(this.btnDCHP);
            this.Controls.Add(this.btnKetQua);
            this.Controls.Add(this.btnCaiThien);
            this.Controls.Add(this.btnKeHoach);
            this.Controls.Add(this.lvHP);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DKHPForm";
            this.Text = "DKHPForm";
            this.Load += new System.EventHandler(this.DKHPForm_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.ListView lvHP;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private Guna.UI.WinForms.GunaButton btnKeHoach;
        private Guna.UI.WinForms.GunaButton btnCaiThien;
        private Guna.UI.WinForms.GunaButton btnKetQua;
        private Guna.UI.WinForms.GunaButton btnDCHP;
    }
}