using System;
namespace LAB8part1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Configuration Manager Console App!");
            Console.WriteLine("----------------------------------------------");

            var configManager1 = ConfigurationManager.Instance;
            configManager1.LoggingMode = "Verbose";
            configManager1.DatabaseConnection = "SQL Server";

            var configManager2 = ConfigurationManager.Instance;
            Console.WriteLine("\nUsing the same instance:");
            Console.WriteLine($"Logging mode: {configManager2.LoggingMode}");
            Console.WriteLine($"Database connection: {configManager2.DatabaseConnection}");

            Console.WriteLine("\nEnter new configuration settings:");
            Console.Write("Logging mode: ");
            configManager1.LoggingMode = Console.ReadLine();
            Console.Write("Database connection: ");
            configManager1.DatabaseConnection = Console.ReadLine();

            Console.WriteLine("\nUsing the same instance after changes:");
            Console.WriteLine($"Logging mode: {configManager2.LoggingMode}");
            Console.WriteLine($"Database connection: {configManager2.DatabaseConnection}");
        }
    }
}