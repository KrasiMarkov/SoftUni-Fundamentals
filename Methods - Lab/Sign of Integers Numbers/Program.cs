using System;

namespace Sign_of_Integers_Numbers
{
    class Program
    {

        static void Main(string[] args)
        {
            
            PrintSign(int.Parse(Console.ReadLine()));
        }

        static void PrintSign( int n)
        {
            
            if (n > 0)  
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {n} is zero.");
            }
        }
    }
}
