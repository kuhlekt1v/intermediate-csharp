namespace Composition
{
    class Program
    {
        static void Main(string [] args)
        {
            // Two ways to handle. 

            // Option 1.
            var dbMigrator = new DbMigrator(new Logger());

            // Option 2.
            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
        }
    }
}
