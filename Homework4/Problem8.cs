using System;

class SumOf5Numbers
{
    static void Main()
    {
        double sum = 0;
        string[] numbers = Console.ReadLine().Split();
        for (int i = 0; i < 5; i++)
			{
                sum += double.Parse(numbers[i]);
			}
        Console.WriteLine(sum);
    }
}
