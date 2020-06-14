namespace TVKCoffe
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.introPanel = new System.Windows.Forms.Panel();
            this.CoffeName = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.WdsMin = new System.Windows.Forms.PictureBox();
            this.WdsClose = new System.Windows.Forms.PictureBox();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.Password = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Username = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnShowPassword = new Bunifu.Framework.UI.BunifuCheckbox();
            this.labelHienmatkhau = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.introPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WdsMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WdsClose)).BeginInit();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // introPanel
            // 
            this.introPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.introPanel.Controls.Add(this.CoffeName);
            this.introPanel.Controls.Add(this.Logo);
            this.introPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.introPanel.Location = new System.Drawing.Point(0, 0);
            this.introPanel.Name = "introPanel";
            this.introPanel.Size = new System.Drawing.Size(240, 343);
            this.introPanel.TabIndex = 0;
            // 
            // CoffeName
            // 
            this.CoffeName.AutoSize = true;
            this.CoffeName.Font = new System.Drawing.Font("UTM Nokia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoffeName.ForeColor = System.Drawing.Color.White;
            this.CoffeName.Location = new System.Drawing.Point(44, 223);
            this.CoffeName.Name = "CoffeName";
            this.CoffeName.Size = new System.Drawing.Size(149, 23);
            this.CoffeName.TabIndex = 1;
            this.CoffeName.Text = "TVK COFFE";
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(39, 80);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(159, 139);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.White;
            this.TitlePanel.Controls.Add(this.WdsMin);
            this.TitlePanel.Controls.Add(this.WdsClose);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(240, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(240, 32);
            this.TitlePanel.TabIndex = 0;
            this.TitlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseDown);
            // 
            // WdsMin
            // 
            this.WdsMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WdsMin.Image = ((System.Drawing.Image)(resources.GetObject("WdsMin.Image")));
            this.WdsMin.Location = new System.Drawing.Point(183, 6);
            this.WdsMin.Name = "WdsMin";
            this.WdsMin.Size = new System.Drawing.Size(20, 20);
            this.WdsMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WdsMin.TabIndex = 0;
            this.WdsMin.TabStop = false;
            this.WdsMin.Click += new System.EventHandler(this.WdsMin_Click);
            // 
            // WdsClose
            // 
            this.WdsClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WdsClose.Image = ((System.Drawing.Image)(resources.GetObject("WdsClose.Image")));
            this.WdsClose.Location = new System.Drawing.Point(212, 6);
            this.WdsClose.Name = "WdsClose";
            this.WdsClose.Size = new System.Drawing.Size(20, 20);
            this.WdsClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WdsClose.TabIndex = 0;
            this.WdsClose.TabStop = false;
            this.WdsClose.Click += new System.EventHandler(this.WdsClose_Click);
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.White;
            this.LoginPanel.Controls.Add(this.Password);
            this.LoginPanel.Controls.Add(this.Username);
            this.LoginPanel.Controls.Add(this.btnShowPassword);
            this.LoginPanel.Controls.Add(this.labelHienmatkhau);
            this.LoginPanel.Controls.Add(this.LabelPassword);
            this.LoginPanel.Controls.Add(this.labelUsername);
            this.LoginPanel.Controls.Add(this.BtnLogin);
            this.LoginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPanel.Location = new System.Drawing.Point(240, 32);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(240, 311);
            this.LoginPanel.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Password.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.Password.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Password.BorderThickness = 3;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Password.isPassword = true;
            this.Password.Location = new System.Drawing.Point(22, 135);
            this.Password.Margin = new System.Windows.Forms.Padding(4);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(195, 32);
            this.Password.TabIndex = 2;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Password.Click += new System.EventHandler(this.Password_Click);
            this.Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_KeyDown);
            // 
            // Username
            // 
            this.Username.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Username.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.Username.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Username.BorderThickness = 3;
            this.Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Username.isPassword = false;
            this.Username.Location = new System.Drawing.Point(21, 67);
            this.Username.Margin = new System.Windows.Forms.Padding(4);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(195, 32);
            this.Username.TabIndex = 1;
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Username.Click += new System.EventHandler(this.Username_Click);
            this.Username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Username_KeyDown);
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnShowPassword.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnShowPassword.Checked = false;
            this.btnShowPassword.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnShowPassword.ForeColor = System.Drawing.Color.White;
            this.btnShowPassword.Location = new System.Drawing.Point(26, 194);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(20, 20);
            this.btnShowPassword.TabIndex = 0;
            this.btnShowPassword.OnChange += new System.EventHandler(this.btnShowPassword_OnChange);
            // 
            // labelHienmatkhau
            // 
            this.labelHienmatkhau.AutoSize = true;
            this.labelHienmatkhau.BackColor = System.Drawing.Color.Transparent;
            this.labelHienmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHienmatkhau.ForeColor = System.Drawing.Color.DimGray;
            this.labelHienmatkhau.Location = new System.Drawing.Point(50, 198);
            this.labelHienmatkhau.Name = "labelHienmatkhau";
            this.labelHienmatkhau.Size = new System.Drawing.Size(90, 13);
            this.labelHienmatkhau.TabIndex = 0;
            this.labelHienmatkhau.Text = "Hiển thị mật khẩu";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.BackColor = System.Drawing.Color.Transparent;
            this.LabelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassword.ForeColor = System.Drawing.Color.DimGray;
            this.LabelPassword.Location = new System.Drawing.Point(22, 117);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(52, 13);
            this.LabelPassword.TabIndex = 0;
            this.LabelPassword.Text = "Mật khẩu";
            this.LabelPassword.Click += new System.EventHandler(this.LabelPassword_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.DimGray;
            this.labelUsername.Location = new System.Drawing.Point(19, 48);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(81, 13);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Tên đăng nhập";
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(25, 246);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(191, 36);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Đăng nhập";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 343);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.TitlePanel);
            this.Controls.Add(this.introPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.introPanel.ResumeLayout(false);
            this.introPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.TitlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WdsMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WdsClose)).EndInit();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel introPanel;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Label CoffeName;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.PictureBox WdsClose;
        private System.Windows.Forms.PictureBox WdsMin;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label LabelPassword;
        private Bunifu.Framework.UI.BunifuCheckbox btnShowPassword;
        private System.Windows.Forms.Label labelHienmatkhau;
        private Bunifu.Framework.UI.BunifuMetroTextbox Username;
        private Bunifu.Framework.UI.BunifuMetroTextbox Password;
    }
}