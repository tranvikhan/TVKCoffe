using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVKCoffe.DTO;

namespace TVKCoffe.DAO
{
    class KhuVucDAO
    {
        private static KhuVucDAO instance;

        public static KhuVucDAO Instance
        {
            get
            {
                if (instance == null) instance = new KhuVucDAO();
                return instance;
            }
            private set => instance = value;
        }
        private KhuVucDAO() { }
        public KhuVucDTO GetKhuVuc(string MaKV)
        {
            string query = "SELECT * FROM KHUVUC WHERE MaKV= @MaVK";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { MaKV });
            return new KhuVucDTO(result.Rows[0]);
        }
        public List<KhuVucDTO> GetListKhuVuc()
        {
            string query = "SELECT * FROM KHUVUC";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            List<KhuVucDTO> list = new List<KhuVucDTO>();
            foreach (DataRow row in result.Rows)
            {
                list.Add(new KhuVucDTO(row));
            }
            return list;
        }
        public int getNewCode()
        {
            string query = "Select MaKV from KHUVUC";
            string ma;
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            if (result.Rows.Count > 0)
                ma = (string)result.Rows[result.Rows.Count - 1]["MaKV"];
            else
                return 1;
            return Int32.Parse(ma.Substring(2)) + 1;
        }
        public bool Insert(KhuVucDTO kv)
        {

            string query = "INSERT INTO KHUVUC VALUES( @maKV , @tenKV )";
            object[] obj = { kv.MaKV,kv.TenKV };
            int result = DataProvider.Instance.ExecuteNonQuery(query, obj);
            return result > 0;
        }
        public bool Delete(string maKV)
        {

            string query = "DELETE FROM KHUVUC WHERE MaKV= @maKV";
            object[] obj = { maKV};
            int result = DataProvider.Instance.ExecuteNonQuery(query, obj);
            return result > 0;
        }
        public bool Update(KhuVucDTO kv)
        {

            string query = "UPDATE KHUVUC SET TenKV= @tenKV WHERE MaKV= @MaKV";
            object[] obj = { kv.TenKV, kv.MaKV };
            int result = DataProvider.Instance.ExecuteNonQuery(query, obj);
            return result > 0;
        }
    }
}
