using System;
using System.Linq;
namespace Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumEvenNumbers = 0;
            int sumOddNumbers = 0;
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int cell = numbers[i];
                if (cell % 2 == 0)
                {
                    sumEvenNumbers += cell;
                }
                else
                {
                    sumOddNumbers += cell;

                }

            }
            result = sumEvenNumbers - sumOddNumbers;
            Console.WriteLine($"{result}");
        }
    }
}
