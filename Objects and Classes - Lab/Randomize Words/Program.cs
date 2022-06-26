using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
namespace Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().ToList();

            var random = new Random();

            for (int i = 0; i < list.Count; i++)
            {
                var randomIndex = random.Next(0, list.Count);

                var randomWord = list[randomIndex];

                var word = list[i];

                list[randomIndex] = word;

                list[i] = randomWord;

            }
            foreach (var words in list)
            {
                Console.WriteLine(words);
            }
        }
    }
}
