using System;
using System.Linq;


namespace LAB6part2
{
    public class MathOperations
    {
        public T Add<T>(T a, T b)
        {
            if (typeof(IConvertible).IsAssignableFrom(typeof(T)))
            {
                dynamic dynamicA = Convert.ChangeType(a, typeof(T));
                dynamic dynamicB = Convert.ChangeType(b, typeof(T));
                return (T)(dynamicA + dynamicB);
            }
            else
            {
                throw new ArgumentException("Type T must implement IConvertible");
            }
        }

        public T[] Add<T>(T[] array1, T[] array2)
        {
            if (array1.Length != array2.Length)
            {
                throw new ArgumentException("Arrays must have the same length");
            }

            T[] result = new T[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                result[i] = Add(array1[i], array2[i]);
            }

            return result;
        }

        public T[,] Add<T>(T[,] matrix1, T[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);

            if (rows != matrix2.GetLength(0) || cols != matrix2.GetLength(1))
            {
                throw new ArgumentException("Matrices must have the same dimensions");
            }

            T[,] result = new T[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = Add(matrix1[i, j], matrix2[i, j]);
                }
            }

            return result;
        }
    }
}