using System;

class Arrow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); ;
        int m = n + (n / 2) * 2;
        char[,] Matrix = new char[m, m];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Matrix[i, j] = '.';
            }
        }
        for (int i = 0; i < n; i++)
        {
            Matrix[0, n / 2 + i] = '#';
        }
        for (int i = 0; i < n / 2 + 1; i++)
        {
            Matrix[n - 1, 0 + i] = '#';
            Matrix[n - 1, m - 1 - i] = '#';
        }
        for (int i = 0; i < m / 2; i++)
        {
            Matrix[i, n / 2] = '#';
            Matrix[i, m - 1 - n / 2] = '#';
        }
        for (int i = m - 1, j = 0, k = 0; i > m / 2; i--, j++, k+=2)
        {
			Matrix[i, m / 2 - j] = '#';
            Matrix[i, m / 2 - j + k] = '#';
        }
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(Matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}
