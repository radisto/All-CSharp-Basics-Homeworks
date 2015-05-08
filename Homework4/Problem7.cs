using System;

class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double x1 = ((b * -1) - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
        double x2 = ((b * -1) + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
        Console.WriteLine(double.IsNaN(x1) && double.IsNaN(x2) ? "no real roots" : "x1=" + x1 + "; x2=" + x2);
    }
}
