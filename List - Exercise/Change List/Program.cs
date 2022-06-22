using System;
using System.Linq;
using System.Collections.Generic;
namespace Change_List
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


                if (othersCommand[0] == "end")
                {
                    break;
                }

                if (othersCommand[0] == "Delete")
                {
                    int number = int.Parse(othersCommand[1]);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int currentNumber = numbers[i];

                        if (currentNumber == number)
                        {
                            numbers.Remove(currentNumber);

                            i = -1;
                        }
                    }

                }
                else if (othersCommand[0] == "Insert")
                {
                    int number = int.Parse(othersCommand[1]);

                    int index = int.Parse(othersCommand[2]);

                    numbers.Insert(index, number);
                    
                        
                    
                    
                }

            }
            Console.WriteLine(string.Join(" ", numbers));
            


        }
    }
}
