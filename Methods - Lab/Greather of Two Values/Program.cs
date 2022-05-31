using System;

namespace Greather_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstNumber, secondNumber));

            }
            else if (type == "char")
            {
                char firstSymbol = char.Parse(Console.ReadLine());
                char secondSymbol = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstSymbol, secondSymbol));
            }
            else if (type == "string")
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();
                Console.WriteLine(GetMax(firstString, secondString));
            }
            
        }

        static int GetMax(int firstNumber, int secondNumber)
        {
            if (firstNumber >= secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }

        static char GetMax(char firstSymbol, char secondSymbol)
        {
            if (firstSymbol > secondSymbol)
            {
                return firstSymbol;
            }
            else
            {
                return secondSymbol;
            }


        }

        static string GetMax(string firstString, string secondString)
        {
            string larger = string.Empty;
            if (firstString.CompareTo(secondString) >= 0)
            {
                return firstString;
            }
            return secondString;
        }

    }


    
}
