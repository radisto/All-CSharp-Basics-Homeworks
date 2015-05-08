using System;

class OddAndEvenProduct
{
    static void Main()
    {
        int odd = 1;
        int even = 1;
        string line = Console.ReadLine();
        string[] numbers = line.Split(' ');
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 0)
            {
                odd *= int.Parse(numbers[i]);
            }
            else
            {
                even *= int.Parse(numbers[i]);
            }
        }
        if (odd == even)
        {
            Console.WriteLine("yes\nproduct = " + odd);
        }
        else
        {
            Console.WriteLine("no\nodd_product = " + odd + "\neven_product = " + even);
        }
    }
}
