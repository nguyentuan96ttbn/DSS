using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
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
            string[] lines = File.ReadAllLines("../../ConnectDB/Config.txt", Encoding.UTF8);
            string datasource = ".\\"+lines[0];
            string database = lines[1];
            string connString = @"Server=" +datasource + ";Database=" + database + ";Trusted_Connection=True;";
            _conn = new SqlConnection(connString);
        }
    }
}
