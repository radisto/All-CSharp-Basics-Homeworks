using System;

class OddEvenSum
{
    static void Main()
    {
        int evensum = 0;
        int oddsum = 0;
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n * 2; i++)
        {
            if (i % 2 == 0)
            {
                evensum += int.Parse(Console.ReadLine());
            }
            else
            {
                oddsum += int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine ((oddsum == evensum) ? "Yes, sum=" + evensum : "No, diff=" + Math.Abs(evensum - oddsum));
    }
}
