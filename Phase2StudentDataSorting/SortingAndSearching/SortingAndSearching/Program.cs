using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public string Class { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = ReadStudentData("C:\\Users\\kpava\\Desktop\\Mphasis\\Simplilearn_Projects\\Phase2StudentDataSorting\\SortingAndSearching\\StudentData.txt");

        students = students.OrderBy(s => s.Name).ToList();

        Console.WriteLine("Sorted Student Data:");
        DisplayStudentData(students);

        Console.Write("\nEnter student name to search: ");
        string searchName = Console.ReadLine();

        Student foundStudent = SearchStudentByName(students, searchName);

        if (foundStudent != null)
        {
            Console.WriteLine($"Student found: {foundStudent.Name}, Class: {foundStudent.Class}");
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }

    static List<Student> ReadStudentData(string filePath)
    {
        List<Student> students = new List<Student>();

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 2)
                    {
                        students.Add(new Student { Name = parts[0].Trim(), Class = parts[1].Trim() });
                    }
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Error: File '{filePath}' not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading data: {ex.Message}");
        }

        return students;
    }

    static void DisplayStudentData(List<Student> students)
    {
        foreach (var student in students)
        {
            Console.WriteLine($"Name: {student.Name}, Class: {student.Class}");
        }
    }

    static Student SearchStudentByName(List<Student> students, string searchName)
    {
        return students.Find(s => s.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));
    }
}
