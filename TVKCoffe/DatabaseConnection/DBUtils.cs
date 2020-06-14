using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVKCoffe.DatabaseConnection
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"localhost\SQLEXPRESS";
            string database = "TVKCOFFE";
            string username = "AdminTVK";
            string password = "admin";

            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }
}
