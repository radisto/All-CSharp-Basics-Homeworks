using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] Matrix = new int[n, n];
        for (int i = 0; i < n; i++)
		{
			for (int j = 0; j < n; j++)
			{
			    Matrix[i, j] = i+j+1;
			}
		}
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(Matrix[i, j]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
