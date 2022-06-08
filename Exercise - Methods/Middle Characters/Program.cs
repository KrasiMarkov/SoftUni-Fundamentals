using System;

namespace Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            PrintMiddleCharacter(text);
        }

        static void PrintMiddleCharacter(string text)
        {
            if (text.Length % 2 == 0)
            {
                char firstSymbol = text[text.Length / 2 - 1];
                char secondSymbol = text[text.Length / 2];
                Console.WriteLine($"{firstSymbol}{secondSymbol}");
            }
            else
            {
                char symbol = text[text.Length / 2];
                Console.WriteLine($"{symbol}");
            }
        }
    }
}
