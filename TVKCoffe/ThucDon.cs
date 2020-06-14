using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;
using TVKCoffe.DAO;
using TVKCoffe.DTO;

namespace TVKCoffe
{
    public partial class ThucDon : Form
    {
        DataTable thucdon;
        public ThucDon()
        {
            InitializeComponent();
            thucdon = new DataTable();
            thucdon.Columns.Add("stt", typeof(int));
            thucdon.Columns.Add("anh", typeof(Image));
            thucdon.Columns.Add("mamon", typeof(string));
            thucdon.Columns.Add("tenmon", typeof(string));
            thucdon.Columns.Add("danhmuc", typeof(string));
            thucdon.Columns.Add("giaban", typeof(string));
            thucdon.Columns.Add("giavon", typeof(string));
            
            DataGridViewImageColumn column = this.ColAnh;
            column.ImageLayout = DataGridViewImageCellLayout.Zoom;

            FillData();
            FillDanhMuc();
        }

        public void FillDanhMuc()
        {
            SelectChonDanhMuc.Clear();
            SelectChonDanhMuc.AddItem("Chọn Danh Mục");
            SelectChonDanhMuc.selectedIndex = 0;
            List<DanhMucDTO> list = DanhMucDAO.Instance.GetListDanhMuc();
            foreach (DanhMucDTO danhmuc in list)
            {
                SelectChonDanhMuc.AddItem(danhmuc.TenDM);
            }
        }

        public void FillData()
        {
            thucdon.Rows.Clear();
            List<SanPhamDTO> list = SanPhamDAO.Instance.GetListSanPham();
            int stt = 0;
            foreach (SanPhamDTO sanpham in list)
            {
                
                thucdon.Rows.Add(new object[] { stt++,sanpham.Anh,sanpham.MaSP,sanpham.TenSP,sanpham.DanhMuc.TenDM,ConvertDTO.Instance.CurrencyFromDecimal(sanpham.GiaBan), ConvertDTO.Instance.CurrencyFromDecimal(sanpham.GiaVon)});
            }
            BangThucDon.DataSource = thucdon;
        }

        private void addFormtoPanel(object formobj)
        {
            if (this.Tag != null)
            {
                Form tmp = this.Tag as Form;
                tmp.Close();
            }
            if (this.Controls.Count > 0)
                this.Controls.Clear();
            Form od = formobj as Form;
            AddOwnedForm(od);
            od.FormBorderStyle = FormBorderStyle.None;
            od.TopLevel = false;
            od.Dock = DockStyle.Fill;
            this.Controls.Add(od);
            this.Tag = od;
            od.BringToFront();
            od.Show();
        }
        private void BtnQuanLyDangMuc_Click(object sender, EventArgs e)
        {
            addFormtoPanel(new DanhMuc());
        }

        private void BtnTimKiem_OnTextChange(object sender, EventArgs e)
        {
            string filterField = "tenmon";
            SelectChonDanhMuc.selectedIndex = 0;
            thucdon.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%' OR [{2}] LIKE '%{1}%'", filterField, BtnTimKiem.text, "mamon");
        }

        private void SelectChonDanhMuc_onItemSelected(object sender, EventArgs e)
        {
            string filterField = "danhmuc";
            BtnTimKiem.text = "";
            if (SelectChonDanhMuc.selectedIndex != 0)
                thucdon.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}'", filterField, SelectChonDanhMuc.selectedValue);
            else
                thucdon.DefaultView.RowFilter = string.Format("");
        }

        private void BtnThemMon_Click(object sender, EventArgs e)
        {
            SanPham_Them fm = new SanPham_Them();
            fm.thucdon = this;
            fm.ShowDialog(this);
        }

        private void BtnXoaMon_Click(object sender, EventArgs e)
        {
            Xoa fm = new Xoa("Món: " + BangThucDon.CurrentRow.Cells[3].Value.ToString(), "SANPHAM", BangThucDon.CurrentRow.Cells[2].Value.ToString());
            fm.thucdon = this;
            fm.ShowDialog(this);
        }

        private void BtnSuaMon_Click(object sender, EventArgs e)
        {
            SanPham_Sua fm = new SanPham_Sua(BangThucDon.CurrentRow.Cells[2].Value.ToString());
            fm.thucdon = this;
            fm.ShowDialog();
        }
    }
}
