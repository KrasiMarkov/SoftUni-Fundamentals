using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
namespace Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());



            BigInteger factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);

        }
    }
}
