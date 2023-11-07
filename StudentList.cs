using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class StudentManager
{
    private List<Student> students;

    public StudentManager()
    {
        students = new List<Student>();
    }

    public void AddStudent(string name, int age)
    {
        Student newStudent = new Student(name, age);
        students.Add(newStudent);
        Console.WriteLine($"Student '{name}' added successfully.");
    }

    public void RemoveStudent(string name)
    {
        Student studentToRemove = students.Find(student => student.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        if (studentToRemove != null)
        {
            students.Remove(studentToRemove);
            Console.WriteLine($"Student '{name}' removed successfully.");
        }
        else
        {
            Console.WriteLine($"Student '{name}' not found.");
        }
    }

    public void ListStudents()
    {
        Console.WriteLine("List of Students:");
        foreach (var student in students)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
        }
    }
}

class StudentList
{
    static void Main()
    {
        StudentManager manager = new StudentManager();

        manager.AddStudent("Alice", 20);
        manager.AddStudent("Bob", 22);
        manager.AddStudent("Charlie", 21);

        manager.ListStudents();

        manager.RemoveStudent("Bob");

        manager.ListStudents();
    }
}
