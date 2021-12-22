namespace QuanLyDangKyHocPhan
{
    partial class LichThiForm
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
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.lbLichThi = new Guna.UI.WinForms.GunaLabel();
            this.cbbHocky = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.lvLichThi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.gunaPanel1.Controls.Add(this.lbLichThi);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1222, 51);
            this.gunaPanel1.TabIndex = 13;
            // 
            // lbLichThi
            // 
            this.lbLichThi.AutoSize = true;
            this.lbLichThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLichThi.ForeColor = System.Drawing.Color.White;
            this.lbLichThi.Location = new System.Drawing.Point(22, 13);
            this.lbLichThi.Name = "lbLichThi";
            this.lbLichThi.Size = new System.Drawing.Size(75, 22);
            this.lbLichThi.TabIndex = 0;
            this.lbLichThi.Text = "Lịch thi";
            // 
            // cbbHocky
            // 
            this.cbbHocky.BackColor = System.Drawing.Color.Transparent;
            this.cbbHocky.BaseColor = System.Drawing.Color.White;
            this.cbbHocky.BorderColor = System.Drawing.Color.Silver;
            this.cbbHocky.BorderSize = 1;
            this.cbbHocky.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbHocky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHocky.FocusedColor = System.Drawing.Color.Empty;
            this.cbbHocky.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbHocky.ForeColor = System.Drawing.Color.Black;
            this.cbbHocky.FormattingEnabled = true;
            this.cbbHocky.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbbHocky.Location = new System.Drawing.Point(82, 64);
            this.cbbHocky.Name = "cbbHocky";
            this.cbbHocky.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbHocky.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbHocky.Radius = 10;
            this.cbbHocky.Size = new System.Drawing.Size(121, 31);
            this.cbbHocky.TabIndex = 17;
            this.cbbHocky.SelectedIndexChanged += new System.EventHandler(this.cbbHocky_SelectedIndexChanged);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(17, 69);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(54, 20);
            this.gunaLabel3.TabIndex = 16;
            this.gunaLabel3.Text = "Học kỳ";
            // 
            // lvLichThi
            // 
            this.lvLichThi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvLichThi.GridLines = true;
            this.lvLichThi.HideSelection = false;
            this.lvLichThi.Location = new System.Drawing.Point(12, 101);
            this.lvLichThi.Name = "lvLichThi";
            this.lvLichThi.Size = new System.Drawing.Size(1198, 640);
            this.lvLichThi.TabIndex = 18;
            this.lvLichThi.UseCompatibleStateImageBehavior = false;
            this.lvLichThi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MaHP";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên HP";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "STC";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày Thi";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Giờ Thi";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Thời lượng";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Phòng thi";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Địa điểm";
            this.columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ghi chú";
            this.columnHeader9.Width = 200;
            // 
            // LichThiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 753);
            this.Controls.Add(this.lvLichThi);
            this.Controls.Add(this.cbbHocky);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LichThiForm";
            this.Text = "LichThiForm";
            this.Load += new System.EventHandler(this.LichThiForm_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel lbLichThi;
        private Guna.UI.WinForms.GunaComboBox cbbHocky;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.ListView lvLichThi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}