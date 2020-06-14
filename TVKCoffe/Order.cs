using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVKCoffe.DAO;
using TVKCoffe.DTO;
using TVKCoffe.Model;

namespace TVKCoffe
{
    public partial class Order : Form
    {
        
        private string maNV;
        OrderDTO od = new OrderDTO();
        decimal tamtinh = 0;
        decimal giamgia = 0;
        decimal phuthu = 0;
        decimal tongcong = 0;
        decimal thue = 0;
        int tongmon=0;

        public string MaNV { get => maNV; set => maNV = value; }

        public Order(string id)
        {
            InitializeComponent();
            od.Ban = new BanDTO();
            od.Ban.MaBan = id;
        }

        public void FillOrder()
        {
            tamtinh = 0;
            tongcong = 0;
            tongmon = 0;
            if (od.Ban.TrangThai == 3)
            {
                this.BtnGiamGia.Enabled = false;
                this.BtnPhuThu.Enabled = false;
                this.btnThanhToan.Enabled = false;
                this.BtnHuyBan.Enabled = true;
                this.BtnHuyBan.Text = "Đóng bàn";
                this.BtnTachBan.Enabled = false;
                this.BtnKhachHang.Enabled = false;
                this.BtnInTamTinh.Enabled = false;
                this.BtnGopBan.Enabled = false;
            }
            else
            {
                this.BtnGiamGia.Enabled = true;
                this.BtnPhuThu.Enabled = true;
                this.btnThanhToan.Enabled = true;
                this.BtnHuyBan.Enabled = true;
                this.BtnTachBan.Enabled = true;
                this.BtnKhachHang.Enabled = true;
                this.BtnInTamTinh.Enabled = true;
            }
            


            this.GioVao.Text = "Mở bàn lúc: " + od.Thoigiantao.ToString("H:mm:ss")+" Ngày: " + od.Thoigiantao.ToString("dd/MM/yyyy");
            this.PhuThu.Text = "+";
            this.GiamGia.Text = "-";
            this.ThueVAT.Text = od.KhachHang.Thue.ToString();

            List<ChiTietOrderDTO> list = ChiTietOrderDAO.Instance.GetList(od.getID());
            PannelOrderItem.Controls.Clear();

            if (list.Count >0)
            {
                foreach(ChiTietOrderDTO item in list)
                {
                   
                    Button Item_SoLuong = new Button();
                    Item_SoLuong.AutoSize = true;
                    Item_SoLuong.BackColor = System.Drawing.Color.White;
                    Item_SoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
                    Item_SoLuong.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                    Item_SoLuong.FlatAppearance.BorderSize = 0;
                    Item_SoLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    Item_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    Item_SoLuong.ForeColor = System.Drawing.Color.Green;
                    Item_SoLuong.Location = new System.Drawing.Point(5, 5);
                    Item_SoLuong.Margin = new System.Windows.Forms.Padding(2);
                    Item_SoLuong.Name = item.MaCT;
                    Item_SoLuong.Size = new System.Drawing.Size(33, 30);
                    Item_SoLuong.TabIndex = 11;
                    if (item.SoLuong > 99)
                    {
                        Item_SoLuong.Text = "*";
                    }
                    else
                    {
                        Item_SoLuong.Text = item.SoLuong.ToString();
                    }

                    Item_SoLuong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                    Item_SoLuong.UseVisualStyleBackColor = false;
                    Item_SoLuong.Click += new System.EventHandler(this.Item_SoLuong_Click);


                    tamtinh = tamtinh + (decimal)item.SoLuong * item.SanPham.GiaBan;
                    tongmon = tongmon + item.SoLuong;

                    Label Item_Ten = new Label();
                    Item_Ten.Dock = System.Windows.Forms.DockStyle.Fill;
                    Item_Ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    Item_Ten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
                    Item_Ten.Location = new System.Drawing.Point(43, 3);
                    Item_Ten.Name = item.MaCT;
                    Item_Ten.Size = new System.Drawing.Size(167, 34);
                    Item_Ten.TabIndex = 3;
                    Item_Ten.Text = item.SanPham.TenSP;
                    Item_Ten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    Item_Ten.Click += new System.EventHandler(this.Item_SoLuong_Click);

                    Label Item_Gia = new Label();
                    Item_Gia.Dock = System.Windows.Forms.DockStyle.Fill;
                    Item_Gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    Item_Gia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
                    Item_Gia.Location = new System.Drawing.Point(220, 3);
                    Item_Gia.Name = item.MaCT;
                    Item_Gia.Size = new System.Drawing.Size(71, 34);
                    Item_Gia.TabIndex = 5;

                    string tempgia = ConvertDTO.Instance.CurrencyFromDecimal(item.SanPham.GiaBan * (decimal)item.SoLuong);
                    if (tempgia.Length > 8) tempgia = tempgia.Substring(0, 7) +"..";
                    
                    Item_Gia.Text = tempgia;
                    Item_Gia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                    Button Item_GhiChu = new Button();
                    Item_GhiChu.AutoSize = true;
                    Item_GhiChu.BackColor = System.Drawing.Color.White;
                    Item_GhiChu.Dock = System.Windows.Forms.DockStyle.Fill;
                    Item_GhiChu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                    Item_GhiChu.FlatAppearance.BorderSize = 0;
                    Item_GhiChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    Item_GhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    Item_GhiChu.ForeColor = System.Drawing.Color.Gray;
                    Item_GhiChu.Location = new System.Drawing.Point(5, 39);
                    Item_GhiChu.Margin = new System.Windows.Forms.Padding(2);
                    Item_GhiChu.Name = item.MaCT;
                    Item_GhiChu.Size = new System.Drawing.Size(210, 21);
                    Item_GhiChu.TabIndex = 8;
                    Item_GhiChu.Text = item.GhiChu;
                    Item_GhiChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    Item_GhiChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                    Item_GhiChu.UseVisualStyleBackColor = false;
                    Item_GhiChu.Click += new System.EventHandler(this.Item_SoLuong_Click);


                    System.ComponentModel.ComponentResourceManager resources1 = new System.ComponentModel.ComponentResourceManager(typeof(Order));
                    Button BtnXoa = new Button();
                    BtnXoa.AutoSize = true;
                    BtnXoa.BackColor = System.Drawing.Color.White;
                    BtnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
                    BtnXoa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                    BtnXoa.FlatAppearance.BorderSize = 0;
                    BtnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    BtnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    BtnXoa.ForeColor = System.Drawing.Color.Gray;
                    BtnXoa.Image = ((System.Drawing.Image)(resources1.GetObject("button13.Image")));
                    BtnXoa.Location = new System.Drawing.Point(219, 39);
                    BtnXoa.Margin = new System.Windows.Forms.Padding(2);
                    BtnXoa.Name = item.MaCT;
                    BtnXoa.Size = new System.Drawing.Size(73, 21);
                    BtnXoa.TabIndex = 9;
                    BtnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    BtnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                    BtnXoa.UseVisualStyleBackColor = false;
                    BtnXoa.Click += new System.EventHandler(this.BtnXoaItem_Click);

                    TableLayoutPanel Order_Item = new TableLayoutPanel();
                    Order_Item.ResumeLayout(false);
                    Order_Item.PerformLayout();
                    Order_Item.SuspendLayout();
                    Order_Item.BackColor = System.Drawing.Color.White;
                    Order_Item.ColumnCount = 3;
                    Order_Item.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.21719F));
                    Order_Item.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.78281F));
                    Order_Item.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
                    Order_Item.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
                    Order_Item.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
                    Order_Item.Controls.Add(Item_SoLuong, 0, 0);
                    Order_Item.Controls.Add(Item_Gia, 4, 0);
                    Order_Item.Controls.Add(Item_GhiChu, 0, 1);
                    Order_Item.Controls.Add(BtnXoa, 2, 1);
                    Order_Item.Controls.Add(Item_Ten, 1, 0);
                    Order_Item.SetColumnSpan(Item_GhiChu, 2);
                    Order_Item.Location = new System.Drawing.Point(11, 11);
                    Order_Item.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
                    Order_Item.Name = item.MaCT;
                    Order_Item.Padding = new System.Windows.Forms.Padding(3);
                    Order_Item.RowCount = 2;
                    Order_Item.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
                    Order_Item.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
                    Order_Item.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
                    Order_Item.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
                    Order_Item.Size = new System.Drawing.Size(297, 65);
                    Order_Item.TabIndex = 0;
                    Order_Item.Click += new System.EventHandler(this.Item_SoLuong_Click);
                    this.PannelOrderItem.Controls.Add(Order_Item);
                }

                tongcong = tamtinh + giamgia + thue - phuthu ;
                this.TamTinh.Text = ConvertDTO.Instance.CurrencyFromDecimal(tamtinh);
                this.TongCong.Text = ConvertDTO.Instance.CurrencyFromDecimal(tongcong);
                this.GiamGia.Text = ConvertDTO.Instance.CurrencyFromDecimal(giamgia);
                this.PhuThu.Text = ConvertDTO.Instance.CurrencyFromDecimal(phuthu);
                this.ThueVAT.Text = ConvertDTO.Instance.CurrencyFromDecimal(thue);
                this.TongMon.Text = "Tổng món: " + tongmon.ToString();

            }
            else
            {
                //Order_Huy fm = new Order_Huy(od.getID());
                //fm.order = this;
                //fm.ShowDialog(this);
            }


         


        }

        private void Item_SoLuong_Click(object sender, EventArgs e)
        {
            if (od.Ban.TrangThai != 3)
            {
                Control bt = sender as Control;
                string maCT = bt.Name;
                Order_Sua fm = new Order_Sua(maCT);
                fm.formOrder = this;
                fm.ShowDialog(this);
            }
        }

        private void BtnXoaItem_Click(object sender, EventArgs e)
        {
            if (od.Ban.TrangThai != 3)
            {
                Button bt = sender as Button;
                string code = bt.Name;
                Xoa fm = new Xoa("Xóa danh mục này khỏi Bàn?", "ITEMORDER", code);
                fm.order = this;
                fm.ShowDialog(this);
            }

        }

        private void KhoiTaoDangMuc()
        {
            List<DanhMucDTO> list = DanhMucDAO.Instance.GetListDanhMuc();
            foreach(DanhMucDTO danhmuc in list)
            {
                Button BtnDanhMuc = new Button();
                BtnDanhMuc.AutoSize = true;
                BtnDanhMuc.BackColor = System.Drawing.Color.White;
                BtnDanhMuc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                BtnDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                BtnDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                BtnDanhMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                BtnDanhMuc.Location = new System.Drawing.Point(17, 12);
                BtnDanhMuc.Margin = new System.Windows.Forms.Padding(2);
                BtnDanhMuc.Name = danhmuc.MaDM;
                BtnDanhMuc.Size = new System.Drawing.Size(76, 46);
                BtnDanhMuc.TabIndex = 4;
                BtnDanhMuc.Text = danhmuc.TenDM;
                BtnDanhMuc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                BtnDanhMuc.UseVisualStyleBackColor = false;

                BtnDanhMuc.Click += new System.EventHandler(this.BtnDanhMuc_Click);
                PanelDanhMuc.Controls.Add(BtnDanhMuc);
            }
            GetPanelSanPham(this.BtnPhoBien);
        }

        private void BtnDanhMuc_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            
            GetPanelSanPham(btn);
        }

        private void GetPanelSanPham(Button btn)
        {
            foreach (Control c in PanelDanhMuc.Controls)
            {
                Button cBtn = c as Button;
                cBtn.BackColor = System.Drawing.Color.White;
            }
            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));

            List<SanPhamDTO> listSP;
            if (!btn.Name.Equals("BtnPhoBien"))
            {
                listSP = SanPhamDAO.Instance.GetListSanPham(btn.Name);
            }
            else
            {
                listSP = SanPhamDAO.Instance.GetListSanPham();
            }
            fillSanPhamPanel(listSP);            
        }

        private void fillSanPhamPanel(List<SanPhamDTO> listSP)
        {
            PanelSanPham.Controls.Clear();
            foreach (SanPhamDTO sanpham in listSP)
            {
                Bunifu.Framework.UI.BunifuCards BtnSanPham = new Bunifu.Framework.UI.BunifuCards();
                Label TenSanPham = new System.Windows.Forms.Label();
                Label GiaSanPham = new System.Windows.Forms.Label();


                TenSanPham.BackColor = System.Drawing.Color.Transparent;
                TenSanPham.Location = new System.Drawing.Point(7, 16);
                TenSanPham.Name = sanpham.MaSP;
                TenSanPham.Size = new System.Drawing.Size(85, 30);
                TenSanPham.TabIndex = 1;
                TenSanPham.Text = sanpham.TenSP;
                TenSanPham.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                TenSanPham.MouseHover += new System.EventHandler(this.OnMouseOver);
                TenSanPham.MouseLeave += new System.EventHandler(this.OnMouseLeave);
                TenSanPham.Click += new System.EventHandler(this.BtnSanPham_Click);

                GiaSanPham.BackColor = System.Drawing.Color.Transparent;
                GiaSanPham.ForeColor = System.Drawing.Color.Red;
                GiaSanPham.Location = new System.Drawing.Point(6, 59);
                GiaSanPham.Name = sanpham.MaSP;
                GiaSanPham.Size = new System.Drawing.Size(85, 14);
                GiaSanPham.TabIndex = 2;
                GiaSanPham.Text = ConvertDTO.Instance.CurrencyFromDecimal(sanpham.GiaBan);
                GiaSanPham.TextAlign = System.Drawing.ContentAlignment.TopCenter;
                GiaSanPham.MouseHover += new System.EventHandler(this.OnMouseOver);
                GiaSanPham.MouseLeave += new System.EventHandler(this.OnMouseLeave);
                GiaSanPham.Click += new System.EventHandler(this.BtnSanPham_Click);

                BtnSanPham.SuspendLayout();
                BtnSanPham.BackColor = System.Drawing.Color.White;
                BtnSanPham.BorderRadius = 20;
                BtnSanPham.BottomSahddow = false;
                BtnSanPham.color = sanpham.Mau;
                BtnSanPham.LeftSahddow = false;
                BtnSanPham.Location = new System.Drawing.Point(18, 13);
                BtnSanPham.Name = sanpham.MaSP;
                BtnSanPham.RightSahddow = false;
                BtnSanPham.ShadowDepth = 20;
                BtnSanPham.Size = new System.Drawing.Size(100, 100);
                BtnSanPham.TabIndex = 0;
                BtnSanPham.Controls.Add(GiaSanPham);
                BtnSanPham.Controls.Add(TenSanPham);
                BtnSanPham.MouseLeave += new System.EventHandler(this.BtnSanPham_MouseLeave);
                BtnSanPham.MouseHover += new System.EventHandler(this.BtnSanPham_MouseHover);
                BtnSanPham.Click += new System.EventHandler(this.BtnSanPham_Click);

                PanelSanPham.Controls.Add(BtnSanPham);
            }
        }

        private void BtnSanPham_Click(object sender, EventArgs e)
        {

            if (od.Ban.TrangThai != 3)
            {
                Control btn = sender as Control;
                Order_Them fm = new Order_Them(btn.Name, od.getID(), maNV);

                fm.formOrder = this;
                fm.ShowDialog();
            }
        }


        private void OnMouseOver(object sender, EventArgs e)
        {
            Control ct = (sender as Control).Parent;
            (ct as Bunifu.Framework.UI.BunifuCards).BackColor = Color.FromArgb(207, 209, 209);

        }
        private void OnMouseLeave(object sender, EventArgs e)
        {
            Control ct = (sender as Control).Parent;
            (ct as Bunifu.Framework.UI.BunifuCards).BackColor = Color.White;

        }
        
        
        public void addFormtoPanel(object formobj)
        {
            if (this.Tag != null)
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
        private void BtnTroVe_Click(object sender, EventArgs e)
        {
            backToBanHang();
        }

        public void backToBanHang()
        {
            BanHang fm = new BanHang();
            fm.MaNV = this.od.NhanVien.MaNV;
            addFormtoPanel(fm);
        }

        private void BtnTaiLai_Click(object sender, EventArgs e)
        {
            Order fm = new Order(od.getID());
            fm.maNV = this.maNV;
            addFormtoPanel(fm);
        }

        private void BtnSanPham_MouseHover(object sender, EventArgs e)
        {
            (sender as Bunifu.Framework.UI.BunifuCards).BackColor = Color.FromArgb(207, 209, 209);
        }

        private void BtnSanPham_MouseLeave(object sender, EventArgs e)
        {
            (sender as Bunifu.Framework.UI.BunifuCards).BackColor = Color.White;
        }

        private void BtnHuyBan_Click(object sender, EventArgs e)
        {
            if (od.Ban.TrangThai != 3)
            {
                Order_Huy fm = new Order_Huy(od.getID());
                fm.order = this;
                fm.ShowDialog(this);
            }
            else
            {
                try
                {
                    BanDAO.Instance.SetTrangThai(0, od.getID());
                    OrderDAO.Instance.Delete(od.getID());
                }
                catch
                {
                    MessageBox.Show("Đã xảy ra lỗi với bàn này!");
                }
                backToBanHang();
            }
            
        }

        private void BtnTachBan_Click(object sender, EventArgs e)
        {
            TachBan fm = new TachBan();
            fm.ShowDialog(this);
        }

        private void BtnGopBan_Click(object sender, EventArgs e)
        {
            
            GopBan fm = new GopBan();
            fm.ShowDialog(this);
        }

        private void BtnKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang_Order fm = new KhachHang_Order();
            fm.ShowDialog(this);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (od.Ban.TrangThai ==2)
            {
                ThanhToan fm = new ThanhToan(od.getID(), this.tongcong);
                fm.fmOrder = this;
                fm.ShowDialog(this);
            }
            else
            {
                PhieuTamTinh fm = new PhieuTamTinh(this.od.getID());
                fm.ShowDialog(this);
                BanDAO.Instance.SetTrangThai(2, this.od.Ban.MaBan);
                od = OrderDAO.Instance.GetOrderFromLocal(this.od.Ban.MaBan, this.maNV);
            }
            
        }

        private void BtnPhuThu_Click(object sender, EventArgs e)
        {
            PhuThu fm = new PhuThu();
            fm.ShowDialog(this);
        }

        private void BtnGiamGia_Click(object sender, EventArgs e)
        {
            GiamGia fm = new GiamGia();
            fm.ShowDialog(this);
        }

        private void BtnInTamTinh_Click(object sender, EventArgs e)
        {
            PhieuTamTinh fm = new PhieuTamTinh(this.od.getID());
            fm.ShowDialog(this);
            BanDAO.Instance.SetTrangThai(2, this.od.Ban.MaBan);
            od = OrderDAO.Instance.GetOrderFromLocal(this.od.Ban.MaBan, this.maNV);
        }

        private void BtnTimKiem_OnTextChange(object sender, EventArgs e)
        {
            List<SanPhamDTO> listS = SanPhamDAO.Instance.GetListSearch(BtnTimKiem.text);
            fillSanPhamPanel(listS);
        }

        private void Order_Load(object sender, EventArgs e)
        {
            this.PannelOrderItem.Controls.Clear();
            this.PanelSanPham.Controls.Clear();
            od = OrderDAO.Instance.GetOrderFromLocal(this.od.Ban.MaBan, this.maNV);
            this.tenBan.Text = od.Ban.TenBan;
            this.tenKhuVuc.Text = od.Ban.KhuVuc.TenKV;
            if (od.Ban.TrangThai != 0 )
            {
                
                od = OrderDAO.Instance.GetOrderFromDB(od.getID());
                FillOrder();
                
            }
            else
            {
                
                this.BtnGiamGia.Enabled = false;
                this.BtnPhuThu.Enabled = false;
                this.btnThanhToan.Enabled = false;
                this.BtnHuyBan.Enabled = false;
                this.BtnTachBan.Enabled = false;
                this.BtnKhachHang.Enabled = false;
                this.BtnInTamTinh.Enabled = false;
            }
            KhoiTaoDangMuc();
        }
    }
}
