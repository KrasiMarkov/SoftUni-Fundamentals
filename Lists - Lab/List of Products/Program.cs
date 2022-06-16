using System;
using System.Linq;
using System.Collections.Generic;
namespace List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> nameOfProducts = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine();
                nameOfProducts.Add(product);

            }
            nameOfProducts.Sort();
            for (int i = 0; i < nameOfProducts.Count; i++)
            {
                
                Console.WriteLine($"{i + 1}.{nameOfProducts[i]}");
            }
        }
    }
}
