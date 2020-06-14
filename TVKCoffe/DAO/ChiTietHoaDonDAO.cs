using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVKCoffe.DTO;

namespace TVKCoffe.DAO
{
    class ChiTietHoaDonDAO
    {
        private static ChiTietHoaDonDAO instance;

        public static ChiTietHoaDonDAO Instance
        {
            get
            {
                if (instance == null) instance = new ChiTietHoaDonDAO();
                return instance;
            }
            private set => instance = value;
        }
        public bool Insert(ChiTietHoaDonDTO ct)
        {

            string query = "INSERT INTO CHITIETHOADON VALUES( @maHD , @sanpm , @maSP , @soluong , @dongia )";
            object[] obj = { ct.MaHD,ct.SanPham,ct.MaSP,ct.SoLuong,ct.DonGia};
            int result = DataProvider.Instance.ExecuteNonQuery(query, obj);
            return result > 0;
        }
        public List<ChiTietHoaDonDTO> getList(string maHD)
        {
            string query = "SELECT * FROM CHITIETHOADON WHERE MaHD = @maHD";
            DataTable result = DataProvider.Instance.ExecuteQuery(query,new object[] { maHD});
            List<ChiTietHoaDonDTO> list = new List<ChiTietHoaDonDTO>();
            foreach (DataRow row in result.Rows)
            {
                ChiTietHoaDonDTO hd = new ChiTietHoaDonDTO(row);
                list.Add(hd);
            }
            return list;
        }
    }
}
