using System;
using System.Text;

class BitsUp
{
    static void Main()
    {
        StringBuilder opq = new StringBuilder();
        StringBuilder str = new StringBuilder();
        string ing = null;
        string abc = null;
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int a = int.Parse(Console.ReadLine());
            if (i == 0)
            {
                abc = Convert.ToString(a, 2).PadLeft(8, '0');
            }
            else
            {
                abc += Convert.ToString(a, 2).PadLeft(8, '0');
            }
        }
        for (int i = 0; i < n*8; i++)
        {
            if (i == 1 || (i - 1) % step == 0)
            {
                opq.Append('1');
            }
            else
            {
                opq.Append(abc[i]);
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int i2 = 0; i2 < 8; i2++)
            {
                str.Append(opq[i2 + 8 * i]);
            }
            ing = str.ToString();
            Console.WriteLine(Convert.ToInt32(ing, 2));
            str = str.Remove(0,8);
        }
    }
}
