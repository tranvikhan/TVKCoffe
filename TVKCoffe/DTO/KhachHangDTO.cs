using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVKCoffe.DTO
{
    class KhachHangDTO
    {
		
		private string maKH;
		private string tenKH;
		private string gioiTinh;
		private string email;
		private string soDienThoai;
		private DateTime ngaySinh;
		private string diaChi;
		private string maSoThue;
		private double thue;
		private double chietKhau;
		public KhachHangDTO()
        {
            this.maKH = "";
            this.tenKH = "";
            this.gioiTinh = "Nam";
            this.email = "";
            this.soDienThoai = "";
            this.ngaySinh = DateTime.Today;
            this.diaChi = "";
            this.maSoThue = "";
            this.thue = 0;
            this.chietKhau = 0;
        }
        public KhachHangDTO(DataRow row)
        {
            MaKH = (string)row["MaKH"];
            TenKH =  (string)row["TenKH"];
            GioiTinh = ConvertDTO.Instance.SexFromLogic(row["GioiTinh"]);
            Email = (string)row["Email"];
            SoDienThoai = (string)row["SoDienThoai"];
            NgaySinh = (DateTime)row["NgaySinh"];
            DiaChi = (string)row["DiaChi"];
            MaSoThue = (string)row["MaSoThue"];
            Thue = (double)row["Thue"];
            ChietKhau = (double)row["ChietKhau"];
        }
        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Email { get => email; set => email = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string MaSoThue { get => maSoThue; set => maSoThue = value; }
        public double Thue { get => thue; set => thue = value; }
        public double ChietKhau { get => chietKhau; set => chietKhau = value; }
    }
}
