namespace TVKCoffe
{
    partial class KhuyenMai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhuyenMai));
            this.panel2 = new System.Windows.Forms.Panel();
            this.BangKhuyenMai = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ColStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenChuongTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLoaiKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaApDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTuXoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SelectLoaiKM = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.BtnTimKiem = new Bunifu.Framework.UI.BunifuTextbox();
            this.BtnXoaNhanVien = new System.Windows.Forms.Button();
            this.BtnThemNhanVien = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BangKhuyenMai)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.BangKhuyenMai);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 463);
            this.panel2.TabIndex = 5;
            // 
            // BangKhuyenMai
            // 
            this.BangKhuyenMai.AllowUserToAddRows = false;
            this.BangKhuyenMai.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BangKhuyenMai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BangKhuyenMai.BackgroundColor = System.Drawing.Color.White;
            this.BangKhuyenMai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BangKhuyenMai.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BangKhuyenMai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BangKhuyenMai.ColumnHeadersHeight = 40;
            this.BangKhuyenMai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColStt,
            this.ColMaKM,
            this.ColTenChuongTrinh,
            this.GiaTri,
            this.ColLoaiKM,
            this.ColMaApDung,
            this.ColNgayBatDau,
            this.ColNgayKetThuc,
            this.ColTrangThai,
            this.ColTuXoa});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BangKhuyenMai.DefaultCellStyle = dataGridViewCellStyle3;
            this.BangKhuyenMai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BangKhuyenMai.DoubleBuffered = true;
            this.BangKhuyenMai.EnableHeadersVisualStyles = false;
            this.BangKhuyenMai.GridColor = System.Drawing.Color.White;
            this.BangKhuyenMai.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.BangKhuyenMai.HeaderForeColor = System.Drawing.Color.White;
            this.BangKhuyenMai.Location = new System.Drawing.Point(0, 0);
            this.BangKhuyenMai.Name = "BangKhuyenMai";
            this.BangKhuyenMai.ReadOnly = true;
            this.BangKhuyenMai.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BangKhuyenMai.RowTemplate.Height = 30;
            this.BangKhuyenMai.Size = new System.Drawing.Size(914, 400);
            this.BangKhuyenMai.TabIndex = 5;
            // 
            // ColStt
            // 
            this.ColStt.DataPropertyName = "Stt";
            this.ColStt.HeaderText = "STT";
            this.ColStt.Name = "ColStt";
            this.ColStt.ReadOnly = true;
            this.ColStt.Width = 70;
            // 
            // ColMaKM
            // 
            this.ColMaKM.DataPropertyName = "MaKM";
            this.ColMaKM.HeaderText = "MÃ KM";
            this.ColMaKM.Name = "ColMaKM";
            this.ColMaKM.ReadOnly = true;
            // 
            // ColTenChuongTrinh
            // 
            this.ColTenChuongTrinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTenChuongTrinh.DataPropertyName = "TenCT";
            this.ColTenChuongTrinh.HeaderText = "TÊN C.TRÌNH";
            this.ColTenChuongTrinh.Name = "ColTenChuongTrinh";
            this.ColTenChuongTrinh.ReadOnly = true;
            // 
            // GiaTri
            // 
            this.GiaTri.DataPropertyName = "GiaTri";
            this.GiaTri.HeaderText = "GIÁ TRỊ";
            this.GiaTri.Name = "GiaTri";
            this.GiaTri.ReadOnly = true;
            // 
            // ColLoaiKM
            // 
            this.ColLoaiKM.DataPropertyName = "LoaiKM";
            this.ColLoaiKM.HeaderText = "LOẠI";
            this.ColLoaiKM.Name = "ColLoaiKM";
            this.ColLoaiKM.ReadOnly = true;
            // 
            // ColMaApDung
            // 
            this.ColMaApDung.DataPropertyName = "MaApDung";
            this.ColMaApDung.HeaderText = "ÁP DỤNG";
            this.ColMaApDung.Name = "ColMaApDung";
            this.ColMaApDung.ReadOnly = true;
            this.ColMaApDung.Width = 130;
            // 
            // ColNgayBatDau
            // 
            this.ColNgayBatDau.DataPropertyName = "BatDau";
            this.ColNgayBatDau.HeaderText = "BẮT ĐẦU";
            this.ColNgayBatDau.Name = "ColNgayBatDau";
            this.ColNgayBatDau.ReadOnly = true;
            // 
            // ColNgayKetThuc
            // 
            this.ColNgayKetThuc.DataPropertyName = "KetThuc";
            this.ColNgayKetThuc.HeaderText = "KẾT THÚC";
            this.ColNgayKetThuc.Name = "ColNgayKetThuc";
            this.ColNgayKetThuc.ReadOnly = true;
            // 
            // ColTrangThai
            // 
            this.ColTrangThai.DataPropertyName = "TrangThai";
            this.ColTrangThai.HeaderText = "TRẠNG THÁI";
            this.ColTrangThai.Name = "ColTrangThai";
            this.ColTrangThai.ReadOnly = true;
            // 
            // ColTuXoa
            // 
            this.ColTuXoa.DataPropertyName = "TuXoa";
            this.ColTuXoa.HeaderText = "TỰ XOA";
            this.ColTuXoa.Name = "ColTuXoa";
            this.ColTuXoa.ReadOnly = true;
            this.ColTuXoa.Width = 80;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.SelectLoaiKM);
            this.panel5.Controls.Add(this.bunifuSeparator1);
            this.panel5.Controls.Add(this.BtnTimKiem);
            this.panel5.Controls.Add(this.BtnXoaNhanVien);
            this.panel5.Controls.Add(this.BtnThemNhanVien);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 400);
            this.panel5.Name = "panel5";
            this.panel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel5.Size = new System.Drawing.Size(914, 63);
            this.panel5.TabIndex = 0;
            // 
            // SelectLoaiKM
            // 
            this.SelectLoaiKM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectLoaiKM.BackColor = System.Drawing.Color.Transparent;
            this.SelectLoaiKM.BorderRadius = 3;
            this.SelectLoaiKM.ForeColor = System.Drawing.Color.White;
            this.SelectLoaiKM.Items = new string[] {
        "Chọn Loại KM",
        "Vocher",
        "Chương Trình"};
            this.SelectLoaiKM.Location = new System.Drawing.Point(503, 18);
            this.SelectLoaiKM.Name = "SelectLoaiKM";
            this.SelectLoaiKM.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.SelectLoaiKM.onHoverColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SelectLoaiKM.selectedIndex = 0;
            this.SelectLoaiKM.Size = new System.Drawing.Size(203, 35);
            this.SelectLoaiKM.TabIndex = 61;
            this.SelectLoaiKM.onItemSelected += new System.EventHandler(this.SelectLoaiKM_onItemSelected);
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
            this.bunifuSeparator1.Size = new System.Drawing.Size(911, 10);
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
            this.BtnTimKiem.Location = new System.Drawing.Point(712, 19);
            this.BtnTimKiem.Name = "BtnTimKiem";
            this.BtnTimKiem.Size = new System.Drawing.Size(190, 34);
            this.BtnTimKiem.TabIndex = 9;
            this.BtnTimKiem.text = "";
            this.BtnTimKiem.OnTextChange += new System.EventHandler(this.BtnTimKiem_OnTextChange);
            // 
            // BtnXoaNhanVien
            // 
            this.BtnXoaNhanVien.AutoSize = true;
            this.BtnXoaNhanVien.BackColor = System.Drawing.Color.White;
            this.BtnXoaNhanVien.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnXoaNhanVien.FlatAppearance.BorderSize = 0;
            this.BtnXoaNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnXoaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXoaNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnXoaNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("BtnXoaNhanVien.Image")));
            this.BtnXoaNhanVien.Location = new System.Drawing.Point(175, 12);
            this.BtnXoaNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.BtnXoaNhanVien.Name = "BtnXoaNhanVien";
            this.BtnXoaNhanVien.Size = new System.Drawing.Size(149, 40);
            this.BtnXoaNhanVien.TabIndex = 7;
            this.BtnXoaNhanVien.Text = "Xóa khuyến mãi";
            this.BtnXoaNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnXoaNhanVien.UseVisualStyleBackColor = false;
            this.BtnXoaNhanVien.Click += new System.EventHandler(this.BtnXoaNhanVien_Click);
            // 
            // BtnThemNhanVien
            // 
            this.BtnThemNhanVien.AutoSize = true;
            this.BtnThemNhanVien.BackColor = System.Drawing.Color.White;
            this.BtnThemNhanVien.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnThemNhanVien.FlatAppearance.BorderSize = 0;
            this.BtnThemNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnThemNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThemNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnThemNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("BtnThemNhanVien.Image")));
            this.BtnThemNhanVien.Location = new System.Drawing.Point(11, 12);
            this.BtnThemNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.BtnThemNhanVien.Name = "BtnThemNhanVien";
            this.BtnThemNhanVien.Size = new System.Drawing.Size(160, 40);
            this.BtnThemNhanVien.TabIndex = 7;
            this.BtnThemNhanVien.Text = "Thêm khuyến mãi";
            this.BtnThemNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnThemNhanVien.UseVisualStyleBackColor = false;
            this.BtnThemNhanVien.Click += new System.EventHandler(this.BtnThemNhanVien_Click);
            // 
            // KhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 463);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KhuyenMai";
            this.Text = "KhuyenMai";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BangKhuyenMai)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid BangKhuyenMai;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuTextbox BtnTimKiem;
        private System.Windows.Forms.Button BtnXoaNhanVien;
        private System.Windows.Forms.Button BtnThemNhanVien;
        private Bunifu.Framework.UI.BunifuDropdown SelectLoaiKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenChuongTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLoaiKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaApDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTuXoa;
    }
}