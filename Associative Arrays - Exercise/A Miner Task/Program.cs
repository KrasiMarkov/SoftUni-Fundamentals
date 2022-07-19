using System;
using System.Linq;
using System.Collections.Generic;
namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, int> resource = new Dictionary<string, int>();


            while (command != "stop")
            {

                int quantity = int.Parse(Console.ReadLine());

                if (!resource.ContainsKey(command))
                {
                    resource[command] = quantity;
                }

                else
                {
                    resource[command] += quantity;
                }
                



                command = Console.ReadLine();


            }

            foreach (var item in resource)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
