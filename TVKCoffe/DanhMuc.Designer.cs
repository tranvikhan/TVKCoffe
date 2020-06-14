namespace TVKCoffe
{
    partial class DanhMuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhMuc));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.BtnTimKiem = new Bunifu.Framework.UI.BunifuTextbox();
            this.BtnXoaDanhMuc = new System.Windows.Forms.Button();
            this.BtnSuaDanhMuc = new System.Windows.Forms.Button();
            this.BtnThemDanhMuc = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BangDanhMuc = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ColStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSoLuongMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnTroVe = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BangDanhMuc)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 0);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(797, 10);
            this.bunifuSeparator1.TabIndex = 6;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
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
            this.BtnTimKiem.Location = new System.Drawing.Point(598, 18);
            this.BtnTimKiem.Name = "BtnTimKiem";
            this.BtnTimKiem.Size = new System.Drawing.Size(190, 31);
            this.BtnTimKiem.TabIndex = 9;
            this.BtnTimKiem.text = "";
            this.BtnTimKiem.OnTextChange += new System.EventHandler(this.BtnTimKiem_OnTextChange);
            // 
            // BtnXoaDanhMuc
            // 
            this.BtnXoaDanhMuc.AutoSize = true;
            this.BtnXoaDanhMuc.BackColor = System.Drawing.Color.White;
            this.BtnXoaDanhMuc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnXoaDanhMuc.FlatAppearance.BorderSize = 0;
            this.BtnXoaDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnXoaDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXoaDanhMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnXoaDanhMuc.Image = ((System.Drawing.Image)(resources.GetObject("BtnXoaDanhMuc.Image")));
            this.BtnXoaDanhMuc.Location = new System.Drawing.Point(401, 15);
            this.BtnXoaDanhMuc.Margin = new System.Windows.Forms.Padding(2);
            this.BtnXoaDanhMuc.Name = "BtnXoaDanhMuc";
            this.BtnXoaDanhMuc.Size = new System.Drawing.Size(139, 40);
            this.BtnXoaDanhMuc.TabIndex = 7;
            this.BtnXoaDanhMuc.Text = "Xóa danh mục";
            this.BtnXoaDanhMuc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnXoaDanhMuc.UseVisualStyleBackColor = false;
            this.BtnXoaDanhMuc.Click += new System.EventHandler(this.BtnXoaDanhMuc_Click);
            // 
            // BtnSuaDanhMuc
            // 
            this.BtnSuaDanhMuc.AutoSize = true;
            this.BtnSuaDanhMuc.BackColor = System.Drawing.Color.White;
            this.BtnSuaDanhMuc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnSuaDanhMuc.FlatAppearance.BorderSize = 0;
            this.BtnSuaDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSuaDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSuaDanhMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSuaDanhMuc.Image = ((System.Drawing.Image)(resources.GetObject("BtnSuaDanhMuc.Image")));
            this.BtnSuaDanhMuc.Location = new System.Drawing.Point(258, 15);
            this.BtnSuaDanhMuc.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSuaDanhMuc.Name = "BtnSuaDanhMuc";
            this.BtnSuaDanhMuc.Size = new System.Drawing.Size(139, 40);
            this.BtnSuaDanhMuc.TabIndex = 7;
            this.BtnSuaDanhMuc.Text = "Sửa danh mục";
            this.BtnSuaDanhMuc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSuaDanhMuc.UseVisualStyleBackColor = false;
            this.BtnSuaDanhMuc.Click += new System.EventHandler(this.BtnSuaDanhMuc_Click);
            // 
            // BtnThemDanhMuc
            // 
            this.BtnThemDanhMuc.AutoSize = true;
            this.BtnThemDanhMuc.BackColor = System.Drawing.Color.White;
            this.BtnThemDanhMuc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnThemDanhMuc.FlatAppearance.BorderSize = 0;
            this.BtnThemDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnThemDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThemDanhMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnThemDanhMuc.Image = ((System.Drawing.Image)(resources.GetObject("BtnThemDanhMuc.Image")));
            this.BtnThemDanhMuc.Location = new System.Drawing.Point(104, 15);
            this.BtnThemDanhMuc.Margin = new System.Windows.Forms.Padding(2);
            this.BtnThemDanhMuc.Name = "BtnThemDanhMuc";
            this.BtnThemDanhMuc.Size = new System.Drawing.Size(150, 40);
            this.BtnThemDanhMuc.TabIndex = 7;
            this.BtnThemDanhMuc.Text = "Thêm danh mục";
            this.BtnThemDanhMuc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnThemDanhMuc.UseVisualStyleBackColor = false;
            this.BtnThemDanhMuc.Click += new System.EventHandler(this.BtnThemDanhMuc_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.BangDanhMuc);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 2;
            // 
            // BangDanhMuc
            // 
            this.BangDanhMuc.AllowUserToAddRows = false;
            this.BangDanhMuc.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BangDanhMuc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BangDanhMuc.BackgroundColor = System.Drawing.Color.White;
            this.BangDanhMuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BangDanhMuc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BangDanhMuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BangDanhMuc.ColumnHeadersHeight = 40;
            this.BangDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColStt,
            this.ColMaDanhMuc,
            this.ColTenDanhMuc,
            this.ColSoLuongMon});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BangDanhMuc.DefaultCellStyle = dataGridViewCellStyle3;
            this.BangDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BangDanhMuc.DoubleBuffered = true;
            this.BangDanhMuc.EnableHeadersVisualStyles = false;
            this.BangDanhMuc.GridColor = System.Drawing.Color.White;
            this.BangDanhMuc.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.BangDanhMuc.HeaderForeColor = System.Drawing.Color.White;
            this.BangDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.BangDanhMuc.Name = "BangDanhMuc";
            this.BangDanhMuc.ReadOnly = true;
            this.BangDanhMuc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BangDanhMuc.RowTemplate.Height = 40;
            this.BangDanhMuc.Size = new System.Drawing.Size(800, 387);
            this.BangDanhMuc.TabIndex = 5;
            // 
            // ColStt
            // 
            this.ColStt.DataPropertyName = "stt";
            this.ColStt.HeaderText = "STT";
            this.ColStt.Name = "ColStt";
            this.ColStt.ReadOnly = true;
            this.ColStt.Width = 30;
            // 
            // ColMaDanhMuc
            // 
            this.ColMaDanhMuc.DataPropertyName = "madanhmuc";
            this.ColMaDanhMuc.HeaderText = "MÃ DANH MỤC";
            this.ColMaDanhMuc.Name = "ColMaDanhMuc";
            this.ColMaDanhMuc.ReadOnly = true;
            this.ColMaDanhMuc.Width = 130;
            // 
            // ColTenDanhMuc
            // 
            this.ColTenDanhMuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTenDanhMuc.DataPropertyName = "tendanhmuc";
            this.ColTenDanhMuc.HeaderText = "TÊN DANH MỤC";
            this.ColTenDanhMuc.Name = "ColTenDanhMuc";
            this.ColTenDanhMuc.ReadOnly = true;
            // 
            // ColSoLuongMon
            // 
            this.ColSoLuongMon.DataPropertyName = "soluongmon";
            this.ColSoLuongMon.HeaderText = "SỐ LƯỢNG MÓN";
            this.ColSoLuongMon.Name = "ColSoLuongMon";
            this.ColSoLuongMon.ReadOnly = true;
            this.ColSoLuongMon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColSoLuongMon.Width = 150;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.bunifuSeparator1);
            this.panel5.Controls.Add(this.BtnTimKiem);
            this.panel5.Controls.Add(this.BtnXoaDanhMuc);
            this.panel5.Controls.Add(this.BtnSuaDanhMuc);
            this.panel5.Controls.Add(this.BtnTroVe);
            this.panel5.Controls.Add(this.BtnThemDanhMuc);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 387);
            this.panel5.Name = "panel5";
            this.panel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel5.Size = new System.Drawing.Size(800, 63);
            this.panel5.TabIndex = 0;
            // 
            // BtnTroVe
            // 
            this.BtnTroVe.AutoSize = true;
            this.BtnTroVe.BackColor = System.Drawing.Color.White;
            this.BtnTroVe.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnTroVe.FlatAppearance.BorderSize = 0;
            this.BtnTroVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTroVe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnTroVe.Image = ((System.Drawing.Image)(resources.GetObject("BtnTroVe.Image")));
            this.BtnTroVe.Location = new System.Drawing.Point(11, 15);
            this.BtnTroVe.Margin = new System.Windows.Forms.Padding(2);
            this.BtnTroVe.Name = "BtnTroVe";
            this.BtnTroVe.Size = new System.Drawing.Size(89, 40);
            this.BtnTroVe.TabIndex = 7;
            this.BtnTroVe.Text = "Trở về";
            this.BtnTroVe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnTroVe.UseVisualStyleBackColor = false;
            this.BtnTroVe.Click += new System.EventHandler(this.BtnTroVe_Click);
            // 
            // DanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DanhMuc";
            this.Text = "DanhMuc";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BangDanhMuc)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuTextbox BtnTimKiem;
        private System.Windows.Forms.Button BtnXoaDanhMuc;
        private System.Windows.Forms.Button BtnSuaDanhMuc;
        private System.Windows.Forms.Button BtnThemDanhMuc;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid BangDanhMuc;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnTroVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSoLuongMon;
    }
}