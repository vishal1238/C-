using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter size of array: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr1 = new int[n];
        int[] arr2 = new int[n];

        Console.WriteLine("Enter array elements:");

        for (int i = 0; i < n; i++)
        {
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Copy elements
        for (int i = 0; i < n; i++)
        {
            arr2[i] = arr1[i];
        }

        Console.WriteLine("Copied array:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(arr2[i] + " ");
        }
    }
}