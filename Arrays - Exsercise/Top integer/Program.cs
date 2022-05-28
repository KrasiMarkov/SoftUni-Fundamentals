using System;
using System.Linq;
namespace Top_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string result = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                int current = numbers[i];
                bool isTopInteger = true;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (current <= numbers[j])
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    result += current + " ";
                }
            }
            Console.WriteLine(result);
        }
    }
}
