namespace QuanLyDangKyHocPhan
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnLogout = new Guna.UI.WinForms.GunaButton();
            this.btnRole = new Guna.UI.WinForms.GunaButton();
            this.btnAccount = new Guna.UI.WinForms.GunaButton();
            this.btnThongKe = new Guna.UI.WinForms.GunaButton();
            this.btnQLDKHP = new Guna.UI.WinForms.GunaButton();
            this.btnQLHP = new Guna.UI.WinForms.GunaButton();
            this.btnQLSV = new Guna.UI.WinForms.GunaButton();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.Container = new Guna.UI.WinForms.GunaPanel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.btnLogout);
            this.gunaPanel1.Controls.Add(this.btnRole);
            this.gunaPanel1.Controls.Add(this.btnAccount);
            this.gunaPanel1.Controls.Add(this.btnThongKe);
            this.gunaPanel1.Controls.Add(this.btnQLDKHP);
            this.gunaPanel1.Controls.Add(this.btnQLHP);
            this.gunaPanel1.Controls.Add(this.btnQLSV);
            this.gunaPanel1.Controls.Add(this.gunaPictureBox2);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(260, 753);
            this.gunaPanel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.AnimationHoverSpeed = 0.07F;
            this.btnLogout.AnimationSpeed = 0.03F;
            this.btnLogout.BaseColor = System.Drawing.Color.White;
            this.btnLogout.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogout.Location = new System.Drawing.Point(3, 688);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnHoverBaseColor = System.Drawing.Color.Salmon;
            this.btnLogout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogout.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogout.OnHoverImage = null;
            this.btnLogout.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogout.Size = new System.Drawing.Size(254, 62);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Đăng Xuất";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnRole
            // 
            this.btnRole.AnimationHoverSpeed = 0.07F;
            this.btnRole.AnimationSpeed = 0.03F;
            this.btnRole.BaseColor = System.Drawing.Color.White;
            this.btnRole.BorderColor = System.Drawing.Color.Black;
            this.btnRole.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRole.FocusedColor = System.Drawing.Color.Empty;
            this.btnRole.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRole.ForeColor = System.Drawing.Color.Black;
            this.btnRole.Image = ((System.Drawing.Image)(resources.GetObject("btnRole.Image")));
            this.btnRole.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRole.Location = new System.Drawing.Point(3, 335);
            this.btnRole.Name = "btnRole";
            this.btnRole.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnRole.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRole.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRole.OnHoverImage = null;
            this.btnRole.OnPressedColor = System.Drawing.Color.Black;
            this.btnRole.Size = new System.Drawing.Size(254, 86);
            this.btnRole.TabIndex = 6;
            this.btnRole.Text = "Quản lý Quyền";
            this.btnRole.Click += new System.EventHandler(this.btnRole_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.AnimationHoverSpeed = 0.07F;
            this.btnAccount.AnimationSpeed = 0.03F;
            this.btnAccount.BaseColor = System.Drawing.Color.White;
            this.btnAccount.BorderColor = System.Drawing.Color.Black;
            this.btnAccount.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAccount.FocusedColor = System.Drawing.Color.Empty;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAccount.ForeColor = System.Drawing.Color.Black;
            this.btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.Image")));
            this.btnAccount.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAccount.Location = new System.Drawing.Point(3, 421);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnAccount.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAccount.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAccount.OnHoverImage = null;
            this.btnAccount.OnPressedColor = System.Drawing.Color.Black;
            this.btnAccount.Size = new System.Drawing.Size(254, 86);
            this.btnAccount.TabIndex = 5;
            this.btnAccount.Text = "Quản lý Người Dùng";
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.AnimationHoverSpeed = 0.07F;
            this.btnThongKe.AnimationSpeed = 0.03F;
            this.btnThongKe.BaseColor = System.Drawing.Color.White;
            this.btnThongKe.BorderColor = System.Drawing.Color.Black;
            this.btnThongKe.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThongKe.FocusedColor = System.Drawing.Color.Empty;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThongKe.ForeColor = System.Drawing.Color.Black;
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThongKe.Location = new System.Drawing.Point(4, 249);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnThongKe.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThongKe.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThongKe.OnHoverImage = null;
            this.btnThongKe.OnPressedColor = System.Drawing.Color.Black;
            this.btnThongKe.Size = new System.Drawing.Size(254, 86);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Quản lý Học Vụ";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnQLDKHP
            // 
            this.btnQLDKHP.AnimationHoverSpeed = 0.07F;
            this.btnQLDKHP.AnimationSpeed = 0.03F;
            this.btnQLDKHP.BaseColor = System.Drawing.Color.White;
            this.btnQLDKHP.BorderColor = System.Drawing.Color.Black;
            this.btnQLDKHP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnQLDKHP.FocusedColor = System.Drawing.Color.Empty;
            this.btnQLDKHP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQLDKHP.ForeColor = System.Drawing.Color.Black;
            this.btnQLDKHP.Image = ((System.Drawing.Image)(resources.GetObject("btnQLDKHP.Image")));
            this.btnQLDKHP.ImageSize = new System.Drawing.Size(20, 20);
            this.btnQLDKHP.Location = new System.Drawing.Point(3, 507);
            this.btnQLDKHP.Name = "btnQLDKHP";
            this.btnQLDKHP.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnQLDKHP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnQLDKHP.OnHoverForeColor = System.Drawing.Color.White;
            this.btnQLDKHP.OnHoverImage = null;
            this.btnQLDKHP.OnPressedColor = System.Drawing.Color.Black;
            this.btnQLDKHP.Size = new System.Drawing.Size(254, 86);
            this.btnQLDKHP.TabIndex = 3;
            this.btnQLDKHP.Text = "Quản lý ĐKHP";
            this.btnQLDKHP.Click += new System.EventHandler(this.btnQLDKHP_Click);
            // 
            // btnQLHP
            // 
            this.btnQLHP.AnimationHoverSpeed = 0.07F;
            this.btnQLHP.AnimationSpeed = 0.03F;
            this.btnQLHP.BaseColor = System.Drawing.Color.White;
            this.btnQLHP.BorderColor = System.Drawing.Color.Black;
            this.btnQLHP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnQLHP.FocusedColor = System.Drawing.Color.Empty;
            this.btnQLHP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQLHP.ForeColor = System.Drawing.Color.Black;
            this.btnQLHP.Image = ((System.Drawing.Image)(resources.GetObject("btnQLHP.Image")));
            this.btnQLHP.ImageSize = new System.Drawing.Size(20, 20);
            this.btnQLHP.Location = new System.Drawing.Point(3, 163);
            this.btnQLHP.Name = "btnQLHP";
            this.btnQLHP.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnQLHP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnQLHP.OnHoverForeColor = System.Drawing.Color.White;
            this.btnQLHP.OnHoverImage = null;
            this.btnQLHP.OnPressedColor = System.Drawing.Color.Black;
            this.btnQLHP.Size = new System.Drawing.Size(254, 86);
            this.btnQLHP.TabIndex = 2;
            this.btnQLHP.Text = "Quản lý Học Phần";
            this.btnQLHP.Click += new System.EventHandler(this.btnQLHP_Click);
            // 
            // btnQLSV
            // 
            this.btnQLSV.AnimationHoverSpeed = 0.07F;
            this.btnQLSV.AnimationSpeed = 0.03F;
            this.btnQLSV.BaseColor = System.Drawing.Color.White;
            this.btnQLSV.BorderColor = System.Drawing.Color.Black;
            this.btnQLSV.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnQLSV.FocusedColor = System.Drawing.Color.Empty;
            this.btnQLSV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQLSV.ForeColor = System.Drawing.Color.Black;
            this.btnQLSV.Image = ((System.Drawing.Image)(resources.GetObject("btnQLSV.Image")));
            this.btnQLSV.ImageSize = new System.Drawing.Size(20, 20);
            this.btnQLSV.Location = new System.Drawing.Point(3, 77);
            this.btnQLSV.Name = "btnQLSV";
            this.btnQLSV.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnQLSV.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnQLSV.OnHoverForeColor = System.Drawing.Color.White;
            this.btnQLSV.OnHoverImage = null;
            this.btnQLSV.OnPressedColor = System.Drawing.Color.Black;
            this.btnQLSV.Size = new System.Drawing.Size(254, 86);
            this.btnQLSV.TabIndex = 1;
            this.btnQLSV.Text = "Quản lý Sinh Viên";
            this.btnQLSV.Click += new System.EventHandler(this.btnQLSV_Click);
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.InitialImage")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(83, 3);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(92, 58);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox2.TabIndex = 0;
            this.gunaPictureBox2.TabStop = false;
            // 
            // Container
            // 
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(260, 0);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(1222, 753);
            this.Container.TabIndex = 2;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // fileSystemWatcher2
            // 
            this.fileSystemWatcher2.EnableRaisingEvents = true;
            this.fileSystemWatcher2.SynchronizingObject = this;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.gunaPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang quản lý";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaButton btnQLSV;
        private Guna.UI.WinForms.GunaButton btnRole;
        private Guna.UI.WinForms.GunaButton btnAccount;
        private Guna.UI.WinForms.GunaButton btnThongKe;
        private Guna.UI.WinForms.GunaButton btnQLDKHP;
        private Guna.UI.WinForms.GunaButton btnQLHP;
        private Guna.UI.WinForms.GunaButton btnLogout;
        private Guna.UI.WinForms.GunaPanel Container;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.IO.FileSystemWatcher fileSystemWatcher2;
    }
}