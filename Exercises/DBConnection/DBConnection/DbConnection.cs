using System;
using System.Collections.Generic;
using System.Text;

namespace DBConnection
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }


        public DbConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new NullReferenceException("Invalid connection string");
            else
                ConnectionString = connectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}
