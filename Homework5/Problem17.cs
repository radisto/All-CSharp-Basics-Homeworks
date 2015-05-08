using System;

class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char[,] Matrix = new char[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Matrix[i, j] = '.';
            }
        }
        for (int i = 0, k = 0; i < n; i++, k+=2)
        {
            Matrix[n / 2, i] = '*';
            if (i < n / 2)
            {
                Matrix[i, n / 2 + i] = '*';
                if (i != 0)
                {
                    Matrix[i, n / 2 + i - k] = '*';
                }
            }
            if (i > n / 2 && i != n - 1)
            {
                Matrix[i, n/4]= '*';
                Matrix[i, n/4 + n - n / 4 * 2 - 1]= '*';
            }
            if (i < n - n / 4 * 2)
            {
                Matrix[n - 1, n / 4 + i] = '*';
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(Matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}
