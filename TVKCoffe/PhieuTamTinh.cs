
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVKCoffe.DAO;
using TVKCoffe.DTO;

namespace TVKCoffe
{
    public partial class PhieuTamTinh : Form
    {
        public decimal phuthu;
        public decimal giamgia;
        public float thuevat = 0;
        private OrderDTO od;

        public PhieuTamTinh(string maOrder)
        {
            InitializeComponent();
            od = OrderDAO.Instance.GetOrderFromDB(maOrder);
        }
       

        private void PhieuTamTinh_Load(object sender, EventArgs e)
        {

            DataTable tb = new DataTable();
            tb.Columns.Add("TenSP", typeof(string));
            tb.Columns.Add("SoLuong", typeof(int));
            tb.Columns.Add("GiaBan", typeof(decimal));
            tb.Columns.Add("Tong", typeof(decimal));

            List<ChiTietOrderDTO> list = ChiTietOrderDAO.Instance.GetListTamTinh(od.getID());
            foreach(ChiTietOrderDTO ct in list)
            {
                decimal tamtinh = (decimal)ct.SoLuong * ct.SanPham.GiaBan;
                tb.Rows.Add(ct.SanPham.TenSP,ct.SoLuong,ct.SanPham.GiaBan,tamtinh);
            }
            phuthu = 0;
            giamgia = 0;
            thuevat = 0;

            ReportDataSource db = new ReportDataSource("DataSetPhieuTamTinh", tb);
            ReportParameter[] pm = new ReportParameter[6];
            pm[0] = new ReportParameter("ngay", od.Thoigiantao.ToString("dd/MM/yyyy H:mm:ss"));
            pm[1] = new ReportParameter("ban",od.Ban.TenBan+" KV: "+od.Ban.KhuVuc.TenKV);
            pm[2] = new ReportParameter("thungan", od.NhanVien.TenNV);
            pm[3] = new ReportParameter("giamgia",giamgia.ToString());
            pm[4] = new ReportParameter("phuthu", phuthu.ToString());
            pm[5] = new ReportParameter("thue", thuevat.ToString());
           


            this.reportViewer1.LocalReport.SetParameters(pm);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(db);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.reportViewer1.RefreshReport();
        }
    }
}
