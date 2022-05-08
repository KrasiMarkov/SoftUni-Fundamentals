using System;

namespace Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            float meters = float.Parse(Console.ReadLine());
            float kilometers = 0;
            kilometers = meters * 0.001f;
            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
