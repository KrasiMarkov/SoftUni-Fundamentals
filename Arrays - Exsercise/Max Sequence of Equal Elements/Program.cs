using System;
using System.Linq;
namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bestCount = 0;
            int bestIndex = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int current = numbers[i];
                int counter = 1;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (current == numbers[j])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }


                }
                if (counter > bestCount)
                {
                    bestCount = counter;
                    bestIndex = i;
                }
            }
            string result = "";
            for (int i = 0; i < bestCount; i++)
            {
                result += numbers[bestIndex] + " ";
            }
            Console.WriteLine(result);
        }
    }
}
