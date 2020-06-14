namespace TVKCoffe
{
    partial class KhuyenMai_ChuongTrinh
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTenCT = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextGiaTri = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Tên chương trình";
            // 
            // TxtTenCT
            // 
            this.TxtTenCT.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.TxtTenCT.BorderColorIdle = System.Drawing.Color.Gray;
            this.TxtTenCT.BorderColorMouseHover = System.Drawing.Color.DimGray;
            this.TxtTenCT.BorderThickness = 3;
            this.TxtTenCT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTenCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTenCT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtTenCT.isPassword = false;
            this.TxtTenCT.Location = new System.Drawing.Point(1, 17);
            this.TxtTenCT.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTenCT.Name = "TxtTenCT";
            this.TxtTenCT.Size = new System.Drawing.Size(207, 41);
            this.TxtTenCT.TabIndex = 39;
            this.TxtTenCT.Text = "Hè Vui Nhộn";
            this.TxtTenCT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Giá trị khuyến mãi";
            // 
            // TextGiaTri
            // 
            this.TextGiaTri.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.TextGiaTri.BorderColorIdle = System.Drawing.Color.Gray;
            this.TextGiaTri.BorderColorMouseHover = System.Drawing.Color.DimGray;
            this.TextGiaTri.BorderThickness = 3;
            this.TextGiaTri.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextGiaTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextGiaTri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextGiaTri.isPassword = false;
            this.TextGiaTri.Location = new System.Drawing.Point(268, 17);
            this.TextGiaTri.Margin = new System.Windows.Forms.Padding(4);
            this.TextGiaTri.Name = "TextGiaTri";
            this.TextGiaTri.Size = new System.Drawing.Size(207, 41);
            this.TextGiaTri.TabIndex = 41;
            this.TextGiaTri.Text = "100000";
            this.TextGiaTri.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // KhuyenMai_ChuongTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(488, 217);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextGiaTri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtTenCT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KhuyenMai_ChuongTrinh";
            this.Opacity = 0.95D;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtTenCT;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox TextGiaTri;
    }
}