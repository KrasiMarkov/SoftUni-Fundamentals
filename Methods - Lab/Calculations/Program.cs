using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            if (operation == "add")
            {
                AddNum(firstNum, secondNum);

            }
            else if (operation == "multiply")
            {
                MultiplyNum(firstNum, secondNum);
            }
            else if (operation == "subtract")
            {
                SubtractNum(firstNum, secondNum);
            }
            else if (operation == "divide")
            {
                DivideNum(firstNum, secondNum);
            }
        }

        static void AddNum(int firstNum, int secondNum)
        {
            int result = firstNum + secondNum;
            Console.WriteLine(result);
        }

        static void MultiplyNum(int firstNum, int secondNum)
        {
            int result = firstNum * secondNum;
            Console.WriteLine(result);
        }

        static void SubtractNum(int firstNum, int secondNum)
        {
            int result = firstNum - secondNum;
            Console.WriteLine(result);
        }

        static void DivideNum(int firstNum, int secondNum)
        {
            int result = firstNum / secondNum;
            Console.WriteLine(result);
        }
    }
}
