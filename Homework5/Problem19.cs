using System;

class BitKiller
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        string abc = null;
        string str = null;
        string magic = null;
        for (int i = 0; i < n; i++)
        {
            str = Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(8, '0');
            abc += str;
        }
        for (int i = 0; i < n*8; i++)
        {
            if (i == 0)
            {
                magic += abc[0];
            }
            else if ((i - 1) % step != 0)
            {
                magic += abc[i];
            }
        }
        Console.WriteLine(magic.Length);
        while (magic.Length % 8 != 0)
        {
            magic = magic.PadRight(magic.Length+1,'0');
        }
        for (int i = 0; i < magic.Length; i+=8)
        {
            Console.WriteLine(Convert.ToInt32((magic.Substring(i,8)),2));
        }
    }
}
