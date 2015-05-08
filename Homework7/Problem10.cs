using System;
using System.Collections.Generic;

class RemoveNames
{
    static void Main()
    {
        string firstline = Console.ReadLine();
        string secondline = Console.ReadLine();
        List<string> firstnames = new List<string>(firstline.Split(' '));
        string[] secondnames = secondline.Split(' ');
        for (int i = 0; i < secondnames.Length; i++)
        {
            firstnames.RemoveAll(item => item == secondnames[i]);
        }
        foreach (string str in firstnames)
        {
            Console.Write(str + " ");
        }
        Console.WriteLine();
    }
}
