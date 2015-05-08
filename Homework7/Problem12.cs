using System;
using System.Collections.Generic;

class CountOfLetters
{
    static void Main()
    {
        int counter = 1;
        List<int> whichletter = new List<int>();
        char[] letters = Console.ReadLine().ToCharArray();
        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        for (int i = 0; i < letters.Length; i+=2)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (letters[i] == alphabet[j])
                {
                    whichletter.Add(j);
                }
            }
        }
        whichletter.Sort();
        for (int i = 0; i < whichletter.Count; i++)
        {
            if (i == whichletter.Count - 1)
            {
                if (whichletter[i] == whichletter[i - 1])
                {
                    counter++;
                    Console.WriteLine(alphabet[whichletter[i]] + " -> " + counter);
                }
                else
                {
                    Console.WriteLine(alphabet[whichletter[i]] + " -> 1");
                }
            }
            else if (i != 0)
            {
                if (whichletter[i] == whichletter[i - 1])
                {
                    counter++;
                    if (whichletter[i] != whichletter[i + 1])
                    {
                        Console.WriteLine(alphabet[whichletter[i]] + " -> " + counter);
                        counter = 1;
                    }
                }
                else
                {
                    if (whichletter[i] != whichletter[i + 1])
                    {
                        Console.WriteLine(alphabet[whichletter[i]] + " -> " + counter);
                        counter = 1;
                    }
                }
            }
            else if (i == 0)
            {
                if (whichletter[i] != whichletter[i + 1])
                {
                    Console.WriteLine(alphabet[whichletter[i]] + " -> 1");
                }
            }
        }
    }
}
