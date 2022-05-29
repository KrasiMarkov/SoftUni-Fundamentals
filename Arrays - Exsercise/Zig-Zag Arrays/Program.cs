using System;
using System.Linq;
namespace Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArrays = new int[n];
            int[] secondArrays = new int[n];
            int[] thirdArrays = new int[2];
            for (int i = 0; i < n; i++)
            {
                thirdArrays = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    firstArrays[i] = thirdArrays[0] ;
                    secondArrays[i] = thirdArrays[1];
                }
                else
                {
                    secondArrays[i] = thirdArrays[0];
                    firstArrays[i] = thirdArrays[1];
                }

            }
            Console.WriteLine(string.Join(" ", firstArrays));
            Console.WriteLine(string.Join(" ", secondArrays));
        }
    }
}
