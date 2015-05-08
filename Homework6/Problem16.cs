using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        string n = Console.ReadLine().ToUpper();
        long number = 0;
        for (int i = n.Length - 1, j = 0; i >= 0; i--, j++)
        {
            number += hexa(n, i) * (long)Math.Pow(16, j);
        }
        Console.WriteLine(number);
    }
    public static int hexa(string s, int i)
    {
        switch (s[i])
        {
            case 'A':
                return 10;
            case 'B':
                return 11;
            case 'C':
                return 12;
            case 'D':
                return 13;
            case 'E':
                return 14;
            case 'F':
                return 15;
            default:
                return (int)char.GetNumericValue(s[i]);
        }
    }
}
