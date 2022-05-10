using System;

namespace Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double volume = 0;
            volume = (length * width * height) / 3;
            
            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {volume:F2}");
        }
    }
}
