using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            double tempPower = power * 0.5;
            int counter = 0;
            while (power >= distance)
            {

                counter++;
                power = power - distance;
                if (power == tempPower && exhaustionFactor != 0)
                {
                    power = power / exhaustionFactor;



                }
            }
            Console.WriteLine(power);
            Console.WriteLine(counter);

        }
    }
}
