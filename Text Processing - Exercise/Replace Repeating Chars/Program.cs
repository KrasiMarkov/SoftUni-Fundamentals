using System;

namespace Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string sequence = Console.ReadLine();

            string result = "";

            char lastSymbol = '!';

            for (int i = 0; i < sequence.Length; i++)
            {
                char symbol = sequence[i];

                if (symbol == lastSymbol)
                {
                    continue;
                }

                result += symbol;

                lastSymbol = symbol;
            }

            Console.WriteLine(result);
        }
    }
}
