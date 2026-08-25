// A class can have multiple constructors with different parameters, allowing for constructor overloading. This means that you can create instances of the class in different ways, depending on the arguments passed to the constructor. Each constructor can perform different initialization tasks based on the provided parameters.

using System;
class Student
{
    public int Id;
    public string Name;

    // Default constructor
    public Student()
    {
        Id = 0;
        Name = "Unknown";
    }

    // Parameterized constructor
    public Student(int id, string name)
    {
        Id = id;
        Name = name;
    }

    // Another parameterized constructor
    public Student(int id)
    {
        Id = id;
        Name = "Unknown";
    }

    public void Display()
    {
        Console.WriteLine("Student ID: " + Id);
        Console.WriteLine("Student Name: " + Name);
    }
}