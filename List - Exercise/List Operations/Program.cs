using System;
using System.Linq;
using System.Collections.Generic;
namespace List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();



            while (true)
            {
                string command = Console.ReadLine();

                string[] othersCommand = command.Split();

                if (othersCommand[0] == "End")
                {
                    break;
                }

                if (othersCommand[0] == "Add")
                {
                    int oneNumber = int.Parse(othersCommand[1]);

                    numbers.Add(oneNumber);
                }
                else if (othersCommand[0] == "Insert")
                {
                    int index = int.Parse(othersCommand[2]);

                    int number = int.Parse(othersCommand[1]);

                    if (index < 0 && index >= numbers.Count-1)
                    {
                        Console.WriteLine("Invalid index");
                       
                    }
                    else
                    {
                        numbers.Insert(index, number);
                    }
                   
                }
                else if (othersCommand[0] == "Remove")
                {
                    int index = int.Parse(othersCommand[1]);

                    if (index < 0 || index >= numbers.Count-1)
                    {
                       Console.WriteLine("Invalid index");
                       
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }
                    
                }
                else if (othersCommand[0] == "Shift" && othersCommand[1] == "left")
                {
                    int count = int.Parse(othersCommand[2]);

                    for (int i = 0; i < count; i++)
                    {
                        numbers.Add(numbers[0]);
                        numbers.RemoveAt(0);
                    }
                }
                else if (othersCommand[0] == "Shift" && othersCommand[1] == "right")
                {
                    int count = int.Parse(othersCommand[2]);

                    for (int i = 0; i < count; i++)
                    {
                        int lastNumber = numbers.Count - 1;
                        numbers.Insert(0, lastNumber);
                        numbers.RemoveAt(lastNumber);
                    }
                }

            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
