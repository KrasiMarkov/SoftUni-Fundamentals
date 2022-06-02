using System;

namespace Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            string newName = ReturnNString(name, number);
            Console.WriteLine(newName);
            
        }

        static string ReturnNString(string name, int number)
        {
            string result = "";
            for (int i = 1; i <= number; i++)
            {

                result += name;
            }
            return result;
        }
    }
}
