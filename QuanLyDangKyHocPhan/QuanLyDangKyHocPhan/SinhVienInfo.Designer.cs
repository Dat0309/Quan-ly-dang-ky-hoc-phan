namespace QuanLyDangKyHocPhan
{
    partial class SinhVienInfo
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
            this.cbbHK = new Guna.UI.WinForms.GunaComboBox();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.SuspendLayout();
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
            this.cbbHK.Location = new System.Drawing.Point(440, 12);
            this.cbbHK.Name = "cbbHK";
            this.cbbHK.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbHK.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbHK.Radius = 5;
            this.cbbHK.Size = new System.Drawing.Size(121, 31);
            this.cbbHK.TabIndex = 17;
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
            "1",
            "2",
            "3"});
            this.gunaComboBox1.Location = new System.Drawing.Point(440, 49);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Radius = 5;
            this.gunaComboBox1.Size = new System.Drawing.Size(121, 31);
            this.gunaComboBox1.TabIndex = 18;
            // 
            // SinhVienInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gunaComboBox1);
            this.Controls.Add(this.cbbHK);
            this.Name = "SinhVienInfo";
            this.Text = "SinhVienInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaComboBox cbbHK;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
    }
}