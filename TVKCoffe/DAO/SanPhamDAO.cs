using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVKCoffe.DTO;

namespace TVKCoffe.DAO
{
    class SanPhamDAO
    {
        private static SanPhamDAO instance;

        public static SanPhamDAO Instance
        {
            get
            {
                if (instance == null) instance = new SanPhamDAO();
                return instance;
            }
            private set => instance = value;
        }
        public SanPhamDTO GetSanPham(string maSP)
        {
            string query = "SELECT * FROM SANPHAM WHERE MaSP = @maSP";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { maSP });
            return new SanPhamDTO(result.Rows[0],DanhMucDAO.Instance.GetDanhMuc((string)result.Rows[0]["DanhMuc"]));
        }
        public List<SanPhamDTO> GetListSanPham()
        {
            string query = "SELECT * FROM SANPHAM";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            List<SanPhamDTO> list = new List<SanPhamDTO>();
            foreach (DataRow row in result.Rows)
            {
                list.Add(new SanPhamDTO(row,DanhMucDAO.Instance.GetDanhMuc((string)row["DanhMuc"])));
            }
            return list;
        }
        public List<SanPhamDTO> GetListSanPham(string maDM)
        {
            string query = "SELECT * FROM SANPHAM WHERE DanhMuc= @MaDM";
            DataTable result = DataProvider.Instance.ExecuteQuery(query,new object[] { maDM});
            List<SanPhamDTO> list = new List<SanPhamDTO>();
            foreach (DataRow row in result.Rows)
            {
                list.Add(new SanPhamDTO(row, DanhMucDAO.Instance.GetDanhMuc((string)row["DanhMuc"])));
            }
            return list;
        }
        public int GetNewCode()
        {
            string query = "Select MaSP from SANPHAM";
            string ma;
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            if (result.Rows.Count > 0)
                ma = (string)result.Rows[result.Rows.Count - 1]["MaSP"];
            else
                return 1;
            return Int32.Parse(ma.Substring(2)) + 1;
        }
        public bool Insert(SanPhamDTO sp)
        {
            string query = "INSERT INTO SANPHAM VALUES ( @MaSP , @TenSP , @MaDM , @GiaBan , @GiaVon , @mau , @anh )";
            object[] obj = new object[] {sp.MaSP,sp.TenSP,sp.DanhMuc.MaDM,sp.GiaBan,sp.GiaVon,ConvertDTO.Instance.StringFromColor(sp.Mau),ConvertDTO.Instance.ByteFromImage(sp.Anh)};
            int result = DataProvider.Instance.ExecuteNonQuery(query, obj);
            return result > 0;
        }
        public bool Update(SanPhamDTO sp)
        {
            string query = "UPDATE SANPHAM SET MaSP= @MaSP ,TenSP= @TenSP ,DanhMuc= @MaDM ,GiaBan= @GiaBan ,GiaVon= @GiaVon ,Mau= @mau ,Anh= @anh WHERE MaSP = @masanpham";
            object[] obj = new object[] { sp.MaSP, sp.TenSP, sp.DanhMuc.MaDM, sp.GiaBan, sp.GiaVon, ConvertDTO.Instance.StringFromColor(sp.Mau), ConvertDTO.Instance.ByteFromImage(sp.Anh),sp.MaSP};
            int result = DataProvider.Instance.ExecuteNonQuery(query, obj);
            return result > 0;
        }
        public bool Delete(string maSP)
        {
            string query = "DELETE FROM SANPHAM WHERE MaSP= @maSP";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maSP});
            return result > 0;
        }
        public int GetCountFromDM(string maDM)
        {
            string query = "SELECT COUNT(MaSP) FROM SANPHAM WHERE DanhMuc= @maDM";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { maDM });
            return (int)result.Rows[0][0];
        }
        public List<SanPhamDTO> GetListSearch(string str)
        {
            string query = "SELECT * FROM SANPHAM WHERE TenSP LIKE '%"+str+"%' OR MaSP LIKE '%"+str+"%'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            List<SanPhamDTO> list = new List<SanPhamDTO>();
            foreach (DataRow row in result.Rows)
            {
                list.Add(new SanPhamDTO(row, DanhMucDAO.Instance.GetDanhMuc((string)row["DanhMuc"])));
            }
            return list;
        }
    }
}
