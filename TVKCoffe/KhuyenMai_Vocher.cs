using Microsoft.Reporting.WinForms.Internal.Soap.ReportingServices2005.Execution;
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
    public partial class KhuyenMai_Vocher : Form
    {
        private List<KhuyenMaiDTO> list;
        public KhuyenMai_Vocher()
        {
            InitializeComponent();
            fillList();
        }
        public void reset()
        {
            TxtSoLuong.Text = "1";
            TxtGiaTri.Text = "100000";
            txtTenVocher.Text = "VOCHER";
        }
        private string getnewcodeKM(int i)
        {
            int maHT = KhuyenMaiDAO.Instance.getNewCode()+i;
            string phanSau = maHT.ToString();
            while (phanSau.Length < 4)
            {
                phanSau = "0" + phanSau;
            }
            return "KM" + phanSau;
        }
        private void fillList()
        {
            DataTable table = new DataTable();


            table.Columns.Add("Stt", typeof(int));
            table.Columns.Add("MaKM", typeof(string));
            table.Columns.Add("TenKM", typeof(string));
            table.Columns.Add("MaApDung", typeof(string));
            table.Columns.Add("GiaTri", typeof(string));

            BangVocher.DataSource = table;

            int soluong;
            try
            {
                soluong = Int32.Parse(TxtSoLuong.Text);
            }
            catch
            {
                soluong = 0;
            }
            list = new List<KhuyenMaiDTO>();
            for (int i = 0; i < soluong; i++)
            {
                KhuyenMaiDTO km = new KhuyenMaiDTO();
                km.MaKM = getnewcodeKM(i);
                km.TenKM = txtTenVocher.Text;
                try
                {
                    km.GiaTri = Decimal.Parse(TxtGiaTri.Text);
                }
                catch
                {
                    km.GiaTri = 0;
                }
                
                km.MaApDung = "VOCHER-" + km.MaKM;
                km.LoaiKM = "Vocher";
                km.BatDau = DateTime.Today;
                km.KetThuc = DateTime.Today;
                km.TuXoa = false;
                km.TrangThai = true;
                list.Add(km);
                table.Rows.Add(i+1,km.MaKM,km.TenKM,km.MaApDung,ConvertDTO.Instance.CurrencyFromDecimal(km.GiaTri));

            }

            BangVocher.DataSource = table;
            

        }
        private void TxtSoLuong_OnValueChanged(object sender, EventArgs e)
        {
            fillList();
        }

        private void txtTenVocher_OnValueChanged(object sender, EventArgs e)
        {
            fillList();
        }

        private void TxtGiaTri_OnValueChanged(object sender, EventArgs e)
        {
            fillList();
        }
        public string getSoLuong()
        {
            return TxtSoLuong.Text;
        }
        public string getTenVoCher()
        {
            return txtTenVocher.Text;
        }
        public string getGiaTri()
        {
            return TxtGiaTri.Text;
        }

        private void BangVocher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
