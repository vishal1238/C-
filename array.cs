using System;

class Program
{
    static void Main(string[] args)
    {
        int[] marks = [75,82,91,68,88];
        
        for (int i = 0; i<5; i++){
            Console.WriteLine("Enter your marks");
            marks[i] = int.Parse(Console.ReadLine());
        }
    }
}