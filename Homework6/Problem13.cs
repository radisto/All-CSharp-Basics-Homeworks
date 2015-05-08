using System;
using System.Collections.Generic;

class RandomizeTheNumbers1N
{
    static void Main()
    {
        int index = 0;
        List<int> numbers = new List<int>();
        Random random = new Random();
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            numbers.Add(i);
        }
        for (int i = 0; i < n; i++)
        {
            index = random.Next(0, numbers.Count);
            Console.Write(numbers[index] + " ");
            numbers.RemoveAt(index);
        }
        Console.WriteLine();
    }
}
