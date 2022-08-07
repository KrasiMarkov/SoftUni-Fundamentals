using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
namespace Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

            string text = Console.ReadLine();

            var matches = regex.Matches(text);

            var names = "";

            foreach (Match match in matches)
            {

                names = names + match + " ";
                
            }

            Console.WriteLine(names);
        }
    }
}
