using System;

namespace Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNUmber = double.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            if (symbol == '*')
            {

                Console.WriteLine(MultiplyNumbers(firstNUmber, secondNumber));
            }
            else if (symbol == '/')
            {
                Console.WriteLine(DivideNumbers(firstNUmber, secondNumber));
            }
            else if (symbol == '+')
            {
                Console.WriteLine(SumNumbers(firstNUmber, secondNumber));
            }
            else if (symbol == '-')
            {
                Console.WriteLine(SubtractNumbers(firstNUmber, secondNumber));
            }
        }

        static double MultiplyNumbers(double firstNumber, double secondNumber)
        {
            double rezult = firstNumber * secondNumber;
            return rezult;
        }

        static double DivideNumbers(double firstNumber, double secondNumber)
        {
            double rezult = firstNumber / secondNumber;
            return rezult;
        }

        static double SumNumbers(double firstNumber, double secondNumber)
        {
            double rezult = firstNumber + secondNumber;
            return rezult;
        }

        static double SubtractNumbers(double firstNumber, double secondNumber)
        {
            double rezult = firstNumber - secondNumber;
            return rezult;
        }
    }
}
