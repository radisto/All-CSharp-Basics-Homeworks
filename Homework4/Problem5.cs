﻿using System;

class NumberComparer
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(a>b ? a : b);
    }
}
