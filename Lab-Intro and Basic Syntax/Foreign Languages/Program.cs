using System;

namespace Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameCountry = Console.ReadLine();
            if (nameCountry == "USA" || nameCountry == "England")
            {
                Console.WriteLine("English");
            }
            else if (nameCountry == "Spain" || nameCountry == "Argentina" || nameCountry == "Mexico")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
