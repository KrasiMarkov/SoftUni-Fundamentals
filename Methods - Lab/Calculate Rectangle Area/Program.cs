using System;

namespace Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int result = CalculateArea(width, height);
            Console.WriteLine(result);
        }

        static int CalculateArea(int width, int height)
        {
             
            return width * height;


        }
    }
}
