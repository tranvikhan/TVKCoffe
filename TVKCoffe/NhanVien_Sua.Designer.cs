namespace TVKCoffe
{
    partial class NhanVien_Sua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien_Sua));
            this.PicAnhDaiDien = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMaNV = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TxtTenNV = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectChucVu = new Bunifu.Framework.UI.BunifuDropdown();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnUpload = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSoDienThoai = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.radioNu = new System.Windows.Forms.RadioButton();
            this.radioNam = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtTenDangNhap = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtMatKhau = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.TimeNgaySinh = new Bunifu.Framework.UI.BunifuDatepicker();
            this.BtnLamLai = new System.Windows.Forms.Button();
            this.BtnLuu = new System.Windows.Forms.Button();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PicAnhDaiDien)).BeginInit();
            this.SuspendLayout();
            // 
            // PicAnhDaiDien
            // 
            this.PicAnhDaiDien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicAnhDaiDien.Image = ((System.Drawing.Image)(resources.GetObject("PicAnhDaiDien.Image")));
            this.PicAnhDaiDien.Location = new System.Drawing.Point(12, 14);
            this.PicAnhDaiDien.Name = "PicAnhDaiDien";
            this.PicAnhDaiDien.Size = new System.Drawing.Size(119, 119);
            this.PicAnhDaiDien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicAnhDaiDien.TabIndex = 36;
            this.PicAnhDaiDien.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Mã nhân viên";
            // 
            // TxtMaNV
            // 
            this.TxtMaNV.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.TxtMaNV.BorderColorIdle = System.Drawing.Color.Gray;
            this.TxtMaNV.BorderColorMouseHover = System.Drawing.Color.DimGray;
            this.TxtMaNV.BorderThickness = 3;
            this.TxtMaNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtMaNV.Enabled = false;
            this.TxtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMaNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtMaNV.isPassword = false;
            this.TxtMaNV.Location = new System.Drawing.Point(145, 29);
            this.TxtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMaNV.Name = "TxtMaNV";
            this.TxtMaNV.Size = new System.Drawing.Size(207, 41);
            this.TxtMaNV.TabIndex = 37;
            this.TxtMaNV.Text = "NV001";
            this.TxtMaNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtTenNV
            // 
            this.TxtTenNV.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.TxtTenNV.BorderColorIdle = System.Drawing.Color.Gray;
            this.TxtTenNV.BorderColorMouseHover = System.Drawing.Color.DimGray;
            this.TxtTenNV.BorderThickness = 3;
            this.TxtTenNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTenNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtTenNV.isPassword = false;
            this.TxtTenNV.Location = new System.Drawing.Point(145, 92);
            this.TxtTenNV.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTenNV.Name = "TxtTenNV";
            this.TxtTenNV.Size = new System.Drawing.Size(207, 41);
            this.TxtTenNV.TabIndex = 37;
            this.TxtTenNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Tên nhân viên";
            // 
            // SelectChucVu
            // 
            this.SelectChucVu.BackColor = System.Drawing.Color.Transparent;
            this.SelectChucVu.BorderRadius = 3;
            this.SelectChucVu.ForeColor = System.Drawing.Color.White;
            this.SelectChucVu.Items = new string[] {
        "Thu Ngân",
        "Quản Lý",
        "Admin"};
            this.SelectChucVu.Location = new System.Drawing.Point(370, 163);
            this.SelectChucVu.Name = "SelectChucVu";
            this.SelectChucVu.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.SelectChucVu.onHoverColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SelectChucVu.selectedIndex = 0;
            this.SelectChucVu.Size = new System.Drawing.Size(203, 38);
            this.SelectChucVu.TabIndex = 40;
            this.SelectChucVu.onItemSelected += new System.EventHandler(this.SelectChucVu_onItemSelected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Chức vụ";
            // 
            // BtnUpload
            // 
            this.BtnUpload.AutoSize = true;
            this.BtnUpload.BackColor = System.Drawing.Color.Transparent;
            this.BtnUpload.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnUpload.FlatAppearance.BorderSize = 0;
            this.BtnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnUpload.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpload.Image")));
            this.BtnUpload.Location = new System.Drawing.Point(11, 147);
            this.BtnUpload.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUpload.Name = "BtnUpload";
            this.BtnUpload.Size = new System.Drawing.Size(120, 41);
            this.BtnUpload.TabIndex = 41;
            this.BtnUpload.Text = "Tải ảnh";
            this.BtnUpload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUpload.UseVisualStyleBackColor = false;
            this.BtnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Email";
            // 
            // TxtEmail
            // 
            this.TxtEmail.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.TxtEmail.BorderColorIdle = System.Drawing.Color.Gray;
            this.TxtEmail.BorderColorMouseHover = System.Drawing.Color.DimGray;
            this.TxtEmail.BorderThickness = 3;
            this.TxtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtEmail.isPassword = false;
            this.TxtEmail.Location = new System.Drawing.Point(366, 29);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(207, 41);
            this.TxtEmail.TabIndex = 42;
            this.TxtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Số điện thoại";
            // 
            // TxtSoDienThoai
            // 
            this.TxtSoDienThoai.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.TxtSoDienThoai.BorderColorIdle = System.Drawing.Color.Gray;
            this.TxtSoDienThoai.BorderColorMouseHover = System.Drawing.Color.DimGray;
            this.TxtSoDienThoai.BorderThickness = 3;
            this.TxtSoDienThoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSoDienThoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtSoDienThoai.isPassword = false;
            this.TxtSoDienThoai.Location = new System.Drawing.Point(366, 92);
            this.TxtSoDienThoai.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSoDienThoai.Name = "TxtSoDienThoai";
            this.TxtSoDienThoai.Size = new System.Drawing.Size(207, 41);
            this.TxtSoDienThoai.TabIndex = 44;
            this.TxtSoDienThoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // radioNu
            // 
            this.radioNu.AutoSize = true;
            this.radioNu.Location = new System.Drawing.Point(92, 240);
            this.radioNu.Name = "radioNu";
            this.radioNu.Size = new System.Drawing.Size(39, 17);
            this.radioNu.TabIndex = 51;
            this.radioNu.TabStop = true;
            this.radioNu.Text = "Nữ";
            this.radioNu.UseVisualStyleBackColor = true;
            // 
            // radioNam
            // 
            this.radioNam.AutoSize = true;
            this.radioNam.Location = new System.Drawing.Point(25, 240);
            this.radioNam.Name = "radioNam";
            this.radioNam.Size = new System.Drawing.Size(47, 17);
            this.radioNam.TabIndex = 50;
            this.radioNam.TabStop = true;
            this.radioNam.Text = "Nam";
            this.radioNam.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Giới tính:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Tên đăng nhập";
            // 
            // TxtTenDangNhap
            // 
            this.TxtTenDangNhap.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.TxtTenDangNhap.BorderColorIdle = System.Drawing.Color.Gray;
            this.TxtTenDangNhap.BorderColorMouseHover = System.Drawing.Color.DimGray;
            this.TxtTenDangNhap.BorderThickness = 3;
            this.TxtTenDangNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTenDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtTenDangNhap.isPassword = false;
            this.TxtTenDangNhap.Location = new System.Drawing.Point(145, 160);
            this.TxtTenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTenDangNhap.Name = "TxtTenDangNhap";
            this.TxtTenDangNhap.Size = new System.Drawing.Size(207, 41);
            this.TxtTenDangNhap.TabIndex = 52;
            this.TxtTenDangNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(146, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Mật Khẩu";
            // 
            // TxtMatKhau
            // 
            this.TxtMatKhau.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.TxtMatKhau.BorderColorIdle = System.Drawing.Color.Gray;
            this.TxtMatKhau.BorderColorMouseHover = System.Drawing.Color.DimGray;
            this.TxtMatKhau.BorderThickness = 3;
            this.TxtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtMatKhau.isPassword = true;
            this.TxtMatKhau.Location = new System.Drawing.Point(145, 227);
            this.TxtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMatKhau.Name = "TxtMatKhau";
            this.TxtMatKhau.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.TxtMatKhau.Size = new System.Drawing.Size(207, 41);
            this.TxtMatKhau.TabIndex = 54;
            this.TxtMatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(370, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "Ngày sinh";
            // 
            // TimeNgaySinh
            // 
            this.TimeNgaySinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.TimeNgaySinh.BorderRadius = 0;
            this.TimeNgaySinh.ForeColor = System.Drawing.Color.White;
            this.TimeNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TimeNgaySinh.FormatCustom = null;
            this.TimeNgaySinh.Location = new System.Drawing.Point(370, 231);
            this.TimeNgaySinh.Name = "TimeNgaySinh";
            this.TimeNgaySinh.Size = new System.Drawing.Size(203, 38);
            this.TimeNgaySinh.TabIndex = 57;
            this.TimeNgaySinh.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // BtnLamLai
            // 
            this.BtnLamLai.AutoSize = true;
            this.BtnLamLai.BackColor = System.Drawing.Color.White;
            this.BtnLamLai.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnLamLai.FlatAppearance.BorderSize = 0;
            this.BtnLamLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLamLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLamLai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnLamLai.Image = ((System.Drawing.Image)(resources.GetObject("BtnLamLai.Image")));
            this.BtnLamLai.Location = new System.Drawing.Point(370, 284);
            this.BtnLamLai.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLamLai.Name = "BtnLamLai";
            this.BtnLamLai.Size = new System.Drawing.Size(203, 41);
            this.BtnLamLai.TabIndex = 58;
            this.BtnLamLai.Text = "Làm lại";
            this.BtnLamLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLamLai.UseVisualStyleBackColor = false;
            this.BtnLamLai.Click += new System.EventHandler(this.BtnLamLai_Click);
            // 
            // BtnLuu
            // 
            this.BtnLuu.AutoSize = true;
            this.BtnLuu.BackColor = System.Drawing.Color.White;
            this.BtnLuu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnLuu.FlatAppearance.BorderSize = 0;
            this.BtnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnLuu.Image = ((System.Drawing.Image)(resources.GetObject("BtnLuu.Image")));
            this.BtnLuu.Location = new System.Drawing.Point(149, 284);
            this.BtnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLuu.Name = "BtnLuu";
            this.BtnLuu.Size = new System.Drawing.Size(203, 41);
            this.BtnLuu.TabIndex = 59;
            this.BtnLuu.Text = "Lưu";
            this.BtnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLuu.UseVisualStyleBackColor = false;
            this.BtnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.DarkGray;
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.DarkGray;
            this.bunifuCheckbox1.Checked = false;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(322, 238);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 60;
            this.bunifuCheckbox1.OnChange += new System.EventHandler(this.bunifuCheckbox1_OnChange);
            // 
            // openFile
            // 
            this.openFile.FileName = "file";
            // 
            // NhanVien_Sua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(588, 345);
            this.Controls.Add(this.bunifuCheckbox1);
            this.Controls.Add(this.BtnLamLai);
            this.Controls.Add(this.BtnLuu);
            this.Controls.Add(this.TimeNgaySinh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtMatKhau);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtTenDangNhap);
            this.Controls.Add(this.radioNu);
            this.Controls.Add(this.radioNam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtSoDienThoai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.BtnUpload);
            this.Controls.Add(this.SelectChucVu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtTenNV);
            this.Controls.Add(this.TxtMaNV);
            this.Controls.Add(this.PicAnhDaiDien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NhanVien_Sua";
            this.Opacity = 0.95D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SỬA NHÂN VIÊN";
            ((System.ComponentModel.ISupportInitialize)(this.PicAnhDaiDien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicAnhDaiDien;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtMaNV;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtTenNV;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDropdown SelectChucVu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnUpload;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtEmail;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtSoDienThoai;
        private System.Windows.Forms.RadioButton radioNu;
        private System.Windows.Forms.RadioButton radioNam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtTenDangNhap;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtMatKhau;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuDatepicker TimeNgaySinh;
        private System.Windows.Forms.Button BtnLamLai;
        private System.Windows.Forms.Button BtnLuu;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}