using System;

namespace TVKCoffe
{
    partial class Order_Huy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order_Huy));
            this.TextCauHoi = new System.Windows.Forms.Label();
            this.BtnCo = new System.Windows.Forms.Button();
            this.BtnKhong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextCauHoi
            // 
            this.TextCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextCauHoi.Location = new System.Drawing.Point(8, 16);
            this.TextCauHoi.Name = "TextCauHoi";
            this.TextCauHoi.Size = new System.Drawing.Size(244, 48);
            this.TextCauHoi.TabIndex = 0;
            this.TextCauHoi.Text = "Bạn có chắc chắn muốn hủy Order bàn này?";
            this.TextCauHoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCo
            // 
            this.BtnCo.AutoSize = true;
            this.BtnCo.BackColor = System.Drawing.Color.White;
            this.BtnCo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCo.FlatAppearance.BorderSize = 0;
            this.BtnCo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnCo.Image = ((System.Drawing.Image)(resources.GetObject("BtnCo.Image")));
            this.BtnCo.Location = new System.Drawing.Point(11, 76);
            this.BtnCo.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCo.Name = "BtnCo";
            this.BtnCo.Size = new System.Drawing.Size(114, 41);
            this.BtnCo.TabIndex = 22;
            this.BtnCo.Text = "Có";
            this.BtnCo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCo.UseVisualStyleBackColor = false;
            this.BtnCo.Click += new System.EventHandler(this.BtnCo_Click);
            // 
            // BtnKhong
            // 
            this.BtnKhong.AutoSize = true;
            this.BtnKhong.BackColor = System.Drawing.Color.White;
            this.BtnKhong.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnKhong.FlatAppearance.BorderSize = 0;
            this.BtnKhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnKhong.Image = ((System.Drawing.Image)(resources.GetObject("BtnKhong.Image")));
            this.BtnKhong.Location = new System.Drawing.Point(129, 76);
            this.BtnKhong.Margin = new System.Windows.Forms.Padding(2);
            this.BtnKhong.Name = "BtnKhong";
            this.BtnKhong.Size = new System.Drawing.Size(123, 41);
            this.BtnKhong.TabIndex = 22;
            this.BtnKhong.Text = "Không";
            this.BtnKhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnKhong.UseVisualStyleBackColor = false;
            this.BtnKhong.Click += new System.EventHandler(this.BtnKhong_Click);
            // 
            // Order_Huy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(264, 131);
            this.Controls.Add(this.BtnKhong);
            this.Controls.Add(this.BtnCo);
            this.Controls.Add(this.TextCauHoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Order_Huy";
            this.Opacity = 0.95D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỦY ORDER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Label TextCauHoi;
        private System.Windows.Forms.Button BtnCo;
        private System.Windows.Forms.Button BtnKhong;
    }
}