using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> total = new List<string>();

            decimal totalMoney = 0;

            while (true)
            {
                string command = Console.ReadLine();


                if (command == "Purchase")
                {
                    break;
                }

                var regex = new Regex(@">>(?<name>.+)<<(?<price>[0-9]+\.?[0-9]*)!(?<quantity>[0-9]+)");

                var match = regex.Match(command);

                if (match.Success == true)
                {

                    var name = match.Groups["name"].Value;

                    var price = match.Groups["price"].Value;

                    var quantity = match.Groups["quantity"].Value;

                    decimal priceToNumber = decimal.Parse(price);

                    int quantityToNumber = int.Parse(quantity);


                    total.Add(name);

                    totalMoney += priceToNumber * quantityToNumber;





                }



            }

            Console.WriteLine("Bought furniture:");

            foreach (var item in total)
            {


                Console.WriteLine($"{item}");

            }

            Console.WriteLine($"Total money spend: {totalMoney:F2}");
        }
    }
}
