using System;

namespace Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());




            if (minutes < 30)
            {
                minutes = minutes + 30;
                Console.WriteLine($"{hours}:{minutes}");
            }
            else
            {
                minutes =  60 - minutes;
                hours = hours + 1;
                Console.WriteLine($"{hours}:{minutes}");
            }

            
        }
    }
}
