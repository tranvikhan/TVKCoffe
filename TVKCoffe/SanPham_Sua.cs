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
    public partial class SanPham_Sua : Form
    {
        private List<DanhMucDTO> listDanhMuc;
        private string maMon;
        public ThucDon thucdon;

        public SanPham_Sua(string mamon)
        {
            InitializeComponent();
            this.maMon = mamon;
            
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
            SanPhamDTO sp = SanPhamDAO.Instance.GetSanPham(maMon);
            PicAnhSP.Image = sp.Anh;
            TxtTenMon.Text = sp.TenSP;
            TxtGiaBan.Text = sp.GiaBan.ToString("0.00").Replace(".00", String.Empty);
            TxtGiaVon.Text = sp.GiaVon.ToString("0.00").Replace(".00", String.Empty);
            MauNhanDien.BackColor = sp.Mau;
            TxtMaMon.Text = this.maMon;
            int index = 0; 
            foreach (DanhMucDTO DM in listDanhMuc)
            {
                if(DM.MaDM == sp.DanhMuc.MaDM)
                {
                    SelectDanhMuc.selectedIndex = index;
                    break;
                }
                index++;
            }
            SelectDanhMuc.selectedIndex = index;
            
            
        }

        private void BtnChonMau_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                MauNhanDien.BackColor = colorDialog.Color;
        }

             

        private void BtnLuu_Click(object sender, EventArgs e)
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
                    if (SanPhamDAO.Instance.Update(sp))
                    {
                        thucdon.FillData();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể sữa sản phẩm này" + ex.Message);
                }
            }
        }

        private void BtnLamLai_Click(object sender, EventArgs e)
        {
            ResetInput();
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string URLavatar = openFile.FileName.ToString();
                PicAnhSP.ImageLocation = URLavatar;
            }
        }
    }
}
