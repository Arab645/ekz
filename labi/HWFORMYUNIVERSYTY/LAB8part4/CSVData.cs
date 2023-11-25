namespace LAB8part4
{
    using System;

    public class CSVData : DataTemplate
    {
        private string csvData;

        public DataTemplate Clone()
        {
            return new CSVData();
        }

        public void FillData()
        {
            Console.WriteLine("Filling CSV data");
            csvData = "CSV Data";
        }

        public void DisplayData()
        {
            Console.WriteLine($"Displaying CSV data: {csvData}");
        }
    }

}