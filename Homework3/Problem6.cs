using System;

class ThirdDigitIs7
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool isit7 = false;
        if (n >= 700 && (n % 1000)/100 == 7 )
        {
            isit7 = true;
        }
        Console.WriteLine(isit7);
    }
}

