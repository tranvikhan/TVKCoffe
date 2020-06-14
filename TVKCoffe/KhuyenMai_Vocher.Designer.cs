namespace TVKCoffe
{
    partial class KhuyenMai_Vocher
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSoLuong = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtGiaTri = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.BangVocher = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtTenVocher = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.ColStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGiaTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BangVocher)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Số lượng";
            // 
            // TxtSoLuong
            // 
            this.TxtSoLuong.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.TxtSoLuong.BorderColorIdle = System.Drawing.Color.Gray;
            this.TxtSoLuong.BorderColorMouseHover = System.Drawing.Color.DimGray;
            this.TxtSoLuong.BorderThickness = 3;
            this.TxtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtSoLuong.isPassword = false;
            this.TxtSoLuong.Location = new System.Drawing.Point(1, 17);
            this.TxtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSoLuong.Name = "TxtSoLuong";
            this.TxtSoLuong.Size = new System.Drawing.Size(111, 41);
            this.TxtSoLuong.TabIndex = 39;
            this.TxtSoLuong.Text = "1";
            this.TxtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtSoLuong.OnValueChanged += new System.EventHandler(this.TxtSoLuong_OnValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Giá trị / 1 Vocher";
            // 
            // TxtGiaTri
            // 
            this.TxtGiaTri.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.TxtGiaTri.BorderColorIdle = System.Drawing.Color.Gray;
            this.TxtGiaTri.BorderColorMouseHover = System.Drawing.Color.DimGray;
            this.TxtGiaTri.BorderThickness = 3;
            this.TxtGiaTri.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtGiaTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGiaTri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtGiaTri.isPassword = false;
            this.TxtGiaTri.Location = new System.Drawing.Point(294, 17);
            this.TxtGiaTri.Margin = new System.Windows.Forms.Padding(4);
            this.TxtGiaTri.Name = "TxtGiaTri";
            this.TxtGiaTri.Size = new System.Drawing.Size(181, 41);
            this.TxtGiaTri.TabIndex = 41;
            this.TxtGiaTri.Text = "100000";
            this.TxtGiaTri.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtGiaTri.OnValueChanged += new System.EventHandler(this.TxtGiaTri_OnValueChanged);
            // 
            // BangVocher
            // 
            this.BangVocher.AllowUserToAddRows = false;
            this.BangVocher.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BangVocher.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BangVocher.BackgroundColor = System.Drawing.Color.White;
            this.BangVocher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BangVocher.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BangVocher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BangVocher.ColumnHeadersHeight = 40;
            this.BangVocher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColStt,
            this.ColMaKM,
            this.ColTenKM,
            this.ColMa,
            this.ColGiaTri});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BangVocher.DefaultCellStyle = dataGridViewCellStyle3;
            this.BangVocher.DoubleBuffered = true;
            this.BangVocher.EnableHeadersVisualStyles = false;
            this.BangVocher.GridColor = System.Drawing.Color.White;
            this.BangVocher.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.BangVocher.HeaderForeColor = System.Drawing.Color.White;
            this.BangVocher.Location = new System.Drawing.Point(5, 75);
            this.BangVocher.Name = "BangVocher";
            this.BangVocher.ReadOnly = true;
            this.BangVocher.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BangVocher.Size = new System.Drawing.Size(470, 137);
            this.BangVocher.TabIndex = 43;
            this.BangVocher.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BangVocher_CellContentClick);
            // 
            // txtTenVocher
            // 
            this.txtTenVocher.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtTenVocher.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtTenVocher.BorderColorMouseHover = System.Drawing.Color.DimGray;
            this.txtTenVocher.BorderThickness = 3;
            this.txtTenVocher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenVocher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenVocher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenVocher.isPassword = false;
            this.txtTenVocher.Location = new System.Drawing.Point(120, 17);
            this.txtTenVocher.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenVocher.Name = "txtTenVocher";
            this.txtTenVocher.Size = new System.Drawing.Size(166, 41);
            this.txtTenVocher.TabIndex = 39;
            this.txtTenVocher.Text = "VOCHER NOEN";
            this.txtTenVocher.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTenVocher.OnValueChanged += new System.EventHandler(this.txtTenVocher_OnValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Tên VOCHER";
            // 
            // ColStt
            // 
            this.ColStt.DataPropertyName = "Stt";
            this.ColStt.HeaderText = "TT";
            this.ColStt.Name = "ColStt";
            this.ColStt.ReadOnly = true;
            this.ColStt.Width = 25;
            // 
            // ColMaKM
            // 
            this.ColMaKM.DataPropertyName = "MaKM";
            this.ColMaKM.HeaderText = "MÃ KM";
            this.ColMaKM.Name = "ColMaKM";
            this.ColMaKM.ReadOnly = true;
            this.ColMaKM.Width = 80;
            // 
            // ColTenKM
            // 
            this.ColTenKM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTenKM.DataPropertyName = "TenKM";
            this.ColTenKM.HeaderText = "TÊN VOCHER";
            this.ColTenKM.Name = "ColTenKM";
            this.ColTenKM.ReadOnly = true;
            // 
            // ColMa
            // 
            this.ColMa.DataPropertyName = "MaApDung";
            this.ColMa.HeaderText = "M.VOCHER";
            this.ColMa.Name = "ColMa";
            this.ColMa.ReadOnly = true;
            this.ColMa.Width = 140;
            // 
            // ColGiaTri
            // 
            this.ColGiaTri.DataPropertyName = "GiaTri";
            this.ColGiaTri.HeaderText = "GIÁ TRỊ";
            this.ColGiaTri.Name = "ColGiaTri";
            this.ColGiaTri.ReadOnly = true;
            this.ColGiaTri.Width = 80;
            // 
            // KhuyenMai_Vocher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(488, 217);
            this.Controls.Add(this.BangVocher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtGiaTri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenVocher);
            this.Controls.Add(this.TxtSoLuong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KhuyenMai_Vocher";
            this.Opacity = 0.95D;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BangVocher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtSoLuong;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtGiaTri;
        private Bunifu.Framework.UI.BunifuCustomDataGrid BangVocher;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTenVocher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGiaTri;
    }
}