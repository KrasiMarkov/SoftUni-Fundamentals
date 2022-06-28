using System;
using System.Linq;
using System.Collections.Generic;
namespace Students_2._0
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

                string firstName = line[0];

                string lastName = line[1];

                int age = int.Parse(line[2]);

                string homeTown = line[3];

                if (IsStudentExisting(students, firstName, lastName))
                {
                    Student student = GetStudent(students, firstName, lastName);

                    student.firstName = firstName;
                    student.lastName = lastName;
                    student.age = age;
                    student.homeTown = homeTown;

                }
                else
                {
                    Student student = new Student();

                    student.firstName = firstName;
                    student.lastName = lastName;
                    student.age = age;
                    student.homeTown = homeTown;

                    students.Add(student);
                }

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

        static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.firstName == firstName && student.lastName == lastName)
                {
                    return true;
                }
            }

            return false;

        }

        static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach (Student student in students)
            {
                if (student.firstName == firstName && student.lastName == lastName)
                {
                    existingStudent = student;


                }
            }
            return existingStudent;

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
