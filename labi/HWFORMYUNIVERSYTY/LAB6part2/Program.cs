using System;

namespace LAB6part2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MathOperations mathOperations = new MathOperations();

            int num1 = 5, num2 = 10;
            Console.WriteLine($"Addition of numbers: {mathOperations.Add(num1, num2)}");

            double[] array1 = { 1.5, 2.5, 3.5 };
            double[] array2 = { 0.5, 1.5, 2.5 };
            var resultArray = mathOperations.Add(array1, array2);
            Console.WriteLine("Addition of arrays: " + string.Join(", ", resultArray));

            int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
            int[,] matrix2 = { { 5, 6 }, { 7, 8 } };
            var resultMatrix = mathOperations.Add(matrix1, matrix2);
            Console.WriteLine("Addition of matrices:");
            PrintMatrix(resultMatrix);
        }

        static void PrintMatrix<T>(T[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}