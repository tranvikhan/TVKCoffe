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
    public partial class Ban_Them : Form
    {
        private BanDTO ban;
        private List<KhuVucDTO> list;
        private int selectindex = 0;
        public Ban_Them(string defaultMaKV)
        {
            InitializeComponent();
            ban = new BanDTO();
            ban.KhuVuc = KhuVucDAO.Instance.GetKhuVuc(defaultMaKV);
            loadKhuVuc();
            fillInput();
        }

        private void loadKhuVuc()
        {
            list = KhuVucDAO.Instance.GetListKhuVuc();
            SelectKhuVuc.Clear();
            int i = 0;
            foreach(KhuVucDTO kv in list)
            {
                SelectKhuVuc.AddItem(kv.TenKV);
                if (kv.MaKV == ban.KhuVuc.MaKV) selectindex = i;
                i++;
            }
        }

        private void fillInput()
        {
            int maHT = BanDAO.Instance.getNewCode();
            string phanSau = maHT.ToString();
            while (phanSau.Length < 3)
            {
                phanSau = "0" + phanSau;
            }
            string newcode = "BAN" + phanSau;
            TxtMaBan.Text = newcode;
            SelectKhuVuc.selectedIndex = selectindex;
            TxtTenBan.Text = "";
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            fillInput();
        }

        private void BtnThemBan_Click(object sender, EventArgs e)
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
                ban.MaBan = TxtMaBan.Text;
                ban.TenBan = TxtTenBan.Text;
                ban.TrangThai = 0;
                ban.KhuVuc = list[SelectKhuVuc.selectedIndex];
                if (BanDAO.Instance.Insert(ban))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không Thể Thêm Bàn Mới");
                }
            }
        }
    }
}
