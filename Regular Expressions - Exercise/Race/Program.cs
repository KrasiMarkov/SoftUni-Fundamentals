using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(", ").ToList();

            Dictionary<string, int> final = new Dictionary<string, int>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end of race")
                {
                    break;
                }

                string name = "";

                int totalDigit = 0;

                for (int i = 0; i < command.Length; i++)
                {
                    char symbol = command[i];


                    if (char.IsLetter(symbol))
                    {
                        name += symbol;
                    }

                    else if (char.IsDigit(symbol))
                    {
                        int digit = int.Parse(symbol.ToString());

                        totalDigit += digit;
                    }
                }

                bool flag = names.Contains(name);

                if (flag == true)
                {
                    if (!final.ContainsKey(name))
                    {
                        final[name] = totalDigit;
                    }

                    else
                    {
                        final[name] += totalDigit;
                    }




                }






            }

            var ordered = final.OrderByDescending(x => x.Value);

            var topThree = ordered.Take(3);

            List<string> finalNames = new List<string>();

            foreach (var item in topThree)
            {
                string name = item.Key;

                finalNames.Add(name);

            }

            Console.WriteLine($"1st place: {finalNames[0]}");
            Console.WriteLine($"2nd place: {finalNames[1]}");
            Console.WriteLine($"3rd place: {finalNames[2]}");

        }
    }
}
