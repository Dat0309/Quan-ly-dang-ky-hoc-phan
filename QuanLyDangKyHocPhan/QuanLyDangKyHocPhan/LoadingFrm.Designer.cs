namespace QuanLyDangKyHocPhan
{
    partial class LoadingFrm
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
            this.pbLoad = new Guna.UI.WinForms.GunaProgressBar();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(189, 45);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(129, 28);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Đang xử lý...";
            // 
            // pbLoad
            // 
            this.pbLoad.BorderColor = System.Drawing.Color.Black;
            this.pbLoad.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.pbLoad.IdleColor = System.Drawing.Color.Gainsboro;
            this.pbLoad.Location = new System.Drawing.Point(60, 107);
            this.pbLoad.Name = "pbLoad";
            this.pbLoad.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.pbLoad.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.pbLoad.Size = new System.Drawing.Size(395, 29);
            this.pbLoad.Style = Guna.UI.WinForms.ProgressBarStyle.Marquee;
            this.pbLoad.TabIndex = 1;
            // 
            // LoadingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 187);
            this.Controls.Add(this.pbLoad);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingFrm";
            this.Load += new System.EventHandler(this.LoadingFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaProgressBar pbLoad;
    }
}