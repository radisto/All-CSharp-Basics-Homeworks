using System;

class OddOrEvenInteger
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Math.Abs(n) % 2 == 1);
    }
}

