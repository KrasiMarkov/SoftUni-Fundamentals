using System;
using System.Linq;
using System.Collections.Generic;
namespace Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                int oneNumber = numbers[i];
                if (oneNumber < 0)
                {
                    numbers.RemoveAt(i);
                    i = -1;
                }


            }

            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                numbers.Reverse();
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
