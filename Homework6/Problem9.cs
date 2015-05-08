using System;

class CalatanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Factorial(2*n)/(Factorial(n+1)*Factorial(n)));
    }
    public static int Factorial(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }
}
