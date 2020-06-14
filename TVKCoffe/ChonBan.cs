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
    public partial class ChonBan : Form
    {
        private List<KhuVucDTO> dsKV;
        private List<BanDTO> dsBAN;
        public ChonBan()
        {
            InitializeComponent();
            dsKV = new List<KhuVucDTO>();
            dsBAN = new List<BanDTO>();
            fillKhuVuc();
            
        }
        
        private void fillKhuVuc()
        { 
            listKhuVuc.Items.Clear();
           
            dsKV = KhuVucDAO.Instance.GetListKhuVuc();
            foreach(KhuVucDTO kv in dsKV)
            {
                listKhuVuc.Items.Add(kv.MaKV+" - "+kv.TenKV);
            }
            listKhuVuc.SelectedIndex = 0;
            fillBan(dsKV[listKhuVuc.SelectedIndex].MaKV);
    
        }

        private void fillBan(string maKV)
        {
            listBan.Items.Clear();
            dsBAN = BanDAO.Instance.GetListBan(maKV);
            foreach(BanDTO ban in dsBAN)
            {
                
                listBan.Items.Add(ban.MaBan + " - " + ban.TenBan+" - "+ConvertDTO.Instance.TrangThaiToString(ban.TrangThai));
            }
        }

        private void listKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillBan(dsKV[listKhuVuc.SelectedIndex].MaKV);
        }

        private void listBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            textKhuVuc.Text = "Khu vực: " + dsBAN[listBan.SelectedIndex].KhuVuc.TenKV;
            textBan.Text = "Bàn: " + dsBAN[listBan.SelectedIndex].TenBan;
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnChonBan_Click(object sender, EventArgs e)
        {
            if(dsBAN[listBan.SelectedIndex].TrangThai != 3)
            {

            }
            else
            {
                MessageBox.Show("Bàn này đã thanh toán");
                this.Close();
            }
        }
    }
}
