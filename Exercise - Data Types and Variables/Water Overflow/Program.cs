using System;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 255;
            int littersInTank = 0;
            for (int i = 1; i <= n; i++)
            {

                int litters = int.Parse(Console.ReadLine());
                if (litters <= sum)
                {
                    sum = sum - litters;
                    littersInTank = littersInTank + litters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");

                }



            }
            Console.WriteLine(littersInTank);
        }
    }
}
