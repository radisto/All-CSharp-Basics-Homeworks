using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        double sum = 0;
        double n = double.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            sum += double.Parse(Console.ReadLine());
        }
        Console.WriteLine(sum);
    }
}
