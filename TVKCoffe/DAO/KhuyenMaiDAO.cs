using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVKCoffe.DTO;

namespace TVKCoffe.DAO
{
    class KhuyenMaiDAO
    {
        private static KhuyenMaiDAO instance;

        public static KhuyenMaiDAO Instance
        {
            get
            {
                if (instance == null) instance = new KhuyenMaiDAO();
                return instance;
            }
            private set => instance = value;
        }
        public List<KhuyenMaiDTO> GetList()
        {
            List<KhuyenMaiDTO> list = new List<KhuyenMaiDTO>();
            string query = "SELECT * FROM KHUYENMAI";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in result.Rows)
            {
                KhuyenMaiDTO km = new KhuyenMaiDTO(row);
                list.Add(km);
            }
            return list;

        }
        public int getNewCode()
        {
            string query = "Select MaKM from KHUYENMAI";
            string ma;
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            if (result.Rows.Count > 0)
                ma = (string)result.Rows[result.Rows.Count - 1]["MaKM"];
            else
                return 1;
            return Int32.Parse(ma.Substring(2)) + 1;
        }
        public bool Insert(KhuyenMaiDTO km)
        {
            
            string query = "INSERT INTO KHUYENMAI VALUES( @MaKM , @TenKM , @GiaTri , @LoaiKM , @MaApDung , @BatDau , @KetThuc , @TrangThai , @TuXoa );";
            object[] obj = { km.MaKM,km.TenKM,km.GiaTri,km.LoaiKM,km.MaApDung,km.BatDau,km.KetThuc,km.TrangThai,km.TuXoa};
            int result = DataProvider.Instance.ExecuteNonQuery(query, obj);
            return result > 0;
        }
        public bool Delete(string maKM)
        {
            string query = "DELETE FROM KHUYENMAI WHERE MaKM = @MaKM";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maKM });
            return result > 0;
        }
        public void RefeshKM()
        {
            DateTime today = DateTime.Today;
            string query = "UPDATE KHUYENMAI Set TrangThai = 1 WHERE BatDau <= @today1 AND KetThuc >= @today2";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {today,today});
            query = "UPDATE KHUYENMAI Set TrangThai = 0 WHERE BatDau > @today1 OR KetThuc < @today2";
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { today, today });
            if (result > 0)
            {
                query = "DELETE FROM KHUYENMAI WHERE TuXoa=1 AND KetThuc < @today";
                result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { today});
            }
        }


    }
}
