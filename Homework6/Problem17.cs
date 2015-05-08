using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        bool counter = false;
        int a = 0;
        string ch = null;
        string hexa = null;
        long n = long.Parse(Console.ReadLine());
        for (int i = 16; i >= 0; i--)
        {
            a = 0;
            while (Math.Pow(16, i) <= n)
            {
                n -= ((long)Math.Pow(16, i));
                a++;
                counter = true;
            }
            if (counter)
            {
                switch (a)
                {
                    case 10:
                        ch = "A";
                        break;
                    case 11:
                        ch = "B";
                        break;
                    case 12:
                        ch = "C";
                        break;
                    case 13:
                        ch = "D";
                        break;
                    case 14:
                        ch = "E";
                        break;
                    case 15:
                        ch = "F";
                        break;
                    default:
                        ch = a.ToString();
                        break;
                }
                hexa += ch;
            }
        }
        Console.WriteLine(hexa);
    }
}
