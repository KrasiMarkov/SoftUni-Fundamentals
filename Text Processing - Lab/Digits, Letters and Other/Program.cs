using System;

namespace Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            string digits = "";

            string letters = "";

            string othersSymbols = "";

            for (int i = 0; i < word.Length; i++)
            {
                char symbol = word[i];

                if (char.IsDigit(symbol))
                {
                    digits += symbol;
                }

                else if (char.IsLetter(symbol))
                {
                    letters += symbol;
                }

                else if (char.IsSymbol(symbol))
                {
                    othersSymbols += symbol;
                }

                else if (char.IsPunctuation(symbol))
                {
                    othersSymbols += symbol;
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(othersSymbols);

        }
    }
}
