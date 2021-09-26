
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
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaPictureBox = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaButtonLoginGV = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaControlBoxMini = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBoxExit = new Guna.UI.WinForms.GunaControlBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.Teal;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "Mã số sinh viên....";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox1.IconLeft")));
            this.guna2TextBox1.IconLeftSize = new System.Drawing.Size(35, 35);
            this.guna2TextBox1.Location = new System.Drawing.Point(40, 314);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.SelectionStart = 19;
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(318, 47);
            this.guna2TextBox1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2TextBox1.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(49, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 34);
            this.label2.TabIndex = 41;
            this.label2.Text = "Đăng nhập sinh viên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaControlBoxMini);
            this.panel1.Controls.Add(this.gunaControlBoxExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 41);
            this.panel1.TabIndex = 47;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gunaPictureBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 204);
            this.panel2.TabIndex = 48;
            // 
            // gunaPictureBox
            // 
            this.gunaPictureBox.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox.Location = new System.Drawing.Point(112, 9);
            this.gunaPictureBox.Name = "gunaPictureBox";
            this.gunaPictureBox.Size = new System.Drawing.Size(170, 141);
            this.gunaPictureBox.TabIndex = 0;
            this.gunaPictureBox.TabStop = false;
            // 
            // gunaButtonLoginGV
            // 
            this.gunaButtonLoginGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gunaButtonLoginGV.Animated = true;
            this.gunaButtonLoginGV.AnimationHoverSpeed = 0.07F;
            this.gunaButtonLoginGV.AnimationSpeed = 0.03F;
            this.gunaButtonLoginGV.BackColor = System.Drawing.Color.Transparent;
            this.gunaButtonLoginGV.BaseColor = System.Drawing.Color.Teal;
            this.gunaButtonLoginGV.BorderColor = System.Drawing.Color.Black;
            this.gunaButtonLoginGV.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButtonLoginGV.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButtonLoginGV.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButtonLoginGV.ForeColor = System.Drawing.Color.White;
            this.gunaButtonLoginGV.Image = null;
            this.gunaButtonLoginGV.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButtonLoginGV.Location = new System.Drawing.Point(123, 492);
            this.gunaButtonLoginGV.Margin = new System.Windows.Forms.Padding(4);
            this.gunaButtonLoginGV.Name = "gunaButtonLoginGV";
            this.gunaButtonLoginGV.OnHoverBaseColor = System.Drawing.Color.DarkCyan;
            this.gunaButtonLoginGV.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButtonLoginGV.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButtonLoginGV.OnHoverImage = null;
            this.gunaButtonLoginGV.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButtonLoginGV.Radius = 20;
            this.gunaButtonLoginGV.Size = new System.Drawing.Size(159, 60);
            this.gunaButtonLoginGV.TabIndex = 51;
            this.gunaButtonLoginGV.Text = "Đăng Nhập";
            this.gunaButtonLoginGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(51, 540);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 46;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BorderColor = System.Drawing.Color.Teal;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "Mật khẩu";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.FocusedState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.guna2TextBox2.HoverState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox2.IconLeft")));
            this.guna2TextBox2.IconLeftSize = new System.Drawing.Size(35, 35);
            this.guna2TextBox2.IconRight = ((System.Drawing.Image)(resources.GetObject("guna2TextBox2.IconRight")));
            this.guna2TextBox2.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TextBox2.IconRightSize = new System.Drawing.Size(25, 25);
            this.guna2TextBox2.Location = new System.Drawing.Point(40, 382);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.SelectionStart = 8;
            this.guna2TextBox2.ShadowDecoration.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Size = new System.Drawing.Size(318, 47);
            this.guna2TextBox2.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2TextBox2.TabIndex = 50;
            this.guna2TextBox2.UseSystemPasswordChar = true;
            // 
            // gunaControlBoxMini
            // 
            this.gunaControlBoxMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBoxMini.AnimationHoverSpeed = 0.07F;
            this.gunaControlBoxMini.AnimationSpeed = 0.03F;
            this.gunaControlBoxMini.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBoxMini.IconColor = System.Drawing.Color.DimGray;
            this.gunaControlBoxMini.IconSize = 15F;
            this.gunaControlBoxMini.Location = new System.Drawing.Point(307, 0);
            this.gunaControlBoxMini.Name = "gunaControlBoxMini";
            this.gunaControlBoxMini.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBoxMini.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBoxMini.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBoxMini.Size = new System.Drawing.Size(51, 41);
            this.gunaControlBoxMini.TabIndex = 44;
            // 
            // gunaControlBoxExit
            // 
            this.gunaControlBoxExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBoxExit.AnimationHoverSpeed = 0.07F;
            this.gunaControlBoxExit.AnimationSpeed = 0.03F;
            this.gunaControlBoxExit.IconColor = System.Drawing.Color.DimGray;
            this.gunaControlBoxExit.IconSize = 15F;
            this.gunaControlBoxExit.Location = new System.Drawing.Point(354, 0);
            this.gunaControlBoxExit.Name = "gunaControlBoxExit";
            this.gunaControlBoxExit.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBoxExit.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBoxExit.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBoxExit.Size = new System.Drawing.Size(51, 41);
            this.gunaControlBoxExit.TabIndex = 45;
            // 
            // frmGiaoVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(405, 606);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gunaButtonLoginGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2TextBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGiaoVu";
            this.Text = "frmGiaoVu";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox;
        private Guna.UI.WinForms.GunaButton gunaButtonLoginGV;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBoxMini;
        private Guna.UI.WinForms.GunaControlBox gunaControlBoxExit;
    }
}