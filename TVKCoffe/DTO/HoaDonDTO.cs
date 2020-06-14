using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVKCoffe.DTO
{
    class HoaDonDTO
    {
        private string maHD;
        private DateTime ngayTao;
        private string tenKH;
        private string maKH;
        private string soDienThoai;
        private string diaChi;
        private string maSoThue;
        private decimal giamGia;
        private decimal thue;
        private decimal phuThu;
        private decimal tong;
        private string tenNV;
        public HoaDonDTO(string maHD,OrderDTO od,decimal giamgia,decimal thue,decimal phuthu,decimal tong)
        {
            this.maHD = maHD;
            this.ngayTao = od.Thoigiantao;
            this.tenKH = od.KhachHang.TenKH;
            this.maKH = od.KhachHang.MaKH;
            this.soDienThoai = od.KhachHang.SoDienThoai;
            this.diaChi = od.KhachHang.DiaChi;
            this.maSoThue = od.KhachHang.MaSoThue;
            this.giamGia = giamGia;
            this.thue = thue;
            this.phuThu = phuThu;
            this.tong = tong;
            this.tenNV = od.NhanVien.TenNV;

        }
        public string MaHD { get => maHD; set => maHD = value; }
        public DateTime NgayTao { get => ngayTao; set => ngayTao = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string MaSoThue { get => maSoThue; set => maSoThue = value; }
        public decimal GiamGia { get => giamGia; set => giamGia = value; }
        public decimal Thue { get => thue; set => thue = value; }
        public decimal PhuThu { get => phuThu; set => phuThu = value; }
        public decimal Tong { get => tong; set => tong = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
    }
}
