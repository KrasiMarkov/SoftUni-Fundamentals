using System;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                char symbol = number[i];
                int digit = int.Parse(symbol.ToString());
                sum = sum + digit;
            }
            Console.WriteLine(sum);
        }
    }
}
