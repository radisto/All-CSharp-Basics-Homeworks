using System;
using System.Text;

class BitsExchange
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        StringBuilder abc = new StringBuilder();
        StringBuilder result = new StringBuilder();
        string binary = Convert.ToString(n, 2);
        if (binary.Length < 32)
        {
            for (int i = binary.Length; i < 32; i++)
            {
                abc.Append('0');
            }
            abc.Append(binary);
        }
        else
        {
            abc.Append(binary);
        }
        string j = abc.ToString();
        for (int i = 0; i < 32; i++)
        {
            if (i == 5)
            {
                result.Append(j.Substring(26, 3));
                i += 2;
            }
            else if (i == 26)
            {
                result.Append(j.Substring(5, 3));
                i += 2;
            }
            else
            {
                result.Append(abc[i]);
            }
        }
        j = result.ToString();
        Console.WriteLine(Convert.ToUInt32(j, 2));
    }
}

