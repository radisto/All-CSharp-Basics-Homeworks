using System;

class NineDigitMagicNumbers
{
    static void Main()
    {
        bool counter = true;
        int stringsum = 0;
        string magic;
        int i2 = 0;
        int i3 = 0;
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        for (int i = 100; i <= 777 - 2 * diff; i++)
        {
            stringsum = 0;
            if (no8or9or0(i))
            {
                i2 = i + diff;
                if (no8or9or0(i2))
                {
                    i3 = i2 + diff;
                    if (no8or9or0(i3))
                    {
                        magic = i.ToString() + i2.ToString() + i3.ToString();
                        for (int n = 0; n < 9; n++)
                        {
                            stringsum += (int)char.GetNumericValue(magic[n]);
                        }
                        if (stringsum == sum)
                        {
                            Console.WriteLine(magic);
                            counter = false;
                        }
                    }
                }
            }
        }
        if (counter)
        {
            Console.WriteLine("No");
        }
    }

    static bool no8or9or0(int i)
    {
        int i2 = i % 100;
        int i3 = i % 10;
        if (i / 100 == 8 || i / 100 == 9)
        {
            return false;
        }
        else
        {
            if (i2 / 10 == 8 || i2 / 10 == 9 || i2 < 10)
            {
                return false;
            }
            else
            {
                if (i3 == 8 || i3 == 9 || i3 == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}

