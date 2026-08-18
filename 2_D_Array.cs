taking 2-D Array input from user in C#:
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        int columns = Convert.ToInt32(Console.ReadLine());

        int[,] arr = new int[rows, columns];

        // Taking input
        Console.WriteLine("Enter array elements:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Displaying array
        Console.WriteLine("2-D Array:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}