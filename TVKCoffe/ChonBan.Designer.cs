namespace TVKCoffe
{
    partial class ChonBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChonBan));
            this.BtnHuy = new System.Windows.Forms.Button();
            this.BtnChonBan = new System.Windows.Forms.Button();
            this.listKhuVuc = new System.Windows.Forms.ListBox();
            this.listBan = new System.Windows.Forms.ListBox();
            this.textKhuVuc = new System.Windows.Forms.Label();
            this.textBan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnHuy
            // 
            this.BtnHuy.AutoSize = true;
            this.BtnHuy.BackColor = System.Drawing.Color.White;
            this.BtnHuy.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnHuy.FlatAppearance.BorderSize = 0;
            this.BtnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnHuy.Image = ((System.Drawing.Image)(resources.GetObject("BtnHuy.Image")));
            this.BtnHuy.Location = new System.Drawing.Point(187, 331);
            this.BtnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.BtnHuy.Name = "BtnHuy";
            this.BtnHuy.Size = new System.Drawing.Size(170, 41);
            this.BtnHuy.TabIndex = 30;
            this.BtnHuy.Text = "Hủy";
            this.BtnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnHuy.UseVisualStyleBackColor = false;
            this.BtnHuy.Click += new System.EventHandler(this.BtnHuy_Click);
            // 
            // BtnChonBan
            // 
            this.BtnChonBan.AutoSize = true;
            this.BtnChonBan.BackColor = System.Drawing.Color.White;
            this.BtnChonBan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnChonBan.FlatAppearance.BorderSize = 0;
            this.BtnChonBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChonBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChonBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnChonBan.Image = ((System.Drawing.Image)(resources.GetObject("BtnChonBan.Image")));
            this.BtnChonBan.Location = new System.Drawing.Point(11, 331);
            this.BtnChonBan.Margin = new System.Windows.Forms.Padding(2);
            this.BtnChonBan.Name = "BtnChonBan";
            this.BtnChonBan.Size = new System.Drawing.Size(170, 41);
            this.BtnChonBan.TabIndex = 31;
            this.BtnChonBan.Text = "Chọn bàn";
            this.BtnChonBan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnChonBan.UseVisualStyleBackColor = false;
            this.BtnChonBan.Click += new System.EventHandler(this.BtnChonBan_Click);
            // 
            // listKhuVuc
            // 
            this.listKhuVuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.listKhuVuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listKhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listKhuVuc.FormattingEnabled = true;
            this.listKhuVuc.ItemHeight = 16;
            this.listKhuVuc.Items.AddRange(new object[] {
            "[KV0001] Sân Vườn",
            "[KV0002] Tầng 1",
            "[KV0003] Tầng 2"});
            this.listKhuVuc.Location = new System.Drawing.Point(11, 38);
            this.listKhuVuc.Name = "listKhuVuc";
            this.listKhuVuc.Size = new System.Drawing.Size(141, 288);
            this.listKhuVuc.TabIndex = 32;
            this.listKhuVuc.SelectedIndexChanged += new System.EventHandler(this.listKhuVuc_SelectedIndexChanged);
            // 
            // listBan
            // 
            this.listBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.listBan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBan.FormattingEnabled = true;
            this.listBan.ItemHeight = 16;
            this.listBan.Items.AddRange(new object[] {
            "Bàn 1",
            "Bàn 2",
            "Bàn 3",
            "Bàn 4"});
            this.listBan.Location = new System.Drawing.Point(158, 38);
            this.listBan.Name = "listBan";
            this.listBan.Size = new System.Drawing.Size(199, 288);
            this.listBan.TabIndex = 32;
            this.listBan.SelectedIndexChanged += new System.EventHandler(this.listBan_SelectedIndexChanged);
            // 
            // textKhuVuc
            // 
            this.textKhuVuc.BackColor = System.Drawing.Color.White;
            this.textKhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textKhuVuc.ForeColor = System.Drawing.Color.Black;
            this.textKhuVuc.Location = new System.Drawing.Point(11, 4);
            this.textKhuVuc.Margin = new System.Windows.Forms.Padding(0);
            this.textKhuVuc.Name = "textKhuVuc";
            this.textKhuVuc.Size = new System.Drawing.Size(141, 31);
            this.textKhuVuc.TabIndex = 33;
            this.textKhuVuc.Text = "Khu Vực:";
            // 
            // textBan
            // 
            this.textBan.BackColor = System.Drawing.Color.White;
            this.textBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBan.ForeColor = System.Drawing.Color.Black;
            this.textBan.Location = new System.Drawing.Point(158, 4);
            this.textBan.Margin = new System.Windows.Forms.Padding(0);
            this.textBan.Name = "textBan";
            this.textBan.Size = new System.Drawing.Size(199, 31);
            this.textBan.TabIndex = 33;
            this.textBan.Text = "Bàn:";
            // 
            // ChonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(369, 382);
            this.Controls.Add(this.textBan);
            this.Controls.Add(this.textKhuVuc);
            this.Controls.Add(this.listBan);
            this.Controls.Add(this.listKhuVuc);
            this.Controls.Add(this.BtnHuy);
            this.Controls.Add(this.BtnChonBan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChonBan";
            this.Opacity = 0.98D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHỌN BÀN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHuy;
        private System.Windows.Forms.Button BtnChonBan;
        private System.Windows.Forms.ListBox listKhuVuc;
        private System.Windows.Forms.ListBox listBan;
        private System.Windows.Forms.Label textKhuVuc;
        private System.Windows.Forms.Label textBan;
    }
}