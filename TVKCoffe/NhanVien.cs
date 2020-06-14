using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVKCoffe.DAO;
using TVKCoffe.DTO;
using TVKCoffe.Model;

namespace TVKCoffe
{
    public partial class NhanVien : Form
    {   
        private string MaNVHienTai;
        private DataTable bangNV = new DataTable();
        public void SetMaNVHienTai(string ma)
        {
            this.MaNVHienTai = ma;
        }
        public NhanVien()
        {
            InitializeComponent();
            bangNV.Columns.Add("stt", typeof(int));
            bangNV.Columns.Add("anh", typeof(Image));
            bangNV.Columns.Add("MaNV", typeof(string));
            bangNV.Columns.Add("TenNV", typeof(string));
            bangNV.Columns.Add("ChucVu", typeof(string));
            bangNV.Columns.Add("NgaySinh", typeof(string));
            bangNV.Columns.Add("GioiTinh", typeof(string));
            bangNV.Columns.Add("Sdt", typeof(string));
            bangNV.Columns.Add("Email", typeof(string));
            DataGridViewImageColumn column = this.ColAnh;
            column.ImageLayout = DataGridViewImageCellLayout.Zoom;
            fillDataGridView();
        }
        public void fillDataGridView()
        {
            bangNV.Rows.Clear();
            List<NhanVienDTO> listnv = NhanVienDAO.Instance.GetListNhavVien();
            int stt = 0;
            foreach(NhanVienDTO nv in listnv)
            {
                
                bangNV.Rows.Add(new object[] {stt++, nv.AnhDaiDien, nv.MaNV, nv.TenNV, nv.ChucVu,ConvertDTO.Instance.DateStringFromDay(nv.NgaySinh),nv.GioiTinh,nv.SoDienThoai, nv.Email});
            }
            BangNhanVien.DataSource = bangNV;
        }

        private void BtnThemNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien_Them fm = new NhanVien_Them();
            fm.nv = this;
            fm.ShowDialog(this);
        }

        private void BtnTimKiem_OnTextChange(object sender, EventArgs e)
        {
            string filterField = "TenNV";
            bangNV.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%' OR [{2}] LIKE '%{1}%'", filterField, BtnTimKiem.text,"MaNV");
        }
        private void BtnSuaNhanVien_Click(object sender, EventArgs e)
        {
            if(BangNhanVien.CurrentRow.Cells[2].Value.ToString() != MaNVHienTai)
            {
                NhanVien_Sua nvSua = new NhanVien_Sua(BangNhanVien.CurrentRow.Cells[2].Value.ToString());
                nvSua.nv = this;
                nvSua.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Vui Lòng Đăng Nhập Bằng Tài Khoản Khác!");
            }
            

        }

        private void BtnXoaNhanVien_Click(object sender, EventArgs e)
        {
            if (BangNhanVien.CurrentRow.Cells[2].Value.ToString() != MaNVHienTai)
            {
                Xoa x = new Xoa("Nhân viên: "+ BangNhanVien.CurrentRow.Cells[3].Value.ToString(), "NHANVIEN",BangNhanVien.CurrentRow.Cells[2].Value.ToString());
                x.nv = this;
                x.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Vui Lòng Đăng Nhập Bằng Tài Khoản Khác!");
            }
        }
    }
}
