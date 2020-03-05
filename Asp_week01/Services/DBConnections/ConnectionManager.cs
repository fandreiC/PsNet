using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DBConnections
{
    class ConnectionManager
    {

        private static readonly string MyConnectionString = "Data Source=.;Initial Catalog=HW09Books;Integrated Security=True";
        private static SqlConnection Myconnection;

        public static SqlConnection GetConnection()
        {
            try
            {
                if (Myconnection == null)
                {
                    Myconnection = new SqlConnection
                    {
                        ConnectionString = MyConnectionString
                    };
                    Myconnection.Open();
                }
                return Myconnection;
            }
            catch (Exception e)
            {
                Console.WriteLine(" Error - when connecting to DB " + e.Message);
                throw;
            }

        }

    }
}
