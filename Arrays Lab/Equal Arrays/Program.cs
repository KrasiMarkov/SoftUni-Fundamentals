using System;
using System.Linq;
namespace Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstMassive = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondMassive = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            int index = 0;
            bool flag = false;
            for (int i = 0; i < firstMassive.Length; i++)
            {
                if (firstMassive[i] == secondMassive[i])
                {
                    int number = firstMassive[i];
                    sum += number;
                }
                else
                {
                    index = i;
                    flag = true;
                    break;
                }
            }
            if (flag == true)
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
            }
            else
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
