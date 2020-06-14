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
    public partial class Order_Sua : Form
    {
        public Order formOrder;
        private ChiTietOrderDTO chitiet;
        private string GhiChu = "";
        int SoLuong = 1;
        int SoLuongPlus = 0;
        public Order_Sua(string maCT)
        {
            InitializeComponent();
            chitiet = ChiTietOrderDAO.Instance.GetChiTietOd(maCT);       
            LoadSanPham();
        }
        private void LoadSanPham()
        {

            PicAnhSP.Image = chitiet.SanPham.Anh;
            this.SoLuong = chitiet.SoLuong;
            this.GhiChu = chitiet.GhiChu;
            this.TextTenMon.Text = "Tên món: " + chitiet.SanPham.TenSP;
            this.TextGiaBan.Text = "Giá bán: " + ConvertDTO.Instance.CurrencyFromDecimal(chitiet.SanPham.GiaBan);
            this.TextMaMon.Text = "Mã món: " + chitiet.SanPham.MaSP;
            this.TextSoLuong.Text = this.SoLuong.ToString();
            this.TextGhiChu.Text = this.GhiChu;
        }
        private void CapNhatSoLuong()
        {
            this.TextSoLuong.Text = SoLuong.ToString();
        }
        private void LamMoiBanPhimSL()
        {
            foreach (Control cr in BanPhimSoLuong.Controls)
            {
                cr.BackColor = Color.FromArgb(236, 240, 241);
            }
        }
        private void AddGhiChu(string str)
        {
            if (!str.Equals(""))
            {
                this.GhiChu = this.GhiChu + ((this.GhiChu.Equals("")) ? "" : ", ") + str;
            }
            this.TextGhiChu.Text = this.GhiChu;
        }
        private void TextSoLuong_OnValueChanged(object sender, EventArgs e)
        {

            try
            {
                SoLuong = Int32.Parse(TextSoLuong.Text);
                SoLuong = (SoLuong > 0) ? SoLuong : 1;
                CapNhatSoLuong();
            }
            catch (Exception)
            {
                SoLuong = 1;
                CapNhatSoLuong();
            }
        }

        private void BtnCong_Click(object sender, EventArgs e)
        {
            SoLuong++;
            CapNhatSoLuong();
            LamMoiBanPhimSL();
        }

        private void BtnTru_Click(object sender, EventArgs e)
        {
            SoLuong--;
            CapNhatSoLuong();
            LamMoiBanPhimSL();
        }
        private void btnSo_click(int i)
        {
            SoLuong = i + SoLuongPlus;
            CapNhatSoLuong();
            SoLuongPlus = 0;
            LamMoiBanPhimSL();
        }
        private void BtnCong_click(int i, Object sender)
        {
            SoLuong = i;
            CapNhatSoLuong();
            SoLuongPlus = i;
            (sender as Button).BackColor = Color.FromArgb(170, 170, 170);
        }
        private void b1_Click(object sender, EventArgs e)
        {
            btnSo_click(1);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            btnSo_click(2);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            btnSo_click(3);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            btnSo_click(4);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            btnSo_click(5);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            btnSo_click(6);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            btnSo_click(7);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            btnSo_click(8);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            btnSo_click(9);
        }

        private void b10_Click(object sender, EventArgs e)
        {
            btnSo_click(10);
        }

        private void b10p_Click(object sender, EventArgs e)
        {
            BtnCong_click(10, sender);
        }

        private void b20p_Click(object sender, EventArgs e)
        {
            BtnCong_click(20, sender);
        }

        private void b30p_Click(object sender, EventArgs e)
        {
            BtnCong_click(30, sender);

        }

        private void b40p_Click(object sender, EventArgs e)
        {
            BtnCong_click(40, sender);
        }

        private void b50p_Click(object sender, EventArgs e)
        {
            BtnCong_click(50, sender);
        }

        private void ghichu1_Click(object sender, EventArgs e)
        {
            AddGhiChu((sender as Button).Text);
        }

        private void ghichu2_Click(object sender, EventArgs e)
        {
            AddGhiChu((sender as Button).Text);
        }

        private void ghichu3_Click(object sender, EventArgs e)
        {
            AddGhiChu((sender as Button).Text);
        }

        private void ghichu4_Click(object sender, EventArgs e)
        {
            AddGhiChu((sender as Button).Text);
        }

        private void ghichu5_Click(object sender, EventArgs e)
        {
            AddGhiChu((sender as Button).Text);
        }

        private void ghichu6_Click(object sender, EventArgs e)
        {
            AddGhiChu((sender as Button).Text);
        }

        private void ghichu7_Click(object sender, EventArgs e)
        {
            AddGhiChu((sender as Button).Text);
        }

        private void TextGhiChu_TextChanged(object sender, EventArgs e)
        {
            this.GhiChu = this.TextGhiChu.Text;
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnXacNhan_Click(object sender, EventArgs e)
        {
            chitiet.SoLuong = this.SoLuong;
            chitiet.GhiChu = this.GhiChu;
            if (ChiTietOrderDAO.Instance.Update(chitiet))
            {
                this.formOrder.FillOrder();
                this.Close();
            }
            else
            {
                MessageBox.Show("Không thể sửa đổi");
            }
            

        }
    }
}
