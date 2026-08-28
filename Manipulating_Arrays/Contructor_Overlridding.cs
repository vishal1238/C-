using System;

class Student
{
    string name;
    int age;

    // Default constructor
    Student()
    {
        name = "Unknown";
        age = 0;
    }

    // Constructor with one parameter
    Student(string name)
    {
        this.name = name;
        age = 0;
    }

    // Constructor with two parameters
    Student(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    void Display()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }

    static void Main()
    {
        Student s1 = new Student();
        Student s2 = new Student("Vishal");
        Student s3 = new Student("Vishal", 22);

        s1.Display();
        s2.Display();
        s3.Display();
    }
}