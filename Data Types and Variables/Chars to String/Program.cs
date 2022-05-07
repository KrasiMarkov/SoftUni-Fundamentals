using System;

namespace Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string sumOfSymbols = "";
            for (int i = 1; i <= 3; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                sumOfSymbols = sumOfSymbols + symbol;

            }
            Console.WriteLine(sumOfSymbols);
        }
    }
}
