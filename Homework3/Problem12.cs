using System;

class BitwiseExtractBitNumber3
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string binary = Convert.ToString(n, 2);
        if (binary.Length < 4)
        {
            Console.WriteLine(0);
        }
        else
        {
            Console.WriteLine(binary[binary.Length-4]);
        }
    }
}

