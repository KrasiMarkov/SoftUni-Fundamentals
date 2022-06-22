using System;
using System.Linq;
using System.Collections.Generic;
namespace House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();

                string[] othersCommand = command.Split();

                string name = othersCommand[0];

                if (othersCommand[1] == "is" && othersCommand[2] == "going!")
                {
                    bool check = names.Contains(name);

                    if (check == false)
                    {
                        names.Add(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }

                }
                else if(othersCommand[2] == "not")
                {
                    bool check = names.Contains(name);

                    if (check == true)
                    {
                        names.Remove(name);

                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }


            }
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
