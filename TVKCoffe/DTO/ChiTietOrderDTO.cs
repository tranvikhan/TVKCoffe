using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVKCoffe.DAO;

namespace TVKCoffe.DTO
{
    class ChiTietOrderDTO
    {
        private string maCT;
        private SanPhamDTO sanPham;
        private OrderDTO order;
        private int soLuong;
        private string ghiChu;
        public ChiTietOrderDTO() { }
        public ChiTietOrderDTO(DataRow row) {

            this.maCT = (string)row["MaCT"];
            this.sanPham = SanPhamDAO.Instance.GetSanPham((string)row["MaSp"]);
            this.order = OrderDAO.Instance.GetOrderFromDB((string)row["MaOrder"]);
            this.soLuong = (int)row["SoLuong"];
            this.ghiChu = (string)row["GhiChu"];
        }
        public ChiTietOrderDTO(DataRow row,string maOrder)
        {

            this.maCT = "";
            this.sanPham = SanPhamDAO.Instance.GetSanPham((string)row["MaSp"]);
            this.order = OrderDAO.Instance.GetOrderFromDB(maOrder);
            this.soLuong = (int)row["SL"];
            this.ghiChu ="";
        }
        public string MaCT { get => maCT; set => maCT = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public SanPhamDTO SanPham { get => sanPham; set => sanPham = value; }
        public OrderDTO Order { get => order; set => order = value; }
    }
}
