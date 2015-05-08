using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? a = null;
        double? b = null;
        Console.WriteLine("{0}\n{1}",a,b);
        a += 1; //nothing happens
        b += 1.1; // nothing happens
        Console.WriteLine("{0}\n{1}", a, b);
        a = 1;
        b = 1.1;
        Console.WriteLine("{0}\n{1}", a, b);
    }
}
