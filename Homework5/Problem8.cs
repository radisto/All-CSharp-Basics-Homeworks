using System;

class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        if (a > b)
        {
            if (a > c)
            {
                Console.Write(a + " ");
                if (b > c)
                {
                    Console.Write(b + " " + c);
                }
                else
                {
                    Console.Write(c + " " + b);
                }
            }
            else
            {
                Console.Write(c + " ");
                if (a > b)
                {
                    Console.Write(a + " " + b);
                }
                else
                {
                    Console.Write(b + " " + a);
                }
            }
        }
        else
        {
            if (b > c)
            {
                Console.Write(b + " ");
                if (a > c)
                {
                    Console.Write(a + " " + c);
                }
                else
                {
                    Console.Write(c + " " + a);
                }
            }
            else
            {
                Console.Write(c + " ");
                if (a > b)
                {
                    Console.Write(a + " " + b);
                }
                else
                {
                    Console.Write(b + " " + a);
                }
            }
        }
        Console.WriteLine();
    }
}
