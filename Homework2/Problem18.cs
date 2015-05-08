using System;

class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        print(n, '*');
        for (int i = 0; i < n / 2 - 1; i++)
        {
            print(n, '/');
        }
        print(n, '/', '|');
        for (int i = 0; i < n / 2 - 1; i++)
        {
            print(n, '/');
        }
        print(n, '*');
    }
    static void print(int n, char a, char b = ' ')
    {
        Console.Write('*');
        for (int i = 0; i < n * 2 - 2; i++)
        {
            Console.Write(a);
        }
        Console.Write('*');
        for (int i2 = 0; i2 < n ; i2++)
        {
            Console.Write(b);
        }
        Console.Write('*');
        for (int i = 0; i < n * 2 - 2; i++)
        {
            Console.Write(a);
        }
        Console.Write('*');
        Console.WriteLine();
    }
}
