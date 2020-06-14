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

namespace TVKCoffe
{
    public partial class SanPham_Them : Form
    {
        private List<DanhMucDTO> listDanhMuc;
        private string maMon;
        public ThucDon thucdon;

        public SanPham_Them()
        {
            InitializeComponent();
            int maHT = SanPhamDAO.Instance.GetNewCode();
            string phanSau = maHT.ToString();
            while (phanSau.Length < 4)
            {
                phanSau = "0" + phanSau;
            }
            this.maMon = "SP" + phanSau;
            SelectDanhMuc.Clear();
            List<DanhMucDTO> list = DanhMucDAO.Instance.GetListDanhMuc();
            listDanhMuc = new List<DanhMucDTO>();
            foreach (DanhMucDTO danhmuc in list)
            {
                SelectDanhMuc.AddItem(danhmuc.TenDM);
                this.listDanhMuc.Add(danhmuc);
            }
            ResetInput();
        }

        private void ResetInput()
        {
            PicAnhSP.Image = global::TVKCoffe.Properties.Resources.plus_150px;
            TxtTenMon.Text = "";
            TxtGiaBan.Text = "";
            TxtGiaVon.Text = "";
            MauNhanDien.BackColor = Color.FromArgb(255, 128, 128);
            TxtMaMon.Text = this.maMon;
            SelectDanhMuc.selectedIndex = 0;
        }

        private void BtnChonMau_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                MauNhanDien.BackColor = colorDialog.Color;
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string URLavatar = openFile.FileName.ToString();
                PicAnhSP.ImageLocation = URLavatar;
            }
        }

        private void BtnLamLai_Click(object sender, EventArgs e)
        {
            ResetInput();
        }

        private void BtnThemSanPham_Click(object sender, EventArgs e)
        {
            bool kt = true;
            if (TxtTenMon.Text.Equals(""))
            {
                kt = false;
                label2.ForeColor = Color.Red;
            }
            else
            {
                label2.ForeColor = Color.Black;
            }
            if (TxtGiaBan.Text.Equals(""))
            {
                kt = false;
                label4.ForeColor = Color.Red;
            }
            else
            {
                label4.ForeColor = Color.Black;
            }
            if (TxtGiaVon.Text.Equals(""))
            {
                kt = false;
                label5.ForeColor = Color.Red;
            }
            else
            {
                label5.ForeColor = Color.Black;
            }
            if (kt)
            {
                try
                {
                    SanPhamDTO sp = new SanPhamDTO();
                    sp.TenSP = TxtTenMon.Text;
                    sp.MaSP = this.maMon;
                    sp.GiaBan = Decimal.Parse(TxtGiaBan.Text);
                    sp.GiaVon = Decimal.Parse(TxtGiaVon.Text);
                    sp.Mau = MauNhanDien.BackColor;
                    sp.Anh = PicAnhSP.Image;
                    sp.DanhMuc = listDanhMuc[SelectDanhMuc.selectedIndex];
                    if (SanPhamDAO.Instance.Insert(sp))
                    {
                        thucdon.FillData();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể thêm sản phẩm mới "+ex.Message);
                }
            }
        }
    }
}
