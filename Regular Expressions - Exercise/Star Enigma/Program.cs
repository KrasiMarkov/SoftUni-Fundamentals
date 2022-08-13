using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            List<string> attack = new List<string>();

            List<string> destruction = new List<string>();

            int countAttack = 0;

            int countDestruction = 0;

            for (int i = 0; i < n; i++)
            {

                string text = Console.ReadLine();

                int count = 0;

                for (int j = 0; j < text.Length; j++)
                {
                    char symbol = text[j];



                    if (symbol == 'S' || symbol == 'T' || symbol == 'A' || symbol == 'R' || symbol == 's' || symbol == 't' || symbol == 'a' || symbol == 'r')
                    {
                        count++;
                    }


                }

                string newText = "";

                for (int k = 0; k < text.Length; k++)
                {
                    char symbol = text[k];

                    int secondSymbol = (int)symbol - count;

                    char secondSymbolToChar = (char)secondSymbol;

                    newText = newText + secondSymbolToChar;


                }

                var regex = new Regex(@".*@(?<planet>[A-Z][a-z]+)[^@\-!:>]*:(?<population>[0-9]+)[^@\-!:>]*!(?<attackOrDestruction>(A)|(D))![^@\-!:>]*->[0-9]+.*");

                var matches = regex.Matches(newText);

                foreach (Match match in matches)
                {

                    string planetName = match.Groups["planet"].Value;

                    string attackOrDestruction = match.Groups["attackOrDestruction"].Value;

                    if (attackOrDestruction == "A")
                    {
                        countAttack++;

                        attack.Add(planetName);
                    }

                    else
                    {
                        countDestruction++;

                        destruction.Add(planetName);
                    }
                }

            }

            Console.WriteLine($"Attacked planets: {countAttack}");

            foreach (var item in attack.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }
            Console.WriteLine($"Destroyed planets: {countDestruction}");

            foreach (var item in destruction.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }
        }
    }
}
