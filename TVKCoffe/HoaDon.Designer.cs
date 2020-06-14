namespace TVKCoffe
{
    partial class HoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDon));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnInHoaDon = new System.Windows.Forms.Button();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnTimKiem = new Bunifu.Framework.UI.BunifuTextbox();
            this.TimeDenNgay = new Bunifu.Framework.UI.BunifuDatepicker();
            this.TimeTuNgay = new Bunifu.Framework.UI.BunifuDatepicker();
            this.BangHoaDon = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ColStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BangHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BtnInHoaDon);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnTimKiem);
            this.panel1.Controls.Add(this.TimeDenNgay);
            this.panel1.Controls.Add(this.TimeTuNgay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 367);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 63);
            this.panel1.TabIndex = 0;
            // 
            // BtnInHoaDon
            // 
            this.BtnInHoaDon.AutoSize = true;
            this.BtnInHoaDon.BackColor = System.Drawing.Color.White;
            this.BtnInHoaDon.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnInHoaDon.FlatAppearance.BorderSize = 0;
            this.BtnInHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnInHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("BtnInHoaDon.Image")));
            this.BtnInHoaDon.Location = new System.Drawing.Point(484, 13);
            this.BtnInHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInHoaDon.Name = "BtnInHoaDon";
            this.BtnInHoaDon.Size = new System.Drawing.Size(119, 40);
            this.BtnInHoaDon.TabIndex = 15;
            this.BtnInHoaDon.Text = "In Hóa Đơn";
            this.BtnInHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInHoaDon.UseVisualStyleBackColor = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 0);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1000, 10);
            this.bunifuSeparator1.TabIndex = 14;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Từ";
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
            this.BtnTimKiem.Location = new System.Drawing.Point(757, 18);
            this.BtnTimKiem.Name = "BtnTimKiem";
            this.BtnTimKiem.Size = new System.Drawing.Size(231, 31);
            this.BtnTimKiem.TabIndex = 12;
            this.BtnTimKiem.text = "";
            this.BtnTimKiem.OnTextChange += new System.EventHandler(this.BtnTimKiem_OnTextChange);
            // 
            // TimeDenNgay
            // 
            this.TimeDenNgay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.TimeDenNgay.BorderRadius = 0;
            this.TimeDenNgay.ForeColor = System.Drawing.Color.White;
            this.TimeDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TimeDenNgay.FormatCustom = null;
            this.TimeDenNgay.Location = new System.Drawing.Point(275, 18);
            this.TimeDenNgay.Name = "TimeDenNgay";
            this.TimeDenNgay.Size = new System.Drawing.Size(192, 32);
            this.TimeDenNgay.TabIndex = 11;
            this.TimeDenNgay.Value = new System.DateTime(2020, 4, 23, 18, 1, 37, 521);
            this.TimeDenNgay.onValueChanged += new System.EventHandler(this.TimeDenNgay_onValueChanged);
            // 
            // TimeTuNgay
            // 
            this.TimeTuNgay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.TimeTuNgay.BorderRadius = 0;
            this.TimeTuNgay.ForeColor = System.Drawing.Color.White;
            this.TimeTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TimeTuNgay.FormatCustom = null;
            this.TimeTuNgay.Location = new System.Drawing.Point(38, 19);
            this.TimeTuNgay.Name = "TimeTuNgay";
            this.TimeTuNgay.Size = new System.Drawing.Size(189, 31);
            this.TimeTuNgay.TabIndex = 11;
            this.TimeTuNgay.Value = new System.DateTime(2020, 4, 23, 18, 1, 37, 521);
            this.TimeTuNgay.onValueChanged += new System.EventHandler(this.TimeTuNgay_onValueChanged);
            // 
            // BangHoaDon
            // 
            this.BangHoaDon.AllowUserToAddRows = false;
            this.BangHoaDon.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BangHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BangHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.BangHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BangHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BangHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BangHoaDon.ColumnHeadersHeight = 40;
            this.BangHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColStt,
            this.ColNgayTao,
            this.ColMaHoaDon,
            this.ColSanPham,
            this.ColTongTien,
            this.ColKhachHang});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BangHoaDon.DefaultCellStyle = dataGridViewCellStyle3;
            this.BangHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BangHoaDon.DoubleBuffered = true;
            this.BangHoaDon.EnableHeadersVisualStyles = false;
            this.BangHoaDon.GridColor = System.Drawing.Color.WhiteSmoke;
            this.BangHoaDon.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.BangHoaDon.HeaderForeColor = System.Drawing.Color.White;
            this.BangHoaDon.Location = new System.Drawing.Point(0, 0);
            this.BangHoaDon.Name = "BangHoaDon";
            this.BangHoaDon.ReadOnly = true;
            this.BangHoaDon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BangHoaDon.RowTemplate.Height = 30;
            this.BangHoaDon.Size = new System.Drawing.Size(1000, 367);
            this.BangHoaDon.TabIndex = 4;
            // 
            // ColStt
            // 
            this.ColStt.DataPropertyName = "stt";
            this.ColStt.HeaderText = "STT";
            this.ColStt.Name = "ColStt";
            this.ColStt.ReadOnly = true;
            this.ColStt.Width = 50;
            // 
            // ColNgayTao
            // 
            this.ColNgayTao.DataPropertyName = "ngaytao";
            this.ColNgayTao.HeaderText = "NGÀY TẠO";
            this.ColNgayTao.Name = "ColNgayTao";
            this.ColNgayTao.ReadOnly = true;
            // 
            // ColMaHoaDon
            // 
            this.ColMaHoaDon.DataPropertyName = "mahoadon";
            this.ColMaHoaDon.HeaderText = "MÃ HÓA ĐƠN";
            this.ColMaHoaDon.Name = "ColMaHoaDon";
            this.ColMaHoaDon.ReadOnly = true;
            this.ColMaHoaDon.Width = 155;
            // 
            // ColSanPham
            // 
            this.ColSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColSanPham.DataPropertyName = "sanpham";
            this.ColSanPham.HeaderText = "SẢN PHẨM";
            this.ColSanPham.Name = "ColSanPham";
            this.ColSanPham.ReadOnly = true;
            // 
            // ColTongTien
            // 
            this.ColTongTien.DataPropertyName = "tongtien";
            this.ColTongTien.HeaderText = "TỔNG TIỀN";
            this.ColTongTien.Name = "ColTongTien";
            this.ColTongTien.ReadOnly = true;
            // 
            // ColKhachHang
            // 
            this.ColKhachHang.DataPropertyName = "khachhang";
            this.ColKhachHang.HeaderText = "KHÁCH HÀNG";
            this.ColKhachHang.Name = "ColKhachHang";
            this.ColKhachHang.ReadOnly = true;
            this.ColKhachHang.Width = 120;
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1000, 430);
            this.Controls.Add(this.BangHoaDon);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BangHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDatepicker TimeTuNgay;
        private Bunifu.Framework.UI.BunifuTextbox BtnTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker TimeDenNgay;
        private Bunifu.Framework.UI.BunifuCustomDataGrid BangHoaDon;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Button BtnInHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgayTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKhachHang;
    }
}