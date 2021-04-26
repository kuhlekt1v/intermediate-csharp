using System;

namespace DBConnection
{
    public class DbCommand
    {
        public string DbInstruction {get; set;}
        public DbConnection DbConnection { get; set; }

        public DbCommand(DbConnection dbConnection, string instructions)
        {
            if (dbConnection == null || String.IsNullOrWhiteSpace(instructions))
                throw new ArgumentNullException("A connection string and a command are required");
            else
            {
                DbInstruction = instructions;
                DbConnection = dbConnection;
            }
        }
        
        public void Execute()
        {
            DbConnection.OpenConnection();
            Console.WriteLine("QUERY: {0}", DbInstruction);
            DbConnection.CloseConnection();
        }
    }
}
