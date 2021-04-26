using System;

namespace DBConnection
{
    class Program
    {
        static void Main(string [] args)
        {
            DbCommand sqlCommand = new DbCommand(new SqlConnection("127.0.0.1"), "SELECT * FROM...");
            sqlCommand.Execute();

            DbCommand oracleCommand = new DbCommand(new OracleConnection("456.1.1.2"), "INSERT INTO...");
            oracleCommand.Execute();

        }
    }
}
