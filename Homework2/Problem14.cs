using System;

class ComparingFloats
{
    static void Main()
    {
        int counter = 0;
        bool equal = false;
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        if (Math.Round(a, 0) == Math.Round(b, 0))
        {
            string astr = a.ToString();
            string bstr = b.ToString();
            int c = ((astr.Length > bstr.Length) ? bstr.Length : astr.Length);
            for (int i = 0; i < c; i++)
            {
                if (astr[i] == ',') //My visual studio console uses , instead of .
                {
                    for (int n = i+1; n < c; n++)
                    {
                        if (astr[n] == bstr[n])
                        {
                            counter++;
                            if (counter == 7)
                            {
                                equal = true;
                                break;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }
        Console.WriteLine(equal);
    }
}
