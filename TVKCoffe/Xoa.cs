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
using TVKCoffe.Model;

namespace TVKCoffe
{
    public partial class Xoa : Form
    {
        private string content;
        private string type;
        private string code;
        public NhanVien nv;
        public Order order;
        public ThucDon thucdon;
        public DanhMuc danhmuc;
        public Xoa(string content,string type,string code)
        {
            InitializeComponent();
            this.TextNoiDung.Text = content;
            this.content = content;
            this.type = type;
            this.code = code;
        }
        private void BtnKhong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCo_Click(object sender, EventArgs e)
        {
            switch (type)
            {
                case "NHANVIEN":
                    NhanVienDAO.Instance.Delete(code);
                    nv.fillDataGridView();
                    this.Close();
                    break;
                case "ITEMORDER":
                    ChiTietOrderDAO.Instance.Delete(code);         
                    order.FillOrder();
                    this.Close();
                    break;
                case "SANPHAM":
                    SanPhamDAO.Instance.Delete(code);
                    thucdon.FillData();
                    this.Close();
                    break;
                case "DANHMUC":
                    DanhMucDAO.Instance.Delete(code);
                    danhmuc.fillData();
                    this.Close();
                    break;
                case "KHACHHANG":
                    this.Close();
                    KhachHangDAO.Instance.Delete(code);
                    break;
                case "KHUVUC":
                    this.Close();
                    KhuVucDAO.Instance.Delete(code);
                    break;
                case "BAN":
                    this.Close();
                    BanDAO.Instance.Delete(code);
                    break;
                case "KHUYENMAI":
                    this.Close();
                    KhuyenMaiDAO.Instance.Delete(code);
                    break;

            }
        }
    }
}
