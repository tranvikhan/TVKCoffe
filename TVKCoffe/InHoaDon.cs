using Microsoft.Reporting.WinForms;
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
    public partial class InHoaDon : Form
    {
        private HoaDonDTO hoadon;
        public InHoaDon(String maHD)
        {
            InitializeComponent();
            hoadon = HoaDonDAO.Instance.getHoaDon(maHD);
        }

        private void InHoaDon_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("Stt", typeof(int));
            tb.Columns.Add("TenSP", typeof(string));
            tb.Columns.Add("SoLuong", typeof(int));
            tb.Columns.Add("DonGia", typeof(string));
            tb.Columns.Add("Tong", typeof(string));
            List<ChiTietHoaDonDTO> list = ChiTietHoaDonDAO.Instance.getList(hoadon.MaHD);
            int stt = 0;
            decimal CongTienHang = 0;
            foreach(ChiTietHoaDonDTO chitiet in list)
            {
                decimal Tong = (decimal)chitiet.SoLuong * chitiet.DonGia;
                CongTienHang = CongTienHang + Tong;
                tb.Rows.Add(++stt,chitiet.SanPham,chitiet.SoLuong,ConvertDTO.Instance.CurrencyFromDecimal(chitiet.DonGia), ConvertDTO.Instance.CurrencyFromDecimal(Tong));
            }


            ReportDataSource db = new ReportDataSource("DataSetHoaDon", tb);
            ReportParameter[] pm = new ReportParameter[12];
            pm[0] = new ReportParameter("Ngay", hoadon.NgayTao.ToString("dd/MM/yyyy"));
            pm[1] = new ReportParameter("MaHD", hoadon.MaHD.ToString());
            pm[2] = new ReportParameter("TenKH", hoadon.TenKH.ToString());
            pm[3] = new ReportParameter("MaSoThue",hoadon.MaSoThue.ToString());
            pm[4] = new ReportParameter("DiaChi", hoadon.DiaChi.ToString());
            pm[5] = new ReportParameter("SoDienThoai", hoadon.SoDienThoai.ToString());
            pm[6] = new ReportParameter("Thue", ConvertDTO.Instance.CurrencyFromDecimal(hoadon.Thue));
            pm[7] = new ReportParameter("PhuThu", ConvertDTO.Instance.CurrencyFromDecimal(hoadon.PhuThu));
            pm[8] = new ReportParameter("GiamGia", ConvertDTO.Instance.CurrencyFromDecimal(hoadon.GiamGia));
            pm[9] = new ReportParameter("TongCong", ConvertDTO.Instance.CurrencyFromDecimal(hoadon.Tong));
            pm[10] = new ReportParameter("PhanTramThue", Math.Round((hoadon.Thue / CongTienHang)*100,2).ToString());
            pm[11] = new ReportParameter("CongTienHang", ConvertDTO.Instance.CurrencyFromDecimal(CongTienHang));

            this.reportViewer1.LocalReport.SetParameters(pm);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(db);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.reportViewer1.RefreshReport();

        }
    }
}
