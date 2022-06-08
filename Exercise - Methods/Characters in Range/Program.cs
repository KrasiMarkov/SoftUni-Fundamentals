using System;

namespace Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());
            
            SymbolsFromASCII(firstSymbol, secondSymbol);


        }

        static void SymbolsFromASCII(char firstSymbol, char secondSymbol)
        {
            int asciiFirstSymbol = Math.Min(firstSymbol, secondSymbol);
            int asciiSecondSymbol = Math.Max(firstSymbol, secondSymbol);

            for (int i = asciiFirstSymbol + 1; i < asciiSecondSymbol; i++)
            {
                char newSymbol = (char)i;
                Console.Write($"{newSymbol} ");
            }
            
        }
    }
}
