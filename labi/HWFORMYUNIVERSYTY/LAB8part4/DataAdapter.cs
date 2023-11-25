namespace LAB8part4
{
    using System;

    public interface DataAdapter
    {
        DataTemplate Convert(DataTemplate sourceData);
    }
}