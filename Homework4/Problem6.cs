using System;

class FormattingNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        Console.Write("|" + Convert.ToString(a,16).ToUpper().PadRight(10,' '));
        Console.Write("|" + Convert.ToString(a, 2).PadLeft(10, '0'));
        Console.Write("|" + b.ToString("0.00").PadLeft(10, ' '));
        Console.WriteLine("|" + c.ToString("0.000").PadRight(10, ' ') + "|");
    }
}
