using System;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());
            double powered = CalculatePower(n, pow);
            Console.WriteLine(powered);

        }

        static double CalculatePower(double n, int pow)
        {
            double result = 1.0d;

            for (int i = 1; i <= pow; i++)
            {
                result *= n;
            }
            return result;


        }
    }
}
