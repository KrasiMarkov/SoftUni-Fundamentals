using System;

namespace Top_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintNumbers(n);

        }

        static void PrintNumbers(int n)
        {


            for (int i = 1; i <= n; i++)
            {
                int digit = i;
                int sum = 0;
                int counter = 0;
                while (digit > 0)
                {
                    int lastNumber = digit % 10;
                    if (lastNumber % 2 == 1)
                    {
                        counter++;
                    }

                    sum = sum + lastNumber;
                    digit = digit / 10;


                }
                if (sum % 8 == 0 && counter >= 1)
                {
                    Console.WriteLine(i);
                }
            }





        }
    }
}
