﻿namespace TVKCoffe
{
    partial class GiamGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiamGia));
            this.SelectLoaiGiamGia = new Bunifu.Framework.UI.BunifuDropdown();
            this.TxtNoiDung = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.BtnLamLai = new System.Windows.Forms.Button();
            this.BtnApDung = new System.Windows.Forms.Button();
            this.labelTieuDe = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textTongGiam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelectLoaiGiamGia
            // 
            this.SelectLoaiGiamGia.BackColor = System.Drawing.Color.Transparent;
            this.SelectLoaiGiamGia.BorderRadius = 3;
            this.SelectLoaiGiamGia.ForeColor = System.Drawing.Color.White;
            this.SelectLoaiGiamGia.Items = new string[] {
        "Giảm Vocher",
        "Giảm Theo Chương Trình",
        "Giảm Theo Sản Phẩm",
        "Giảm Theo Khách Hàng"};
            this.SelectLoaiGiamGia.Location = new System.Drawing.Point(12, 12);
            this.SelectLoaiGiamGia.Name = "SelectLoaiGiamGia";
            this.SelectLoaiGiamGia.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.SelectLoaiGiamGia.onHoverColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SelectLoaiGiamGia.selectedIndex = -1;
            this.SelectLoaiGiamGia.Size = new System.Drawing.Size(295, 38);
            this.SelectLoaiGiamGia.TabIndex = 42;
            // 
            // TxtNoiDung
            // 
            this.TxtNoiDung.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.TxtNoiDung.BorderColorIdle = System.Drawing.Color.Gray;
            this.TxtNoiDung.BorderColorMouseHover = System.Drawing.Color.DimGray;
            this.TxtNoiDung.BorderThickness = 3;
            this.TxtNoiDung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNoiDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtNoiDung.isPassword = false;
            this.TxtNoiDung.Location = new System.Drawing.Point(12, 77);
            this.TxtNoiDung.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNoiDung.Name = "TxtNoiDung";
            this.TxtNoiDung.Size = new System.Drawing.Size(295, 41);
            this.TxtNoiDung.TabIndex = 43;
            this.TxtNoiDung.Text = "20000";
            this.TxtNoiDung.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.BtnLamLai.Location = new System.Drawing.Point(171, 171);
            this.BtnLamLai.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLamLai.Name = "BtnLamLai";
            this.BtnLamLai.Size = new System.Drawing.Size(136, 41);
            this.BtnLamLai.TabIndex = 60;
            this.BtnLamLai.Text = "Làm lại";
            this.BtnLamLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLamLai.UseVisualStyleBackColor = false;
            // 
            // BtnApDung
            // 
            this.BtnApDung.AutoSize = true;
            this.BtnApDung.BackColor = System.Drawing.Color.White;
            this.BtnApDung.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnApDung.FlatAppearance.BorderSize = 0;
            this.BtnApDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnApDung.Image = ((System.Drawing.Image)(resources.GetObject("BtnApDung.Image")));
            this.BtnApDung.Location = new System.Drawing.Point(11, 171);
            this.BtnApDung.Margin = new System.Windows.Forms.Padding(2);
            this.BtnApDung.Name = "BtnApDung";
            this.BtnApDung.Size = new System.Drawing.Size(145, 41);
            this.BtnApDung.TabIndex = 61;
            this.BtnApDung.Text = "Áp dụng";
            this.BtnApDung.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnApDung.UseVisualStyleBackColor = false;
            // 
            // labelTieuDe
            // 
            this.labelTieuDe.AutoSize = true;
            this.labelTieuDe.Location = new System.Drawing.Point(12, 60);
            this.labelTieuDe.Name = "labelTieuDe";
            this.labelTieuDe.Size = new System.Drawing.Size(95, 13);
            this.labelTieuDe.TabIndex = 62;
            this.labelTieuDe.Text = "Nhập tiền giảm giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 63;
            this.label2.Text = "Tổng giảm giá:";
            // 
            // textTongGiam
            // 
            this.textTongGiam.AutoSize = true;
            this.textTongGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTongGiam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.textTongGiam.Location = new System.Drawing.Point(107, 138);
            this.textTongGiam.Name = "textTongGiam";
            this.textTongGiam.Size = new System.Drawing.Size(64, 15);
            this.textTongGiam.TabIndex = 63;
            this.textTongGiam.Text = "-20.000đ";
            // 
            // GiamGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(319, 223);
            this.Controls.Add(this.textTongGiam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTieuDe);
            this.Controls.Add(this.BtnLamLai);
            this.Controls.Add(this.BtnApDung);
            this.Controls.Add(this.TxtNoiDung);
            this.Controls.Add(this.SelectLoaiGiamGia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GiamGia";
            this.Opacity = 0.98D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GIẢM GIÁ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDropdown SelectLoaiGiamGia;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtNoiDung;
        private System.Windows.Forms.Button BtnLamLai;
        private System.Windows.Forms.Button BtnApDung;
        private System.Windows.Forms.Label labelTieuDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label textTongGiam;
    }
}