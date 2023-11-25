namespace LAB8part4
{
    using System;

    public class JSONData : DataTemplate
    {
        private string jsonData;

        public DataTemplate Clone()
        {
            return new JSONData();
        }

        public void FillData()
        {
            Console.WriteLine("Filling JSON data");
            jsonData = "JSON Data";
        }

        public void DisplayData()
        {
            Console.WriteLine($"Displaying JSON data: {jsonData}");
        }
    }

}