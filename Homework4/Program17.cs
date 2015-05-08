using System;

class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0, j = n/2, g = 1; i < Math.Ceiling((double)n/2); i++, j--, g+=2)
        {
            for (int h = 0; h < j; h++)
            {
                Console.Write('-');
            }
            for (int h = 0; h < g; h++)
            {
                Console.Write('*');
            }
            for (int h = 0; h < j; h++)
            {
                Console.Write('-');
            }
            Console.WriteLine();
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write('|');
            for (int j = 0; j < n-2; j++)
            {
                Console.Write('*');
            }
            Console.WriteLine('|');
        }
    }
}