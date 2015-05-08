using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine(isitone(n, p+1));
    }

    static bool isitone(int n, int p)
    {
        string binary = Convert.ToString(n, 2);
        if (binary.Length < p)
        {
            return false;
        }
        else
        {
            if ((int)char.GetNumericValue(binary[binary.Length - p]) == 0)
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

