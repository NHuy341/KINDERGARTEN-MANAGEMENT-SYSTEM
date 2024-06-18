using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class SqlConnectionData
    {
        public static  SqlConnection Connect() 
        {
            string s = @"Data Source=DESKTOP-090D3KQ\NHATHUY;Initial Catalog = TRUONGMAMNON;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(s);
            return conn;
        }
    }
    public class DatabaseAccess
    {

    }
}
