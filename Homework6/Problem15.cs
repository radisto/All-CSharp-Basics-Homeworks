using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        bool counter = false;
        string binary = null;
        long n = long.Parse(Console.ReadLine());
        for (int i = 64; i >=0; i--)
		{
            if (Math.Pow(2, i) <= n)
            {
                n -= ((long)Math.Pow(2, i));
                binary += '1';
                counter = true;
            }
            else
            {
                if (counter)
                {
                    binary += '0';
                }
            }
		}
        Console.WriteLine(binary);
    }
}
