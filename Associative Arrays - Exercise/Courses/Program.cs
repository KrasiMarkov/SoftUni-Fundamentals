using System;
using System.Collections.Generic;
using System.Linq;
namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();


            while (true)
            {
                string[] command = Console.ReadLine().Split(" : ");

                if (command[0] == "end")
                {
                    break;
                }

                string courseName = command[0];

                string studentName = command[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses[courseName] = new List<string>();
                }

               
                
                    courses[courseName].Add(studentName);
                

            }

            var sortedCourses = courses.OrderByDescending(x => x.Value.Count);


            foreach (var item in sortedCourses)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");

                var orderedStudent = item.Value.OrderBy(x => x);

                foreach (var kvp in orderedStudent)
                {
                    Console.WriteLine($"-- {kvp}");
                }
            }
        }
    }
}
