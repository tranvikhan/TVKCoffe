using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVKCoffe.DTO
{
    class NhanVienDTO
    {
		private string maNV;
		private string tenNV;
		private string tenDangNhap;
		private string matKhau;
		private string gioiTinh;
		private string email;
		private string soDienThoai;
		private string chucVu;
		private DateTime ngaySinh;
		private Image anhDaiDien;

        public NhanVienDTO(DataRow row)
        {
            this.maNV = (string)row["MaNV"];
            this.tenNV = (string)row["TenNV"];
            this.tenDangNhap = (string)row["TenDangNhap"];
            this.matKhau = (string)row["MatKhau"];
            this.gioiTinh = ConvertDTO.Instance.SexFromLogic(row["GioiTinh"]);
            this.email = (string)row["Email"];
            this.soDienThoai = (string)row["SoDienThoai"];
            this.chucVu = (string)row["ChucVu"];
            this.ngaySinh = (DateTime)row["NgaySinh"];
            this.anhDaiDien = ConvertDTO.Instance.ImageFromByte((byte[])row["AnhDaiDien"]); 

        }
        public NhanVienDTO() { }

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Email { get => email; set => email = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public Image AnhDaiDien { get => anhDaiDien; set => anhDaiDien = value; }
    }
}
