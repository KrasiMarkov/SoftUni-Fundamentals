using System;
using System.Collections.Generic;
using System.Linq;
namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();

            string firstWord = words[0];

            string secondWord = words[1];

            if (firstWord.Length == secondWord.Length)
            {
                int result = 0;


                for (int i = 0; i < firstWord.Length; i++)
                {
                    int symbolFirstWord = firstWord[i];

                    int symbolSecondWord = secondWord[i];

                    result = result + symbolFirstWord * symbolSecondWord;


                }
                Console.WriteLine(result);

            }

            else
            {
                int total = 0;

                for (int i = 0; i < Math.Min(firstWord.Length, secondWord.Length); i++)
                {
                    int symbolFirstWord = firstWord[i];

                    int symbolSecondWord = secondWord[i];

                    total = total + symbolFirstWord * symbolSecondWord;





                }

                string maxStr = "";

                if (firstWord.Length > secondWord.Length)
                {
                    maxStr = firstWord;
                }
                else if (secondWord.Length > firstWord.Length)
                {
                    maxStr = secondWord;
                }

                for (int i = Math.Min(firstWord.Length, secondWord.Length); i < Math.Max(firstWord.Length, secondWord.Length); i++)
                {
                    int symbol = maxStr[i];

                    total += symbol;


                }

                Console.WriteLine(total);
            }
        }
    }
}
