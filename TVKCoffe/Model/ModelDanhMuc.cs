﻿using System;
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
    class ModelDanhMuc
    {
        public static DataTable GetDanhMuc()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DANHMUC", conn);
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
