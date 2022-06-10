using System;

namespace Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            PrintBool(command);
            

        }

        static void PrintBool(string command)
        {
            while (command != "END")
            {
                string reverseString = "";
                for (int i = command.Length - 1; i >= 0; i--)
                {
                    char symbol = command[i];
                    reverseString = reverseString + symbol;
                }
                if (reverseString == command)
                {
                    Console.WriteLine("true");

                }
                else
                {
                    Console.WriteLine("false");
                }

                command = Console.ReadLine();
            }
            

        }
    }
}
