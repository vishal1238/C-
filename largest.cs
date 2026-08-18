using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number: ");
        int c = Convert.ToInt32(Console.ReadLine());

        if (a >= b && a >= c)
        {
            Console.WriteLine("Largest number = " + a);
        }
        else if (b >= a && b >= c)
        {
            Console.WriteLine("Largest number = " + b);
        }
        else
        {
            Console.WriteLine("Largest number = " + c);
        }
    }
}