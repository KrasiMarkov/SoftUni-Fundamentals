using System;
using System.Collections.Generic;
using System.Linq;
namespace Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split('\\').ToList();

            List<string> words = new List<string>();

            string total = text[text.Count - 1];

            string[] final = total.Split('.');

            Console.WriteLine($"File name: {final[0]}");
            Console.WriteLine($"File extension: {final[1]}");








        }
    }
}
