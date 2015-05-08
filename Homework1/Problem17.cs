using System;

class PrintLongSequence
{
    static void Main()
    {
        for (int i = 2; i < 1002; i++)
        {
            Console.WriteLine((i % 2 == 0) ? i : i*-1); 
        }
    }
}