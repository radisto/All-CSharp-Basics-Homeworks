using System;
using System.Text;

class BitsInverter
{
    static void Main()
    {
        string c = "global variable";
        StringBuilder newstring = new StringBuilder();
        StringBuilder inverted = new StringBuilder();
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        for (int i2 = 0; i2 < n; i2++)
        {
            int a = int.Parse(Console.ReadLine());
            string b = (Convert.ToString(a, 2));
            if (i2 == 0)
            {
                c = (BitsFixed(b));
            }
            else
            {
                c += (BitsFixed(b));
            }
        }
        for (int i = 0; i < 8 * n; i++)
        {
            if (i % step == 0)
            {
                newstring.Append(oneorzero(c[i]));
            }
            else
            {
                newstring.Append(c[i]);
            }
        }
        for (int i3 = 0; i3 < 8 * n; i3++)
        {
            inverted.Append(newstring[i3]);
            if (i3 == 7 || (i3-7) % 8 == 0)
            {
                string abc = inverted.ToString();
                Console.WriteLine(Convert.ToInt32(abc, 2));
                inverted = inverted.Remove(0, inverted.Length);
            }
        }
    }

    static string BitsFixed(string a)
    {
        string b = "0";
        if (a.Length < 8)
        {
            for (int i = 1; i < 8 - a.Length; i++)
            {
                b += "0";
            }
            b += a;
            return b;
        }
        else
        {
            return a;
        }
    }

    static char oneorzero(char i)
    {
        if (i == '0')
        {
            return '1';
        }
        else
        {
            return '0';
        }
    }

}

