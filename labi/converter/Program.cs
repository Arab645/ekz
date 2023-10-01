using System;
namespace converter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Converter converter = new Converter(37.6, 40.5, 9.3);

            Console.Write("Enter your money: ");
            double userInput = Convert.ToDouble(Console.ReadLine());

            double userDollar = converter.ChangeUahInUsd(userInput);
            double userEuro = converter.ChangeUahInEuro(userInput);
            double userPln = converter.ChangeUahInPln(userInput);
            
            Console.WriteLine($"{userInput} UAH - {userDollar} USD");
            Console.WriteLine($"{userInput} UAH - {userEuro} EURO");
            Console.WriteLine($"{userInput} UAH - {userPln} PLN");
        }
    }
}