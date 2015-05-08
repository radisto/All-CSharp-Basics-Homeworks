using System;

class TheExplorer
{
    static void Main()
    {
        int i5 = 0;
        int n = int.Parse(Console.ReadLine());
        char[,] matrix = new char[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int i2 = 0; i2 < n; i2++)
            {
                matrix[i, i2] = '-';
            }
        }
        for (int i3 = 0; i3 < n/2+1; i3++)
        {
            matrix[i3, n/2-i3] = '*';
            matrix[i3, (n/2-i3)+i3*2] = '*';
        }
        for (int i4 = n-1; i4 > n/2; i4--)
        {
            matrix[i4, n/2-i5] = '*';
            matrix[i4, (n/2-i5)+i5*2] = '*';
            i5++;
        }

        for (int i = 0; i < n; i++)
        {
            for (int i2 = 0; i2 < n; i2++)
            {
                Console.Write(matrix[i, i2]);
            }
            Console.WriteLine();
        }
    }
}
