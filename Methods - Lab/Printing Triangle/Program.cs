﻿using System;

namespace Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                PrintLine(i);
            }
            for (int i = n - 1; i >= 0; i--)
            {
                PrintLine(i);
            }
        }

        static void PrintLine(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
        }
    }
}
