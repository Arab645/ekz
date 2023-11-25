using System;
namespace LAB8part4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose source data format (CSV/XML/JSON):");
            string sourceFormat = Console.ReadLine().ToUpper();

            Console.WriteLine("Choose target data format (CSV/XML/JSON):");
            string targetFormat = Console.ReadLine().ToUpper();

            DataTemplate sourceData = null;
            DataAdapter adapter = null;

            switch (sourceFormat)
            {
                case "CSV":
                    sourceData = new CSVData();
                    break;
                case "XML":
                    sourceData = new XMLData();
                    break;
                case "JSON":
                    sourceData = new JSONData();
                    break;
                default:
                    Console.WriteLine("Invalid source data format");
                    return;
            }

            switch (targetFormat)
            {
                case "CSV":
                    adapter = new CSVAdapter();
                    break;
                case "XML":
                    adapter = new XMLAdapter();
                    break;
                case "JSON":
                    adapter = new JSONAdapter();
                    break;
                default:
                    Console.WriteLine("Invalid target data format");
                    return;
            }

            DataConverter.ConvertData(sourceData, adapter);
        }
    }
}