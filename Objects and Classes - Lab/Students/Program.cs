using System;
using System.Linq;
using System.Collections.Generic;
namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();


            while (true)
            {
                string[] line = Console.ReadLine().Split().ToArray();

                if (line[0] == "end")
                {
                    break;
                }

                Student student = new Student();

                student.firstName = line[0];
                student.lastName = line[1];
                student.age = int.Parse(line[2]);
                student.homeTown = line[3];

                students.Add(student);


            }

            string nameCity = Console.ReadLine();

            foreach (Student student in students)
            {
                if (nameCity == student.homeTown)
                {
                    Console.WriteLine($"{student.firstName} {student.lastName} is {student.age} years old.");
                }
            }



        }
    }

    class Student
    {
        public string firstName { get; set; }

        public string lastName { get; set; }

        public int age { get; set; }

        public string homeTown { get; set; }


    }
}
