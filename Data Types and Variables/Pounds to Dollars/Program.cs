﻿using System;

namespace Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());
            decimal dollars = 0;
            dollars = pounds * 1.31M;
            Console.WriteLine($"{dollars:F3}");
        }
    }
}
