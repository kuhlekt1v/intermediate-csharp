using System;
using System.Collections.Generic;
using System.Text;

namespace DBConnection
{
    public class OracleConnection : DbConnection
    {
        // Constructor to confirm db connection string provided.
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Oracle opened with connection {0}", ConnectionString);
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Oracle connection {0} closed.", ConnectionString);
        }
    }
}
