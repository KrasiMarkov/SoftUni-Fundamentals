using System;

namespace Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string row = Console.ReadLine();
            string[] names = row.Split();
            for (int i = names.Length - 1; i >= 0; i--)
            {
                string reverseNames = names[i];
                Console.Write($"{reverseNames} ");
            }
        }
    }
}
