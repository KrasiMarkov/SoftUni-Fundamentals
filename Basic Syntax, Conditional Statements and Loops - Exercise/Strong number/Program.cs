using System;

namespace Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            int tempNum = number;
            int sum = 0;
            while (tempNum > 0)
            {
                int digit = tempNum % 10;
                tempNum = tempNum / 10;
                int result = 1;
                for (int i = 1; i <= digit; i++)
                {
                    result = result * i;
                    
                }
                sum = sum + result;
            }
            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }


        }
    }
}
