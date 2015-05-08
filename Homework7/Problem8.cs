using System;

class MatrixOfPolindromes
{
    static void Main()
    {
        char[] a = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        int r = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write(a[i]);
                Console.Write(a[i + j]);
                Console.Write(a[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
