﻿using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            TotalPrice(product, quantity);

        }
        static void TotalPrice(string product, int quantity)
        {
            switch (product)
            {
                case "coffee":
                    Console.WriteLine($"{(quantity * 1.50):F2}");
                    break;
                case "water":
                    Console.WriteLine($"{(quantity * 1.00):F2}");
                    break;
                case "coke":
                    Console.WriteLine($"{(quantity * 1.40):F2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{(quantity * 2.00):F2}");
                    break;
                default:
                    break;
            }
           
        }


    }
}
