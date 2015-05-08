using System;

class NumbersNotDivisibleBy5and7
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (i % 5 == 0 || i % 7 == 0)
            {
            }
            else
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}
