using System;
using System.Collections.Generic;

class SortingNumbers
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            numbers.Add(int.Parse(Console.ReadLine()));
        }
        numbers.Sort();
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
    }
}
