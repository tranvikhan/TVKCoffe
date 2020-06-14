using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVKCoffe.DAO;
using TVKCoffe.DTO;
using TVKCoffe.Model;

namespace TVKCoffe
{
    public partial class BanHang : Form
    {
       
        private Button active;
        private string maNV;

        public string MaNV { get => maNV; set => maNV = value; }

        public BanHang()
        {
            InitializeComponent();
            
            TaoKhuVuc();  
            this.active = btnDangHoatDong;
            fillTable(this.active);
            timerNow.Start();
        }
       
        private void addFormtoPanel(object formobj)
        {
            if(this.Tag != null)
            {
                Form tmp = this.Tag as Form;
                tmp.Close();
            }
            if (this.Controls.Count > 0)
                this.Controls.Clear();
            Form od = formobj as Form;
            AddOwnedForm(od);
            od.FormBorderStyle = FormBorderStyle.None;
            od.TopLevel = false;
            od.Dock = DockStyle.Fill;
            this.Controls.Add(od);
            this.Tag = od;
            od.BringToFront();
            od.Show();
        }

        private void TaoKhuVuc()
        {
            List<KhuVucDTO> list = KhuVucDAO.Instance.GetListKhuVuc();
            foreach(KhuVucDTO kv in list)
            {
                Button BtnKhuVuc = new Button();
                BtnKhuVuc.AutoSize = true;
                BtnKhuVuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
                BtnKhuVuc.FlatAppearance.BorderSize = 0;
                BtnKhuVuc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
                BtnKhuVuc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
                BtnKhuVuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                BtnKhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                BtnKhuVuc.ForeColor = System.Drawing.Color.White;
                BtnKhuVuc.Location = new System.Drawing.Point(134, 8);
                BtnKhuVuc.Name = kv.MaKV;
                BtnKhuVuc.Size = new System.Drawing.Size(93, 38);
                BtnKhuVuc.TabIndex = 0;
                BtnKhuVuc.Text = kv.TenKV; 
                BtnKhuVuc.UseVisualStyleBackColor = false;
                BtnKhuVuc.Click += new System.EventHandler(this.BtnKhuVuc_Click);
                this.MenuKhuVuc.Controls.Add(BtnKhuVuc);
            }
        }

        private void BtnKhuVuc_Click(object sender, EventArgs e)
        {
            KhuVucContent.Controls.Clear();
            Button btn = sender as Button;
            this.active = btn;
            fillTable(this.active);
            
        }

        private void fillTable(Button btn)
        {
            foreach (Control c in MenuKhuVuc.Controls)
            {
                Button cBtn = c as Button;
                switch (cBtn.Name)
                {
                    case "btnDangHoatDong":
                        cBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
                        break;
                    case "btnDaTamTinh":
                        cBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
                        break;
                    case "btnDaThanhToan":
                        cBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
                        break;
                    default:
                        cBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
                        break;
                }
               
            }
            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            List<BanDTO> listBan;
            switch (btn.Name)
            {
                case "btnDangHoatDong":
                    listBan = BanDAO.Instance.GetListBanActive();
                    break;
                case "btnDaTamTinh":
                    listBan = BanDAO.Instance.GetListBanInTamTinh();
                    break;
                case "btnDaThanhToan":
                    listBan = BanDAO.Instance.GetListBanDaThanhToan();
                    break;
                default:
                    listBan = BanDAO.Instance.GetListBan(btn.Name);
                    break;
            }
            TenKhuVuc.Text = btn.Text;
            SoBan.Text = listBan.Count.ToString();
            int banhoatdong = 0;
            int bandatamtinh = 0;
            int bandathanhtoan = 0;
            foreach (BanDTO ban in listBan)
            {
                Button BtnBan = new Button();
                switch (ban.TrangThai)
                {
                    case 1:
                        banhoatdong++;
                        BtnBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
                        BtnBan.ForeColor = System.Drawing.Color.White;
                        break;
                    case 2:
                        bandatamtinh++;
                        BtnBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
                        BtnBan.ForeColor = System.Drawing.Color.White;
                        break;
                    case 3:
                        bandathanhtoan++;
                        BtnBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
                        BtnBan.ForeColor = System.Drawing.Color.White;
                        break;
                    default:
                        BtnBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
                        BtnBan.BackColor = System.Drawing.Color.White;
                        break;
                }
                BtnBan.FlatAppearance.BorderSize = 0;
                BtnBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                BtnBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                BtnBan.Location = new System.Drawing.Point(15, 15);
                BtnBan.Margin = new System.Windows.Forms.Padding(10);
                BtnBan.Name = ban.MaBan;
                BtnBan.Size = new System.Drawing.Size(100, 100);
                BtnBan.TabIndex = 0;
                BtnBan.Text = ban.TenBan;
                BtnBan.UseVisualStyleBackColor = false;
                KhuVucContent.Controls.Add(BtnBan);
                BtnBan.Click += new System.EventHandler(this.BtnBan_Click);
            }
            SoBanHoatDong.Text = banhoatdong.ToString();
            SoBanDaTamTinh.Text = bandatamtinh.ToString();
        }

        private void BtnBan_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Order fm = new Order(btn.Name.ToString());
            fm.MaNV = this.maNV;
            addFormtoPanel(fm);
        }

        private void timerNow_Tick(object sender, EventArgs e)
        {
            TxtTimeNow.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }
    }
}
