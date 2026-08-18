using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter marks for Subject 1: ");
        double sub1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter marks for Subject 2: ");
        double sub2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter marks for Subject 3: ");
        double sub3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter marks for Subject 4: ");
        double sub4 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter marks for Subject 5: ");
        double sub5 = Convert.ToDouble(Console.ReadLine());

        double total = sub1 + sub2 + sub3 + sub4 + sub5;

        double percentage = total / 5;

        Console.WriteLine("Total Marks = " + total);
        Console.WriteLine("Percentage = " + percentage + "%");

        if (percentage >= 90)
        {
            Console.WriteLine("Grade = A+");
        }
        else if (percentage >= 80)
        {
            Console.WriteLine("Grade = A");
        }
        else if (percentage >= 70)
        {
            Console.WriteLine("Grade = B");
        }
        else if (percentage >= 60)
        {
            Console.WriteLine("Grade = C");
        }
        else if (percentage >= 50)
        {
            Console.WriteLine("Grade = D");
        }
        else
        {
            Console.WriteLine("Grade = F");
        }
    }
}