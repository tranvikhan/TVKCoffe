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
    public partial class Ban_Sua : Form
    {
        private BanDTO ban;
        private List<KhuVucDTO> list;
        private int selectindex = 0;
        public Ban_Sua(string maBan)
        {
            InitializeComponent();
            ban = BanDAO.Instance.GetBan(maBan);
            loadKhuVuc();
            fillInput();
        }
        private void loadKhuVuc()
        {
            list = KhuVucDAO.Instance.GetListKhuVuc();
            SelectKhuVuc.Clear();
            int i = 0;
            foreach (KhuVucDTO kv in list)
            {
                SelectKhuVuc.AddItem(kv.TenKV);
                if (kv.MaKV == ban.KhuVuc.MaKV) selectindex = i;
                i++;
            }
        }
        private void fillInput()
        {
            TxtMaBan.Text = ban.MaBan;
            SelectKhuVuc.selectedIndex = selectindex;
            TxtTenBan.Text = ban.TenBan;
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            fillInput();
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            bool kt = true;
            if (TxtTenBan.Text.Equals(""))
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
                ban.TenBan = TxtTenBan.Text;
                ban.KhuVuc = list[SelectKhuVuc.selectedIndex];
                if (BanDAO.Instance.Update(ban))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không Thể sửa Bàn");
                }
            }
        }
    }
}
