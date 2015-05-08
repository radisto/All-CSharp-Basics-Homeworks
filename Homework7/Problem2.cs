using System;
using System.Collections.Generic;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(fib(n));
    }
    public static int fib(int n)
    {
        List<int> fiblist = new List<int>();
        fiblist.Add(1);
        fiblist.Add(1);
        for (int i = 2; i <= n; i++)
        {
            fiblist.Add(fiblist[i - 1] + fiblist[i - 2]);
        }
        return fiblist[n];
    }
}
