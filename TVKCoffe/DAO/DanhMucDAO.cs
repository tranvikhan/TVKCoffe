using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVKCoffe.DTO;

namespace TVKCoffe.DAO
{
    class DanhMucDAO
    {
        private static DanhMucDAO instance;

        public static DanhMucDAO Instance
        {
            get
            {
                if (instance == null) instance = new DanhMucDAO();
                return instance;
            }
            private set => instance = value;
        }
        public DanhMucDTO GetDanhMuc(string maDM)
        {
            string query = "SELECT * FROM DANHMUC WHERE MaDM = @maDM";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { maDM });
            return new DanhMucDTO(result.Rows[0]);
        }
        public List<DanhMucDTO> GetListDanhMuc()
        {
            string query = "SELECT * FROM DANHMUC";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            List<DanhMucDTO> list = new List<DanhMucDTO>();
            foreach(DataRow row in result.Rows)
            {
                list.Add(new DanhMucDTO(row));
            }
            return list;
        }
        public int GetNewCode()
        {
            string query = "Select MaDM from DANHMUC";
            string ma;
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            if (result.Rows.Count > 0)
                ma = (string)result.Rows[result.Rows.Count - 1]["MaDM"];
            else
                return 1;
            return Int32.Parse(ma.Substring(2)) + 1;
        }
        public bool Insert(DanhMucDTO dm)
        {
            string query = "INSERT INTO DANHMUC VALUES( @MaDM , @TenDM )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {dm.MaDM,dm.TenDM });
            return result > 0;
        }
        public bool Update(DanhMucDTO dm)
        {
            string query = "UPDATE DANHMUC SET TenDM= @TenDM WHERE MaDM= @MaDM ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {dm.TenDM, dm.MaDM});
            return result > 0;
        }
        public bool Delete(string maDM)
        {
            string query = "DELETE FROM DANHMUC WHERE MaDM= @MaDM ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maDM });
            return result > 0;
        }

    }
}
