using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVKCoffe.DTO
{
    class KhuyenMaiDTO
    {
        private string maKM;
		private string tenKM;
		private decimal giaTri;
		private string loaiKM;
		private string maApDung;
		private DateTime batDau;
		private DateTime ketThuc;
		private bool trangThai;
		private bool tuXoa;
        public KhuyenMaiDTO() { }
        public KhuyenMaiDTO(DataRow row)
        {
            this.maKM = (string)row["MaKM"];
            this.TenKM = (string)row["TenKM"];
            this.giaTri = (decimal)row["GiaTri"];
            this.loaiKM = (string)row["LoaiKM"];
            this.maApDung = (string)row["MaApDung"];
            this.batDau = (DateTime)row["BatDau"];
            this.ketThuc= (DateTime)row["KetThuc"];
            this.trangThai = (bool)row["TrangThai"];
            this.tuXoa = (bool)row["TuXoa"];

        }
        public string MaKM { get => maKM; set => maKM = value; }
        public string TenKM { get => tenKM; set => tenKM = value; }
        public decimal GiaTri { get => giaTri; set => giaTri = value; }
        public string LoaiKM { get => loaiKM; set => loaiKM = value; }
        public string MaApDung { get => maApDung; set => maApDung = value; }
        public DateTime BatDau { get => batDau; set => batDau = value; }
        public DateTime KetThuc { get => ketThuc; set => ketThuc = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
        public bool TuXoa { get => tuXoa; set => tuXoa = value; }
    }
}
