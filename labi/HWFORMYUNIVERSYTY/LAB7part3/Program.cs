using System;
namespace LAB7part3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            FunctionCache<string, int> cache = new FunctionCache<string, int>();
            Func<string, int> customFunction = key =>
            {
                Console.WriteLine($"Executing custom function for key: {key}");
                return key.Length;
            };
            string key1 = "hello";
            int result1 = cache.GetOrCreate(key1, customFunction, TimeSpan.FromSeconds(5));
            Console.WriteLine($"Result for key '{key1}': {result1}");
            int result2 = cache.GetOrCreate(key1, customFunction, TimeSpan.FromSeconds(5));
            Console.WriteLine($"Result for key '{key1}' (from cache): {result2}");
            string key2 = "world";
            int result3 = cache.GetOrCreate(key2, customFunction, TimeSpan.FromSeconds(5));
            Console.WriteLine($"Result for key '{key2}': {result3}");
        }
    }
}