using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVKCoffe.DatabaseConnection;

namespace TVKCoffe.Model
{
    class ModelNhanVien
    {
        private string tenNV;
        private  Image AnhDaiDien = null;
    
        public static string CheckLogin(String Username, String Password)
        {
            string maNV ="";
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                string sql = "Select MaNV from NHANVIEN WHERE TenDangNhap='" + Username+ "' AND MatKhau='" + Password+ "'";
                // Tạo một đối tượng Command.
                SqlCommand cmd = new SqlCommand();
                // Liên hợp Command với Connection.
                cmd.Connection = conn;
                cmd.CommandText = sql;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                      while(reader.Read())
                        maNV = reader.GetString(0);
                        
                    }
                }

            }
            catch (System.Exception)
            {
                //ThongBaoLoi
                MessageBox.Show("Kết nối thất bại");
            }
            finally
            {
                // Đóng kết nối.
                conn.Close();
                conn.Dispose();
            }
            return maNV;
        }
        // .........................................
        public ModelNhanVien(String MaNV)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                string sql = "Select TenNV,AnhDaiDien from NHANVIEN WHERE MaNV='" + MaNV +"'";
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
                        this.tenNV = reader.GetString(0);
                        byte[] img = (byte[])(reader[1]);
                        if (img == null)
                        {
                            this.AnhDaiDien = null;

                        }
                        else
                        {
                            MemoryStream ms = new MemoryStream(img);
                            this.AnhDaiDien = Image.FromStream(ms);

                        }
                    }
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
        public string getTenNV()
        {
            return this.tenNV;
        }
        public Image getAnhDaiDien()
        {
            return this.AnhDaiDien;
        }
        public static DataTable GetDuLieu()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NHANVIEN",conn);
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
        public static DataTable GetDuLieu(string MaNV)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NHANVIEN WHERE MaNV='"+MaNV+"'", conn);
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
        public static int getMaNVMoi()
        {
            string ma = "";
            int CodeNo = 0;
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                string sql = "Select MaNV from NHANVIEN";
                // Tạo một đối tượng Command.
                SqlCommand cmd = new SqlCommand();
                // Liên hợp Command với Connection.
                cmd.Connection = conn;
                cmd.CommandText = sql;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ma = reader.GetString(0);
                            if (Int32.Parse(ma.Substring(2)) > CodeNo) CodeNo = Int32.Parse(ma.Substring(2));
                        }
                      
                    }
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
            
            return CodeNo;
        }
        public static void ThemNhanVien(string maNV,string TenNV,string TenDangNhap,string MatKhau,bool GioiTinh,string Email,string SoDienThoai,string ChucVu, DateTime date, byte[] img)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                int GTinh = 0;
                if (GioiTinh) GTinh = 1; else GTinh = 0;
                string sql = "INSERT INTO NHANVIEN VALUES('"+maNV+"',N'"+TenNV+"','"+TenDangNhap+"','"+MatKhau+"',"+GTinh+",'"+Email+"','"+SoDienThoai+"',N'"+ChucVu+"',@date,@img)";
                // Tạo một đối tượng Command.
                SqlCommand cmd = new SqlCommand();
                // Liên hợp Command với Connection.
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new SqlParameter("@img",img));
                cmd.Parameters.AddWithValue("@date", date);
                if (cmd.ExecuteNonQuery()==1)
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
        public static void SuaNhanVien(string maSua,string maNV, string TenNV, string TenDangNhap, string MatKhau, bool GioiTinh, string Email, string SoDienThoai, string ChucVu, DateTime date, byte[] img,bool mode)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try 
            {
                int GTinh = 0;
                string sql;
                // Tạo một đối tượng Command.
                SqlCommand cmd = new SqlCommand();
                
                
                if (GioiTinh) GTinh = 1; else GTinh = 0;
                if (mode)
                {
                    sql = "UPDATE NHANVIEN SET TenNV = N'" + TenNV + "',TenDangNhap='" + TenDangNhap + "',MatKhau='" + MatKhau + "',GioiTinh=" + GTinh + ",Email='" + Email + "',SoDienThoai='" + SoDienThoai + "',ChucVu = N'" + ChucVu + "',NgaySinh =@date,AnhDaiDien=@img WHERE MaNV ='" + maNV + "'";
                    cmd.Parameters.Add(new SqlParameter("@img", img));
                }     
                else
                    sql = "UPDATE NHANVIEN SET MaNV='"+maNV+"',TenNV = N'" + TenNV + "',TenDangNhap='" + TenDangNhap + "',MatKhau='" + MatKhau + "',GioiTinh=" + GTinh + ",Email='" + Email + "',SoDienThoai='" + SoDienThoai + "',ChucVu = N'" + ChucVu + "',NgaySinh =@date WHERE MaNV ='" + maSua + "'";
                // Liên hợp Command với Connection.
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@date", date);
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
        public static void XoaNhanVien(string maNV)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                
                string sql = "DELETE NHANVIEN WHERE MaNV='"+maNV+"'";
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

    }
}
