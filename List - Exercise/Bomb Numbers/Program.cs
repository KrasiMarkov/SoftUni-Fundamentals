using System;
using System.Linq;
using System.Collections.Generic;
namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] othersNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bomb = othersNumbers[0];

            int power = othersNumbers[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                int current = numbers[i];

                if (current == bomb)
                {
                    BombNumbers(numbers, power, i);

                    
                }
            }

            Console.WriteLine(numbers.Sum());

        }

        static void BombNumbers(List<int> numbers, int power, int i)
        {
            int start = Math.Max(0, i - power);

            int end = Math.Min(numbers.Count - 1, i + power);

            for (int j = start; j <= end; j++)
            {
                numbers[j] = 0;
            }
        }
    }
}
