using System;
using System.Collections.Generic;
using System.Linq;

class MagicStrings
{
    static void Main()
    {
        List<string> solutions = new List<string>();
        string solution = null;
        bool counter = true;
        int sum1 = 0;
        int sum2 = 0;
        int diff = int.Parse(Console.ReadLine());
        for (int i = 1111; i <= 5555; i++)
        {
            if (i > 1555 && i < 3111)
            {
                continue;
            }
            if (ksnp(i))
            {
                sum1 = 0;
                int[] arrayi = i.ToString().Select(a => Convert.ToInt32(a)).ToArray();
                foreach (char x in arrayi)
                {
                    sum1 += (int)char.GetNumericValue(x);
                }
                for (int j = 1111; j <= 5555; j++)
                {
                    if (j > 1555 && j < 3111)
                    {
                        continue;
                    }
                    if (ksnp(j))
                    {
                        sum2 = 0;
                        int[] arrayj = j.ToString().Select(b => Convert.ToInt32(b)).ToArray();
                        foreach (char y in arrayj)
                        {
                            sum2 += (int)char.GetNumericValue(y);
                        }
                        if (Math.Abs(sum1-sum2) == diff)
                        {
                            counter = false;
                            string newarr = i.ToString() + j.ToString();
                            foreach (char z in newarr)
                            {
                                switch (z)
                                {
                                    case '1':
                                        solution += 'k';
                                        break;
                                    case '3':
                                        solution += 's';
                                        break;
                                    case '4':
                                        solution += 'n';
                                        break;
                                    case '5':
                                        solution += 'p';
                                        break;
                                }
                            }
                            solutions.Add(solution);
                            solution = null;
                        }
                    }
                }
            }
        }
        if (counter)
        {
            Console.WriteLine("No");
        }
        else
        {
            solutions.Sort();
            foreach (string str in solutions)
            {
                Console.WriteLine(str);
            }
        }
    }

    static bool ksnp(int n)
    {
        string strn = n.ToString();
        foreach(char ch in strn)
        {
            if (ch == '0' || ch == '2' || ch == '6' || ch == '7' || ch == '8' || ch == '9')
            {
                return false;
            }
        }
        return true;
    }
}