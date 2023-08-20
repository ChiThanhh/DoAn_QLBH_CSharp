using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DO_AN.DAL
{
    public class DBConection
    {
        public DBConection()
        {
        }
        public SqlConnection CreateConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=LAPTOP-7TA8V8TO\SQLEXPRESS;Initial Catalog=QLBH; 
								User Id=sa; Password=sa";
            return conn;
        }
    }
}
