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
    public partial class KhuyenMai : Form
    {
        DataTable table;
        public KhuyenMai()
        {
            InitializeComponent();

            fillData();
        }

        private void fillData()
        {
            table = new DataTable();
            table.Columns.Add("Stt", typeof(int));
            table.Columns.Add("MaKM", typeof(string));
            table.Columns.Add("TenCT", typeof(string));
            table.Columns.Add("GiaTri", typeof(string));
            table.Columns.Add("LoaiKM", typeof(string));
            table.Columns.Add("MaApDung", typeof(string));
            table.Columns.Add("BatDau", typeof(string));
            table.Columns.Add("KetThuc", typeof(string));
            table.Columns.Add("TrangThai", typeof(string));
            table.Columns.Add("TuXoa", typeof(string));

            BangKhuyenMai.DataSource = table;
            int stt= 0;
            List<KhuyenMaiDTO> list = KhuyenMaiDAO.Instance.GetList();
            foreach(KhuyenMaiDTO km in list)
            {
                stt++;
                table.Rows.Add(stt,km.MaKM,km.TenKM,ConvertDTO.Instance.CurrencyFromDecimal(km.GiaTri),km.LoaiKM,km.MaApDung,km.BatDau.ToString("dd/MM/yyyy"),km.KetThuc.ToString("dd/MM/yyyy"),km.TrangThai.ToString(),km.TuXoa.ToString());
            }
            BangKhuyenMai.DataSource = table;

        }

        private void BtnTimKiem_OnTextChange(object sender, EventArgs e)
        {
            string filterField1 = "MaKM";
            string filterField2 = "TenCT";
            string filterField3 = "MaApDung";
            table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%' OR [{2}] LIKE '%{1}%' OR  [{3}] LIKE '%{1}%'", filterField1, BtnTimKiem.text, filterField2, filterField3);
        }

        private void SelectLoaiKM_onItemSelected(object sender, EventArgs e)
        {
            if(SelectLoaiKM.selectedIndex != 0)
            {
                BtnTimKiem.text = "";
                string filterField = "LoaiKM";
                table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, SelectLoaiKM.selectedValue);
            }
            else
            {
                table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "LoaiKM", "");
            }
            
        }

        private void BtnThemNhanVien_Click(object sender, EventArgs e)
        {
            KhuyenMai_Them fm = new KhuyenMai_Them();
            fm.ShowDialog(this);
            fillData();
        }

        private void BtnXoaNhanVien_Click(object sender, EventArgs e)
        {
            Xoa fm = new Xoa("KM: "+ BangKhuyenMai.CurrentRow.Cells[2].Value.ToString(),"KHUYENMAI", BangKhuyenMai.CurrentRow.Cells[1].Value.ToString());
            fm.ShowDialog(this);
            fillData();
        }
    }
}
