using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVKCoffe.DTO
{
    class SanPhamDTO
    {
        private string maSP;
        private string tenSP;
	    private DanhMucDTO danhMuc;
	    private decimal giaBan;
        private decimal giaVon;
        private Color mau;
	    private Image anh;

        
        public SanPhamDTO(DataRow row, DanhMucDTO DM)
        {
            DanhMuc = DM;
            MaSP = (string)row["MaSP"];
            TenSP = (string)row["TenSP"];
            GiaBan = (decimal)row["GiaBan"];
            GiaVon = (decimal)row["GiaVon"];
            Mau = ConvertDTO.Instance.ColorFromString((string)row["Mau"]);
            Anh = ConvertDTO.Instance.ImageFromByte((byte[])row["Anh"]);
        }
        public SanPhamDTO() { }
        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public DanhMucDTO DanhMuc { get => danhMuc; set => danhMuc = value; }
        public decimal GiaBan { get => giaBan; set => giaBan = value; }
        public decimal GiaVon { get => giaVon; set => giaVon = value; }
        public Color Mau { get => mau; set => mau = value; }
        public Image Anh { get => anh; set => anh = value; }

    }
}
