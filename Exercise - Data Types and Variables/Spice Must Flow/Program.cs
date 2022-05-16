using System;

namespace Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield= int.Parse(Console.ReadLine());
            int amount = 0;
            int counter = 0;
            while (startingYield >= 100)
            {
                amount = amount + startingYield;
                startingYield = startingYield - 10;
                counter++;
                if (amount - 26 < 0)
                {
                    amount = 0;
                }
                else
                {
                    amount = amount - 26;
                }

            }
            if (amount - 26 < 0)
            {
                amount = 0;
            }
            else
            {
                amount = amount - 26;
            }
            Console.WriteLine(counter);
            Console.WriteLine(amount);

        }
    }
}
