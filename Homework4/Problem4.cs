using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        Console.WriteLine(Math.Round((Math.PI * 2 * r),2)); 
        Console.WriteLine(Math.Round((Math.PI*r*r),2));
    }
}
