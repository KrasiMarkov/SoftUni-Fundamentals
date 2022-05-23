using System;
using System.Linq;
namespace Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                
                int otherNumber = numbers[i];
                if (otherNumber % 2 == 0)
                {
                    sum += otherNumber;
                }
            }
            Console.WriteLine($"{sum}");
        }
    }
}
