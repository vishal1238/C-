using System;
class Program{
    
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        int vowelCount = CountVowels(input);
        Console.WriteLine("Number of vowels: " + vowelCount);
    }

    static int CountVowels(string str)
    {
        int count = 0;
        foreach (char c in str.ToLower())
        {
            if ("aeiou".Contains(c))
            {
                count++;
            }
        }
        return count;
    }
}