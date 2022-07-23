using System;
using System.Linq;
using System.Collections.Generic;
namespace Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> averageGrade = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();

                double grade = double.Parse(Console.ReadLine());

                if (!averageGrade.ContainsKey(name))
                {
                    averageGrade[name] = new List<double>();

                    averageGrade[name].Add(grade);
                }

                else
                {
                    averageGrade[name].Add(grade);
                }


            }

            

            foreach (var item in averageGrade.OrderByDescending(x => x.Value.Average()))
            {
                if (item.Value.Average() >= 4.5)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value.Average():F2}");
                }
            }
        }
    }
}
