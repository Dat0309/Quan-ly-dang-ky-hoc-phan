
namespace QuanLyDangKyHocPhan.CustomControl
{
    partial class UCHocPhi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.cbbTenKhoa = new Guna.UI.WinForms.GunaComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // gunaComboBox1
            // 
            this.gunaComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.gunaComboBox1.Location = new System.Drawing.Point(296, 42);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.Turquoise;
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Radius = 3;
            this.gunaComboBox1.Size = new System.Drawing.Size(102, 26);
            this.gunaComboBox1.TabIndex = 54;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(226, 45);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(64, 20);
            this.gunaLabel3.TabIndex = 53;
            this.gunaLabel3.Text = "Học kỳ :";
            // 
            // cbbTenKhoa
            // 
            this.cbbTenKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbbTenKhoa.BackColor = System.Drawing.Color.Transparent;
            this.cbbTenKhoa.BaseColor = System.Drawing.Color.White;
            this.cbbTenKhoa.BorderColor = System.Drawing.Color.Silver;
            this.cbbTenKhoa.BorderSize = 1;
            this.cbbTenKhoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTenKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenKhoa.FocusedColor = System.Drawing.Color.Empty;
            this.cbbTenKhoa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbTenKhoa.ForeColor = System.Drawing.Color.Black;
            this.cbbTenKhoa.FormattingEnabled = true;
            this.cbbTenKhoa.Location = new System.Drawing.Point(112, 42);
            this.cbbTenKhoa.Name = "cbbTenKhoa";
            this.cbbTenKhoa.OnHoverItemBaseColor = System.Drawing.Color.Turquoise;
            this.cbbTenKhoa.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbTenKhoa.Radius = 3;
            this.cbbTenKhoa.Size = new System.Drawing.Size(102, 26);
            this.cbbTenKhoa.TabIndex = 52;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(14, 111);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1037, 290);
            this.listView1.TabIndex = 51;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Mã phí";
            this.columnHeader10.Width = 219;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Tên phí";
            this.columnHeader11.Width = 501;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Còn nợ";
            this.columnHeader12.Width = 239;
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(34, 81);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(1000, 10);
            this.gunaSeparator1.TabIndex = 50;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(30, 45);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(80, 20);
            this.gunaLabel1.TabIndex = 49;
            this.gunaLabel1.Text = "Năm học :";
            // 
            // UCHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaComboBox1);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.cbbTenKhoa);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "UCHocPhi";
            this.Size = new System.Drawing.Size(1065, 711);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaComboBox cbbTenKhoa;
        private System.Windows.Forms.ListView listView1;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}
