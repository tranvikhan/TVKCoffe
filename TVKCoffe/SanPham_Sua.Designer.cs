namespace TVKCoffe
{
    partial class SanPham_Sua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPham_Sua));
            this.BtnLamLai = new System.Windows.Forms.Button();
            this.BtnLuu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTenMon = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TxtMaMon = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.SelectDanhMuc = new Bunifu.Framework.UI.BunifuDropdown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtGiaBan = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtGiaVon = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.PicAnhSP = new System.Windows.Forms.PictureBox();
            this.BtnUpload = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.BtnChonMau = new System.Windows.Forms.Button();
            this.MauNhanDien = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PicAnhSP)).BeginInit();
            this.SuspendLayout();
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
            this.BtnLamLai.Location = new System.Drawing.Point(369, 224);
            this.BtnLamLai.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLamLai.Name = "BtnLamLai";
            this.BtnLamLai.Size = new System.Drawing.Size(203, 41);
            this.BtnLamLai.TabIndex = 26;
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
            this.BtnLuu.Location = new System.Drawing.Point(147, 224);
            this.BtnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLuu.Name = "BtnLuu";
            this.BtnLuu.Size = new System.Drawing.Size(203, 41);
            this.BtnLuu.TabIndex = 27;
            this.BtnLuu.Text = "Lưu";
            this.BtnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLuu.UseVisualStyleBackColor = false;
            this.BtnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên món";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã món";
            // 
            // TxtTenMon
            // 
            this.TxtTenMon.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.TxtTenMon.BorderColorIdle = System.Drawing.Color.Gray;
            this.TxtTenMon.BorderColorMouseHover = System.Drawing.Color.DimGray;
            this.TxtTenMon.BorderThickness = 3;
            this.TxtTenMon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTenMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtTenMon.isPassword = false;
            this.TxtTenMon.Location = new System.Drawing.Point(143, 95);
            this.TxtTenMon.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTenMon.Name = "TxtTenMon";
            this.TxtTenMon.Size = new System.Drawing.Size(207, 41);
            this.TxtTenMon.TabIndex = 22;
            this.TxtTenMon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtMaMon
            // 
            this.TxtMaMon.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.TxtMaMon.BorderColorIdle = System.Drawing.Color.Gray;
            this.TxtMaMon.BorderColorMouseHover = System.Drawing.Color.DimGray;
            this.TxtMaMon.BorderThickness = 3;
            this.TxtMaMon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtMaMon.Enabled = false;
            this.TxtMaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMaMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtMaMon.isPassword = false;
            this.TxtMaMon.Location = new System.Drawing.Point(143, 30);
            this.TxtMaMon.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMaMon.Name = "TxtMaMon";
            this.TxtMaMon.Size = new System.Drawing.Size(207, 41);
            this.TxtMaMon.TabIndex = 23;
            this.TxtMaMon.Text = "SP0001";
            this.TxtMaMon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // SelectDanhMuc
            // 
            this.SelectDanhMuc.BackColor = System.Drawing.Color.Transparent;
            this.SelectDanhMuc.BorderRadius = 3;
            this.SelectDanhMuc.ForeColor = System.Drawing.Color.White;
            this.SelectDanhMuc.Items = new string[] {
        "Cà phê",
        "Nước ép",
        "Sinh tố",
        "Nước đóng chai"};
            this.SelectDanhMuc.Location = new System.Drawing.Point(366, 30);
            this.SelectDanhMuc.Name = "SelectDanhMuc";
            this.SelectDanhMuc.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.SelectDanhMuc.onHoverColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SelectDanhMuc.selectedIndex = 0;
            this.SelectDanhMuc.Size = new System.Drawing.Size(207, 38);
            this.SelectDanhMuc.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Danh mục";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Giá bán (đ)";
            // 
            // TxtGiaBan
            // 
            this.TxtGiaBan.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.TxtGiaBan.BorderColorIdle = System.Drawing.Color.Gray;
            this.TxtGiaBan.BorderColorMouseHover = System.Drawing.Color.DimGray;
            this.TxtGiaBan.BorderThickness = 3;
            this.TxtGiaBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGiaBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtGiaBan.isPassword = false;
            this.TxtGiaBan.Location = new System.Drawing.Point(143, 162);
            this.TxtGiaBan.Margin = new System.Windows.Forms.Padding(4);
            this.TxtGiaBan.Name = "TxtGiaBan";
            this.TxtGiaBan.Size = new System.Drawing.Size(207, 41);
            this.TxtGiaBan.TabIndex = 31;
            this.TxtGiaBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Giá vốn (đ)";
            // 
            // TxtGiaVon
            // 
            this.TxtGiaVon.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.TxtGiaVon.BorderColorIdle = System.Drawing.Color.Gray;
            this.TxtGiaVon.BorderColorMouseHover = System.Drawing.Color.DimGray;
            this.TxtGiaVon.BorderThickness = 3;
            this.TxtGiaVon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtGiaVon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGiaVon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtGiaVon.isPassword = false;
            this.TxtGiaVon.Location = new System.Drawing.Point(366, 162);
            this.TxtGiaVon.Margin = new System.Windows.Forms.Padding(4);
            this.TxtGiaVon.Name = "TxtGiaVon";
            this.TxtGiaVon.Size = new System.Drawing.Size(207, 41);
            this.TxtGiaVon.TabIndex = 33;
            this.TxtGiaVon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PicAnhSP
            // 
            this.PicAnhSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicAnhSP.Image = ((System.Drawing.Image)(resources.GetObject("PicAnhSP.Image")));
            this.PicAnhSP.Location = new System.Drawing.Point(12, 12);
            this.PicAnhSP.Name = "PicAnhSP";
            this.PicAnhSP.Size = new System.Drawing.Size(124, 124);
            this.PicAnhSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicAnhSP.TabIndex = 35;
            this.PicAnhSP.TabStop = false;
            // 
            // BtnUpload
            // 
            this.BtnUpload.AutoSize = true;
            this.BtnUpload.BackColor = System.Drawing.Color.White;
            this.BtnUpload.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnUpload.FlatAppearance.BorderSize = 0;
            this.BtnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnUpload.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpload.Image")));
            this.BtnUpload.Location = new System.Drawing.Point(11, 162);
            this.BtnUpload.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUpload.Name = "BtnUpload";
            this.BtnUpload.Size = new System.Drawing.Size(125, 41);
            this.BtnUpload.TabIndex = 36;
            this.BtnUpload.Text = "Tải ảnh";
            this.BtnUpload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUpload.UseVisualStyleBackColor = false;
            this.BtnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // BtnChonMau
            // 
            this.BtnChonMau.AutoSize = true;
            this.BtnChonMau.BackColor = System.Drawing.Color.White;
            this.BtnChonMau.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnChonMau.FlatAppearance.BorderSize = 2;
            this.BtnChonMau.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnChonMau.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.BtnChonMau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChonMau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChonMau.ForeColor = System.Drawing.Color.Black;
            this.BtnChonMau.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnChonMau.Location = new System.Drawing.Point(366, 97);
            this.BtnChonMau.Margin = new System.Windows.Forms.Padding(2);
            this.BtnChonMau.Name = "BtnChonMau";
            this.BtnChonMau.Size = new System.Drawing.Size(206, 39);
            this.BtnChonMau.TabIndex = 37;
            this.BtnChonMau.Text = "Chọn màu nhận diện";
            this.BtnChonMau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnChonMau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnChonMau.UseVisualStyleBackColor = false;
            this.BtnChonMau.Click += new System.EventHandler(this.BtnChonMau_Click);
            // 
            // MauNhanDien
            // 
            this.MauNhanDien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.MauNhanDien.Location = new System.Drawing.Point(538, 102);
            this.MauNhanDien.Name = "MauNhanDien";
            this.MauNhanDien.Size = new System.Drawing.Size(28, 28);
            this.MauNhanDien.TabIndex = 38;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // SanPham_Sua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(583, 281);
            this.Controls.Add(this.MauNhanDien);
            this.Controls.Add(this.BtnChonMau);
            this.Controls.Add(this.BtnUpload);
            this.Controls.Add(this.PicAnhSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtGiaVon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtGiaBan);
            this.Controls.Add(this.SelectDanhMuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnLamLai);
            this.Controls.Add(this.BtnLuu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTenMon);
            this.Controls.Add(this.TxtMaMon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SanPham_Sua";
            this.Opacity = 0.95D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SỬA SẢN PHẨM";
            ((System.ComponentModel.ISupportInitialize)(this.PicAnhSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLamLai;
        private System.Windows.Forms.Button BtnLuu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtTenMon;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtMaMon;
        private Bunifu.Framework.UI.BunifuDropdown SelectDanhMuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtGiaBan;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtGiaVon;
        private System.Windows.Forms.PictureBox PicAnhSP;
        private System.Windows.Forms.Button BtnUpload;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button BtnChonMau;
        private System.Windows.Forms.Label MauNhanDien;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}