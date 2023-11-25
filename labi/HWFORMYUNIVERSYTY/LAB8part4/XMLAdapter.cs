namespace LAB8part4
{
    using System;

    public class XMLAdapter : DataAdapter
    {
        public DataTemplate Convert(DataTemplate sourceData)
        {
            Console.WriteLine("Converting XML data to the target format");
            DataTemplate targetData = sourceData.Clone();
            targetData.FillData(); 
            return targetData;
        }
    }

}