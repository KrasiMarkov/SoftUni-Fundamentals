using System;
using System.Collections.Generic;
using System.Linq;
namespace Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(n => n).ToList();

            if (numbers.Count >= 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
            }

            else
            {
                Console.WriteLine(string.Join(" ", numbers));
            }

        }
    }
}
