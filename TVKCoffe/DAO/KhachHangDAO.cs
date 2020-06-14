using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVKCoffe.DTO;

namespace TVKCoffe.DAO
{
    class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get
            {
                if (instance == null) instance = new KhachHangDAO();
                return instance;
            }
            private set => instance = value;
        }
        public KhachHangDTO GetKhach(string maKH)
        {
            string query = "SELECT * FROM KHACHHANG WHERE MaKH = @maKH ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { maKH });
            return new KhachHangDTO(result.Rows[0]);
        }
        public List<KhachHangDTO> GetListKhach()
        {
            string query = "SELECT * FROM KHACHHANG";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            List<KhachHangDTO> list = new List<KhachHangDTO>();
            foreach(DataRow row in result.Rows)
            {
                KhachHangDTO khachhang = new KhachHangDTO(row);
                list.Add(khachhang);
            }
            return list;
        }
        public int getNewCode()
        {
            string query = "Select MaKH from KHACHHANG";
            string ma;
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            if (result.Rows.Count > 0)
                ma = (string)result.Rows[result.Rows.Count - 1]["MaKH"];
            else
                return 1;
            return Int32.Parse(ma.Substring(2)) + 1;
        }
        public bool Insert(KhachHangDTO kh)
        {
            bool gioitinh = ConvertDTO.Instance.LogicFromSex(kh.GioiTinh);
            string query = "INSERT INTO KHACHHANG VALUES( @MaKH , @TenKH , @gioTinh , @email , @sodienthoai , @ngaysinh , @diachi , @masothue , @thue , @chietkhau );";
            object[] obj = { kh.MaKH, kh.TenKH, gioitinh, kh.Email, kh.SoDienThoai,kh.NgaySinh, kh.DiaChi, kh.MaSoThue, kh.Thue, kh.ChietKhau };
            int result = DataProvider.Instance.ExecuteNonQuery(query,obj);
            return result>0;
        }
        public bool Delete(string maKH)
        {
            string query = "DELETE FROM KHACHHANG WHERE MaKH = @MaKH";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maKH });
            return result > 0;
        }
        public bool Update(KhachHangDTO kh)
        {
            bool gioitinh = ConvertDTO.Instance.LogicFromSex(kh.GioiTinh);
            string query = "UPDATE KHACHHANG SET TenKH= @TenKH ,GioiTinh= @gioTinh ,Email= @email ,SoDienThoai= @sodienthoai ,NgaySinh= @ngaysinh ,DiaChi= @diachi ,MaSoThue= @masothue ,Thue= @thue ,ChietKhau= @chietkhau WHERE MaKH= @MaKH";
            object[] obj = {kh.TenKH, gioitinh, kh.Email, kh.SoDienThoai, kh.NgaySinh, kh.DiaChi, kh.MaSoThue, kh.Thue, kh.ChietKhau, kh.MaKH };
            int result = DataProvider.Instance.ExecuteNonQuery(query, obj);
            return result > 0;
        }
    }
}
