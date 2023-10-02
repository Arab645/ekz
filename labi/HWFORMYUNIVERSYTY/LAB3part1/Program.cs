using System;
namespace LAB3part1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the length of the first side of the rectangle: ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the length of the second side of the rectangle: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);

            Console.WriteLine($"Rectangle's Area: {rectangle.Area}");
            Console.WriteLine($"Rectangle's Perimeter: {rectangle.Perimeter}");
        }
    }
}