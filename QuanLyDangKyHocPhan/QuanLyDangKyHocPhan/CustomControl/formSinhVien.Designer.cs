
namespace QuanLyDangKyHocPhan.CustomControl
{
    partial class formSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSinhVien));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHide = new Guna.UI.WinForms.GunaControlBox();
            this.btnClose = new Guna.UI.WinForms.GunaControlBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaTextBoxMSSV = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaTextBoxMKSV = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(38, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 26);
            this.label2.TabIndex = 41;
            this.label2.Text = "Đăng nhập sinh viên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHide);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 33);
            this.panel1.TabIndex = 42;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnHide
            // 
            this.btnHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHide.AnimationHoverSpeed = 0.07F;
            this.btnHide.AnimationSpeed = 0.03F;
            this.btnHide.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.btnHide.IconColor = System.Drawing.Color.DimGray;
            this.btnHide.IconSize = 15F;
            this.btnHide.Location = new System.Drawing.Point(230, 0);
            this.btnHide.Margin = new System.Windows.Forms.Padding(2);
            this.btnHide.Name = "btnHide";
            this.btnHide.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnHide.OnHoverIconColor = System.Drawing.Color.White;
            this.btnHide.OnPressedColor = System.Drawing.Color.Black;
            this.btnHide.Size = new System.Drawing.Size(38, 33);
            this.btnHide.TabIndex = 43;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.IconColor = System.Drawing.Color.DimGray;
            this.btnClose.IconSize = 15F;
            this.btnClose.Location = new System.Drawing.Point(266, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnClose.OnHoverIconColor = System.Drawing.Color.White;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Size = new System.Drawing.Size(38, 33);
            this.btnClose.TabIndex = 43;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gunaPictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 154);
            this.panel2.TabIndex = 43;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Location = new System.Drawing.Point(84, 0);
            this.gunaPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(128, 115);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            this.gunaPictureBox1.Click += new System.EventHandler(this.gunaPictureBox1_Click);
            // 
            // gunaButton2
            // 
            this.gunaButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaButton2.Animated = true;
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.Teal;
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = null;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(84, 366);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.DarkCyan;
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 20;
            this.gunaButton2.Size = new System.Drawing.Size(119, 51);
            this.gunaButton2.TabIndex = 45;
            this.gunaButton2.Text = "Đăng Nhập";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(38, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 41;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gunaTextBoxMSSV
            // 
            this.gunaTextBoxMSSV.BorderColor = System.Drawing.Color.Teal;
            this.gunaTextBoxMSSV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBoxMSSV.DefaultText = "Mã số sinh viên....";
            this.gunaTextBoxMSSV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gunaTextBoxMSSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gunaTextBoxMSSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTextBoxMSSV.DisabledState.Parent = this.gunaTextBoxMSSV;
            this.gunaTextBoxMSSV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTextBoxMSSV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTextBoxMSSV.FocusedState.Parent = this.gunaTextBoxMSSV;
            this.gunaTextBoxMSSV.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaTextBoxMSSV.HoverState.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.gunaTextBoxMSSV.HoverState.Parent = this.gunaTextBoxMSSV;
            this.gunaTextBoxMSSV.IconLeft = ((System.Drawing.Image)(resources.GetObject("gunaTextBoxMSSV.IconLeft")));
            this.gunaTextBoxMSSV.IconLeftSize = new System.Drawing.Size(35, 35);
            this.gunaTextBoxMSSV.Location = new System.Drawing.Point(30, 223);
            this.gunaTextBoxMSSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaTextBoxMSSV.Multiline = true;
            this.gunaTextBoxMSSV.Name = "gunaTextBoxMSSV";
            this.gunaTextBoxMSSV.PasswordChar = '\0';
            this.gunaTextBoxMSSV.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.gunaTextBoxMSSV.PlaceholderText = "";
            this.gunaTextBoxMSSV.SelectedText = "";
            this.gunaTextBoxMSSV.SelectionStart = 19;
            this.gunaTextBoxMSSV.ShadowDecoration.Parent = this.gunaTextBoxMSSV;
            this.gunaTextBoxMSSV.Size = new System.Drawing.Size(238, 38);
            this.gunaTextBoxMSSV.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.gunaTextBoxMSSV.TabIndex = 44;
            this.gunaTextBoxMSSV.UseSystemPasswordChar = true;
            this.gunaTextBoxMSSV.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            this.gunaTextBoxMSSV.Enter += new System.EventHandler(this.gunaTextBoxMSSV_Enter);
            this.gunaTextBoxMSSV.Leave += new System.EventHandler(this.gunaTextBoxMSSV_Leave);
            // 
            // gunaTextBoxMKSV
            // 
            this.gunaTextBoxMKSV.BorderColor = System.Drawing.Color.Teal;
            this.gunaTextBoxMKSV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBoxMKSV.DefaultText = "Nhập mật khẩu...";
            this.gunaTextBoxMKSV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gunaTextBoxMKSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gunaTextBoxMKSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTextBoxMKSV.DisabledState.Parent = this.gunaTextBoxMKSV;
            this.gunaTextBoxMKSV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTextBoxMKSV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTextBoxMKSV.FocusedState.Parent = this.gunaTextBoxMKSV;
            this.gunaTextBoxMKSV.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaTextBoxMKSV.HoverState.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.gunaTextBoxMKSV.HoverState.Parent = this.gunaTextBoxMKSV;
            this.gunaTextBoxMKSV.IconLeft = ((System.Drawing.Image)(resources.GetObject("gunaTextBoxMKSV.IconLeft")));
            this.gunaTextBoxMKSV.IconLeftSize = new System.Drawing.Size(35, 35);
            this.gunaTextBoxMKSV.IconRight = ((System.Drawing.Image)(resources.GetObject("gunaTextBoxMKSV.IconRight")));
            this.gunaTextBoxMKSV.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTextBoxMKSV.IconRightSize = new System.Drawing.Size(25, 25);
            this.gunaTextBoxMKSV.Location = new System.Drawing.Point(28, 269);
            this.gunaTextBoxMKSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaTextBoxMKSV.Multiline = true;
            this.gunaTextBoxMKSV.Name = "gunaTextBoxMKSV";
            this.gunaTextBoxMKSV.PasswordChar = '\0';
            this.gunaTextBoxMKSV.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.gunaTextBoxMKSV.PlaceholderText = "";
            this.gunaTextBoxMKSV.SelectedText = "";
            this.gunaTextBoxMKSV.SelectionStart = 16;
            this.gunaTextBoxMKSV.ShadowDecoration.Parent = this.gunaTextBoxMKSV;
            this.gunaTextBoxMKSV.Size = new System.Drawing.Size(238, 38);
            this.gunaTextBoxMKSV.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.gunaTextBoxMKSV.TabIndex = 50;
            this.gunaTextBoxMKSV.Enter += new System.EventHandler(this.gunaTextBoxMKSV_Enter_1);
            this.gunaTextBoxMKSV.Leave += new System.EventHandler(this.gunaTextBoxMKSV_Leave);
            // 
            // formSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(304, 495);
            this.Controls.Add(this.gunaTextBoxMKSV);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaTextBoxMSSV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formSinhVien";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaControlBox btnClose;
        private Guna.UI.WinForms.GunaControlBox btnHide;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox gunaTextBoxMSSV;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox gunaTextBoxMKSV;
    }
}