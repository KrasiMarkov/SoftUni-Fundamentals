using System;
using System.Linq;
using System.Collections.Generic;
namespace Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            Dictionary<string, int> output = new Dictionary<string, int>();

            List<string> total = new List<string>();


            for (int i = 0; i < input.Count; i++)
            {
                string name = input[i];
                input[i] = name.ToLower();
                
            }
              
            


            foreach (var item in input)
            {
                if (!output.ContainsKey(item))
                {
                    output[item] = 1;

                }
                else
                {
                    output[item]++;
                }
            }

            foreach (var item in output)
            {
                if (item.Value % 2 == 1)
                {
                    total.Add(item.Key);
                }
            }

            Console.WriteLine(string.Join(" ", total));
        }
    }
}
