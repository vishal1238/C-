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

        Console.Write("Enter index to update: ");
        int index = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter new value: ");
        int newValue = Convert.ToInt32(Console.ReadLine());

        arr[index] = newValue;

        Console.WriteLine("Updated array:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}