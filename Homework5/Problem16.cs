using System;

class Pairs
{
    static void Main()
    {
        int lastpair = 0;
        int firstpair = 0;
        int current = 0;
        int maxdiff = 0;
        string input = Console.ReadLine();
        string[] split = input.Split(' ');
        for (int i = 0; i < split.Length; i++)
        {
            if (i == 1)
            {
                firstpair = Convert.ToInt16(split[0]) + Convert.ToInt16(split[1]);
            }
            else if (i % 2 == 1)
            {
                lastpair = Convert.ToInt16(split[i - 2]) + Convert.ToInt16(split[i - 3]);
                current = Convert.ToInt16(split[i]) + Convert.ToInt16(split[i - 1]);
                if (i == 3)
                {
                    maxdiff = Math.Abs(firstpair - current);
                }
                else
                {
                    maxdiff = (maxdiff > Math.Abs(current - lastpair) ? maxdiff : Math.Abs(current - lastpair));
                }
            }
        }
        if (maxdiff == 0)
        {
            Console.WriteLine("Yes, value=" + firstpair);
        }
        else
        {
            Console.WriteLine("No, maxdiff=" + maxdiff);
        }
    }
}
