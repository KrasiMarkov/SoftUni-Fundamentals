using System;
using System.Linq;
using System.Collections.Generic;
namespace Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();

            Dictionary<char, int> total = new Dictionary<char, int>();

            for (int i = 0; i < words.Count; i++)
            {
                string name = words[i];

                for (int j = 0; j < name.Length; j++)
                {
                    char symbol = name[j];

                    if (!total.ContainsKey(symbol))
                    {
                        total[symbol] = 1;
                    }

                    else
                    {
                        total[symbol]++;
                    }

                }
            }

            foreach (var item in total)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
