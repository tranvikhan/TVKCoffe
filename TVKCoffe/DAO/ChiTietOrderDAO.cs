using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVKCoffe.DTO;

namespace TVKCoffe.DAO
{
    class ChiTietOrderDAO
    {
        private static ChiTietOrderDAO instance;

        public static ChiTietOrderDAO Instance
        {
            get
            {
                if (instance == null) instance = new ChiTietOrderDAO();
                return instance;
            }
            private set => instance = value;
        }
        public int GetNewCode()
        {
            string query = "Select MaCT from CHITIETORDER";
            string ma;
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            if (result.Rows.Count > 0)
                ma = (string)result.Rows[result.Rows.Count - 1]["MaCT"];
            else
                return 1;
            return Int32.Parse(ma.Substring(2)) + 1;
        }
        public bool Insert(ChiTietOrderDTO ct)
        {
            string query = "INSERT INTO CHITIETORDER VALUES( @MaCt , @MaOrder , @MaSP , @SoLuong , @GhiChu )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {ct.MaCT,ct.Order.getID(),ct.SanPham.MaSP,ct.SoLuong,ct.GhiChu });
            return result>0;
        }
        public ChiTietOrderDTO GetChiTietOd(string maCT)
        {
            string query = "Select * from CHITIETORDER WHERE MaCT= @maCT ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { maCT });
            return new ChiTietOrderDTO(result.Rows[0]);
        } 
        public List<ChiTietOrderDTO> GetList(string maOrder)
        {
            List<ChiTietOrderDTO> list = new List<ChiTietOrderDTO>();
            string query = "Select * from CHITIETORDER WHERE MaOrder= @maOrder ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { maOrder });
            foreach(DataRow row in result.Rows)
            {
                ChiTietOrderDTO item = new ChiTietOrderDTO(row);
                list.Add(item);
            }
            return list;

        }
        public bool Update(ChiTietOrderDTO ct)
        {
            string query = "UPDATE CHITIETORDER SET SoLuong= @Soluong ,GhiChu= @ghichu WHERE MaCT= @maCT ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {ct.SoLuong,ct.GhiChu,ct.MaCT});
            return result > 0;
        }
        public bool Delete(string maCT)
        {
            string query = "DELETE FROM CHITIETORDER WHERE MaCT = @maCT ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maCT});
            return result > 0;
        }
        public List<ChiTietOrderDTO> GetListTamTinh(string maOrder)
        {
            List<ChiTietOrderDTO> list = new List<ChiTietOrderDTO>();
            string query = "Select MaSp,SUM(Soluong) AS SL from CHITIETORDER WHERE MaOrder= @maOrder Group by MaSp";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { maOrder });
            foreach (DataRow row in result.Rows)
            {
                ChiTietOrderDTO item = new ChiTietOrderDTO(row, maOrder);
                list.Add(item);
            }
            return list;

        }
    }
}
