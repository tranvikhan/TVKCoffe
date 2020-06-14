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
    public partial class DanhMuc_Sua : Form
    {
        public DanhMuc danhmuc;
        private string MaDM;
        public DanhMuc_Sua(string maDM)
        {
            InitializeComponent();
            this.MaDM = maDM;
            ResetData();
        }

        private void ResetData()
        {
            TxtMaDanhMuc.Text = this.MaDM;
            DanhMucDTO DM= DanhMucDAO.Instance.GetDanhMuc(this.MaDM);
            TxtTenDanhMuc.Text = DM.TenDM;
        }

        private void BtnLamLai_Click(object sender, EventArgs e)
        {
            ResetData();
        }

        private void BtnThemDanhMuc_Click(object sender, EventArgs e)
        {
            bool kt = true;
            if (TxtTenDanhMuc.Text.Equals(""))
            {
                label2.ForeColor = Color.Red;
                kt = false;
            }
            else
            {
                label2.ForeColor = Color.Black;
            }
            if (kt)
            {
                try
                {
                    DanhMucDTO dm = new DanhMucDTO();
                    dm.MaDM = this.MaDM;
                    dm.TenDM = this.TxtTenDanhMuc.Text;
                    if (DanhMucDAO.Instance.Update(dm))
                    {
                        danhmuc.fillData();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể sửa danh mục này " + ex.Message);
                }
            }
        }
    }
}
