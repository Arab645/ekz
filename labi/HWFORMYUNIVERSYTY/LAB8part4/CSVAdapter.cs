namespace LAB8part4
{
    using System;

    public class CSVAdapter : DataAdapter
    {
        public DataTemplate Convert(DataTemplate sourceData)
        {
            Console.WriteLine("Converting CSV data to the target format");
            DataTemplate targetData = sourceData.Clone();
            targetData.FillData(); 
            return targetData;
        }
    }

}