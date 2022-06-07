using System;

namespace Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(Subtract(firstNumber, secondNumber, thirdNumber));
        }

        static int Sum(int firstNumber, int secondNumber, int thirdNumber)
        {
            int sum = firstNumber + secondNumber;
            return sum;
            
        }

        static int Subtract(int firstNumber, int secondNumber, int thirdNumber)
        {
            int result = Sum(firstNumber, secondNumber, thirdNumber) - thirdNumber;
            return result;
        }
    }
}
