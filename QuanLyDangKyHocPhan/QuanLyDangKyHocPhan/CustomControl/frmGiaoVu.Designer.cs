
namespace QuanLyDangKyHocPhan.CustomControl
{
    partial class frmGiaoVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoVu));
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHide = new Guna.UI.WinForms.GunaControlBox();
            this.btnClose = new Guna.UI.WinForms.GunaControlBox();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaTextBoxMKGV = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaTextBoxMSGV = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gunaPictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-7, 38);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 167);
            this.panel2.TabIndex = 48;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Location = new System.Drawing.Point(84, 13);
            this.gunaPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(128, 115);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(46, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 26);
            this.label2.TabIndex = 41;
            this.label2.Text = "Đăng nhập giáo vụ";
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
            this.panel1.TabIndex = 47;
            // 
            // btnHide
            // 
            this.btnHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHide.AnimationHoverSpeed = 0.07F;
            this.btnHide.AnimationSpeed = 0.03F;
            this.btnHide.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.btnHide.IconColor = System.Drawing.Color.DimGray;
            this.btnHide.IconSize = 15F;
            this.btnHide.Location = new System.Drawing.Point(231, 0);
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
            this.gunaButton2.Location = new System.Drawing.Point(86, 386);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.DarkCyan;
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 20;
            this.gunaButton2.Size = new System.Drawing.Size(119, 51);
            this.gunaButton2.TabIndex = 51;
            this.gunaButton2.Text = "Đăng Nhập";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(32, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 46;
            // 
            // gunaTextBoxMKGV
            // 
            this.gunaTextBoxMKGV.BorderColor = System.Drawing.Color.Teal;
            this.gunaTextBoxMKGV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBoxMKGV.DefaultText = "Nhập mật khẩu...";
            this.gunaTextBoxMKGV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gunaTextBoxMKGV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gunaTextBoxMKGV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTextBoxMKGV.DisabledState.Parent = this.gunaTextBoxMKGV;
            this.gunaTextBoxMKGV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTextBoxMKGV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTextBoxMKGV.FocusedState.Parent = this.gunaTextBoxMKGV;
            this.gunaTextBoxMKGV.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaTextBoxMKGV.HoverState.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.gunaTextBoxMKGV.HoverState.Parent = this.gunaTextBoxMKGV;
            this.gunaTextBoxMKGV.IconLeft = ((System.Drawing.Image)(resources.GetObject("gunaTextBoxMKGV.IconLeft")));
            this.gunaTextBoxMKGV.IconLeftSize = new System.Drawing.Size(35, 35);
            this.gunaTextBoxMKGV.IconRight = ((System.Drawing.Image)(resources.GetObject("gunaTextBoxMKGV.IconRight")));
            this.gunaTextBoxMKGV.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.gunaTextBoxMKGV.IconRightSize = new System.Drawing.Size(25, 25);
            this.gunaTextBoxMKGV.Location = new System.Drawing.Point(23, 288);
            this.gunaTextBoxMKGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaTextBoxMKGV.Multiline = true;
            this.gunaTextBoxMKGV.Name = "gunaTextBoxMKGV";
            this.gunaTextBoxMKGV.PasswordChar = '*';
            this.gunaTextBoxMKGV.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.gunaTextBoxMKGV.PlaceholderText = "";
            this.gunaTextBoxMKGV.SelectedText = "";
            this.gunaTextBoxMKGV.SelectionStart = 16;
            this.gunaTextBoxMKGV.ShadowDecoration.Parent = this.gunaTextBoxMKGV;
            this.gunaTextBoxMKGV.Size = new System.Drawing.Size(238, 38);
            this.gunaTextBoxMKGV.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.gunaTextBoxMKGV.TabIndex = 49;
            this.gunaTextBoxMKGV.UseSystemPasswordChar = true;
            this.gunaTextBoxMKGV.Enter += new System.EventHandler(this.gunaTextBoxMKGV_Enter);
            this.gunaTextBoxMKGV.Leave += new System.EventHandler(this.gunaTextBoxMKGV_Leave);
            // 
            // gunaTextBoxMSGV
            // 
            this.gunaTextBoxMSGV.AccessibleDescription = "";
            this.gunaTextBoxMSGV.BorderColor = System.Drawing.Color.Teal;
            this.gunaTextBoxMSGV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBoxMSGV.DefaultText = "Mã số giáo vụ....";
            this.gunaTextBoxMSGV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gunaTextBoxMSGV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gunaTextBoxMSGV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTextBoxMSGV.DisabledState.Parent = this.gunaTextBoxMSGV;
            this.gunaTextBoxMSGV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTextBoxMSGV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTextBoxMSGV.FocusedState.Parent = this.gunaTextBoxMSGV;
            this.gunaTextBoxMSGV.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaTextBoxMSGV.HoverState.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.gunaTextBoxMSGV.HoverState.Parent = this.gunaTextBoxMSGV;
            this.gunaTextBoxMSGV.IconLeft = ((System.Drawing.Image)(resources.GetObject("gunaTextBoxMSGV.IconLeft")));
            this.gunaTextBoxMSGV.IconLeftSize = new System.Drawing.Size(35, 35);
            this.gunaTextBoxMSGV.Location = new System.Drawing.Point(23, 244);
            this.gunaTextBoxMSGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaTextBoxMSGV.Name = "gunaTextBoxMSGV";
            this.gunaTextBoxMSGV.PasswordChar = '\0';
            this.gunaTextBoxMSGV.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.gunaTextBoxMSGV.PlaceholderText = "";
            this.gunaTextBoxMSGV.SelectedText = "";
            this.gunaTextBoxMSGV.SelectionStart = 17;
            this.gunaTextBoxMSGV.ShadowDecoration.Parent = this.gunaTextBoxMSGV;
            this.gunaTextBoxMSGV.Size = new System.Drawing.Size(238, 38);
            this.gunaTextBoxMSGV.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.gunaTextBoxMSGV.TabIndex = 50;
            this.gunaTextBoxMSGV.Tag = "";
            this.gunaTextBoxMSGV.Enter += new System.EventHandler(this.gunaTextBoxMSGV_Enter);
            this.gunaTextBoxMSGV.Leave += new System.EventHandler(this.gunaTextBoxMSGV_Leave);
            // 
            // frmGiaoVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(304, 495);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaTextBoxMKGV);
            this.Controls.Add(this.gunaTextBoxMSGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmGiaoVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGiaoVu";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaControlBox btnHide;
        private Guna.UI.WinForms.GunaControlBox btnClose;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox gunaTextBoxMKGV;
        private Guna.UI2.WinForms.Guna2TextBox gunaTextBoxMSGV;
    }
}