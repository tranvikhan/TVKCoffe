using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVKCoffe.DTO
{
    class ChiTietHoaDonDTO
    {
        private string maHD;
        private string sanPham;
        private string maSP;
        private int soLuong;
        private decimal donGia;
        public ChiTietHoaDonDTO() { }
        public ChiTietHoaDonDTO(DataRow row)
        {
            MaHD = (string)row["MaHD"];
            SanPham = (string)row["SanPham"];
            MaSP = (string)row["MaSP"];
            SoLuong = (int)row["SoLuong"];
            DonGia = (decimal)row["DonGia"];
        }
        public string MaHD { get => maHD; set => maHD = value; }
        public string SanPham { get => sanPham; set => sanPham = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public decimal DonGia { get => donGia; set => donGia = value; }
    }
}
