using System;

namespace NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintNxN(n);
            
            
        }
        static void PrintNxN(int n)
        {

            for (int i = 0; i < n; i++)
            {
                for (int j = n; j > 0; j--)
                {
                    Console.Write($"{n} ");


                }
                Console.WriteLine();
            }






        }
    }
}
