using System;
using System.Collections.Generic;

namespace OOPBasedSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            List<Teacher> teachers = new List<Teacher>();
            List<Subject> subjects = new List<Subject>();

            // filling up the lists with data
            List<Student> studentsData = new List<Student>()
            {
                new Student { Name = "Ramanji", ClassAndSection = "10A" },
                new Student { Name = "Prakash", ClassAndSection = "10A" },
                new Student { Name = "Swaroo", ClassAndSection = "10B" },
                new Student { Name = "Praveen", ClassAndSection = "10A" },
                new Student { Name = "Durga", ClassAndSection = "10B" },
                new Student { Name = "Suri", ClassAndSection = "10B" },
                new Student { Name = "Mahesh", ClassAndSection = "10A" },
                new Student { Name = "Kalyan", ClassAndSection = "9A" },
                new Student { Name = "Yerrayya", ClassAndSection = "9A" },
                new Student { Name = "Teja", ClassAndSection = "10A" }
            };
            students.AddRange(studentsData);

            List<Teacher> teachersData = new List<Teacher>
            {
                new Teacher { Name = "Venkat Ramana", ClassAndSection = "9A" },
                new Teacher { Name = "Suresh", ClassAndSection = "10A" },
                new Teacher { Name = "Lokesh", ClassAndSection = "10B" },
                new Teacher { Name = "Rubitha", ClassAndSection = "10B" },
                new Teacher { Name = "Sateesh", ClassAndSection = "10B" },
                new Teacher { Name = "Babu", ClassAndSection = "10A" },
                new Teacher { Name = "Rani", ClassAndSection = "10A" },
            };
            teachers.AddRange(teachersData);

            List<Subject> subjectsData = new List<Subject>
            {
                new Subject { Name = "Telugu", SubjectCode = 10101, Teacher = "Rani" },
                new Subject { Name = "Hindi", SubjectCode = 10102, Teacher = "Babu" },
                new Subject { Name = "English", SubjectCode = 10103, Teacher = "Rubitha" },
                new Subject { Name = "Maths", SubjectCode = 10104, Teacher = "Suresh" },
                new Subject { Name = "Science", SubjectCode = 10105, Teacher = "Venkat Ramana" },
                new Subject { Name = "Social", SubjectCode = 10106, Teacher = "Lokesh" }
            };
            subjects.AddRange(subjectsData);

            // Displaying the data
            Console.Write("Enter a class and section you want (9A / 10A / 10B): ");
            string choice = Console.ReadLine();
            switch(choice)
            {
                case "9A":
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine($"Students in the class {choice} are:");
                    Console.WriteLine("-------------------------------------------");
                    foreach (Student student in students)
                    {
                        if (student.ClassAndSection == "9A")
                        {
                            Console.WriteLine(student.Name);
                        }
                    }
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("Subjects taught by teacher:");
                    Console.WriteLine("-------------------------------------------");
                    foreach (Teacher teacher in teachers)
                    {
                        if (teacher.ClassAndSection == "9A")
                        {
                            foreach (Subject subject in subjects)
                            {
                                if (teacher.Name ==  subject.Teacher)
                                {
                                    Console.WriteLine($"{subject.Name} is taught by {subject.Teacher}");
                                }
                            }
                        }
                    }
                    Console.WriteLine("-------------------------------------------");
                    break;
                case "10A":
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine($"Students in the class {choice} are:");
                    Console.WriteLine("-------------------------------------------");
                    foreach (Student student in students)
                    {
                        if (student.ClassAndSection == "10A")
                        {
                            Console.WriteLine(student.Name);
                        }
                    }
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("Subjects taught by teacher:");
                    Console.WriteLine("-------------------------------------------");
                    foreach (Teacher teacher in teachers)
                    {
                        if (teacher.ClassAndSection == "10A")
                        {
                            foreach (Subject subject in subjects)
                            {
                                if (teacher.Name == subject.Teacher)
                                {
                                    Console.WriteLine($"{subject.Name} is taught by {subject.Teacher}");
                                }
                            }
                        }
                    }
                    Console.WriteLine("-------------------------------------------");
                    break;
                case "10B":
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine($"Students in the class {choice} are:");
                    Console.WriteLine("-------------------------------------------");
                    foreach (Student student in students)
                    {
                        if (student.ClassAndSection == "10B")
                        {
                            Console.WriteLine(student.Name);
                        }
                    }
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("Subjects taught by teacher:");
                    Console.WriteLine("-------------------------------------------");
                    foreach (Teacher teacher in teachers)
                    {
                        if (teacher.ClassAndSection == "10B")
                        {
                            foreach (Subject subject in subjects)
                            {
                                if (teacher.Name == subject.Teacher)
                                {
                                    Console.WriteLine($"{subject.Name} is taught by {subject.Teacher}");
                                }
                            }
                        }
                    }
                    Console.WriteLine("-------------------------------------------");
                    break;
                default:
                    Console.WriteLine("Sorry, such class and section is not present. Enter a valid option.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
