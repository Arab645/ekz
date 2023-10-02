using System;

namespace LAB2part2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Converter converter = new Converter(37.6, 40.5, 9.3);
            Console.WriteLine("Enter your valute - uah , pln , euro , usd");
            string valute = Console.ReadLine();
            Console.Write("Enter your money: ");
            double userInput = Convert.ToDouble(Console.ReadLine());
            switch (valute)
            {
                case "uah":
                    double userDollar = converter.ChangeUahInUsd(userInput);
                    double userEuro = converter.ChangeUahInEuro(userInput);
                    double userPln = converter.ChangeUahInPln(userInput);
                    Console.WriteLine($"{userInput} UAH - {userDollar} USD");
                    Console.WriteLine($"{userInput} UAH - {userEuro} EURO");
                    Console.WriteLine($"{userInput} UAH - {userPln} PLN");
                    break;
                case "usd":
                    double userHryvnainDollar = converter.ChangeUsdInUah(userInput); 
                    Console.WriteLine($"{userInput} USD - {userHryvnainDollar} UAH");
                    break;
                case"euro":
                    double userHryvnainEuro = converter.ChangeEuroInUah(userInput); 
                    Console.WriteLine($"{userInput} EURO - {userHryvnainEuro} UAH");
                    break;
                case"pln":
                    double userHryvnainPln = converter.ChangePlnInUah(userInput); 
                    Console.WriteLine($"{userInput} PLN - {userHryvnainPln} UAH");
                    break;
            }
        }
    }
}