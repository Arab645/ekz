namespace LAB8part1
{
    using System;

    public class ConfigurationManager
    {
        private static ConfigurationManager instance;
        private string loggingMode;
        private string databaseConnection;

        private ConfigurationManager() { }

        public static ConfigurationManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ConfigurationManager();
                }
                return instance;
            }
        }

        public string LoggingMode
        {
            get { return loggingMode; }
            set
            {
                loggingMode = value;
                Console.WriteLine($"Logging mode set to: {loggingMode}");
            }
        }

        public string DatabaseConnection
        {
            get { return databaseConnection; }
            set
            {
                databaseConnection = value;
                Console.WriteLine($"Database connection set to: {databaseConnection}");
            }
        }
    }
}