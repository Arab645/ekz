using System;
namespace LAB6part3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Quaternion q1 = new Quaternion(5, 2, 1, 6);
            Quaternion q2 = new Quaternion(9, 8, 7, 7);
            Quaternion sum = QuaternionOperations.Add(q1, q2);
            Console.WriteLine($"Addition: {sum.W}, {sum.X}, {sum.Y}, {sum.Z}");
            Quaternion difference = QuaternionOperations.Subtract(q1, q2);
            Console.WriteLine($"Subtraction: {difference.W}, {difference.X}, {difference.Y}, {difference.Z}");
            Quaternion product = QuaternionOperations.Multiply(q1, q2);
            Console.WriteLine($"Multiplication: {product.W}, {product.X}, {product.Y}, {product.Z}");
        }
    }
}