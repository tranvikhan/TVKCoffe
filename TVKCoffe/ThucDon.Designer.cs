namespace TVKCoffe
{
    partial class ThucDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThucDon));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.SelectChonDanhMuc = new Bunifu.Framework.UI.BunifuDropdown();
            this.BtnTimKiem = new Bunifu.Framework.UI.BunifuTextbox();
            this.BtnQuanLyDangMuc = new System.Windows.Forms.Button();
            this.BtnXoaMon = new System.Windows.Forms.Button();
            this.BtnSuaMon = new System.Windows.Forms.Button();
            this.BtnThemMon = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BangThucDon = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ColStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAnh = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColMaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGiaVon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BangThucDon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.bunifuSeparator1);
            this.panel5.Controls.Add(this.SelectChonDanhMuc);
            this.panel5.Controls.Add(this.BtnTimKiem);
            this.panel5.Controls.Add(this.BtnQuanLyDangMuc);
            this.panel5.Controls.Add(this.BtnXoaMon);
            this.panel5.Controls.Add(this.BtnSuaMon);
            this.panel5.Controls.Add(this.BtnThemMon);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 379);
            this.panel5.Name = "panel5";
            this.panel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel5.Size = new System.Drawing.Size(1000, 63);
            this.panel5.TabIndex = 0;
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
            this.bunifuSeparator1.Size = new System.Drawing.Size(997, 10);
            this.bunifuSeparator1.TabIndex = 6;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // SelectChonDanhMuc
            // 
            this.SelectChonDanhMuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectChonDanhMuc.BackColor = System.Drawing.Color.Transparent;
            this.SelectChonDanhMuc.BorderRadius = 3;
            this.SelectChonDanhMuc.ForeColor = System.Drawing.Color.White;
            this.SelectChonDanhMuc.Items = new string[] {
        "Chọn Danh Mục",
        "Cà Phê",
        "Sinh Tố",
        "Nước Ép",
        "Nước Đóng Chai"};
            this.SelectChonDanhMuc.Location = new System.Drawing.Point(585, 18);
            this.SelectChonDanhMuc.Name = "SelectChonDanhMuc";
            this.SelectChonDanhMuc.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.SelectChonDanhMuc.onHoverColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SelectChonDanhMuc.selectedIndex = 0;
            this.SelectChonDanhMuc.Size = new System.Drawing.Size(198, 31);
            this.SelectChonDanhMuc.TabIndex = 10;
            this.SelectChonDanhMuc.onItemSelected += new System.EventHandler(this.SelectChonDanhMuc_onItemSelected);
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
            this.BtnTimKiem.Location = new System.Drawing.Point(798, 18);
            this.BtnTimKiem.Name = "BtnTimKiem";
            this.BtnTimKiem.Size = new System.Drawing.Size(190, 31);
            this.BtnTimKiem.TabIndex = 9;
            this.BtnTimKiem.text = "";
            this.BtnTimKiem.OnTextChange += new System.EventHandler(this.BtnTimKiem_OnTextChange);
            // 
            // BtnQuanLyDangMuc
            // 
            this.BtnQuanLyDangMuc.AutoSize = true;
            this.BtnQuanLyDangMuc.BackColor = System.Drawing.Color.White;
            this.BtnQuanLyDangMuc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnQuanLyDangMuc.FlatAppearance.BorderSize = 0;
            this.BtnQuanLyDangMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuanLyDangMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuanLyDangMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnQuanLyDangMuc.Image = ((System.Drawing.Image)(resources.GetObject("BtnQuanLyDangMuc.Image")));
            this.BtnQuanLyDangMuc.Location = new System.Drawing.Point(346, 13);
            this.BtnQuanLyDangMuc.Margin = new System.Windows.Forms.Padding(2);
            this.BtnQuanLyDangMuc.Name = "BtnQuanLyDangMuc";
            this.BtnQuanLyDangMuc.Size = new System.Drawing.Size(163, 40);
            this.BtnQuanLyDangMuc.TabIndex = 7;
            this.BtnQuanLyDangMuc.Text = "Quản lý danh mục";
            this.BtnQuanLyDangMuc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnQuanLyDangMuc.UseVisualStyleBackColor = false;
            this.BtnQuanLyDangMuc.Click += new System.EventHandler(this.BtnQuanLyDangMuc_Click);
            // 
            // BtnXoaMon
            // 
            this.BtnXoaMon.AutoSize = true;
            this.BtnXoaMon.BackColor = System.Drawing.Color.White;
            this.BtnXoaMon.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnXoaMon.FlatAppearance.BorderSize = 0;
            this.BtnXoaMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnXoaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXoaMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnXoaMon.Image = ((System.Drawing.Image)(resources.GetObject("BtnXoaMon.Image")));
            this.BtnXoaMon.Location = new System.Drawing.Point(238, 13);
            this.BtnXoaMon.Margin = new System.Windows.Forms.Padding(2);
            this.BtnXoaMon.Name = "BtnXoaMon";
            this.BtnXoaMon.Size = new System.Drawing.Size(104, 40);
            this.BtnXoaMon.TabIndex = 7;
            this.BtnXoaMon.Text = "Xóa món";
            this.BtnXoaMon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnXoaMon.UseVisualStyleBackColor = false;
            this.BtnXoaMon.Click += new System.EventHandler(this.BtnXoaMon_Click);
            // 
            // BtnSuaMon
            // 
            this.BtnSuaMon.AutoSize = true;
            this.BtnSuaMon.BackColor = System.Drawing.Color.White;
            this.BtnSuaMon.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnSuaMon.FlatAppearance.BorderSize = 0;
            this.BtnSuaMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSuaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSuaMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSuaMon.Image = ((System.Drawing.Image)(resources.GetObject("BtnSuaMon.Image")));
            this.BtnSuaMon.Location = new System.Drawing.Point(130, 13);
            this.BtnSuaMon.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSuaMon.Name = "BtnSuaMon";
            this.BtnSuaMon.Size = new System.Drawing.Size(104, 40);
            this.BtnSuaMon.TabIndex = 7;
            this.BtnSuaMon.Text = "Sửa món";
            this.BtnSuaMon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSuaMon.UseVisualStyleBackColor = false;
            this.BtnSuaMon.Click += new System.EventHandler(this.BtnSuaMon_Click);
            // 
            // BtnThemMon
            // 
            this.BtnThemMon.AutoSize = true;
            this.BtnThemMon.BackColor = System.Drawing.Color.White;
            this.BtnThemMon.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnThemMon.FlatAppearance.BorderSize = 0;
            this.BtnThemMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnThemMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThemMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnThemMon.Image = ((System.Drawing.Image)(resources.GetObject("BtnThemMon.Image")));
            this.BtnThemMon.Location = new System.Drawing.Point(11, 13);
            this.BtnThemMon.Margin = new System.Windows.Forms.Padding(2);
            this.BtnThemMon.Name = "BtnThemMon";
            this.BtnThemMon.Size = new System.Drawing.Size(115, 40);
            this.BtnThemMon.TabIndex = 7;
            this.BtnThemMon.Text = "Thêm món";
            this.BtnThemMon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnThemMon.UseVisualStyleBackColor = false;
            this.BtnThemMon.Click += new System.EventHandler(this.BtnThemMon_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.BangThucDon);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 442);
            this.panel2.TabIndex = 1;
            // 
            // BangThucDon
            // 
            this.BangThucDon.AllowUserToAddRows = false;
            this.BangThucDon.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BangThucDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BangThucDon.BackgroundColor = System.Drawing.Color.White;
            this.BangThucDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BangThucDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BangThucDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BangThucDon.ColumnHeadersHeight = 40;
            this.BangThucDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColStt,
            this.ColAnh,
            this.ColMaMon,
            this.ColTenMon,
            this.ColDanhMuc,
            this.ColGiaBan,
            this.ColGiaVon});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BangThucDon.DefaultCellStyle = dataGridViewCellStyle3;
            this.BangThucDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BangThucDon.DoubleBuffered = true;
            this.BangThucDon.EnableHeadersVisualStyles = false;
            this.BangThucDon.GridColor = System.Drawing.Color.White;
            this.BangThucDon.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.BangThucDon.HeaderForeColor = System.Drawing.Color.White;
            this.BangThucDon.Location = new System.Drawing.Point(0, 0);
            this.BangThucDon.Name = "BangThucDon";
            this.BangThucDon.ReadOnly = true;
            this.BangThucDon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BangThucDon.RowTemplate.Height = 50;
            this.BangThucDon.Size = new System.Drawing.Size(1000, 379);
            this.BangThucDon.TabIndex = 5;
            // 
            // ColStt
            // 
            this.ColStt.DataPropertyName = "stt";
            this.ColStt.HeaderText = "STT";
            this.ColStt.Name = "ColStt";
            this.ColStt.ReadOnly = true;
            this.ColStt.Width = 30;
            // 
            // ColAnh
            // 
            this.ColAnh.DataPropertyName = "anh";
            this.ColAnh.HeaderText = "ẢNH";
            this.ColAnh.Name = "ColAnh";
            this.ColAnh.ReadOnly = true;
            this.ColAnh.Width = 50;
            // 
            // ColMaMon
            // 
            this.ColMaMon.DataPropertyName = "mamon";
            this.ColMaMon.HeaderText = "MÃ MÓN";
            this.ColMaMon.Name = "ColMaMon";
            this.ColMaMon.ReadOnly = true;
            // 
            // ColTenMon
            // 
            this.ColTenMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTenMon.DataPropertyName = "tenmon";
            this.ColTenMon.HeaderText = "TÊN MÓN";
            this.ColTenMon.Name = "ColTenMon";
            this.ColTenMon.ReadOnly = true;
            // 
            // ColDanhMuc
            // 
            this.ColDanhMuc.DataPropertyName = "danhmuc";
            this.ColDanhMuc.HeaderText = "DANH MỤC";
            this.ColDanhMuc.Name = "ColDanhMuc";
            this.ColDanhMuc.ReadOnly = true;
            this.ColDanhMuc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColDanhMuc.Width = 150;
            // 
            // ColGiaBan
            // 
            this.ColGiaBan.DataPropertyName = "giaban";
            this.ColGiaBan.HeaderText = "GIÁ BÁN";
            this.ColGiaBan.Name = "ColGiaBan";
            this.ColGiaBan.ReadOnly = true;
            this.ColGiaBan.Width = 120;
            // 
            // ColGiaVon
            // 
            this.ColGiaVon.DataPropertyName = "giavon";
            this.ColGiaVon.HeaderText = "GIÁ VỐN";
            this.ColGiaVon.Name = "ColGiaVon";
            this.ColGiaVon.ReadOnly = true;
            this.ColGiaVon.Width = 120;
            // 
            // ThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 442);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThucDon";
            this.Text = "ThucDon";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BangThucDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuDropdown SelectChonDanhMuc;
        private Bunifu.Framework.UI.BunifuTextbox BtnTimKiem;
        private System.Windows.Forms.Button BtnQuanLyDangMuc;
        private System.Windows.Forms.Button BtnXoaMon;
        private System.Windows.Forms.Button BtnSuaMon;
        private System.Windows.Forms.Button BtnThemMon;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid BangThucDon;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStt;
        private System.Windows.Forms.DataGridViewImageColumn ColAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGiaVon;
    }
}