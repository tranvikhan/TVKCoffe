using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVKCoffe.DatabaseConnection;

namespace TVKCoffe.Model
{
    class ModelOrder
    {
        public static DataTable GetOrder(string MaBan)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [ORDER] WHERE MaOrder='" + MaBan + "'", conn);
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
        public static DataTable GetChiTiet(string MaOrder)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT  CHITIETORDER.MaCT,CHITIETORDER.MaSp,CHITIETORDER.ThoiGian,SoLuong,GhiChu,SANPHAM.TenSP,SANPHAM.GiaBan FROM (CHITIETORDER INNER JOIN SANPHAM ON CHITIETORDER.MaSp = SANPHAM.MaSP) WHERE MaOrder='" + MaOrder+"'", conn);
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
        public static DataTable GetChiTiet2(string MaCT)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT MaCT,MaSp,ThoiGian,SoLuong,GhiChu FROM CHITIETORDER WHERE MaCT=" + MaCT, conn);
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
        public static void XoaItem(string code)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                string sql = "DELETE FROM CHITIETORDER WHERE MaCT="+code;
                // Tạo một đối tượng Command.
                SqlCommand cmd = new SqlCommand();
                // Liên hợp Command với Connection.
                cmd.Connection = conn;
                cmd.CommandText = sql;
                if (cmd.ExecuteNonQuery() == 1)
                {
                }
                else
                {
                    MessageBox.Show("Lỗi xóa dữ liệu!");
                }
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
        }

        public static void TaoOrder(string MaBan,string MaKH)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                DateTime time = DateTime.Now;
                string sql = "INSERT INTO [ORDER] VALUES('"+MaBan+"',@time,'"+MaKH+"',0,0)";
                // Tạo một đối tượng Command.
                SqlCommand cmd = new SqlCommand();
                // Liên hợp Command với Connection.
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@time", time);
                if (cmd.ExecuteNonQuery() == 1)
                {

                }
                else
                {
                    MessageBox.Show("Lỗi them du lieu!");
                }
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
        }
        public static void ThemSanPhamVao(string MaOrder, string MaSanPham,int SoLuong,string GhiChu)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                DateTime time = DateTime.Now;
                int maCT = taoMaCTOrder();
                string sql = "INSERT INTO CHITIETORDER VALUES("+maCT+",'"+MaOrder+"',@time,'"+MaSanPham+"',"+SoLuong.ToString()+",N'"+GhiChu+"')";
                // Tạo một đối tượng Command.
                SqlCommand cmd = new SqlCommand();
                // Liên hợp Command với Connection.
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@time", time);
                if (cmd.ExecuteNonQuery() == 1)
                {

                }
                else
                {
                    MessageBox.Show("Lỗi them du lieu!");
                }
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
        }
        private static int taoMaCTOrder()
        {
            int ma=0;
            DataTable dt = new DataTable();
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                string sql = " SELECT MAX(MACT) FROM CHITIETORDER;";
                // Tạo một đối tượng Command.
                SqlCommand cmd = new SqlCommand();
                // Liên hợp Command với Connection.
                cmd.Connection = conn;
                cmd.CommandText = sql;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        try
                        {
                            ma = reader.GetInt32(0) + 1;
                        }
                        catch (Exception)
                        {
                            ma = 0;
                        }
                        
                    }
                }
            }
            catch (System.Exception)
            {
                //ThongBaoLoi
                MessageBox.Show("Lỗi tạo Mã!");
            }
            finally
            {
                // Đóng kết nối.
                conn.Close();
                conn.Dispose();
            }
            return ma;
        }

        public static void SuaSanPham(string maCT, int soLuong, string ghiChu)
        {

            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                DateTime time = DateTime.Now;
               
                string sql = "UPDATE CHITIETORDER SET SoLuong="+soLuong+",GhiChu=N'"+ghiChu+"' WHERE MaCT="+maCT;
                // Tạo một đối tượng Command.
                SqlCommand cmd = new SqlCommand();
                // Liên hợp Command với Connection.
                cmd.Connection = conn;
                cmd.CommandText = sql;
                if (cmd.ExecuteNonQuery() == 1)
                {

                }
                else
                {
                    MessageBox.Show("Lỗi sua du lieu!");
                }
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
        }

        public static void Huy(string code)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                string sql = "DELETE FROM CHITIETORDER WHERE MaOrder='"+code+ "';DELETE FROM [ORDER] WHERE MaOrder='"+code+"';";
                // Tạo một đối tượng Command.
                SqlCommand cmd = new SqlCommand();
                // Liên hợp Command với Connection.
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

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
        }
    }
}
