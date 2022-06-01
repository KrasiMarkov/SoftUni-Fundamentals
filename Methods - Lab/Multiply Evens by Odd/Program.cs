using System;

namespace Multiply_Evens_by_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int endNumber = Math.Abs(number);
            int rezult = GetMultipleOfEvenAndOdds(endNumber);
            Console.WriteLine(rezult);


        }

        static int GetMultipleOfEvenAndOdds(int endNumber)
        {
            int rezult = GetSumOfEvenDigits(endNumber) * GetSumOfOddDigits(endNumber);
            return rezult;


        }
        static int GetSumOfEvenDigits(int endNumber)
        {
            string numberToString = endNumber.ToString();
            int sumOfEvenDigits = 0;
            for (int i = 0; i < numberToString.Length; i++)
            {
                char symbol = numberToString[i];
                int symbolToInt = int.Parse(symbol.ToString());
                if (symbolToInt % 2 == 0)
                {
                    sumOfEvenDigits += symbolToInt;
                }
                else
                {
                    continue;
                }
                

            }
            return sumOfEvenDigits;


        }

        static int GetSumOfOddDigits(int endNumber)
        {
            string numberToString = endNumber.ToString();
            int sumOfOddDigits = 0;
            for (int i = 0; i < numberToString.Length; i++)
            {
                char symbol = numberToString[i];
                int symbolToInt = int.Parse(symbol.ToString());
                if (symbolToInt % 2 == 1)
                {
                    sumOfOddDigits += symbolToInt;
                }
                else
                {
                    continue;
                }
                
            }
            return sumOfOddDigits;
        }
    }
}
