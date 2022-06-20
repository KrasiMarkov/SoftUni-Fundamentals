using System;
using System.Linq;
using System.Collections.Generic;
namespace Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbersAsString = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToArray();


            List<string> reversedNumbers = new List<string>();

            for (int i = numbersAsString.Length-1; i >= 0; i--)
            {
                string[] finalArray = numbersAsString[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                
                reversedNumbers.AddRange(finalArray);


            }

            Console.WriteLine(string.Join(" ", reversedNumbers));





        }
    }
}
