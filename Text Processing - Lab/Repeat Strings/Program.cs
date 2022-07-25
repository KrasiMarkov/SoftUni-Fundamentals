using System;
using System.Linq;
using System.Collections.Generic;
namespace Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();

            string finalResult = "";

            for (int i = 0; i < words.Length; i++)
            {
                string symbols = words[i];

                int result = symbols.Length;

                for (int j = 0; j < result; j++)
                {
                    finalResult += symbols;
                }
            }

            Console.WriteLine(finalResult);
        }
    }
}
