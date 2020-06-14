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
    public partial class HoaDon : Form
    {
        private DataTable table;
        public HoaDon()
        {
            InitializeComponent();
            TimeTuNgay.Value = DateTime.Now.AddDays(-1);
            TimeDenNgay.Value = DateTime.Now;
            filldata();
        }

        private void filldata()
        {
            table = new DataTable();
            table.Columns.Add("stt", typeof(int));
            table.Columns.Add("ngaytao", typeof(string));
            table.Columns.Add("mahoadon", typeof(string));
            table.Columns.Add("sanpham", typeof(string));
            table.Columns.Add("tongtien", typeof(string));
            table.Columns.Add("khachhang", typeof(string));

            BangHoaDon.DataSource = table;
            List<HoaDonDTO> listhd = HoaDonDAO.Instance.getList(TimeTuNgay.Value, TimeDenNgay.Value);
            for (int i = listhd.Count - 1; i >= 0; i--)
            {
                string sanphamstr = "";
                List<ChiTietHoaDonDTO> listct = ChiTietHoaDonDAO.Instance.getList(listhd[i].MaHD);
                foreach(ChiTietHoaDonDTO ct in listct)
                {
                    sanphamstr = sanphamstr+"[" + ct.SoLuong.ToString() + "]" + ct.SanPham + ", ";
                }
                table.Rows.Add(listhd.Count - i, listhd[i].NgayTao.ToString("dd/MM/yyyy H:mm:ss"), listhd[i].MaHD, sanphamstr, ConvertDTO.Instance.CurrencyFromDecimal(listhd[i].Tong), listhd[i].TenKH);
            }

        }

        private void BtnTimKiem_OnTextChange(object sender, EventArgs e)
        {
            string filterField = "mahoadon";
            table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, BtnTimKiem.text);
        }

        private void TimeTuNgay_onValueChanged(object sender, EventArgs e)
        {
            filldata();
        }

        private void TimeDenNgay_onValueChanged(object sender, EventArgs e)
        {
            filldata();
        }
    }
}
