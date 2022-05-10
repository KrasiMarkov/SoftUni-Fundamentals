using System;

namespace Reversed_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string sumOfSymbols = "";

            for (int i = 1; i <= 3; i++)
            {
                char symbols = char.Parse(Console.ReadLine());
                sumOfSymbols = sumOfSymbols + symbols;
            }
            
            for (int i = sumOfSymbols.Length - 1; i >= 0; i--)
            {

                char reversedChar = sumOfSymbols[i];

                Console.Write($"{reversedChar} ");
            }
            
        }
    }
}
