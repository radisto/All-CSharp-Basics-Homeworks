using System;
using System.Collections.Generic;

class PrimesInGivenRange
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        foreach (int i in FindPrimesInRange(start, end))
        {
            Console.Write(i + ", ");
        }
        if (FindPrimesInRange(start, end).Count == 0)
        {
            Console.WriteLine("empty list");
        }
    }
    static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primes = new List<int>();
        for (int i = startNum; i <= endNum; i++)
        {
            for (int j = 2; j <= i; j++)
            {
                if (i % j == 0)
                {
                    if (i == j)
                    {
                        primes.Add(i);
                    }
                    else
                    {
                        i++;
                        j = 1;
                        continue;
                    }
                }
            }
        }
        return primes;
    }
}
