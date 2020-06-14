namespace TVKCoffe
{
    partial class KhuyenMai_SanPham_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhuyenMai_SanPham_Edit));
            this.BtnLamLai = new System.Windows.Forms.Button();
            this.BtnLuu = new System.Windows.Forms.Button();
            this.TxtGia = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.BtnLamLai.Location = new System.Drawing.Point(339, 27);
            this.BtnLamLai.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLamLai.Name = "BtnLamLai";
            this.BtnLamLai.Size = new System.Drawing.Size(93, 41);
            this.BtnLamLai.TabIndex = 28;
            this.BtnLamLai.Text = "Làm lại";
            this.BtnLamLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLamLai.UseVisualStyleBackColor = false;
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
            this.BtnLuu.Location = new System.Drawing.Point(223, 27);
            this.BtnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLuu.Name = "BtnLuu";
            this.BtnLuu.Size = new System.Drawing.Size(108, 41);
            this.BtnLuu.TabIndex = 29;
            this.BtnLuu.Text = "Lưu";
            this.BtnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLuu.UseVisualStyleBackColor = false;
            // 
            // TxtGia
            // 
            this.TxtGia.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.TxtGia.BorderColorIdle = System.Drawing.Color.Gray;
            this.TxtGia.BorderColorMouseHover = System.Drawing.Color.DimGray;
            this.TxtGia.BorderThickness = 3;
            this.TxtGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtGia.isPassword = false;
            this.TxtGia.Location = new System.Drawing.Point(7, 25);
            this.TxtGia.Margin = new System.Windows.Forms.Padding(4);
            this.TxtGia.Name = "TxtGia";
            this.TxtGia.Size = new System.Drawing.Size(207, 41);
            this.TxtGia.TabIndex = 40;
            this.TxtGia.Text = "100";
            this.TxtGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "Giảm Giá đ";
            // 
            // KhuyenMai_SanPham_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(444, 86);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtGia);
            this.Controls.Add(this.BtnLamLai);
            this.Controls.Add(this.BtnLuu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KhuyenMai_SanPham_Edit";
            this.Opacity = 0.98D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SỬA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnLamLai;
        private System.Windows.Forms.Button BtnLuu;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtGia;
        private System.Windows.Forms.Label label1;
    }
}