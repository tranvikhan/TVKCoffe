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
    public partial class KhuVuc_Them: Form
    {
        public KhuVuc_Them()
        {
            InitializeComponent();
            fillInput();
        }

        private void fillInput()
        {
            
            int maHT = KhuVucDAO.Instance.getNewCode();
            string phanSau = maHT.ToString();
            while (phanSau.Length < 4)
            {
                phanSau = "0" + phanSau;
            }
            string newcode = "KV"+phanSau;

            TxtTenKhuVuc.Text = "";
            TxtMaKhuVuc.Text = newcode;
        }

        private void BtnLamLai_Click(object sender, EventArgs e)
        {
            fillInput();
        }

        private void BtnThemKhuVuc_Click(object sender, EventArgs e)
        {
            bool kt;
            if (TxtTenKhuVuc.Text.Equals(""))
            {
                kt = false;
                label2.ForeColor = Color.Red;
            }
            else
            {
                kt = true;
                label2.ForeColor = Color.Black;
            }
            if (kt)
            {
                KhuVucDTO kv = new KhuVucDTO();
                kv.MaKV = TxtMaKhuVuc.Text;
                kv.TenKV = TxtTenKhuVuc.Text;
                if (KhuVucDAO.Instance.Insert(kv))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể thêm Khu Vực");
                }
            }
        }
    }
}
