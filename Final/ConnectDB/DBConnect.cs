using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.ConnectDB
{
    class DBConnect
    {
        public SqlConnection _conn;

        public DBConnect()
        {
            string datasource = @".\SQLEXPRESS";
            string database = "DSS";
            string connString = @"Server=" + datasource + ";Database=" + database + ";Trusted_Connection=True;";
            _conn = new SqlConnection(connString);
        }
    }
}
