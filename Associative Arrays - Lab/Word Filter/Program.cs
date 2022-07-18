using System;
using System.Collections.Generic;
using System.Linq;
namespace Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();

            string[] filtredData = words.Where(x => x.Length % 2 == 0).ToArray();

            foreach (var item in filtredData)
            {
                Console.WriteLine(item);
            }

        }
    }
}
