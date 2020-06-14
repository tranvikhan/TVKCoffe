namespace TVKCoffe
{
    partial class KhuyenMai_SanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhuyenMai_SanPham));
            this.BangSanPham = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ColStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGiaTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnThemKM = new System.Windows.Forms.Button();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BangSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // BangSanPham
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BangSanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BangSanPham.BackgroundColor = System.Drawing.Color.White;
            this.BangSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BangSanPham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BangSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BangSanPham.ColumnHeadersHeight = 40;
            this.BangSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColStt,
            this.ColMaKM,
            this.ColTenKM,
            this.ColMa,
            this.ColGiaTri});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BangSanPham.DefaultCellStyle = dataGridViewCellStyle3;
            this.BangSanPham.DoubleBuffered = true;
            this.BangSanPham.EnableHeadersVisualStyles = false;
            this.BangSanPham.GridColor = System.Drawing.Color.White;
            this.BangSanPham.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.BangSanPham.HeaderForeColor = System.Drawing.Color.White;
            this.BangSanPham.Location = new System.Drawing.Point(5, 60);
            this.BangSanPham.Name = "BangSanPham";
            this.BangSanPham.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BangSanPham.Size = new System.Drawing.Size(470, 152);
            this.BangSanPham.TabIndex = 43;
            // 
            // ColStt
            // 
            this.ColStt.HeaderText = "STT";
            this.ColStt.Name = "ColStt";
            this.ColStt.Width = 30;
            // 
            // ColMaKM
            // 
            this.ColMaKM.HeaderText = "MÃ KM";
            this.ColMaKM.Name = "ColMaKM";
            this.ColMaKM.Width = 80;
            // 
            // ColTenKM
            // 
            this.ColTenKM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTenKM.HeaderText = "TÊN MÓN";
            this.ColTenKM.Name = "ColTenKM";
            // 
            // ColMa
            // 
            this.ColMa.HeaderText = "M.MÓN";
            this.ColMa.Name = "ColMa";
            // 
            // ColGiaTri
            // 
            this.ColGiaTri.HeaderText = "GIÁ TRỊ";
            this.ColGiaTri.Name = "ColGiaTri";
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
            this.BtnThemKM.Location = new System.Drawing.Point(5, 11);
            this.BtnThemKM.Margin = new System.Windows.Forms.Padding(2);
            this.BtnThemKM.Name = "BtnThemKM";
            this.BtnThemKM.Size = new System.Drawing.Size(171, 41);
            this.BtnThemKM.TabIndex = 60;
            this.BtnThemKM.Text = "Thêm Món KM";
            this.BtnThemKM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnThemKM.UseVisualStyleBackColor = false;
            // 
            // BtnXoa
            // 
            this.BtnXoa.AutoSize = true;
            this.BtnXoa.BackColor = System.Drawing.Color.White;
            this.BtnXoa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnXoa.FlatAppearance.BorderSize = 0;
            this.BtnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnXoa.Image = ((System.Drawing.Image)(resources.GetObject("BtnXoa.Image")));
            this.BtnXoa.Location = new System.Drawing.Point(360, 11);
            this.BtnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(115, 41);
            this.BtnXoa.TabIndex = 62;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnXoa.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(180, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 41);
            this.button1.TabIndex = 63;
            this.button1.Text = "Sửa";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // KhuyenMai_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(488, 217);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnXoa);
            this.Controls.Add(this.BtnThemKM);
            this.Controls.Add(this.BangSanPham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KhuyenMai_SanPham";
            this.Opacity = 0.95D;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BangSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid BangSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGiaTri;
        private System.Windows.Forms.Button BtnThemKM;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.Button button1;
    }
}