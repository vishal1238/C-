using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Before swapping:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("After swapping:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}