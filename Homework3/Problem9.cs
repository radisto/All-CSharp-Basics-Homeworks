using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int counter = 0;
        bool isitprime = false;
        int n = int.Parse(Console.ReadLine());
        if (n >= 2 && n <= 100)
        {
            for (int i = 2; i <= 10; i++)
            {
                if (n % i != 0)
                {
                    counter++;
                    if (counter == 9)
                    {
                        isitprime = true;
                    }
                }
                else if (n % i == 0 && n == i)
                {
                    counter++;
                }
            }
        }
        Console.WriteLine(isitprime);
    }
}

