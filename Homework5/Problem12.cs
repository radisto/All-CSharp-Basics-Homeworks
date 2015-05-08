using System;

class NumberAsWords
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string[] _0to9 = new string[10] {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"};
        string[] _10to19 = new string[10] {"Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
        string[] _20to90 = new string[10] {"", "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};
        string _100 = "hundred";
        if (number < 10)
        {
            Console.WriteLine(_0to9[number]);
        }
        else if (number < 20)
        {
            Console.WriteLine(_10to19[number-10]);
        }
        else if (number < 100 && number%10==0)
        {
            Console.WriteLine(_20to90[number/10]);
        }
        else if (number < 100)
        {
            Console.WriteLine(_20to90[number / 10] + " " + _0to9[number%10]);
        }
        else if (number < 1000 && number%10==0)
        {
            if (number % 100 == 0)
            {
                Console.WriteLine(_0to9[number/100] + " " + _100);
            }
            else
            {
                Console.WriteLine(_0to9[number/100] + " " + _100 + " and " + _20to90[(number%100)/10].ToLower());
            }
        }
        else if (number < 1000)
        {
            if (number%100 < 10)
            {
                Console.WriteLine(_0to9[number / 100] + " " + _100 + " and " + _0to9[number%100].ToLower());
            }
            else if (number%100 < 20)
            {
                Console.WriteLine(_0to9[number / 100] + " " + _100 + " and " + _10to19[number%100-10].ToLower());
            }
            else
            {
                Console.WriteLine(_0to9[number / 100] + " " + _100 + " and " + _20to90[(number%100)/10].ToLower() + " " + _0to9[number%10].ToLower());
            }
        }
    }
}
