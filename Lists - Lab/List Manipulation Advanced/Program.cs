using System;
using System.Linq;
using System.Collections.Generic;
namespace List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int counter = 0;
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] othersCommand = command.Split();
                if (othersCommand[0] == "Add")
                {
                    int firstNumber = int.Parse(othersCommand[1]);
                    numbers.Add(firstNumber);
                    counter++;

                }
                else if (othersCommand[0] == "Remove")
                {
                    int firstNumber = int.Parse(othersCommand[1]);
                    numbers.Remove(firstNumber);
                    counter++;
                }
                else if (othersCommand[0] == "RemoveAt")
                {
                    int firstNumber = int.Parse(othersCommand[1]);
                    numbers.RemoveAt(firstNumber);
                    counter++;
                }
                else if (othersCommand[0] == "Insert")
                {
                    int value = int.Parse(othersCommand[1]);
                    int index = int.Parse(othersCommand[2]);
                    numbers.Insert(index, value);
                    counter++;
                }
                else if (othersCommand[0] == "Contains")
                {
                    int firstNumber = int.Parse(othersCommand[1]);

                    bool yesOrNo = numbers.Contains(firstNumber);

                    if (yesOrNo == true)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (othersCommand[0] == "PrintEven")
                {

                    PrintEvenNumbers(numbers);

                }
                else if (othersCommand[0] == "PrintOdd")
                {
                    PrintOddNumbers(numbers);

                }
                else if (othersCommand[0] == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (othersCommand[0] == "Filter")
                {
                    if (othersCommand[1] == ">=")
                    {
                        int firstNumber = int.Parse(othersCommand[2]);

                        Console.WriteLine(string.Join(" ", numbers.Where(x => x >= firstNumber)));
                    }
                    else if (othersCommand[1] == "<=")
                    {
                        int firstNumber = int.Parse(othersCommand[2]);

                        Console.WriteLine(string.Join(" ", numbers.Where(x => x <= firstNumber)));

                    }
                    else if (othersCommand[1] == "<")
                    {
                        int firstNumber = int.Parse(othersCommand[2]);

                        Console.WriteLine(string.Join(" ", numbers.Where(x => x < firstNumber)));
                    }
                    else if (othersCommand[1] == ">")
                    {
                        int firstNumber = int.Parse(othersCommand[2]);

                        Console.WriteLine(string.Join(" ", numbers.Where(x => x > firstNumber)));
                    }

                    
                }


            }
            if (counter > 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }

        }


        static void PrintEvenNumbers(List<int> numbers)
        {
            string evenNumbers = "";
            for (int i = 0; i < numbers.Count; i++)
            {

                int firstNumber = numbers[i];
                if (firstNumber % 2 == 0)
                {
                    evenNumbers += firstNumber + " ";
                }

            }
            Console.WriteLine(string.Join(" ", evenNumbers));
        }

        static void PrintOddNumbers(List<int> numbers)
        {
            string oddNumbers = "";
            for (int i = 0; i < numbers.Count; i++)
            {

                int firstNumber = numbers[i];
                if (firstNumber % 2 == 1)
                {
                    oddNumbers += firstNumber + " ";
                }

            }
            Console.WriteLine(string.Join(" ", oddNumbers));
        }
    }
}
