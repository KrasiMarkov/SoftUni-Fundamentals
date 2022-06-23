using System;
using System.Linq;
using System.Collections.Generic;
namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int maxCapacityOfWagon = int.Parse(Console.ReadLine());

            while (true)
            {


                string command = Console.ReadLine();

                string[] otherCommand = command.Split();



                if (otherCommand[0] == "end")
                {
                    break;
                }



                if (otherCommand[0] == "Add")
                {
                    int passengers = int.Parse(otherCommand[1]);
                    numbers.Add(passengers);
                }
                else
                {
                    int numPassengers = int.Parse(otherCommand[0]);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int currentPassengers = numbers[i];

                        int sum = numPassengers + currentPassengers;

                        if (sum <= maxCapacityOfWagon)
                        {
                            numbers[i] = sum;
                            break;
                        }
                    }
                }






            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
