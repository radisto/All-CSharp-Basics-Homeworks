using System;
using System.Collections.Generic;

class OddEvenElement
{
    static void Main()
    {
        string line = Console.ReadLine();
        string[] numbers = line.Split(' ');
        if (numbers[0] == "")
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
        }
        else
        {
            double oddsum = 0;
            double evensum = 0;
            List<double> odd = new List<double>();
            List<double> even = new List<double>();
            for (int i = 0; i < numbers.Length; i++)
            {
                double todouble = Convert.ToDouble(numbers[i]);
                if (i % 2 == 0)
                {
                    odd.Add(todouble);
                    oddsum += todouble;
                }
                else
                {
                    even.Add(todouble);
                    evensum += todouble;
                }
            }
            odd.Sort();
            even.Sort();
            if (numbers.Length == 1)
            {
                Console.WriteLine("OddSum=" + oddsum + ", OddMin=" + odd[0] + ", OddMax=" + odd[odd.Count - 1] + ", EvenSum=No, EvenMin=No, EvenMax=No");
            }
            else
            {
                Console.WriteLine("OddSum=" + oddsum + ", OddMin=" + odd[0] + ", OddMax=" + odd[odd.Count - 1] + ", EvenSum=" + evensum + ", EvenMin=" + even[0] + ", EvenMax=" + even[even.Count - 1]);
            }
        }
    }
}
