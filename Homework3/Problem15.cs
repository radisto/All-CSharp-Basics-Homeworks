using System;
using System.Text;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        char v = (char)Console.Read();
        p++;
        StringBuilder abc = new StringBuilder();
        string binary = Convert.ToString(n, 2);
        if (binary.Length < 16)
        {
            for (int i = binary.Length; i < 16; i++)
            {
                abc.Append("0");
            }
            abc.Append(binary);
        }
        else
        {
            abc.Append(binary);
        }
        abc[16 - p] = v;
        Console.WriteLine(Convert.ToInt32(abc.ToString(), 2));
    }
}

