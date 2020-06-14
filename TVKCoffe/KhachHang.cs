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
    public partial class KhachHang : Form
    {
        private DataTable table;
        public KhachHang()
        {
            InitializeComponent();
            
        }

        private void fillKhachHang()
        {
            table = new DataTable();
            table.Columns.Add("stt", typeof(int));
            table.Columns.Add("makh", typeof(string));
            table.Columns.Add("tenkh", typeof(string));
            table.Columns.Add("sodt", typeof(string));
            table.Columns.Add("email", typeof(string));
            table.Columns.Add("gioitinh", typeof(string));
            table.Columns.Add("ngaysinh", typeof(string));
            table.Columns.Add("masothue", typeof(string));
            table.Columns.Add("thue", typeof(string));
            table.Columns.Add("chietkhau", typeof(string));
            BangKhachHang.DataSource = table;
            List<KhachHangDTO> list = KhachHangDAO.Instance.GetListKhach();
            int i = 0;
            foreach(KhachHangDTO kh in list)
            {
                i++;
                table.Rows.Add(new object[] {i,kh.MaKH,kh.TenKH,kh.SoDienThoai,kh.Email,kh.GioiTinh,kh.NgaySinh.ToString("dd/MM/yyyy"),kh.MaSoThue,kh.Thue.ToString(),kh.ChietKhau.ToString()});
            }
            BangKhachHang.DataSource = table;
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            fillKhachHang();
        }

        private void BtnThemKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang_Them fm = new KhachHang_Them();
            fm.ShowDialog(this);
            fillKhachHang();
        }

        private void BtnXoaKhachHang_Click(object sender, EventArgs e)
        {
            if (BangKhachHang.CurrentRow.Cells[1].Value.ToString().Equals("KH0001"))
            {
                MessageBox.Show("Không thể xóa!");
            }
            else
            {
                Xoa fm = new Xoa("Khách Hàng: " + BangKhachHang.CurrentRow.Cells[2].Value.ToString(), "KHACHHANG", BangKhachHang.CurrentRow.Cells[1].Value.ToString());
                fm.ShowDialog(this);
                fillKhachHang();
            }
            
        }

        private void BtnTimKiem_OnTextChange(object sender, EventArgs e)
        {
            string filterField = "TenKH";
            table.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%' OR [{2}] LIKE '%{1}%'", filterField, BtnTimKiem.text, "MaKH");
        }

        private void BtnSuaKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang_Sua fm = new KhachHang_Sua(BangKhachHang.CurrentRow.Cells[1].Value.ToString());
            fm.ShowDialog(this);
            fillKhachHang();
        }
    }
}
