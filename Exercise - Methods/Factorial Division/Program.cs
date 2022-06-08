using System;

namespace Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            double firstFactorial = GetFirstFactorial(firstNumber);
            double secondFactorial = GetSecondFactorial(secondNumber);

            double result = firstFactorial / secondFactorial;
            Console.WriteLine($"{result:F2}");
        }




        static double GetFirstFactorial(int firstNumber)
        {

            double firstFactorial = firstNumber;

            for (int i = firstNumber - 1; i >= 1; i--)
            {
                firstFactorial = firstFactorial * i;
            }
            return firstFactorial;








        }

        static double GetSecondFactorial(int secondNumber)
        {
            double secondFactorial = secondNumber;

            for (int i = secondNumber - 1; i >= 1; i--)
            {
                secondFactorial = secondFactorial * i;
            }
            return secondFactorial;
        }

    }   
    
}
