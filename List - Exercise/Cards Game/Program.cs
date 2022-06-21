using System;
using System.Linq;
using System.Collections.Generic;
namespace Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> secondNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();


            while (firstNumbers.Count != 0 && secondNumbers.Count != 0)
            {
                int currentFirstNumber = firstNumbers[0];

                int currentSecondNumber = secondNumbers[0];

                if (currentFirstNumber > currentSecondNumber)
                {
                    firstNumbers.Add(currentFirstNumber);
                    firstNumbers.Add(currentSecondNumber);
                    firstNumbers.RemoveAt(0);
                    secondNumbers.RemoveAt(0);
                }

                else if (currentFirstNumber < currentSecondNumber)
                {
                    secondNumbers.Add(currentSecondNumber);
                    secondNumbers.Add(currentFirstNumber);
                    secondNumbers.RemoveAt(0);
                    firstNumbers.RemoveAt(0);
                }
                else
                {
                    firstNumbers.RemoveAt(0);
                    secondNumbers.RemoveAt(0);
                }


            }

            if (firstNumbers.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstNumbers.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondNumbers.Sum()}");
                
            }










        }
    }
}
