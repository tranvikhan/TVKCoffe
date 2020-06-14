namespace TVKCoffe
{
    partial class KhuyenMai_Them
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhuyenMai_Them));
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TimeNgayBatDau = new Bunifu.Framework.UI.BunifuDatepicker();
            this.BtnLamLai = new System.Windows.Forms.Button();
            this.BtnThemKM = new System.Windows.Forms.Button();
            this.SelectLoaiKM = new Bunifu.Framework.UI.BunifuDropdown();
            this.TimeNgayKetThuc = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SwitchTuXoa = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.panelKhuyenMai = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Loại khuyến mãi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "Ngày bắt đầu";
            // 
            // TimeNgayBatDau
            // 
            this.TimeNgayBatDau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.TimeNgayBatDau.BorderRadius = 0;
            this.TimeNgayBatDau.ForeColor = System.Drawing.Color.White;
            this.TimeNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TimeNgayBatDau.FormatCustom = null;
            this.TimeNgayBatDau.Location = new System.Drawing.Point(12, 85);
            this.TimeNgayBatDau.Name = "TimeNgayBatDau";
            this.TimeNgayBatDau.Size = new System.Drawing.Size(203, 38);
            this.TimeNgayBatDau.TabIndex = 57;
            this.TimeNgayBatDau.Value = new System.DateTime(2020, 4, 23, 0, 0, 0, 0);
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
            this.BtnLamLai.Location = new System.Drawing.Point(479, 234);
            this.BtnLamLai.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLamLai.Name = "BtnLamLai";
            this.BtnLamLai.Size = new System.Drawing.Size(247, 41);
            this.BtnLamLai.TabIndex = 58;
            this.BtnLamLai.Text = "Làm lại";
            this.BtnLamLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLamLai.UseVisualStyleBackColor = false;
            this.BtnLamLai.Click += new System.EventHandler(this.BtnLamLai_Click);
            // 
            // BtnThemKM
            // 
            this.BtnThemKM.AutoSize = true;
            this.BtnThemKM.BackColor = System.Drawing.Color.White;
            this.BtnThemKM.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnThemKM.FlatAppearance.BorderSize = 0;
            this.BtnThemKM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnThemKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThemKM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnThemKM.Image = ((System.Drawing.Image)(resources.GetObject("BtnThemKM.Image")));
            this.BtnThemKM.Location = new System.Drawing.Point(238, 234);
            this.BtnThemKM.Margin = new System.Windows.Forms.Padding(2);
            this.BtnThemKM.Name = "BtnThemKM";
            this.BtnThemKM.Size = new System.Drawing.Size(237, 41);
            this.BtnThemKM.TabIndex = 59;
            this.BtnThemKM.Text = "Thêm khuyến mãi";
            this.BtnThemKM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnThemKM.UseVisualStyleBackColor = false;
            this.BtnThemKM.Click += new System.EventHandler(this.BtnThemKM_Click);
            // 
            // SelectLoaiKM
            // 
            this.SelectLoaiKM.BackColor = System.Drawing.Color.Transparent;
            this.SelectLoaiKM.BorderRadius = 3;
            this.SelectLoaiKM.ForeColor = System.Drawing.Color.White;
            this.SelectLoaiKM.Items = new string[] {
        "Vocher",
        "Chương Trình"};
            this.SelectLoaiKM.Location = new System.Drawing.Point(12, 26);
            this.SelectLoaiKM.Name = "SelectLoaiKM";
            this.SelectLoaiKM.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.SelectLoaiKM.onHoverColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SelectLoaiKM.selectedIndex = 0;
            this.SelectLoaiKM.Size = new System.Drawing.Size(203, 38);
            this.SelectLoaiKM.TabIndex = 60;
            this.SelectLoaiKM.onItemSelected += new System.EventHandler(this.SelectLoaiKM_onItemSelected);
            // 
            // TimeNgayKetThuc
            // 
            this.TimeNgayKetThuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.TimeNgayKetThuc.BorderRadius = 0;
            this.TimeNgayKetThuc.ForeColor = System.Drawing.Color.White;
            this.TimeNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TimeNgayKetThuc.FormatCustom = null;
            this.TimeNgayKetThuc.Location = new System.Drawing.Point(12, 148);
            this.TimeNgayKetThuc.Name = "TimeNgayKetThuc";
            this.TimeNgayKetThuc.Size = new System.Drawing.Size(203, 38);
            this.TimeNgayKetThuc.TabIndex = 62;
            this.TimeNgayKetThuc.Value = new System.DateTime(2020, 4, 23, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Ngày kết thúc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Tự xóa khi kết thúc:";
            // 
            // SwitchTuXoa
            // 
            this.SwitchTuXoa.BackColor = System.Drawing.Color.Transparent;
            this.SwitchTuXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SwitchTuXoa.BackgroundImage")));
            this.SwitchTuXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SwitchTuXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwitchTuXoa.Location = new System.Drawing.Point(172, 204);
            this.SwitchTuXoa.Name = "SwitchTuXoa";
            this.SwitchTuXoa.OffColor = System.Drawing.Color.Gray;
            this.SwitchTuXoa.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.SwitchTuXoa.Size = new System.Drawing.Size(43, 25);
            this.SwitchTuXoa.TabIndex = 63;
            this.SwitchTuXoa.Value = true;
            // 
            // panelKhuyenMai
            // 
            this.panelKhuyenMai.Location = new System.Drawing.Point(238, 12);
            this.panelKhuyenMai.Name = "panelKhuyenMai";
            this.panelKhuyenMai.Size = new System.Drawing.Size(488, 217);
            this.panelKhuyenMai.TabIndex = 65;
            // 
            // KhuyenMai_Them
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(738, 289);
            this.Controls.Add(this.panelKhuyenMai);
            this.Controls.Add(this.SwitchTuXoa);
            this.Controls.Add(this.TimeNgayKetThuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SelectLoaiKM);
            this.Controls.Add(this.BtnLamLai);
            this.Controls.Add(this.BtnThemKM);
            this.Controls.Add(this.TimeNgayBatDau);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KhuyenMai_Them";
            this.Opacity = 0.95D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÊM KHUYẾN MÃI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuDatepicker TimeNgayBatDau;
        private System.Windows.Forms.Button BtnLamLai;
        private System.Windows.Forms.Button BtnThemKM;
        private Bunifu.Framework.UI.BunifuDropdown SelectLoaiKM;
        private Bunifu.Framework.UI.BunifuDatepicker TimeNgayKetThuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuiOSSwitch SwitchTuXoa;
        private System.Windows.Forms.Panel panelKhuyenMai;
    }
}