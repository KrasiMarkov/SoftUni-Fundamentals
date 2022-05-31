using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintGrade(double.Parse(Console.ReadLine()));
        }

        static void PrintGrade(double number)
        {
            if (number >= 2.00 && number < 3.00)
            {
                Console.WriteLine("Fail");
            }
            else if (number >= 3.00 && number < 3.50)
            {
                Console.WriteLine("Poor");
            }
            else if (number >= 3.50 && number < 4.50)
            {
                Console.WriteLine("Good");
            }
            else if (number >= 4.50 && number < 5.50)
            {
                Console.WriteLine("Very good");
            }
            else if (number >= 5.50 && number <= 6.00)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
