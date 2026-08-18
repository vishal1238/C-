using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter size: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[n];

        Console.WriteLine("Enter elements:");

        for (int i = 0; i < n; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Array elements:");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}

// // using foreach loop to traverse the array:
// using System;

// class Program
// {
//     static void Main()
//     {
//         int[] numbers = { 10, 20, 30, 40, 50 };

//         foreach (int num in numbers)
//         {
//             Console.WriteLine(num);
//         }
//     }
// }