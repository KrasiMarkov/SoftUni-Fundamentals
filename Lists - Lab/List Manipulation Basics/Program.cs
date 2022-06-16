using System;
using System.Linq;
using System.Collections.Generic;
namespace List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
           

            

           
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
                    
                    
                }
                else if (othersCommand[0] == "Remove")
                {
                    int firstNumber = int.Parse(othersCommand[1]);
                    numbers.Remove(firstNumber);
                    
                }
                else if (othersCommand[0] == "RemoveAt")
                {
                    int firstNumber = int.Parse(othersCommand[1]);
                    numbers.RemoveAt(firstNumber);
                    
                }
                else if (othersCommand[0] == "Insert")
                {
                    int value = int.Parse(othersCommand[1]);
                    int index = int.Parse(othersCommand[2]);
                    numbers.Insert(index, value);
                   
                }




                
            }
            Console.WriteLine(string.Join(" ", numbers));


        }
    }
}
