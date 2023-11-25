namespace LAB8part4
{
    using System;

    public interface DataTemplate
    {
        DataTemplate Clone();
        void FillData();
        void DisplayData();
    }

}