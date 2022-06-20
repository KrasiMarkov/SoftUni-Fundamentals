using System;
using System.Linq;
using System.Collections.Generic;
namespace Anonumous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().ToArray();

            List<string> finalResult = new List<string>();

            int currentEndIndex = 0;

            int finalEndIndex = -1;



            while (true)
            {
                string command = Console.ReadLine();

                string[] othersCommand = command.Split();

                if (othersCommand[0] == "3:1")
                {
                    break;
                }



                if (othersCommand[0] == "merge")
                {
                    int startIndex = int.Parse(othersCommand[1]);

                    int endIndex = int.Parse(othersCommand[2]);

                    if (startIndex < 0 || startIndex > arr.Length - 1)
                    {
                        startIndex = 0;

                    }

                    if (endIndex < 0 || endIndex > arr.Length - 1)
                    {
                        endIndex = arr.Length - 1;
                    }

                    if (endIndex > currentEndIndex)
                    {

                        if (startIndex <= finalEndIndex)
                        {
                            startIndex = startIndex + 1;
                        }

                        for (int i = startIndex; i <= endIndex; i++)
                        {

                            finalResult.Add(arr[i]);

                        }



                    }

                    finalEndIndex = endIndex;

                    currentEndIndex = endIndex;

                    Console.WriteLine(string.Join("", finalResult));
                }

                else
                {
                    
                }



            }

            

        }
    }
}
