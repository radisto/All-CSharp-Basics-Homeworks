using System;
using System.Collections.Generic;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Fibonacci(n);
    }

    public static void Fibonacci(int n)
    {
        List<int> FibNumbers = new List<int>();
        if (n == 1)
        {
            Console.WriteLine("0");
        }
        else if (n == 2)
        {
            Console.WriteLine("0 1");
        }
        else
        {
            FibNumbers.Add(0);
            FibNumbers.Add(1);
            for (int i = 2; i < n; i++)
            {
                FibNumbers.Add(FibNumbers[i-1]+FibNumbers[i-2]);
            }
            foreach (int fib in FibNumbers)
            {
                Console.Write(fib + " ");
            }
            Console.WriteLine();
        }
    }
}
