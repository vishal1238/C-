// Runtime Polymorphism is a concept in object-oriented programming that allows a method to behave differently based on the object that it is acting upon. In C#, this is typically achieved through method overriding, where a derived class provides a specific implementation of a method that is already defined in its base class.
using System;
abstract class Animal
{
    public abstract double CalculateArea();
    public void Display(){
        console.WriteLine("Area: " + CalculateArea());
    }
}
class Circle : Animal
{
    private double radius;
    public Circle(double r)
    {
        radius = r;
    }
    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
}

class Rectangle : Animal
{
    private double length;
    private double width;
    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }
    public override double CalculateArea()
    {
        return length * width;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal circle = new Circle(5);
        circle.Display(); // Output: Area: 78.53981633974483

        Animal rectangle = new Rectangle(4, 6);
        rectangle.Display(); // Output: Area: 24
    }
}