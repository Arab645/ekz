namespace LAB8part4
{
    using System;

    public class XMLData : DataTemplate
    {
        private string xmlData;

        public DataTemplate Clone()
        {
            return new XMLData();
        }

        public void FillData()
        {
            Console.WriteLine("Filling XML data");
            xmlData = "XML Data";
        }

        public void DisplayData()
        {
            Console.WriteLine($"Displaying XML data: {xmlData}");
        }
    }
}