using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVKCoffe.DTO
{
    class OrderDTO
    {
        private BanDTO ban;
        private DateTime thoigiantao;
        private KhachHangDTO khachHang;
        private NhanVienDTO nhanVien;
        private List<ChiTietOrderDTO> listChiTietOrder;
        private List<PhuThuDTO> listPhuThu;
        private List<KhuyenMaiDTO> listGiamGia;

        
        public OrderDTO()
        {

        }
        public string getID()
        {
            return this.Ban.MaBan.ToString();   
        }

        public DateTime Thoigiantao { get => thoigiantao; set => thoigiantao = value; }
        public BanDTO Ban { get => ban; set => ban = value; }
        public KhachHangDTO KhachHang { get => khachHang; set => khachHang = value; }
        public NhanVienDTO NhanVien { get => nhanVien; set => nhanVien = value; }
        public List<ChiTietOrderDTO> ListChiTietOrder { get => listChiTietOrder; set => listChiTietOrder = value; }
        public List<PhuThuDTO> ListPhuThu { get => listPhuThu; set => listPhuThu = value; }
        public List<KhuyenMaiDTO> ListGiamGia { get => listGiamGia; set => listGiamGia = value; }
    }
}
