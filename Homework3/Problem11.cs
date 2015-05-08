using System;

class PointInsideACircleAndOutsideOfARectangle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        bool isitinside = false;
        if (y > 1)
        {
            if (Math.Abs(y - 1) <= Math.Sqrt(2.25 - Math.Pow(Math.Abs(x - 1), 2)))
            {
                isitinside = true;
            }
        }
        Console.WriteLine(isitinside ? "yes" : "no");
    }
}

