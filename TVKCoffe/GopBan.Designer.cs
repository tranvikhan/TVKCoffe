namespace TVKCoffe
{
    partial class GopBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GopBan));
            this.BtnAddBan = new System.Windows.Forms.Button();
            this.BtnLamLai = new System.Windows.Forms.Button();
            this.BtnGopBan = new System.Windows.Forms.Button();
            this.listDanhSachBan = new System.Windows.Forms.ListBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnRemoveBan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAddBan
            // 
            this.BtnAddBan.AutoSize = true;
            this.BtnAddBan.BackColor = System.Drawing.Color.White;
            this.BtnAddBan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAddBan.FlatAppearance.BorderSize = 0;
            this.BtnAddBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAddBan.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddBan.Image")));
            this.BtnAddBan.Location = new System.Drawing.Point(15, 238);
            this.BtnAddBan.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAddBan.Name = "BtnAddBan";
            this.BtnAddBan.Size = new System.Drawing.Size(132, 41);
            this.BtnAddBan.TabIndex = 33;
            this.BtnAddBan.Text = "Thêm bàn";
            this.BtnAddBan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddBan.UseVisualStyleBackColor = false;
            this.BtnAddBan.Click += new System.EventHandler(this.BtnAddBan_Click);
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
            this.BtnLamLai.Location = new System.Drawing.Point(147, 294);
            this.BtnLamLai.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLamLai.Name = "BtnLamLai";
            this.BtnLamLai.Size = new System.Drawing.Size(132, 41);
            this.BtnLamLai.TabIndex = 31;
            this.BtnLamLai.Text = "Làm lại";
            this.BtnLamLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLamLai.UseVisualStyleBackColor = false;
            // 
            // BtnGopBan
            // 
            this.BtnGopBan.AutoSize = true;
            this.BtnGopBan.BackColor = System.Drawing.Color.White;
            this.BtnGopBan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnGopBan.FlatAppearance.BorderSize = 0;
            this.BtnGopBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGopBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGopBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnGopBan.Image = ((System.Drawing.Image)(resources.GetObject("BtnGopBan.Image")));
            this.BtnGopBan.Location = new System.Drawing.Point(15, 294);
            this.BtnGopBan.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGopBan.Name = "BtnGopBan";
            this.BtnGopBan.Size = new System.Drawing.Size(132, 41);
            this.BtnGopBan.TabIndex = 32;
            this.BtnGopBan.Text = "Gộp bàn";
            this.BtnGopBan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGopBan.UseVisualStyleBackColor = false;
            this.BtnGopBan.Click += new System.EventHandler(this.BtnGopBan_Click);
            // 
            // listDanhSachBan
            // 
            this.listDanhSachBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.listDanhSachBan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listDanhSachBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDanhSachBan.FormattingEnabled = true;
            this.listDanhSachBan.ItemHeight = 16;
            this.listDanhSachBan.Items.AddRange(new object[] {
            "Bàn hiện tại: 1 - Sân Vườn"});
            this.listDanhSachBan.Location = new System.Drawing.Point(15, 34);
            this.listDanhSachBan.Name = "listDanhSachBan";
            this.listDanhSachBan.Size = new System.Drawing.Size(264, 192);
            this.listDanhSachBan.TabIndex = 35;
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(91, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(109, 22);
            this.labelTitle.TabIndex = 36;
            this.labelTitle.Text = "Danh Sách Bàn";
            // 
            // btnRemoveBan
            // 
            this.btnRemoveBan.AutoSize = true;
            this.btnRemoveBan.BackColor = System.Drawing.Color.White;
            this.btnRemoveBan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRemoveBan.FlatAppearance.BorderSize = 0;
            this.btnRemoveBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemoveBan.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveBan.Image")));
            this.btnRemoveBan.Location = new System.Drawing.Point(147, 238);
            this.btnRemoveBan.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveBan.Name = "btnRemoveBan";
            this.btnRemoveBan.Size = new System.Drawing.Size(132, 41);
            this.btnRemoveBan.TabIndex = 33;
            this.btnRemoveBan.Text = "Xóa bàn";
            this.btnRemoveBan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveBan.UseVisualStyleBackColor = false;
            // 
            // GopBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(290, 340);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.listDanhSachBan);
            this.Controls.Add(this.btnRemoveBan);
            this.Controls.Add(this.BtnAddBan);
            this.Controls.Add(this.BtnLamLai);
            this.Controls.Add(this.BtnGopBan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GopBan";
            this.Opacity = 0.98D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GỘP BÀN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAddBan;
        private System.Windows.Forms.Button BtnLamLai;
        private System.Windows.Forms.Button BtnGopBan;
        private System.Windows.Forms.ListBox listDanhSachBan;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnRemoveBan;
    }
}