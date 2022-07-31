using System;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string finalStr = "";

            for (int i = 0; i < text.Length; i++)
            {
                int symbol = text[i];

                symbol += 3;

                char newSymbol = (char)symbol;

                finalStr += newSymbol;

            }

            Console.WriteLine(finalStr);
        }
    }
}
