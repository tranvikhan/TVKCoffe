using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVKCoffe.DTO;

namespace TVKCoffe.DAO
{
    class OrderDAO
    {
        private static OrderDAO instance;

        public static OrderDAO Instance
        {
            get
            {
                if (instance == null) instance = new OrderDAO();
                return instance;
            }
            private set => instance = value;
        }
        public OrderDTO GetOrderFromLocal(string maBan,string maNV)
        {
            OrderDTO od = new OrderDTO();
            od.Ban = BanDAO.Instance.GetBan(maBan);
            od.NhanVien = NhanVienDAO.Instance.GetNhanVien(maNV);
            od.KhachHang = new KhachHangDTO();
            od.KhachHang.MaKH = "KH0001";
            od.Thoigiantao = DateTime.Now;
            return od;
        }
        public OrderDTO GetOrderFromDB(string maOrder)
        {
            OrderDTO od = new OrderDTO();
            string query = "SELECT * FROM [ORDER] WHERE MaOrder = @maOrder ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {maOrder });
            od.Ban = BanDAO.Instance.GetBan(maOrder);
            od.NhanVien = NhanVienDAO.Instance.GetNhanVien((string)result.Rows[0]["MaNV"]);
            od.KhachHang = KhachHangDAO.Instance.GetKhach((string)result.Rows[0]["MaKH"]);
            od.Thoigiantao = (DateTime)result.Rows[0]["ThoiGianTao"];
            return od;

        }
        public bool Insert(OrderDTO od)
        {
            string query = "INSERT INTO [ORDER] VALUES( @MaOrder , @ThoiGianTao , @MaKH , @MaNV )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {od.getID(),od.Thoigiantao,od.KhachHang.MaKH,od.NhanVien.MaNV});
            return result > 0;
        }
        public bool Delete(string maOrder)
        {
            string query = "DELETE FROM [ORDER] WHERE MaOrder = @maOrder";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maOrder });
            return result > 0;
        }

    }
}
