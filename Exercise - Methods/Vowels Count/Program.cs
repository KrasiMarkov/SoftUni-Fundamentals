using System;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine().ToLower();
            Console.WriteLine(ReturnCountVowels(name));
        }

        static int ReturnCountVowels(string name)
        {
            int sum = 0;
            for (int i = 0; i < name.Length; i++)
            {
                char symbol = name[i];
                if (symbol == 'e' || symbol == 'a' || symbol == 'i' || symbol == 'u' || symbol == 'o')
                {
                    sum++;
                }

            }
            return sum;
        }
    }
}
