namespace Interfaces
{
    class Program
    {
        static void Main(string [] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger("C:\\SheridanC\\log.txt"));
            dbMigrator.Migrate();
        }
    }
}
