using System;
using System.Linq;
using System.Collections.Generic;
namespace Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            SortedDictionary<double, int> count = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!count.ContainsKey(number))
                {
                    count[number] = 1;
                }
                else
                {
                    count[number]++;
                }


            }

            foreach (var item in count)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
