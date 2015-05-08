using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int current = 0;
        int max = 0;
        int min = 0;
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            current = int.Parse(Console.ReadLine());
            sum += current;
            if (i == 0)
            {
                max = current;
                min = current;
            }
            else
            {
                if (current > max)
                {
                    max = current;
                }
                if (current < min)
                {
                    min = current;
                }
            }
        }
        Console.WriteLine("min = " + min);
        Console.WriteLine("max = " + max);
        Console.WriteLine("sum = " + sum);
        Console.WriteLine("avg = {0:0.00}", ((double)sum/n));
    }
}
