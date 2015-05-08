using System;
using System.Collections.Generic;

class TheBiggestOf5Numbers
{
    static void Main()
    {
        int maxcounter = 0;
        int counter = 0;
        double max = 0;
        double[] numbers = new double[5];
        for (int i = 0; i < 5; i++)
        {
            numbers[i] = double.Parse(Console.ReadLine());
        }
        for (int i = 0; i < 5; i++)
        {
            counter = 0;
            for (int j = 0; j < 5; j++)
            {
                if (numbers[i] > numbers[j])
                {
                    counter++;
                }
                if (j == 4)
                {
                    if (counter > maxcounter)
                    {
                        maxcounter = counter;
                        max = numbers[i];
                    }
                }
            }
        }
        Console.WriteLine(max);
    }
}
