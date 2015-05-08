using System;
using System.Linq;

class SumOfElements
{
    static void Main()
    {
        string input = Console.ReadLine();
        int sum = 0;
        int[] intarray = input.Split(null).Select(s => Convert.ToInt32(s)).ToArray();
        intarray = intarray.OrderByDescending(c => c).ToArray();
        for (int i = 1; i < intarray.Length; i++)
        {
            sum += intarray[i];
        }
        Console.WriteLine(sum == intarray[0] ? "Yes, sum=" + sum : "No, diff=" + Math.Abs(sum - intarray[0]));
    }
}