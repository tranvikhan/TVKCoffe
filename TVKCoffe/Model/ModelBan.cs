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
    class ModelBan
    {
        public static DataTable GetBanKV(string MaKV)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BAN WHERE KhuVuc='"+MaKV+"'", conn);
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
        public static DataTable GetBanHoatDong()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BAN WHERE TrangThai=1", conn);
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
        public static DataTable GetBan(string MaBan)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT BAN.TenBan,BAN.TrangThai,KHUVUC.TenKV,KHUVUC.MaKV FROM(BAN INNER JOIN KHUVUC ON BAN.KhuVuc = KHUVUC.MaKV) WHERE MaBan = '"+MaBan+"'", conn);
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
        public static void TrangThai(string MaBan,int key)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                string sql = "UPDATE BAN SET TrangThai="+key.ToString()+" WHERE MaBan='"+MaBan+"'";
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
                    MessageBox.Show("Lỗi set trạng thái!");
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
