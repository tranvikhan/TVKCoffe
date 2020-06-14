using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVKCoffe.DTO
{
    class ChiTietHoaDonDTO
    {
        private string maHD;
        private string tenSP;
        private string maSP;
        private int soLuong;
        private decimal donGia;
        public ChiTietHoaDonDTO(string maHD,ChiTietOrderDTO ct)
        {
            this.maHD = maHD;
            this.tenSP = ct.SanPham.TenSP;
            this.maSP = ct.SanPham.MaSP;
            this.soLuong = ct.SoLuong;
            this.donGia = ct.SanPham.GiaBan;
        }
        public string MaHD { get => maHD; set => maHD = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public decimal DonGia { get => donGia; set => donGia = value; }
    }
}
