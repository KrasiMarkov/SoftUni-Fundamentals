using System;
using System.Linq;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> products = new Dictionary<string, double>();

            Dictionary<string, int> totalQuantity = new Dictionary<string, int>();

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                string name = command[0];

                if (command[0] == "buy")
                {
                    break;
                }

                double price = double.Parse(command[1]);

                int quantity = int.Parse(command[2]);



               

                if (!products.ContainsKey(name))
                {
                    products[name] = price;

                    totalQuantity[name] = quantity;
                }

                else
                {
                    if (!products.ContainsValue(price))
                    {
                        products[name] = price;

                        totalQuantity[name] = totalQuantity[name] + quantity;
                    }
                    else
                    {
                        totalQuantity[name] = totalQuantity[name] + quantity;
                    }
                    
                }




            }

            foreach (var item in totalQuantity)
            {
                string name = item.Key;
                int quantity = item.Value;
                double price = products[name];

                double result = price * quantity;

                Console.WriteLine($"{name} -> {result:F2}");

            }

        }
    }
}
