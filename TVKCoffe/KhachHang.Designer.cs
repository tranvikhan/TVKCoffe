namespace TVKCoffe
{
    partial class KhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHang));
            this.BangKhachHang = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ColStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaSoThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColChietKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.BtnTimKiem = new Bunifu.Framework.UI.BunifuTextbox();
            this.BtnXoaKhachHang = new System.Windows.Forms.Button();
            this.BtnSuaKhachHang = new System.Windows.Forms.Button();
            this.BtnThemKhachHang = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BangKhachHang)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // BangKhachHang
            // 
            this.BangKhachHang.AllowUserToAddRows = false;
            this.BangKhachHang.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BangKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BangKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.BangKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BangKhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BangKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BangKhachHang.ColumnHeadersHeight = 40;
            this.BangKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColStt,
            this.ColMaKhachHang,
            this.ColTenKhachHang,
            this.ColSoDienThoai,
            this.ColEmail,
            this.ColGioiTinh,
            this.ColNgaySinh,
            this.ColMaSoThue,
            this.ColThue,
            this.ColChietKhau});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BangKhachHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.BangKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BangKhachHang.DoubleBuffered = true;
            this.BangKhachHang.EnableHeadersVisualStyles = false;
            this.BangKhachHang.GridColor = System.Drawing.Color.White;
            this.BangKhachHang.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.BangKhachHang.HeaderForeColor = System.Drawing.Color.White;
            this.BangKhachHang.Location = new System.Drawing.Point(0, 0);
            this.BangKhachHang.Name = "BangKhachHang";
            this.BangKhachHang.ReadOnly = true;
            this.BangKhachHang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BangKhachHang.RowTemplate.Height = 30;
            this.BangKhachHang.Size = new System.Drawing.Size(800, 387);
            this.BangKhachHang.TabIndex = 5;
            // 
            // ColStt
            // 
            this.ColStt.DataPropertyName = "stt";
            this.ColStt.HeaderText = "STT";
            this.ColStt.Name = "ColStt";
            this.ColStt.ReadOnly = true;
            this.ColStt.Width = 30;
            // 
            // ColMaKhachHang
            // 
            this.ColMaKhachHang.DataPropertyName = "makh";
            this.ColMaKhachHang.HeaderText = "MÃ KH";
            this.ColMaKhachHang.Name = "ColMaKhachHang";
            this.ColMaKhachHang.ReadOnly = true;
            this.ColMaKhachHang.Width = 80;
            // 
            // ColTenKhachHang
            // 
            this.ColTenKhachHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTenKhachHang.DataPropertyName = "tenkh";
            this.ColTenKhachHang.HeaderText = "TÊN KHÁCH HÀNG";
            this.ColTenKhachHang.Name = "ColTenKhachHang";
            this.ColTenKhachHang.ReadOnly = true;
            // 
            // ColSoDienThoai
            // 
            this.ColSoDienThoai.DataPropertyName = "sodt";
            this.ColSoDienThoai.HeaderText = "SỐ ĐT";
            this.ColSoDienThoai.Name = "ColSoDienThoai";
            this.ColSoDienThoai.ReadOnly = true;
            this.ColSoDienThoai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColEmail
            // 
            this.ColEmail.DataPropertyName = "email";
            this.ColEmail.HeaderText = "EMAIL";
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.ReadOnly = true;
            this.ColEmail.Width = 140;
            // 
            // ColGioiTinh
            // 
            this.ColGioiTinh.DataPropertyName = "gioitinh";
            this.ColGioiTinh.HeaderText = "GIỚI TÍNH";
            this.ColGioiTinh.Name = "ColGioiTinh";
            this.ColGioiTinh.ReadOnly = true;
            // 
            // ColNgaySinh
            // 
            this.ColNgaySinh.DataPropertyName = "ngaysinh";
            this.ColNgaySinh.HeaderText = "NGÀY SINH";
            this.ColNgaySinh.Name = "ColNgaySinh";
            this.ColNgaySinh.ReadOnly = true;
            // 
            // ColMaSoThue
            // 
            this.ColMaSoThue.DataPropertyName = "masothue";
            this.ColMaSoThue.HeaderText = "MÃ SỐ THUẾ";
            this.ColMaSoThue.Name = "ColMaSoThue";
            this.ColMaSoThue.ReadOnly = true;
            this.ColMaSoThue.Width = 120;
            // 
            // ColThue
            // 
            this.ColThue.DataPropertyName = "thue";
            this.ColThue.HeaderText = "THUẾ";
            this.ColThue.Name = "ColThue";
            this.ColThue.ReadOnly = true;
            this.ColThue.Width = 80;
            // 
            // ColChietKhau
            // 
            this.ColChietKhau.DataPropertyName = "chietkhau";
            this.ColChietKhau.HeaderText = "CHIẾT KHẤU";
            this.ColChietKhau.Name = "ColChietKhau";
            this.ColChietKhau.ReadOnly = true;
            this.ColChietKhau.Width = 110;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 0);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(797, 10);
            this.bunifuSeparator1.TabIndex = 6;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // BtnTimKiem
            // 
            this.BtnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnTimKiem.AutoSize = true;
            this.BtnTimKiem.BackColor = System.Drawing.Color.White;
            this.BtnTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnTimKiem.BackgroundImage")));
            this.BtnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTimKiem.ForeColor = System.Drawing.Color.Gray;
            this.BtnTimKiem.Icon = ((System.Drawing.Image)(resources.GetObject("BtnTimKiem.Icon")));
            this.BtnTimKiem.Location = new System.Drawing.Point(598, 18);
            this.BtnTimKiem.Name = "BtnTimKiem";
            this.BtnTimKiem.Size = new System.Drawing.Size(190, 31);
            this.BtnTimKiem.TabIndex = 9;
            this.BtnTimKiem.text = "";
            this.BtnTimKiem.OnTextChange += new System.EventHandler(this.BtnTimKiem_OnTextChange);
            // 
            // BtnXoaKhachHang
            // 
            this.BtnXoaKhachHang.AutoSize = true;
            this.BtnXoaKhachHang.BackColor = System.Drawing.Color.White;
            this.BtnXoaKhachHang.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnXoaKhachHang.FlatAppearance.BorderSize = 0;
            this.BtnXoaKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnXoaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXoaKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnXoaKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("BtnXoaKhachHang.Image")));
            this.BtnXoaKhachHang.Location = new System.Drawing.Point(332, 12);
            this.BtnXoaKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.BtnXoaKhachHang.Name = "BtnXoaKhachHang";
            this.BtnXoaKhachHang.Size = new System.Drawing.Size(151, 40);
            this.BtnXoaKhachHang.TabIndex = 7;
            this.BtnXoaKhachHang.Text = "Xóa khách hàng";
            this.BtnXoaKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnXoaKhachHang.UseVisualStyleBackColor = false;
            this.BtnXoaKhachHang.Click += new System.EventHandler(this.BtnXoaKhachHang_Click);
            // 
            // BtnSuaKhachHang
            // 
            this.BtnSuaKhachHang.AutoSize = true;
            this.BtnSuaKhachHang.BackColor = System.Drawing.Color.White;
            this.BtnSuaKhachHang.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnSuaKhachHang.FlatAppearance.BorderSize = 0;
            this.BtnSuaKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSuaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSuaKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSuaKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("BtnSuaKhachHang.Image")));
            this.BtnSuaKhachHang.Location = new System.Drawing.Point(177, 12);
            this.BtnSuaKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSuaKhachHang.Name = "BtnSuaKhachHang";
            this.BtnSuaKhachHang.Size = new System.Drawing.Size(151, 40);
            this.BtnSuaKhachHang.TabIndex = 7;
            this.BtnSuaKhachHang.Text = "Sửa khách hàng";
            this.BtnSuaKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSuaKhachHang.UseVisualStyleBackColor = false;
            this.BtnSuaKhachHang.Click += new System.EventHandler(this.BtnSuaKhachHang_Click);
            // 
            // BtnThemKhachHang
            // 
            this.BtnThemKhachHang.AutoSize = true;
            this.BtnThemKhachHang.BackColor = System.Drawing.Color.White;
            this.BtnThemKhachHang.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnThemKhachHang.FlatAppearance.BorderSize = 0;
            this.BtnThemKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnThemKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThemKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnThemKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("BtnThemKhachHang.Image")));
            this.BtnThemKhachHang.Location = new System.Drawing.Point(11, 12);
            this.BtnThemKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.BtnThemKhachHang.Name = "BtnThemKhachHang";
            this.BtnThemKhachHang.Size = new System.Drawing.Size(162, 40);
            this.BtnThemKhachHang.TabIndex = 7;
            this.BtnThemKhachHang.Text = "Thêm khách hàng";
            this.BtnThemKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnThemKhachHang.UseVisualStyleBackColor = false;
            this.BtnThemKhachHang.Click += new System.EventHandler(this.BtnThemKhachHang_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.BangKhachHang);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.bunifuSeparator1);
            this.panel5.Controls.Add(this.BtnTimKiem);
            this.panel5.Controls.Add(this.BtnXoaKhachHang);
            this.panel5.Controls.Add(this.BtnSuaKhachHang);
            this.panel5.Controls.Add(this.BtnThemKhachHang);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 387);
            this.panel5.Name = "panel5";
            this.panel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel5.Size = new System.Drawing.Size(800, 63);
            this.panel5.TabIndex = 0;
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KhachHang";
            this.Text = "KhachHang";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BangKhachHang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid BangKhachHang;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuTextbox BtnTimKiem;
        private System.Windows.Forms.Button BtnXoaKhachHang;
        private System.Windows.Forms.Button BtnSuaKhachHang;
        private System.Windows.Forms.Button BtnThemKhachHang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaSoThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColChietKhau;
    }
}