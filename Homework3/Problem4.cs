using System;

class DivideBy7And5
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool isdivided = false;
        if (n % 5 == 0 && n % 7 == 0 && n != 7 && n != 5 && n != 0)
        {
                isdivided = true;
        }
        Console.WriteLine(isdivided);
    }
}

