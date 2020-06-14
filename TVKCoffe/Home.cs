using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using TVKCoffe.DatabaseConnection;
using System.Data.Common;
using TVKCoffe.Model;
using System.Drawing.Drawing2D;
using TVKCoffe.DAO;
using TVKCoffe.DTO;

namespace TVKCoffe
{
    public partial class Home : Form
    {
        public Login lg = null;
        private String nhanVienDangNhap;

        public string NhanVienDangNhap { get => nhanVienDangNhap; set => nhanVienDangNhap = value; }

        public Home()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (PanelMenu.Width == 160)
            {
                PanelMenu.Width = 40;
            }
            else
            {
                PanelMenu.Width = 160;
            }
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (lg != null) lg.Close();
            Application.Exit();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMax.Visible = false;
            BtnUnMax.Visible = true;
        }

        private void BtnUnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnMax.Visible = true;
            BtnUnMax.Visible = false;
        }

        private void DockTile_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void addFormtoPanel(object formobj)
        {
            if (this.panelContencedor.Tag!= null)
            {
                Form tmp = this.panelContencedor.Tag as Form;
                if(tmp.Tag !=null)
                {
                    Form tmp2 = tmp.Tag as Form;
                    tmp2.Close();
                }
                tmp.Close();
            }
                                   
            this.panelContencedor.Controls.Clear();
                
            Form fh = formobj as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContencedor.Controls.Add(fh);
            this.panelContencedor.Tag = fh;
            fh.Show();

        }
        private void active(Object obj)
        {
            foreach(Control control in this.PanelMenu.Controls)
            {
                
                control.BackColor = Color.FromArgb(52, 152, 219);
            }
            (obj as Button).BackColor = Color.FromArgb(44, 62, 80);
        }
        private void BtnBanHang_Click(object sender, EventArgs e)
        {
            BanHang fm = new BanHang();
            fm.MaNV = this.nhanVienDangNhap;
            addFormtoPanel(fm);
            active(sender);
        }

        private void BtnHoaDon_Click(object sender, EventArgs e)
        {
            addFormtoPanel(new HoaDon());
            active(sender);
        }

        private void BtnDoanhThu_Click(object sender, EventArgs e)
        {
            addFormtoPanel(new DoanhThu());
            active(sender);
        }

        private void BtnThucDon_Click(object sender, EventArgs e)
        {
            addFormtoPanel(new ThucDon());
            active(sender);
        }

        private void BtnSoDo_Click(object sender, EventArgs e)
        {
            addFormtoPanel(new SoDoBan());
            active(sender);
        }

        

        private void BtnNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.SetMaNVHienTai(NhanVienDangNhap);
            addFormtoPanel(nv);
            active(sender);
        }

        private void BtnCaiDat_Click(object sender, EventArgs e)
        {
            addFormtoPanel(new CaiDat());
            active(sender);
        }

        private void BtnKhachHang_Click(object sender, EventArgs e)
        {
            addFormtoPanel(new KhachHang());
            active(sender);
        }

        private void BtnKhuyenMai_MouseClick(object sender, MouseEventArgs e)
        {
            active(sender);
            addFormtoPanel(new KhuyenMai());
        }

        private void Home_Load(object sender, EventArgs e)
        {
            NhanVienDTO nv = NhanVienDAO.Instance.GetNhanVien(NhanVienDangNhap);
            if (nv.AnhDaiDien == null)
            {
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
                this.UserAvatar.Image = ((System.Drawing.Image)(resources.GetObject("UserAvatar.Image")));
            }
            else
            {
                Image img = ConvertDTO.Instance.ResizeImage(nv.AnhDaiDien, new Size(100, 100), false);
                Image anh = ConvertDTO.Instance.CropToCircle(img, Color.White);
                this.UserAvatar.Image = anh;
                this.UserName.Text = nv.TenNV;
                BanHang fm = new BanHang();
                fm.MaNV = this.nhanVienDangNhap;
                addFormtoPanel(fm);
                active(this.BtnBanHang);
            }
        }


        private void BtnDangXuat_Click(object sender, EventArgs e)
        {
            lg.hm = this;
            lg.Show();
            this.Hide();
        }
     
    }
}
