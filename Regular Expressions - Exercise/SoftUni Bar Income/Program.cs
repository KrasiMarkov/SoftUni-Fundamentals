using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
namespace SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {

            string regex = @"^%(?<customer>[A-Z]{1}[a-z]+)%[^|$%\.]*?<(?<product>[A-Z][a-z]+)>[^|$%\.]*?\|(?<count>[0-9]+)\|[^|$%\.]*?(?<price>[0-9]+\.?[0-9]*)\$$";
            decimal totalMoney = 0.0m;

            while (true)
            {
                string text = Console.ReadLine();

                if (text == "end of shift")
                {
                    break;
                }

                

                Match match = Regex.Match(text, regex);

                if (match.Success)
                {

                    string name = match.Groups["customer"].Value;

                    string product = match.Groups["product"].Value;

                    long count = long.Parse(match.Groups["count"].Value);

                    decimal price = decimal.Parse(match.Groups["price"].Value);

                    if (count != 0)
                    {
                        decimal money = count * price;

                        totalMoney += money;

                        Console.WriteLine($"{name}: {product} - {money:F2}");
                    }
                   

                   


                }

            }
            
            Console.WriteLine($"Total income: {totalMoney:F2}");




        }
    }
}
