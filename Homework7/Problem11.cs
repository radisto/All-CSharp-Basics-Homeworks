using System;
using System.Collections.Generic;

class JoinLists
{
    static void Main()
    {
        List<string> numbers = new List<string>();
        List<string> merged = new List<string>();
        string line1 = Console.ReadLine();
        string[] line1array = line1.Split(' ');
        string line2 = Console.ReadLine();
        string[] line2array = line2.Split(' ');
        merged.AddRange(line1array);
        merged.AddRange(line2array);
        for (int i = 0; i < line1array.Length + line2array.Length; i++)
        {
            if (i == 0)
            {
                numbers.Add(merged[i]);
            }
            else
            {
                for (int j = i-1; j >= 0; j--)
                {
                    if (merged[i] == merged[j])
                    {
                        break;
                    }
                    if (j == 0)
                    {
                        numbers.Add(merged[i]);
                    }
                }
            }
        }
        numbers.Sort();
        foreach (string str in numbers)
        {
            Console.Write(str + ' ');
        }
        Console.WriteLine();
    }
}
