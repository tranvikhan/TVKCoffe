using System;
using System.Collections.Generic;
using System.Data;
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
        private string nhanVien;
        public HoaDonDTO() { }
        public HoaDonDTO(DataRow row)
        {
            MaHD = (string)row["MaHD"];
            NgayTao = (DateTime)row["NgayTao"];
            TenKH = (string)row["TenKH"];
            MaKH = (string)row["MaKH"];
            SoDienThoai = (string)row["SoDienThoai"];
            DiaChi = (string)row["DiaChi"];
            MaSoThue = (string)row["MaSoThue"];
            NhanVien = (string)row["NhanVien"];
            GiamGia = (decimal)row["GiamGia"];
            PhuThu = (decimal)row["PhuThu"];
            Thue = (decimal)row["Thue"];
            Tong = (decimal)row["Tong"];

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
        public string NhanVien { get => nhanVien; set => nhanVien = value; }
    }
}
