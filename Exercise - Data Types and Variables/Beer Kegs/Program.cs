using System;

namespace Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            double maxVolume = double.MinValue;
            double volume = double.MinValue;
            string maxKeg = "";
            for (int i = 1; i <= n; i++)
            {
                string nameKeg = Console.ReadLine();
                float radiusKeg = float.Parse(Console.ReadLine());
                int heightKeg = int.Parse(Console.ReadLine());

                volume = Math.PI * Math.Pow(radiusKeg, 2) * heightKeg;

                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    maxKeg = nameKeg;
                }

            }
            Console.WriteLine($"{maxKeg}");
        }
    }
}
