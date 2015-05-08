using System;

class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        star(2 * n, '*');
        star(n, ' ');
        star(2 * n, '*');
        Console.WriteLine();
        empty(n);
        star(2 * n, '*');
        star(n, ' ');
        star(2 * n, '*');
        Console.WriteLine();
    }

    static void star(int n, char m)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write(m);
        }
    }

    static void empty(int n)
    {
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write('*');
            for (int i2 = 0; i2 < n * 2 - 2; i2++)
            {
                Console.Write('/');
            }
            Console.Write('*');
            if (i == n / 2 - 1)
            {
                star(n, '|');
            }
            else
            {
                star(n, ' ');
            }
            Console.Write('*');
            for (int i2 = 0; i2 < n * 2 - 2; i2++)
            {
                Console.Write('/');
            }
            Console.Write('*');
            Console.WriteLine();
        }
    }
}