using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVKCoffe.DTO;

namespace TVKCoffe.DAO
{
    class BanDAO
    {
        private static BanDAO instance;

        public static BanDAO Instance
        {
            get
            {
                if (instance == null) instance = new BanDAO();
                return instance;
            }
            private set => instance = value;
        }
        private BanDAO() { }
        public BanDTO GetBan(string maBan)
        {
            string query = "SELECT * FROM BAN WHERE MaBan= @MaBan";
            DataTable result = DataProvider.Instance.ExecuteQuery (query, new object[] { maBan });
            return (new BanDTO(result.Rows[0],KhuVucDAO.Instance.GetKhuVuc((string)result.Rows[0]["KhuVuc"])));
        }
        public List<BanDTO> GetListBan(string maKV)
        {
            string query = "SELECT * FROM BAN WHERE KhuVuc= @maKV";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { maKV });
            List<BanDTO> list = new List<BanDTO>();
            foreach(DataRow row in result.Rows)
            {
                list.Add(new BanDTO(row, KhuVucDAO.Instance.GetKhuVuc((string)row["KhuVuc"])));
            }
            return list;
        }
        public List<BanDTO> GetListBan()
        {

            string query = "SELECT * FROM BAN";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            List<BanDTO> list = new List<BanDTO>();
            foreach (DataRow row in result.Rows)
            {
                list.Add(new BanDTO(row, KhuVucDAO.Instance.GetKhuVuc((string)row["KhuVuc"])));
            }
            return list;
        }
        public List<BanDTO> GetListBanActive()
        {

            string query = "SELECT * FROM BAN WHERE TrangThai = 1";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            List<BanDTO> list = new List<BanDTO>();
            foreach (DataRow row in result.Rows)
            {
                list.Add(new BanDTO(row, KhuVucDAO.Instance.GetKhuVuc((string)row["KhuVuc"])));
            }
            return list;
        }
        public List<BanDTO> GetListBanInTamTinh()
        {

            string query = "SELECT * FROM BAN WHERE TrangThai = 2";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            List<BanDTO> list = new List<BanDTO>();
            foreach (DataRow row in result.Rows)
            {
                list.Add(new BanDTO(row, KhuVucDAO.Instance.GetKhuVuc((string)row["KhuVuc"])));
            }
            return list;
        }
        public List<BanDTO> GetListBanDaThanhToan()
        {

            string query = "SELECT * FROM BAN WHERE TrangThai = 3";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            List<BanDTO> list = new List<BanDTO>();
            foreach (DataRow row in result.Rows)
            {
                list.Add(new BanDTO(row, KhuVucDAO.Instance.GetKhuVuc((string)row["KhuVuc"])));
            }
            return list;
        }
        public bool SetTrangThai(int trangthai,string maBan)
        {
            string query = "UPDATE BAN SET TrangThai= @trangthai WHERE MaBan = @maban";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { trangthai, maBan });
            return result > 0;
        }
        public int CountBanFromKV(string MaKV)
        {
            string query = "SELECT COUNT(MaBan) as SL FROM BAN WHERE KhuVuc = @maKV";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[]{ MaKV});
            return (int)result.Rows[0]["SL"];
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
            string query = "Select MaBan from BAN";
            string ma;
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            if (result.Rows.Count > 0)
                ma = (string)result.Rows[result.Rows.Count - 1]["MaBan"];
            else
                return 1;
            return Int32.Parse(ma.Substring(3)) + 1;
        }
        public bool Insert(BanDTO ban)
        {

            string query = "INSERT INTO BAN VALUES( @maBan , @tenBan , @TrangThai , @KhuVuc )";
            object[] obj = { ban.MaBan,ban.TenBan,ban.TrangThai,ban.KhuVuc.MaKV };
            int result = DataProvider.Instance.ExecuteNonQuery(query, obj);
            return result > 0;
        }
        public bool Delete(string maBan)
        {

            string query = "DELETE FROM BAN WHERE MaBan= @maBan";
            object[] obj = { maBan };
            int result = DataProvider.Instance.ExecuteNonQuery(query, obj);
            return result > 0;
        }
        public bool Update(BanDTO ban)
        {

            string query = "UPDATE BAN SET TenBan= @tenBan ,KhuVuc= @KhuVuc WHERE MaBan= @MaBan ";
            object[] obj = {  ban.TenBan,  ban.KhuVuc.MaKV , ban.MaBan};
            int result = DataProvider.Instance.ExecuteNonQuery(query, obj);
            return result > 0;
        }

    }
}
