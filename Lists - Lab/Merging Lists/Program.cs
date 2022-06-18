using System;
using System.Linq;
using System.Collections.Generic;
namespace Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstNumber = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondNumber = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> thirdNumber = new List<int>();

            for (int i = 0; i < Math.Max(firstNumber.Count, secondNumber.Count); i++)
            {
                if (i < firstNumber.Count)
                {
                    thirdNumber.Add(firstNumber[i]);
                }
                if (i < secondNumber.Count)
                {
                    thirdNumber.Add(secondNumber[i]);
                }

            }

            Console.WriteLine(string.Join(" ", thirdNumber));

        }
    }
}
