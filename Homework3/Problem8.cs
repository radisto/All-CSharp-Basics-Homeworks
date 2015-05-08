using System;

class PointInACircle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        bool isitinside = false;
        if (Math.Abs(y) <= Math.Sqrt(4 - Math.Pow(Math.Abs(x), 2)))
        {
            isitinside = true;
        }
        Console.WriteLine(isitinside);
    }
}

