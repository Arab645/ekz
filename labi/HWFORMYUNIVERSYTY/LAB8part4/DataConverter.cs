namespace LAB8part4
{
    using System;

    public class DataConverter
    {
        public static void ConvertData(DataTemplate sourceData, DataAdapter adapter)
        {
            Console.WriteLine("Starting data conversion...");
            DataTemplate targetData = adapter.Convert(sourceData);
            Console.WriteLine("Converted data:");
            targetData.DisplayData();
        }
    }

}