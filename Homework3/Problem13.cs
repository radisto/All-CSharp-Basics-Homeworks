using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        p++;
        string binary = Convert.ToString(n, 2);
        if (binary.Length < p)
        {
            Console.WriteLine(0);
        }
        else
        {
            Console.WriteLine(binary[binary.Length - p]);
        }
    }
}

