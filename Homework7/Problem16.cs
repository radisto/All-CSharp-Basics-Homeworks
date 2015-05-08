using System;

class ExtractURLfromText
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > 10 && (words[i].Substring(0, 4) == "www." || words[i].Substring(0, 7) == "http://"))
            {
                if (words[i].Substring(words[i].Length - 1, 1) == ".")
                {
                    words[i] = words[i].Remove(words[i].Length - 1);
                }
                Console.WriteLine(words[i]);
            }
        }
    }
}
