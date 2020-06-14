using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVKCoffe.DTO;

namespace TVKCoffe.DAO
{
    class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Instance
        {
            get
            {
                if (instance == null) instance = new HoaDonDAO();
                return instance;
            }
            private set => instance = value;
        }
        public int getNewCode()
        {
            string query = "Select MaHD from HOADON";
            string ma;
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            if (result.Rows.Count > 0)
                ma = (string)result.Rows[result.Rows.Count - 1]["MaHD"];
            else
                return 1;
            return Int32.Parse(ma.Substring(3)) + 1;
        }
        public bool Insert(HoaDonDTO hd)
        {

            string query = "INSERT INTO HOADON VALUES( @maHD , @ngaytao , @tenkh , @makh , @sdt , @diachi , @mst , @giamgia , @thue , @phuthu , @tong , @nv )";
            object[] obj = {hd.MaHD,hd.NgayTao,hd.TenKH,hd.MaKH,hd.SoDienThoai,hd.DiaChi,hd.MaSoThue,hd.GiamGia,hd.Thue,hd.PhuThu,hd.Tong,hd.NhanVien};
            int result = DataProvider.Instance.ExecuteNonQuery(query, obj);
            return result > 0;
        }
        public HoaDonDTO getHoaDon(string MaHK)
        {
            string query = "SELECT * FROM HOADON WHERE MaHD = @maHD";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { MaHK});
            return new HoaDonDTO(result.Rows[0]);
        }
        public List<HoaDonDTO> getList(DateTime tungay,DateTime denngay)
        {
            string query = "SELECT * FROM HOADON WHERE @tungay <= NgayTao AND @denngay >= NgayTao";
            DataTable result = DataProvider.Instance.ExecuteQuery(query,new object[] { tungay,denngay});
            List<HoaDonDTO> list = new List<HoaDonDTO>();
            foreach(DataRow row in result.Rows)
            {
                HoaDonDTO hd = new HoaDonDTO(row);
                list.Add(hd);
            }
            return list;
        }
    }
}
