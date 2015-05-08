using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        int p = 0;
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                p++;
            }
        }
        Console.WriteLine(p);
    }
}
