using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter size of array: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter array elements:");

        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            sum = sum + arr[i];
        }

        Console.WriteLine("Sum of array elements: " + sum);
    }
}