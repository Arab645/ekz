using System;
using System.Collections.Generic;

namespace LAB7part2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Repository<int> intRepository = new Repository<int>();
            intRepository.Add(1);
            intRepository.Add(5);
            intRepository.Add(10);

            Criteria<int> criteria = x => x > 3;

            List<int> result = intRepository.Find(criteria);

            Console.WriteLine("Elements that satisfy the criteria:");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

    }
}