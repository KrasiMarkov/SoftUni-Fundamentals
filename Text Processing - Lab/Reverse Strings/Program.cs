using System;

namespace Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string result = "";

                string word = Console.ReadLine();

                if (word == "end")
                {
                    break;
                }

                for (int i = word.Length - 1; i >= 0; i--)
                {
                    char symbol = word[i];

                    result = result + symbol;
                }

                Console.WriteLine($"{word} = {result}");

            }
        }
    }
}
