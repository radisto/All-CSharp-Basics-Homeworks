using System;

class LongestAreaInArray
{
    static void Main()
    {
        int maxcounter = 0;
        int index = 0;
        int counter = 1;
        int n = int.Parse(Console.ReadLine());
        string[] strarray = new string[n];
        for (int i = 0; i < n; i++)
        {
            strarray[i] = Console.ReadLine();
            if (i > 0)
            {
                if (strarray[i] == strarray[i - 1])
                {
                    counter++;
                    if (i == n - 1)
                    {
                        if (counter > maxcounter)
                        {
                            index = i - counter + 1;
                            maxcounter = counter;
                        }
                    }
                }
                else
                {
                    if (counter > maxcounter)
                    {
                        index = i - counter;
                        maxcounter = counter;
                    }
                    counter = 1;
                }
            }
        }
        Console.WriteLine(maxcounter);
        for (int i = index; i < index + maxcounter; i++)
        {
            Console.WriteLine(strarray[i]);
        }
    }
}
