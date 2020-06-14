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
    public partial class KhuVuc_Sua: Form
    {
        KhuVucDTO khuvuc;
        public KhuVuc_Sua(string maKV)
        {
            InitializeComponent();
            khuvuc = KhuVucDAO.Instance.GetKhuVuc(maKV);
            fillInput();
        }

        private void fillInput()
        {
            TxtMaKhuVuc.Text = khuvuc.MaKV;
            TxtTenKhuVuc.Text = khuvuc.TenKV;
        }

        private void BtnLamLai_Click(object sender, EventArgs e)
        {
            fillInput();
        }

        private void BtnLuu_Click(object sender, EventArgs e)
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
                if (KhuVucDAO.Instance.Update(kv))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể sửa Khu Vực");
                }
            }
        }
    }
}
