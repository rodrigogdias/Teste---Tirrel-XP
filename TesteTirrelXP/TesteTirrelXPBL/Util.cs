using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTirrelXPBL
{
    class Util
    {
        public static SqlConnection ReturnConnection(String sConnectionString)
        {

            SqlConnection conn;
            //connetionString = "Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password"
            try
            {
                conn = new SqlConnection(sConnectionString);
                return conn;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
