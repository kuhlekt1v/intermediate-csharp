using System;
using System.Collections.Generic;
using System.Text;

namespace DBConnection
{
    public class SqlConnection : DbConnection
    {
        // Constructor to confirm db connection string provided.
        public SqlConnection(string connectionString) : base(connectionString)
        { 
        }

        public override void OpenConnection()
        {
            Console.WriteLine("SQL opened with connection {0}", ConnectionString);
        }

        public override void CloseConnection()
        {
            Console.WriteLine("SQL connection {0} closed.", ConnectionString);
        }
    }
}
