using System;

class VariableInHexadecimalFormat
{
    static void Main()
    {
        int a = 254;
        string b = a.ToString("X");
        Console.WriteLine("{0}\n{1}",b,Convert.ToInt32(b, 16));
    }
}
