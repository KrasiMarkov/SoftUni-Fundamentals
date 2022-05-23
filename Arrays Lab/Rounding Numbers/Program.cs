using System;

namespace Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string row = Console.ReadLine();
            string[] numbersAsText = row.Split();
            double[] numbers = new double[numbersAsText.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(numbersAsText[i]);
                Console.WriteLine($"{numbers[i]} => {Math.Round(numbers[i], MidpointRounding.AwayFromZero)}");

            }





        }
    }
}
