namespace LAB8part4
{
    using System;

    public class JSONAdapter : DataAdapter
    {
        public DataTemplate Convert(DataTemplate sourceData)
        {
            Console.WriteLine("Converting JSON data to the target format");
            DataTemplate targetData = sourceData.Clone();
            targetData.FillData(); 
            return targetData;
        }
    }

}