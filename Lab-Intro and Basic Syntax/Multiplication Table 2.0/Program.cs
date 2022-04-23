using System;

namespace Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            if (n <= 10 && j <= 10)
            {
                for (int i = j; i <= 10; i++)
                {
                    Console.WriteLine($"{n} X {i} = {n * i}");
                }
            }
            else if (n > 10 || j > 10 )
            {
                Console.WriteLine($"{n} X {j} = {n * j}");
            }
                
        }
    }
}
