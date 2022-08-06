using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
namespace Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            var regex = new Regex(@"\b(?<day>[0-9]{2})(-|\/|.)(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})\b");

            var matches = regex.Matches(text);


            foreach (Match match in matches)
            {
                var day = match.Groups["day"].Value;

                var month = match.Groups["month"].Value;

                var year = match.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");

                
            }
        }
    }
}