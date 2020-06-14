using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVKCoffe.DTO;

namespace TVKCoffe.DAO
{
    class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance {
            get { if (instance == null) instance = new NhanVienDAO(); return instance;} 
            private set => instance = value; 
        }
        private NhanVienDAO() { }
        public string Login(string TenDangNhap, string MatKhau)
        {
            string maNV = "";
            string query= "Select MaNV from NHANVIEN WHERE TenDangNhap= @Username AND MatKhau= @Password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query,new object[] {TenDangNhap,MatKhau});
            if(result.Rows.Count>0) maNV =(string)result.Rows[0]["MaNV"];
            return maNV;
        }
        public NhanVienDTO GetNhanVien(string maNV)
        {
            string query = "Select * from NHANVIEN WHERE MaNV= @maNV";
            DataTable result = DataProvider.Instance.ExecuteQuery(query,new object[] { maNV});
            return new NhanVienDTO(result.Rows[0]);
        }
        public List<NhanVienDTO> GetListNhavVien()
        {
            List<NhanVienDTO> listnv = new List<NhanVienDTO>();
            string query = "Select * from NHANVIEN";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in result.Rows)
            {
                NhanVienDTO nv = new NhanVienDTO(row);
                listnv.Add(nv);
            }
            return listnv;
        }
        public int GetNewCode()
        {
            string query = "Select MaNV from NHANVIEN";
            string ma;
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            if (result.Rows.Count > 0)
                ma = (string)result.Rows[result.Rows.Count - 1]["MaNV"];
            else
                return 1;
            return Int32.Parse(ma.Substring(2))+1;
        }
        public bool Insert(NhanVienDTO nv)
        {
            
            string query = "INSERT INTO NHANVIEN VALUES( @maNV , @tenNV , @tenDangNhap , @matKhau , @gioiTinh , @email , @sodienthoai , @chucvu , @NgaySinh , @AnhDaiDien )";
            object[] obj = { nv.MaNV, nv.TenNV, nv.TenDangNhap, nv.MatKhau, ConvertDTO.Instance.ByteFromSex(nv.GioiTinh), nv.Email, nv.SoDienThoai, nv.ChucVu, nv.NgaySinh, ConvertDTO.Instance.ByteFromImage(nv.AnhDaiDien) };
            int result = DataProvider.Instance.ExecuteNonQuery(query,obj);
            return result > 0;
        }
        public bool Update(NhanVienDTO nv,string OdlCode)
        {
            string query = "UPDATE NHANVIEN SET MaNV= @maNV ,TenNV= @tenNV ,TenDangNhap= @tenDangNhap ,MatKhau= @matKhau ,GioiTinh= @gioiTinh ,Email= @email ,SoDienThoai= @sodienthoai ,ChucVu= @chucvu ,NgaySinh= @NgaySinh ,AnhDaiDien= @AnhDaiDien WHERE MaNV = @OdlCode";
            object[] obj = { nv.MaNV, nv.TenNV, nv.TenDangNhap, nv.MatKhau, ConvertDTO.Instance.ByteFromSex(nv.GioiTinh), nv.Email, nv.SoDienThoai, nv.ChucVu, nv.NgaySinh, ConvertDTO.Instance.ByteFromImage(nv.AnhDaiDien), OdlCode};
            int result = DataProvider.Instance.ExecuteNonQuery(query, obj);
            return result > 0;
        }
        public bool Delete(string maNV)
        {
            string query = "DELETE FROM NHANVIEN WHERE MaNV= @maNV";
            int result = DataProvider.Instance.ExecuteNonQuery(query,new object[] { maNV});
            return result > 0;
        }
    }
}
