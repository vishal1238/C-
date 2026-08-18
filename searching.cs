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

        Console.Write("Enter element to search: ");
        int search = Convert.ToInt32(Console.ReadLine());

        bool found = false;

        for (int i = 0; i < n; i++)
        {
            if (arr[i] == search)
            {
                Console.WriteLine("Element found at index: " + i);
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Element not found.");
        }
    }
}