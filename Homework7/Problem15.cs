using System;

class LongestWordInAText
{
    static void Main()
    {
        string[] words = Console.ReadLine().Replace(".","").Split(' ');
        string maxword = words[0];
        for (int i = 1; i < words.Length; i++)
        {
            if (words[i].Length > maxword.Length)
            {
                maxword = words[i];
            }
        }
        Console.WriteLine(maxword);
    }
}
