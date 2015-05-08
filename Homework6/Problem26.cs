using System;

class BitRoller
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int f = int.Parse(Console.ReadLine());
        f = 18 - f;
        int r = int.Parse(Console.ReadLine());
        string binary = Convert.ToString(n , 2).PadLeft(19, '0');
        string newstr = binary;
        for (int i = 0; i < r; i++)
        {
            binary = newstr;
            newstr = null;
            for (int j = 0; j < 19; j++)
            {
                if (f != 0 && f != 18)
                {
                    if (j == 0)
                    {
                        newstr += binary[18];
                    }
                    else if (j == f)
                    {
                        newstr += binary[f];
                    }
                    else if (j == (f + 1))
                    {
                        newstr += binary[f - 1];
                    }
                    else
                    {
                        newstr += binary[j - 1];
                    }
                }
                else if (f == 0)
                {
                    if (j == 0)
                    {
                        newstr += binary[0];
                    }
                    else if (j == 1)
                    {
                        newstr += binary[18];
                    }
                    else
                    {
                        newstr += binary[j - 1];
                    }
                }
                else if (f == 18)
                {
                    if (j == 0)
                    {
                        newstr += binary[17];
                    }
                    else if (j == 18)
                    {
                        newstr += binary[18];
                    }
                    else
                    {
                        newstr += binary[j - 1];
                    }
                }
            }
        }
        Console.WriteLine(Convert.ToInt32(newstr, 2));
    }
}
