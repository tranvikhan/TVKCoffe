﻿namespace TVKCoffe
{
    partial class DanhMuc_Sua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhMuc_Sua));
            this.BtnLamLai = new System.Windows.Forms.Button();
            this.BtnLuu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTenDanhMuc = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TxtMaDanhMuc = new Bunifu.Framework.UI.BunifuMetroTextbox();
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
            this.BtnLamLai.Location = new System.Drawing.Point(155, 179);
            this.BtnLamLai.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLamLai.Name = "BtnLamLai";
            this.BtnLamLai.Size = new System.Drawing.Size(133, 41);
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
            this.BtnLuu.Location = new System.Drawing.Point(14, 179);
            this.BtnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLuu.Name = "BtnLuu";
            this.BtnLuu.Size = new System.Drawing.Size(137, 41);
            this.BtnLuu.TabIndex = 27;
            this.BtnLuu.Text = "Lưu";
            this.BtnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLuu.UseVisualStyleBackColor = false;
            this.BtnLuu.Click += new System.EventHandler(this.BtnThemDanhMuc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên danh mục";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã danh mục";
            // 
            // TxtTenDanhMuc
            // 
            this.TxtTenDanhMuc.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.TxtTenDanhMuc.BorderColorIdle = System.Drawing.Color.Gray;
            this.TxtTenDanhMuc.BorderColorMouseHover = System.Drawing.Color.DimGray;
            this.TxtTenDanhMuc.BorderThickness = 3;
            this.TxtTenDanhMuc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTenDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTenDanhMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtTenDanhMuc.isPassword = false;
            this.TxtTenDanhMuc.Location = new System.Drawing.Point(13, 113);
            this.TxtTenDanhMuc.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTenDanhMuc.Name = "TxtTenDanhMuc";
            this.TxtTenDanhMuc.Size = new System.Drawing.Size(279, 41);
            this.TxtTenDanhMuc.TabIndex = 22;
            this.TxtTenDanhMuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtMaDanhMuc
            // 
            this.TxtMaDanhMuc.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.TxtMaDanhMuc.BorderColorIdle = System.Drawing.Color.Gray;
            this.TxtMaDanhMuc.BorderColorMouseHover = System.Drawing.Color.DimGray;
            this.TxtMaDanhMuc.BorderThickness = 3;
            this.TxtMaDanhMuc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtMaDanhMuc.Enabled = false;
            this.TxtMaDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMaDanhMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtMaDanhMuc.isPassword = false;
            this.TxtMaDanhMuc.Location = new System.Drawing.Point(13, 45);
            this.TxtMaDanhMuc.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMaDanhMuc.Name = "TxtMaDanhMuc";
            this.TxtMaDanhMuc.Size = new System.Drawing.Size(279, 41);
            this.TxtMaDanhMuc.TabIndex = 23;
            this.TxtMaDanhMuc.Text = "DM0001";
            this.TxtMaDanhMuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DanhMuc_Sua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 242);
            this.Controls.Add(this.BtnLamLai);
            this.Controls.Add(this.BtnLuu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTenDanhMuc);
            this.Controls.Add(this.TxtMaDanhMuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DanhMuc_Sua";
            this.Opacity = 0.95D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SỬA DANH MỤC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLamLai;
        private System.Windows.Forms.Button BtnLuu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtTenDanhMuc;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtMaDanhMuc;
    }
}