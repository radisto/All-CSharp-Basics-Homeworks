using System;

class CountOfNames
{
    static void Main()
    {
        int counter = 1;
        string[] names = Console.ReadLine().Split(' ');
        Array.Sort(names);
        for (int i = 0; i < names.Length; i++)
        {
            if (i == 0)
            {
                if (names[i] != names[i + 1])
                {
                    Console.WriteLine(names[i] + " -> 1");
                }
                else
                {
                    counter++;
                }
            }
            else if (i == names.Length - 1)
            {
                if (names[i] != names[i - 1])
                {
                    Console.WriteLine(names[i] + " -> 1");
                }
                else
                {
                    counter++;
                    Console.WriteLine(names[i] + " -> " + counter);
                }
            }
            else
            {
                if (names[i] != names[i - 1])
                {
                    if (names[i] != names[i + 1])
                    {
                        Console.WriteLine(names[i] + " -> 1");
                    }
                }
                else
                {
                    counter++;
                    if (names[i] != names[i + 1])
                    {
                        Console.WriteLine(names[i] + " -> " + counter);
                        counter = 1;
                    }
                }
            }
        }
    }
}
