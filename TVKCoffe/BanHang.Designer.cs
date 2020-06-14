namespace TVKCoffe
{
    partial class BanHang
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
            this.components = new System.ComponentModel.Container();
            this.MenuKhuVuc = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDangHoatDong = new System.Windows.Forms.Button();
            this.btnDaTamTinh = new System.Windows.Forms.Button();
            this.btnDaThanhToan = new System.Windows.Forms.Button();
            this.BottomInfomation = new System.Windows.Forms.Panel();
            this.SoBanDaTamTinh = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTimeNow = new System.Windows.Forms.Label();
            this.TenKhuVuc = new System.Windows.Forms.Label();
            this.labeltenKhuVuc = new System.Windows.Forms.Label();
            this.SoBanHoatDong = new System.Windows.Forms.Label();
            this.SoBan = new System.Windows.Forms.Label();
            this.labelDangHoatDong = new System.Windows.Forms.Label();
            this.labelSoBan = new System.Windows.Forms.Label();
            this.KhuVucContent = new System.Windows.Forms.FlowLayoutPanel();
            this.timerNow = new System.Windows.Forms.Timer(this.components);
            this.MenuKhuVuc.SuspendLayout();
            this.BottomInfomation.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuKhuVuc
            // 
            this.MenuKhuVuc.AutoScroll = true;
            this.MenuKhuVuc.BackColor = System.Drawing.Color.White;
            this.MenuKhuVuc.Controls.Add(this.btnDangHoatDong);
            this.MenuKhuVuc.Controls.Add(this.btnDaTamTinh);
            this.MenuKhuVuc.Controls.Add(this.btnDaThanhToan);
            this.MenuKhuVuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuKhuVuc.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MenuKhuVuc.Location = new System.Drawing.Point(0, 0);
            this.MenuKhuVuc.Name = "MenuKhuVuc";
            this.MenuKhuVuc.Padding = new System.Windows.Forms.Padding(5);
            this.MenuKhuVuc.Size = new System.Drawing.Size(778, 65);
            this.MenuKhuVuc.TabIndex = 0;
            // 
            // btnDangHoatDong
            // 
            this.btnDangHoatDong.AutoSize = true;
            this.btnDangHoatDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnDangHoatDong.FlatAppearance.BorderSize = 0;
            this.btnDangHoatDong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnDangHoatDong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnDangHoatDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangHoatDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangHoatDong.ForeColor = System.Drawing.Color.White;
            this.btnDangHoatDong.Location = new System.Drawing.Point(8, 8);
            this.btnDangHoatDong.Name = "btnDangHoatDong";
            this.btnDangHoatDong.Size = new System.Drawing.Size(120, 38);
            this.btnDangHoatDong.TabIndex = 0;
            this.btnDangHoatDong.Text = "Đang hoạt động";
            this.btnDangHoatDong.UseVisualStyleBackColor = false;
            this.btnDangHoatDong.Click += new System.EventHandler(this.BtnKhuVuc_Click);
            // 
            // btnDaTamTinh
            // 
            this.btnDaTamTinh.AutoSize = true;
            this.btnDaTamTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnDaTamTinh.FlatAppearance.BorderSize = 0;
            this.btnDaTamTinh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnDaTamTinh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnDaTamTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaTamTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaTamTinh.ForeColor = System.Drawing.Color.White;
            this.btnDaTamTinh.Location = new System.Drawing.Point(134, 8);
            this.btnDaTamTinh.Name = "btnDaTamTinh";
            this.btnDaTamTinh.Size = new System.Drawing.Size(100, 38);
            this.btnDaTamTinh.TabIndex = 0;
            this.btnDaTamTinh.Text = "Đã Tạm Tính";
            this.btnDaTamTinh.UseVisualStyleBackColor = false;
            this.btnDaTamTinh.Click += new System.EventHandler(this.BtnKhuVuc_Click);
            // 
            // btnDaThanhToan
            // 
            this.btnDaThanhToan.AutoSize = true;
            this.btnDaThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDaThanhToan.FlatAppearance.BorderSize = 0;
            this.btnDaThanhToan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnDaThanhToan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnDaThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnDaThanhToan.Location = new System.Drawing.Point(240, 8);
            this.btnDaThanhToan.Name = "btnDaThanhToan";
            this.btnDaThanhToan.Size = new System.Drawing.Size(118, 38);
            this.btnDaThanhToan.TabIndex = 1;
            this.btnDaThanhToan.Text = "Đã Thanh Toán";
            this.btnDaThanhToan.UseVisualStyleBackColor = false;
            this.btnDaThanhToan.Click += new System.EventHandler(this.BtnKhuVuc_Click);
            // 
            // BottomInfomation
            // 
            this.BottomInfomation.BackColor = System.Drawing.Color.White;
            this.BottomInfomation.Controls.Add(this.SoBanDaTamTinh);
            this.BottomInfomation.Controls.Add(this.label2);
            this.BottomInfomation.Controls.Add(this.TxtTimeNow);
            this.BottomInfomation.Controls.Add(this.TenKhuVuc);
            this.BottomInfomation.Controls.Add(this.labeltenKhuVuc);
            this.BottomInfomation.Controls.Add(this.SoBanHoatDong);
            this.BottomInfomation.Controls.Add(this.SoBan);
            this.BottomInfomation.Controls.Add(this.labelDangHoatDong);
            this.BottomInfomation.Controls.Add(this.labelSoBan);
            this.BottomInfomation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomInfomation.Location = new System.Drawing.Point(0, 417);
            this.BottomInfomation.Name = "BottomInfomation";
            this.BottomInfomation.Size = new System.Drawing.Size(778, 19);
            this.BottomInfomation.TabIndex = 1;
            // 
            // SoBanDaTamTinh
            // 
            this.SoBanDaTamTinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SoBanDaTamTinh.AutoSize = true;
            this.SoBanDaTamTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoBanDaTamTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.SoBanDaTamTinh.Location = new System.Drawing.Point(753, 3);
            this.SoBanDaTamTinh.Name = "SoBanDaTamTinh";
            this.SoBanDaTamTinh.Size = new System.Drawing.Size(13, 13);
            this.SoBanDaTamTinh.TabIndex = 4;
            this.SoBanDaTamTinh.Text = "5";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(684, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Đã tạm tính";
            // 
            // TxtTimeNow
            // 
            this.TxtTimeNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTimeNow.AutoSize = true;
            this.TxtTimeNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtTimeNow.Location = new System.Drawing.Point(142, 3);
            this.TxtTimeNow.Name = "TxtTimeNow";
            this.TxtTimeNow.Size = new System.Drawing.Size(27, 13);
            this.TxtTimeNow.TabIndex = 3;
            this.TxtTimeNow.Text = "now";
            // 
            // TenKhuVuc
            // 
            this.TenKhuVuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TenKhuVuc.AutoSize = true;
            this.TenKhuVuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TenKhuVuc.Location = new System.Drawing.Point(377, 3);
            this.TenKhuVuc.Name = "TenKhuVuc";
            this.TenKhuVuc.Size = new System.Drawing.Size(64, 13);
            this.TenKhuVuc.TabIndex = 2;
            this.TenKhuVuc.Text = "A Sân Vườn";
            // 
            // labeltenKhuVuc
            // 
            this.labeltenKhuVuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labeltenKhuVuc.AutoSize = true;
            this.labeltenKhuVuc.ForeColor = System.Drawing.Color.Gray;
            this.labeltenKhuVuc.Location = new System.Drawing.Point(329, 3);
            this.labeltenKhuVuc.Name = "labeltenKhuVuc";
            this.labeltenKhuVuc.Size = new System.Drawing.Size(51, 13);
            this.labeltenKhuVuc.TabIndex = 1;
            this.labeltenKhuVuc.Text = "Khu Vực:";
            // 
            // SoBanHoatDong
            // 
            this.SoBanHoatDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SoBanHoatDong.AutoSize = true;
            this.SoBanHoatDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoBanHoatDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.SoBanHoatDong.Location = new System.Drawing.Point(659, 3);
            this.SoBanHoatDong.Name = "SoBanHoatDong";
            this.SoBanHoatDong.Size = new System.Drawing.Size(13, 13);
            this.SoBanHoatDong.TabIndex = 0;
            this.SoBanHoatDong.Text = "5";
            // 
            // SoBan
            // 
            this.SoBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SoBan.AutoSize = true;
            this.SoBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SoBan.Location = new System.Drawing.Point(531, 3);
            this.SoBan.Name = "SoBan";
            this.SoBan.Size = new System.Drawing.Size(19, 13);
            this.SoBan.TabIndex = 0;
            this.SoBan.Text = "20";
            // 
            // labelDangHoatDong
            // 
            this.labelDangHoatDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDangHoatDong.AutoSize = true;
            this.labelDangHoatDong.ForeColor = System.Drawing.Color.Gray;
            this.labelDangHoatDong.Location = new System.Drawing.Point(567, 3);
            this.labelDangHoatDong.Name = "labelDangHoatDong";
            this.labelDangHoatDong.Size = new System.Drawing.Size(85, 13);
            this.labelDangHoatDong.TabIndex = 0;
            this.labelDangHoatDong.Text = "Đang hoạt động";
            // 
            // labelSoBan
            // 
            this.labelSoBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSoBan.AutoSize = true;
            this.labelSoBan.ForeColor = System.Drawing.Color.Gray;
            this.labelSoBan.Location = new System.Drawing.Point(467, 3);
            this.labelSoBan.Name = "labelSoBan";
            this.labelSoBan.Size = new System.Drawing.Size(67, 13);
            this.labelSoBan.TabIndex = 0;
            this.labelSoBan.Text = "Tổng số bàn";
            // 
            // KhuVucContent
            // 
            this.KhuVucContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KhuVucContent.Location = new System.Drawing.Point(0, 65);
            this.KhuVucContent.Name = "KhuVucContent";
            this.KhuVucContent.Padding = new System.Windows.Forms.Padding(5);
            this.KhuVucContent.Size = new System.Drawing.Size(778, 352);
            this.KhuVucContent.TabIndex = 2;
            // 
            // timerNow
            // 
            this.timerNow.Enabled = true;
            this.timerNow.Interval = 1000;
            this.timerNow.Tick += new System.EventHandler(this.timerNow_Tick);
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(778, 436);
            this.Controls.Add(this.KhuVucContent);
            this.Controls.Add(this.BottomInfomation);
            this.Controls.Add(this.MenuKhuVuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BanHang";
            this.Text = "BanHang";
            this.MenuKhuVuc.ResumeLayout(false);
            this.MenuKhuVuc.PerformLayout();
            this.BottomInfomation.ResumeLayout(false);
            this.BottomInfomation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MenuKhuVuc;
        private System.Windows.Forms.Button btnDangHoatDong;
        private System.Windows.Forms.Panel BottomInfomation;
        private System.Windows.Forms.FlowLayoutPanel KhuVucContent;
        private System.Windows.Forms.Label labelDangHoatDong;
        private System.Windows.Forms.Label labelSoBan;
        private System.Windows.Forms.Label SoBanHoatDong;
        private System.Windows.Forms.Label SoBan;
        private System.Windows.Forms.Label TenKhuVuc;
        private System.Windows.Forms.Label labeltenKhuVuc;
        private System.Windows.Forms.Label TxtTimeNow;
        private System.Windows.Forms.Timer timerNow;
        private System.Windows.Forms.Button btnDaTamTinh;
        private System.Windows.Forms.Label SoBanDaTamTinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDaThanhToan;
    }
}