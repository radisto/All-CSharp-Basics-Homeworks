using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        string n = Console.ReadLine();
        long number = 0;
        for (int i = n.Length-1, j=0; i >= 0; i--, j++)
        {
            number += (int)char.GetNumericValue(n[i]) * (long)Math.Pow(2, j);
        }
        Console.WriteLine(number);
    }
}
