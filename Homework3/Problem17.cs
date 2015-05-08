using System;
using System.Text;

class BitsExchangeAdvanced
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int first = 32 - q - k;
        int last = 32 - p - k;
        if (k > Math.Abs(q - p) || k > Math.Abs(p - q) || (p + k) > 32 || (q + k) > 32 || p < 0 || q < 0 || k < 0 || n > uint.MaxValue || n < 0)
        {
            if (k > Math.Abs(q - p) || k > Math.Abs(p - q))
            {
                Console.WriteLine("overlapping");
            }
            else
            {
                Console.WriteLine("out of range");
            }
        }
        else
        {
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
                if (i == first)
                {
                    result.Append(j.Substring(last, k));
                    i += k-1;
                }
                else if (i == last)
                {
                    result.Append(j.Substring(first, k));
                    i += k-1;
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
}

