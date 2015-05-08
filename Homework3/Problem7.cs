using System;
using System.Text;

class FourDigitNumber
{
    static void Main()
    {
        StringBuilder dcba = new StringBuilder();
        dcba = dcba.Append("0000");
        int i = 3;
        int sum = 0;
        string n = Console.ReadLine();
        string dabc = n[3].ToString() +n[0] + n[1] + n[2];
        string acbd = n[0].ToString() + n[2] + n[1] + n[3];
        string nstr = n.ToString();
        foreach (char m in nstr)
        {
            sum += (int)char.GetNumericValue(m);
            dcba[i] = m;
            i--;
        }
        Console.WriteLine(sum);
        Console.WriteLine(dcba);
        Console.WriteLine(dabc);
        Console.WriteLine(acbd);
    }
}

