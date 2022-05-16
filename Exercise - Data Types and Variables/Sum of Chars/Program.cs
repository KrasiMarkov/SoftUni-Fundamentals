using System;

namespace Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                char symbols = char.Parse(Console.ReadLine());
                int intSymbols = symbols;
                sum = sum + intSymbols;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
