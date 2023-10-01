using System;

namespace hwForUniversity
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Address myAddress = new Address();
            
            myAddress.Index = 1234;
            myAddress.Country = "Ukraine";
            myAddress.City = "Kyiv";
            myAddress.Street = "Shevchenko";
            myAddress.House = "Loud";
            myAddress.Apartment = "Cozy";

            Console.WriteLine($"Index: {myAddress.Index}");
            Console.WriteLine($"Country: {myAddress.Country}");
            Console.WriteLine($"City: {myAddress.City}");
            Console.WriteLine($"Street: {myAddress.Street}");
            Console.WriteLine($"House: {myAddress.House}");
            Console.WriteLine($"Apartment: {myAddress.Apartment}");
        }
    }
}