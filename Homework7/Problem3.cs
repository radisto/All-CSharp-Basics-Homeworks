using System;

class PrimeChecker
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());
        Console.WriteLine(isPrime(n));
    }
    public static bool isPrime(ulong n)
    {
        ulong m = (ulong)Math.Floor(Math.Sqrt(n));
        if (n == 0 || n == 1)
        {
            return false;
        }
        if (n == 2 || n == 3)
        {
            return true;
        }
        for (ulong i = 2; i <= m; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
            if (i == m)
            {
                return true;
            }
        }
        return false;
    }
}
