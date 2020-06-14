using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVKCoffe.DatabaseConnection;

namespace TVKCoffe.Model
{
    class ModelSanPham
    {
        public static DataTable GetSanPhamOfDM(string MaDM)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT MaSP,TenSP,GiaBan,Mau FROM SANPHAM WHERE DanhMuc='"+MaDM+"'", conn);
                da.Fill(dt);

            }
            catch (System.Exception)
            {
                //ThongBaoLoi
                MessageBox.Show("Lỗi !");
            }
            finally
            {
                // Đóng kết nối.
                conn.Close();
                conn.Dispose();
            }
            return dt;
        }
        public static DataTable GetSanPham(string MaSP)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SANPHAM WHERE MaSP='" + MaSP + "'", conn);
                da.Fill(dt);

            }
            catch (System.Exception)
            {
                //ThongBaoLoi
                MessageBox.Show("Lỗi !");
            }
            finally
            {
                // Đóng kết nối.
                conn.Close();
                conn.Dispose();
            }
            return dt;
        }
    }
}
